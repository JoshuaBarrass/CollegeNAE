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
    public partial class StaffAccountManager : Form
    {
        public StaffAccountManager()
        {
            InitializeComponent();

            NameLabel.Text = Program.globalCurrentUser.getName() + " - " + Program.globalCurrentUser.getEmail();
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoadStaffAccounts()
        {

            var strQuery = "SELECT * FROM StaffTable";

            OleDbConnection myConn = new OleDbConnection(Program.strDSN);       // Connects to database
            OleDbCommand myComm = new OleDbCommand(strQuery, myConn);     // Takes in connection and query

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

                            int ID = int.Parse(r[0].ToString());
                            string StaffName = r[1].ToString();
                            var DOB = DateTime.Parse(r[2].ToString());
                            var workedSince = DateTime.Parse(r[3].ToString());   // r[i] refers to row in sql table read as r
                            string rolesCSV = r[4].ToString();                   // Then parsing into correct datatype
                            bool isAdmin = bool.Parse(r[5].ToString());          // Also when doing this found out that nothing can be blank on the table
                            string Contract = r[6].ToString();                   // Or this breaks 
                            double wage = double.Parse(r[7].ToString());
                            string Email = r[8].ToString();
                            string ContactDetails = r[9].ToString();
                            string EmergCOntact = r[11].ToString();
                            bool Medical = bool.Parse(r[12].ToString());

                            List<int> intRoles = new List<int>();

                            foreach (var item in rolesCSV.Split(','))
                            {
                                intRoles.Add(int.Parse(item));
                            }

                            var newStaff = new StaffProfile(StaffName, DOB, workedSince, isAdmin, Contract, wage, Email, ContactDetails, EmergCOntact, Medical, intRoles);
                            newStaff.setID(ID);

                            var newStaffView = new StaffItem(newStaff); //Sets up item 
                            newStaffView.Visible = true;
                            newStaffView.Parent = StaffPanel;

                           
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


            for(int i = 0; i < StaffPanel.Controls.Count; i++)
            {
                if(StaffPanel.Width > 335* 2)
                {
                    if( i % 2 == 1)
                    {
                        StaffPanel.Controls[i].Top = ((i-1) * 350/2);
                        StaffPanel.Controls[i].Left += 335;
                    }
                    else
                    {
                        StaffPanel.Controls[i].Top = (i*350/2);
                    }
                }
                else
                {
                    StaffPanel.Controls[i].Top = (i * 350/2);
                }
            } //Sorts Page to display items in correct Places

            StaffPanel.AutoScrollMargin = new System.Drawing.Size(0, StaffPanel.Controls.Count*2);

        }

        private void StaffAccountManager_Load(object sender, EventArgs e)
        {
            LoadStaffAccounts();
        }

        private void ClearStaffAccount()
        {
            StaffPanel.Controls.Clear();
        }

        private void StaffPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminaccounts_Click(object sender, EventArgs e)
        {
            ClearStaffAccount();
            LoadStaffAccounts();

            int TotalCount = StaffPanel.Controls.Count;
            List<int> ToRemove = new List<int>();

            for (int i = 0; i < TotalCount; i++)
            {
                var item = (StaffItem)StaffPanel.Controls[i].GetContainerControl(); //Get StaffItem

                if (!item.isAdmin()) //Using function to get bool after casting item
                {
                    ToRemove.Add(i); //List Of indexes to remove
                }

            }

            for (int i = ToRemove.Count; i > 0 ; i--)
            {
                StaffPanel.Controls.RemoveAt(ToRemove[i-1]); // We loop through the list backwords so that we dont have index errors as each index would change as we remove them
            }

            for (int i = 0; i < StaffPanel.Controls.Count; i++)
            {
                StaffPanel.Controls[i].Left = 0;
                if (StaffPanel.Width > 335 * 2)
                {
                    if (i % 2 == 1)
                    {
                        StaffPanel.Controls[i].Top = ((i - 1) * 350 / 2);
                        StaffPanel.Controls[i].Left += 335;
                    }
                    else
                    {
                        StaffPanel.Controls[i].Top = (i * 350 / 2);
                    }
                }
                else
                {
                    StaffPanel.Controls[i].Top = (i * 350 / 2);
                }
            } //Sorts Page to display items in correct Places

            StaffPanel.AutoScrollMargin = new System.Drawing.Size(0, StaffPanel.Controls.Count * 2);

        }

        private void showAll_Click(object sender, EventArgs e)
        {
            ClearStaffAccount();
            LoadStaffAccounts();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void medicallytrained_Click(object sender, EventArgs e)
        {
            ClearStaffAccount();
            LoadStaffAccounts();

            int TotalCount = StaffPanel.Controls.Count;
            List<int> ToRemove = new List<int>();

            for (int i = 0; i < TotalCount; i++)
            {
                var item = (StaffItem)StaffPanel.Controls[i].GetContainerControl(); //Get StaffItem

                if (!item.isMedic()) //Using function to get bool after casting item
                {
                    ToRemove.Add(i); //List Of indexes to remove
                }

            }

            for (int i = ToRemove.Count; i > 0; i--)
            {
                StaffPanel.Controls.RemoveAt(ToRemove[i - 1]); // We loop through the list backwords so that we dont have index errors as each index would change as we remove them
            }

            for (int i = 0; i < StaffPanel.Controls.Count; i++)
            {
                StaffPanel.Controls[i].Left = 0;
                if (StaffPanel.Width > 335 * 2)
                {
                    if (i % 2 == 1)
                    {
                        StaffPanel.Controls[i].Top = ((i - 1) * 350 / 2);
                        StaffPanel.Controls[i].Left += 335;
                    }
                    else
                    {
                        StaffPanel.Controls[i].Top = (i * 350 / 2);
                    }
                }
                else
                {
                    StaffPanel.Controls[i].Top = (i * 350 / 2);
                }
            } //Sorts Page to display items in correct Places

            StaffPanel.AutoScrollMargin = new System.Drawing.Size(0, StaffPanel.Controls.Count * 2);
        }
    }
}
