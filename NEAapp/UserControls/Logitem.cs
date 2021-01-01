using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEAapp.UserControls
{
    public partial class Logitem : UserControl
    {
        public Logitem(string Name, DateTime when, string info)
        {
            InitializeComponent();

            NameTag.Text = "User ID : " + Name;
            Date.Text = when.ToString();
            InfoTag.Text = info;

        }

        private void InfoTag_Click(object sender, EventArgs e)
        {

        }
    }
}
