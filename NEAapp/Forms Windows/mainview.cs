using NEAapp.Classes;
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
    public partial class MainMenu : Form
    {
        public MainMenu(int id)
        {
            InitializeComponent();

            LoadStaffAccount(id);

            //Get Roles


            //Update valid UI

            NameLabel.Text = Program.globalCurrentUser.getName() + " - " + Program.globalCurrentUser.getEmail();


        }

        private void LoadStaffAccount(int id)
        {
            // SELECT * FROM StaffTable WHERE Id = id
            // Load all into global staff object

            string strQRY = ($"SELECT * from StaffTable where ID=@id");   // Our query
            OleDbConnection myConn = new OleDbConnection(Program.strDSN);       // Connects to database
            OleDbCommand myComm = new OleDbCommand(strQRY, myConn);     // Takes in connection and query
            myComm.Parameters.Add("@id", OleDbType.Integer).Value = id;

            myConn.Open();  //Opens connection
            OleDbDataReader reader = myComm.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                var staffName = reader[1].ToString();
                var DOB = DateTime.Parse(reader[2].ToString());
                var WorkedSince = DateTime.Parse(reader[3].ToString());

                var TempRoles = reader[4].ToString();
                var RealRoles = TempRoles.Split(',');

                var admin = bool.Parse(reader[5].ToString());
                var contract = reader[6].ToString();
                var wage = double.Parse(reader[7].ToString());
                var email = reader[8].ToString();
                var contactDetails = reader[9].ToString();
                var timeOff = reader[10]; //Not Used
                var EmergencyContact = reader[11].ToString();
                var isMedicallyTrained = bool.Parse(reader[12].ToString());
                var hoursWorked = reader[13]; //Not Used
                var staffUsername = reader[14]; //Not Used

                List<int> intRoles = new List<int>();

                foreach (var item in RealRoles)
                {
                    intRoles.Add(int.Parse(item));
                }

                Program.globalCurrentUser.InitProfile(staffName, DOB, WorkedSince, admin, contract, wage, email, contactDetails, EmergencyContact, isMedicallyTrained, intRoles);
                // Sets Global user to currently Logged in user


                //Testing

                /*
                for (int i = 0; i < 15; i++)
                {
                    Label temp = new Label();
                    temp.Text = reader[i].ToString();
                    temp.Parent = leftPanel;
                    temp.Top += 20 * i;

                    
                }
                */

            }
            else
            {
                MessageBox.Show("Error: Account Not Found", "Account Missing");
                myConn.Close();
                return;
            }
            myConn.Close();         // close connection


        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            ClearNoticeBoard();
            UpdateNoticeBaord();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            addNotice NewNotice = new addNotice();
            NewNotice.Show();

        }

        private void ClearNoticeBoard()
        {
        }

        private void UpdateNoticeBaord()
        {
            //get all notiveboarditems from sql
            string strQRY = ($"SELECT * from NoticeBoardTable");   // Our query

            OleDbConnection myConn = new OleDbConnection(Program.strDSN);       // Connects to database
            OleDbCommand myComm = new OleDbCommand(strQRY, myConn);     // Takes in connection and query

            myConn.Open();  //Opens connection
            OleDbDataReader r = myComm.ExecuteReader();


            if (r.HasRows)    // Opens a reader for the sql query and checks if we got Rows aka. if anything was returned
            {
                do
                {
                    while (r.Read())
                    {
                        var user = r[1];
                        var title = r[2];
                        var info = r[3];
                        var date = r[4];
                        var newNotice = new NoticeBoardItem(title.ToString(), user.ToString(), info.ToString(), DateTime.Parse(date.ToString()));
                        newNotice.AutoSize = true;
                        newNotice.Visible = true;
                        newNotice.Parent = TrueNoticePanel;
                    }
                } while (r.NextResult());
            }
            else
            {

                myConn.Close();         // close connection
                return;
            }

            myConn.Close();         // close connection

            for (int i = 1; i < TrueNoticePanel.Controls.Count; i++)
            {
                TrueNoticePanel.Controls[i].Top += (120 * i);
            }

            TrueNoticePanel.AutoScrollMargin = new System.Drawing.Size(10, 60 * TrueNoticePanel.Controls.Count);
        }
    }
}
