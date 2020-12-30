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

            if (nameBox.Text == "" || nameBox.Text.Length < 5)
            {
                MessageBox.Show("Name Cannot Exist", "Invalid Name");
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

            if(ContactDetailsBox.Text == "" || ContactDetailsBox.Text.Length < 5)
            {
                MessageBox.Show("Contact Detials Cannot be Empty", "Invalid Contact Details");
                return;
            }
            

            if (EmergencyContactBox.Text == "" || EmergencyContactBox.Text.Length < 2)
            {
                MessageBox.Show("Emergency Contact Detials Cannot be Empty", "Invalid Emergency Contact Detials");
                return;
            }
            // Check Username is valid with above bool

            if (!CanUseName)
            {
                MessageBox.Show("Username In Use", "Invalid Username");
                return;
            }


            // Add Login and Password to loginTable and add new staffData, 
            // find staff table id and set logintable id to be the same on both
            //               INSERT INTO Customer (FirstName, LastName, City, Country, Phone)
            //               VALUES('Craig', 'Smith', 'New York', 'USA', 1 - 01 - 993 2800)
            var staffquery = "INSERT INTO StaffTable (StaffUsername, StaffName, [DOB], [WorkedSince], AquiredRoles, Email, contactDetails, EmergencyContact, MedicallyTrained ) " +
                "VALUES(@username, @name, @Dob, @workedSince, @roles, @email, @contact, @emergency, @medical)";

            OleDbConnection myConn = new OleDbConnection(Program.strDSN);       // Connects to database
            OleDbCommand myComm = new OleDbCommand(staffquery, myConn);     // Takes in connection and query
            myConn.Open();
            myComm.Parameters.Add("@username", OleDbType.VarChar).Value = UsernameTextBox.Text;   // puts variables into query in place of @something
            myComm.Parameters.Add("@name", OleDbType.VarChar).Value = nameBox.Text;
            myComm.Parameters.Add("@Dob", OleDbType.Date).Value = DOBPicker.Value.Date;
            myComm.Parameters.Add("@workedSince", OleDbType.Date).Value = DateTime.Now.Date;
            myComm.Parameters.Add("@roles", OleDbType.VarChar).Value = "1";
            myComm.Parameters.Add("@email", OleDbType.VarChar).Value = EmailBox.Text;
            myComm.Parameters.Add("@contact", OleDbType.VarChar).Value = ContactDetailsBox.Text;
            myComm.Parameters.Add("@emergency", OleDbType.VarChar).Value = EmergencyContactBox.Text;
            myComm.Parameters.Add("@medical", OleDbType.Boolean).Value = MedicalCheckBox.Checked;

            if (myComm.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("Account Not Saved", "Query Issue");
                return;
            }
            else 
            {
                MessageBox.Show("Account Saved", "Query Fine");
            }
            myConn.Close();



            var getIdQuery = "SELECT Id FROM StaffTable WHERE StaffUsername = @username";
            OleDbConnection myConn2 = new OleDbConnection(Program.strDSN);       // Connects to database
            OleDbCommand myComm2 = new OleDbCommand(getIdQuery, myConn2);     // Takes in connection and query
            myComm2.Parameters.Add("@username", OleDbType.VarChar).Value = UsernameTextBox.Text;

            int id = 0;

            myConn2.Open();
            using (OleDbDataReader r = myComm2.ExecuteReader()) // Best way i could Find to do it so i can check a Login Exists
            {
                if (r.HasRows)    // Opens a reader for the sql query and checks if we got Rows aka. if anything was returned
                {
                    r.Read();
                    id = r.GetInt32(0);     // Reads found Line with the ID of the Account

                    //MessageBox.Show($"Found ID {id} for account {inputUsername}", "Correct Login");   //Message box for testing 
                }
                else
                {
                    MessageBox.Show("unknown Error", "SQL ERROR");
                    return;
                }
            }
            myConn2.Close();         // close connection

            var stdQuery = "INSERT INTO LoginTable ([Username], [Password], [LinkingID]) " +
                "VALUES(?, ?, ?)";
            //             "INSERT INTO StaffTable (StaffUsername, StaffName, [DOB]) VALUES(@username, @name, @Dob)";
            OleDbConnection myConn3 = new OleDbConnection(Program.strDSN);       // Connects to database
            OleDbCommand myComm3 = new OleDbCommand(stdQuery, myConn3);     // Takes in connection and query
            myComm3.Parameters.Add("?", OleDbType.VarChar).Value = UsernameTextBox.Text;
            myComm3.Parameters.Add("?", OleDbType.VarChar).Value = passwordTextBox.Text;
            myComm3.Parameters.Add("?", OleDbType.Integer).Value = id;

            myConn3.Open();
            if(myComm3.ExecuteNonQuery() != 0)
            {
                MessageBox.Show($"Login Successfully Saved at id {id.ToString()}", "Login Added");
                LogEvent.LogStaffCreateAccount(id, UsernameTextBox.Text);
            }
            else
            {
                MessageBox.Show("unknown Error", "SQL ERROR");
                return;
            }
            myConn3.Close();

            //Once created all that go back to the main login Screen
            this.Close();

        }

        private void ShwoPassword_CheckedChanged(object sender, EventArgs e)
        {
            ShowPassword();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            ShowPassword();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
