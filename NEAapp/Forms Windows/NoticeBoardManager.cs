using NEAapp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEAapp.Forms_Windows
{
    public partial class NoticeBoardManager : Form
    {
        public NoticeBoardManager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NoticeBoardManager_Load(object sender, EventArgs e)
        {
            UpdateNoticeBoard();

        }

        public void refreshBoard()
        {
            cleadBaord();
            UpdateNoticeBoard();
        }

        private void cleadBaord()
        {
            noticepanel.Controls.Clear();
        }

        private void UpdateNoticeBoard()
        {

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
                            var id = r[0];
                            var user = r[1];
                            var title = r[2];
                            var info = r[3];
                            var date = r[4];
                            var newNotice = new NoticeBoardManageItem(title.ToString(),  info.ToString(), user.ToString(), DateTime.Parse(date.ToString()), int.Parse(id.ToString()));
                            newNotice.AutoSize = true;
                            newNotice.Visible = true;
                            newNotice.Parent = noticepanel;
                        }
                    } while (r.NextResult());
                }
                else
                {

                    myConn.Close();         // close connection
                    return;
                }


                for (int i = 0; i < noticepanel.Controls.Count; i++)
                {
                    noticepanel.Controls[i].Top += (120 * i);
                }

                noticepanel.AutoScrollMargin = new System.Drawing.Size(0, noticepanel.Controls.Count);
                noticepanel.Width = noticepanel.Controls[0].Width + noticepanel.AutoScrollMargin.Width;
            }
            catch
            {
                MessageBox.Show("ERROR - INCORRECT SQL STATEMENT", "INCORRECT SQL");
            }


            myConn.Close();         // close connection

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.refreshBoard();
        }

        private void noticepanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
