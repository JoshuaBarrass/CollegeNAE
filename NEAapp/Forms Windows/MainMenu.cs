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
    public partial class MainMenu : Form
    {
        public MainMenu(int id)
        {
            InitializeComponent();

            LoadStaffAccount(id);

        }

        private void LoadStaffAccount(int id)
        {

            throw new NotImplementedException();


            // SELECT * FROM StaffTable WHERE Id = id
            // Load all into global staff object

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
