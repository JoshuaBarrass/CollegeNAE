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
    public partial class Create_Account : Form
    {

        bool CanUseName = true;

        public Create_Account()
        {
            InitializeComponent();
            timer1.Start();
            ShowPassword();
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

            //Check if Username is taken
            var inputUsername = UsernameTextBox.Text;
            string strQRY = ($"SELECT * from LoginTable WHERE Username=@username");

            OleDbConnection myConn = new OleDbConnection(Program.strDSN);
            OleDbCommand myComm = new OleDbCommand(strQRY, myConn);
            myComm.Parameters.AddWithValue("@username", inputUsername);

            myConn.Open();

            using (OleDbDataReader r = myComm.ExecuteReader()) // Best way i could Find to do it so i can check a Login Exists
            {
                if (r.HasRows)
                {
                    CanUseName = false;
                }
                else
                    CanUseName = true;

            }
            myConn.Close();

            UsernameAvaliable.Text = !CanUseName ? "Username Is Taken!" : "Username is Free!";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerLabel.Text = System.DateTime.Now.ToString();
        }

        private void TimerLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void ShowPassword()
        {
            if (passwordTextBox.Text == "Password" || ShwoPassword.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Do checks to see if inputs ar eempty

            if (UsernameTextBox.Text == "" || UsernameTextBox.Text.Length < 3)
            {
                MessageBox.Show("Your Username Cannot be Empty or Less than 3 Characters", "Invalid Username");
                return;
            }

            if (passwordTextBox.Text == "" || passwordTextBox.Text.Length < 3)
            {
                MessageBox.Show("Your Password Cannot be Empty or Less than 3 Characters", "Invalid Password");
                return;
            }

            if ((DateTime.Now - DOBPicker.Value).TotalDays < 18 * 365)
            {
                MessageBox.Show("You Cannot Be Less Than 18", "Invalid Age");
                return;
            }

            if(EmailBox .Text == "" || EmailBox.Text.Length < 5)
            {
                MessageBox.Show("Email Cannot Exist", "Invalid Email");
                return;
            }
            // Check Username is valid with above bool

            // Add Login and Password to loginTable and add new staffData, 
            // find staff table id and set logintable id to be the same on both

            //Once created all that go back to the main login Screen

        }

        private void ShwoPassword_CheckedChanged(object sender, EventArgs e)
        {
            ShowPassword();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            ShowPassword();
        }
    }
}
