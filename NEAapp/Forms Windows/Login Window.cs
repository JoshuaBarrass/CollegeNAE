using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.OleDb;
using NEAapp.Forms_Windows;

namespace NEAapp
{

    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            timer1.Start();

            label2.Text = $"This is Update {Program.UPDATE} of the NEA Business Software";      //Information text box 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            var result = MessageBox.Show("Open Github?", "Github", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/JoshuaBarrass/");
                Process.Start(sInfo);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ShowPassword();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerLabel.Text = System.DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var inputUsername = UsernameTextBox.Text;
            var inputPassword = passwordTextBox.Text;
            string strQRY = ($"SELECT LinkingID from LoginTable WHERE Username=@username AND Password=@password");   // Our query

            OleDbConnection myConn = new OleDbConnection(Program.strDSN);       // Connects to database
            OleDbCommand myComm = new OleDbCommand(strQRY, myConn);     // Takes in connection and query
            myComm.Parameters.AddWithValue("@username", inputUsername);   // puts variables into query in place of @something
            myComm.Parameters.AddWithValue("@password", inputPassword);

            myConn.Open();  //Opens connection
            bool userExists;
            using (OleDbDataReader r = myComm.ExecuteReader()) // Best way i could Find to do it so i can check a Login Exists
            {
                if (r.HasRows)    // Opens a reader for the sql query and checks if we got Rows aka. if anything was returned
                {
                    userExists = true;      // if something was returned then we have a user
                    int id = 0;
                    r.Read();
                    id = r.GetInt32(0);     // Reads found Line with the ID of the Account

                    MessageBox.Show($"Found ID {id} for account {inputUsername}", "Correct Login");   //Message box for testing 

                    Forms_Windows.MainMenu main = new Forms_Windows.MainMenu(id);
                    main.Closed += (s, args) => this.Close(); // When you close the new window, this one opens back up
                    main.Show();
                    this.Hide();

                }
                else
                    userExists = false; // else no user found 

            }
            myConn.Close();         // close connection

            if (!userExists)
            {
                MessageBox.Show("Incorrect Login", "User Doesn't exist");
            }


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Create_Account newWindow = new Create_Account();
            newWindow.Closed += (s, args) => this.Show(); // When you close the new window, this one opens back up
            newWindow.Show();
            this.Hide();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            string strQRY = "SELECT * FROM LoginTable";
            OleDbConnection myConn = new OleDbConnection(Program.strDSN);
            OleDbDataAdapter myCmd = new OleDbDataAdapter(strQRY, myConn);  // Test to check we can access database right at the beginning of the program
            myConn.Open();                                                  // Easier then having it crash after launch
            myConn.Close();



        }

        private void ShwoPassword_CheckedChanged(object sender, EventArgs e)
        {
            ShowPassword();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
