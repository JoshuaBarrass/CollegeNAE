using NEAapp.Classes;
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
    public partial class addNotice : Form
    {
        public addNotice()
        {
            InitializeComponent();
            NameLabel.Text = Program.globalCurrentUser.getName() + " - " + Program.globalCurrentUser.getEmail();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            CharacterLimitLabel.Text = $"{DescriptionTextBox.Text.Length.ToString()} / 1000 Characters";
        }

        private void addNoticeButton_Click(object sender, EventArgs e)
        {
            if (Program.globalCurrentUser.checkAdmin() || Program.globalCurrentUser.checkRole(roleTypes.NOTICEBOARDACCESS)){
                string strQRY = ($"INSERT INTO NoticeBoardTable ([username], [Title], [Information], [when]) " +
                    "VALUES(?, ?, ?, ?)");   // Our query

                OleDbConnection myConn = new OleDbConnection(Program.strDSN);       // Connects to database
                OleDbCommand myComm = new OleDbCommand(strQRY, myConn);     // Takes in connection and query
                myComm.Parameters.Add("?", OleDbType.VarChar).Value = Program.globalCurrentUser.getName();
                myComm.Parameters.Add("?", OleDbType.VarChar).Value = TitleTextBox.Text;
                myComm.Parameters.Add("?", OleDbType.VarChar).Value = DescriptionTextBox.Text;
                myComm.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;

                myConn.Open();  //Opens connection
                myComm.ExecuteNonQuery();
                myConn.Close();
                MessageBox.Show("NoticeBoard Message Added", "Notice Added");
                LogEvent.AddNotice(Program.globalCurrentUser.getID(), Program.globalCurrentUser.getName(), DescriptionTextBox.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("You do not have Adequate Role Access to do this action", "Insufficient Role Access");
            }
        }

        private void cancelNotice_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
