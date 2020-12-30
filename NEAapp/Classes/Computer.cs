using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEAapp.Classes
{
    class Computer
    {

        List<string> Hardware = new List<string>();
        DateTime timeOfInstall;
        string primaryUser;
        string av;
        List<DateTime> pastUpdates = new List<DateTime>();
        string currentOS;
        string currentUpdate;

        public Computer(List<string> Hardware, DateTime timeFInstall, string primUser, string AV, string OS, string lastUpdate)
        {
            this.Hardware = Hardware;
            this.timeOfInstall = timeFInstall;
            this.primaryUser = primUser;
            this.av = AV;
            this.currentOS = OS;
            this.currentUpdate = lastUpdate;
        }

        public Computer()
        {

        }

        public string getOs()
        {
            if (this.currentOS != null)
                return this.currentOS;
            else
                return "Error - NULL OS";
        }

        public DateTime getDOI()
        {
            if (this.timeOfInstall != null)
                return this.timeOfInstall;
            else
                return DateTime.Now;
        }

        public string getUser()
        {
            if (this.primaryUser != null)
                return this.primaryUser;
            else
                return "Error - NULL primaryUser";
        }

        public string getAv()
        {
            if (this.av != null)
                return this.av;
            else
                return "Error - NULL av";
        }
        
        public string getCurrentUpdate()
        {
            if (this.currentUpdate != null)
                return this.currentUpdate;
            else
                return "Error - NULL currentUpdate";
        }

        public bool checkUpdate(string lastest)
        {
            if (this.currentUpdate != lastest)
            {
                return false;
            }
            else
                return true;
        }

        public void setUpdate(string Update)
        {
            this.currentUpdate = Update;
            this.pastUpdates.Add(DateTime.Now);
        }


    }
}
