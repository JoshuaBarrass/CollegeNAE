using NEAapp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEAapp.Forms_Windows
{
    public partial class logMenu : Form
    {
        public logMenu()
        {
            InitializeComponent();
            NameLabel.Text = Program.globalCurrentUser.getName() + " - " + Program.globalCurrentUser.getEmail();
            updateLogMenu();
        }

        private void LogPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateLogMenu()
        {
            //get all notiveboarditems from sql
            string strQRY = SQLStateText.Text;   // Our query

            OleDbConnection myConn = new OleDbConnection(Program.strDSN);       // Connects to database
            OleDbCommand myComm = new OleDbCommand(strQRY, myConn);     // Takes in connection and query

            myConn.Open();  //Opens connection
            try
            {
                OleDbDataReader r = myComm.ExecuteReader();



                if (r.HasRows)    // Opens a reader for the sql query and checks if we got Rows aka. if anything was returned
                {
                    do
                    {
                        while (r.Read())
                        {
                            var user = r[1];
                            var info = r[2];
                            var date = r[3];
                            var newLog = new Logitem(user.ToString(), DateTime.Parse(date.ToString()), info.ToString());
                            newLog.AutoSize = true;
                            newLog.Visible = true;
                            newLog.Parent = LogPanel;
                        }
                    } while (r.NextResult());
                }
                else
                {

                    myConn.Close();         // close connection
                    return;
                }
            }
            catch
            {
                MessageBox.Show("ERROR - INCORRECT SQL STATEMENT", "INCORRECT SQL");
            }
            myConn.Close();         // close connection

            for (int i = 0; i < LogPanel.Controls.Count; i++)
            {
                LogPanel.Controls[i].Top += (60 * i);
                LogPanel.Controls[i].Width = LogPanel.Width;
            }

            LogPanel.AutoScrollMargin = new System.Drawing.Size(0, LogPanel.Controls.Count);
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Open w3schools??", "w3schools", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                ProcessStartInfo sInfo = new ProcessStartInfo("https://www.w3schools.com/sql/");
                Process.Start(sInfo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogPanel.Controls.Clear();
            updateLogMenu();
        }
    }
}
