using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEAapp
{
    static class Program
    {

        // Global variables visiable throught the whole program - used sparingly for only needed variables
        public static StaffProfile globalCurrentUser = new StaffProfile();
        public static string strDSN = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ..\..\Database\ProjectDatabase1.accdb");
        public static string UPDATE = "1.0.5";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginScreen());
            
        }
    }
}
