using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEAapp.Forms_Windows;

namespace NEAapp.UserControls
{
    public partial class StaffItem : UserControl
    {
        private StaffProfile staff;

        public StaffItem(StaffProfile profile)
        {
            InitializeComponent();

            this.staff = profile;

            NameLabel.Text = profile.getName() + $" - Logging ID : {profile.getID().ToString()}";
            doblable.Text = "DOB - " + profile.getDOB().Date.ToString();
            emaillabel.Text = profile.getEmail();

            if (profile.isMedic())
            {
                MedicalLabel.Show();
            }
            else
            {
                MedicalLabel.Hide();
            }

            contactinfo.Text = profile.getContactDetails();
            
        }

        private void moreinfobutton_Click(object sender, EventArgs e)
        {
            var overview = new StaffOverview(this.staff);
            overview.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool isAdmin()
        {
            return staff.checkRole(Classes.roleTypes.ADMIN);
        }

        public bool isMedic()
        {
            return staff.isMedic();
        }
    }
}
