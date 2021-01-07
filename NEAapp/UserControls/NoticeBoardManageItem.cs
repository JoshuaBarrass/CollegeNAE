using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using NEAapp.Forms_Windows;

namespace NEAapp.UserControls
{
    public partial class NoticeBoardManageItem : UserControl
    {
        private int sqlID;

        public NoticeBoardManageItem(string Title, string info, string User, DateTime date, int SQLID)
        {
            InitializeComponent();

            this.TitleLabel.Text = Title;
            this.DescriptionLabel.Text = info;
            this.UserLabel.Text = User;
            this.DateLabel.Text = date.ToString();
            this.sqlID = SQLID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            removeNotice();
        }

        public void removeNotice()
        {
            string squery = "DELETE FROM NoticeBoardTable WHERE ID = @id";

            OleDbConnection myConn = new OleDbConnection(Program.strDSN);       // Connects to database
            OleDbCommand myComm = new OleDbCommand(squery, myConn);     // Takes in connection and query
            myComm.Parameters.AddWithValue("@id", this.sqlID);   // puts variables into query in place of @something

            myConn.Open();

            myComm.ExecuteNonQuery();

            myConn.Close();

            NoticeBoardManager main = (NoticeBoardManager)this.FindForm();
            main.refreshBoard();

        }

        private void DescriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
