using NEAapp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEAapp.Forms_Windows
{
    public partial class StaffOverview : Form
    {

        private StaffProfile staff;

        public StaffOverview(StaffProfile profile)
        {
            InitializeComponent();

            this.staff = profile;

            this.Text = $"Staff Overview - {profile.getName()}";

            //Set up Box
            RolesCheckedBox.Items.Add(roleTypes.GENERALSTAFF);
            RolesCheckedBox.Items.Add(roleTypes.ENGINEER);
            RolesCheckedBox.Items.Add(roleTypes.ACCOUNTANT);
            RolesCheckedBox.Items.Add(roleTypes.MANAGER);
            RolesCheckedBox.Items.Add(roleTypes.SUPERVISOR);
            RolesCheckedBox.Items.Add(roleTypes.NOTICEBOARDACCESS);
            RolesCheckedBox.Items.Add(roleTypes.INVOICEACCESS);
            RolesCheckedBox.Items.Add(roleTypes.PROJECTSACCESS);
            RolesCheckedBox.Items.Add(roleTypes.QUERYACCESS);
            RolesCheckedBox.Items.Add(roleTypes.ADMIN);


            List<Roles> profileRoles = profile.getRoles();
            profileRoles.ForEach(Role => RolesCheckedBox.SetItemChecked(RolesCheckedBox.Items.IndexOf(Role.getRole()), true));
            // This SHOULD go through each role, get the type and set the Role on the Check list to active... SHOULD 
            // Lamdba is weird to use and im still getting use to using it in these single line ForEach Loops

            //Name, Email, DOB...

            NameLabel.Text = profile.getName() + $" - Logging ID : {profile.getID().ToString()}";

            NameTextBox.Text = profile.getName();
            EmailTextBox.Text = profile.getEmail();
            DOBPicker.Value = profile.getDOB();
            wage.Value = decimal.Parse(profile.getWage().ToString());
            COntactInfo.Text = profile.getContactDetails();
            emergencyContact.Text = profile.getEmergencyContact();

            MedicalCheckBox.Checked = profile.isMedic();

        }

        private void StaffOverview_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Call SQL Update and reload Profile From sql 
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show($"Are you sure you wat to remove {this.staff.getName()}", "Remove Staff Account", MessageBoxButtons.YesNo);
            if(answer == DialogResult.Yes)
            {
                RemoveAccount();
            }
            
        }

        private void RemoveAccount()
        {
            throw new NotImplementedException();
        }
    }
}
