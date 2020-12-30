using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEAapp.Classes
{
    class Site
    {

        string SiteName;
        string Address;
        bool Main = false;
        string ISP;
        string phoneProv;
        string printerProv;
        List<Computer> computersOnSite = new List<Computer>();

        public Site(string Name, string Address, bool MainSite, string internet, string phone, string print) 
        {

            this.SiteName = Name;
            this.Address = Address;
            this.Main = MainSite;
            this.ISP = internet;
            this.phoneProv = phone;
            this.printerProv = print;

        }

        public Site()
        {

        }

        void addComputer(Computer newComp)
        {
            this.computersOnSite.Add(newComp);
        }

        void UpdateAllComputers(string UpdateNumber)
        {
            this.computersOnSite.ForEach(comp =>
            {
                if (comp.getCurrentUpdate() != UpdateNumber)   //List uses lambda so i have to do this :cry: 
                    comp.setUpdate(UpdateNumber);
            });
        }

        public bool isMain()
        {
            return this.Main;
        }

        public string getName()
        {
            if (this.SiteName != null)
                return this.SiteName;
            else
                return "Error - NULL SiteName";
        }

        public string getAddress()
        {
            if (this.Address != null)
                return this.Address;
            else
                return "Error - NULL Address";
        }

        public string getISP()
        {
            if (this.ISP != null)
                return this.ISP;
            else
                return "Error - NULL ISP";
        }

        public string getPhoneProv()
        {
            if (this.phoneProv != null)
                return this.phoneProv;
            else
                return "Error - NULL phoneProv";
        }

        public string getPrinterProv()
        {
            if (this.printerProv != null)
                return this.printerProv;
            else
                return "Error - NULL printerProv";
        }

        public void updateAddress(string newAddress)
        {
            this.Address = newAddress;
        }

        public void updateISP(string updateISP)
        {
            this.ISP = updateISP;
        }

        public void updatePrinterP(string updatePrinterP)
        {
            this.printerProv = updatePrinterP;
        }

        public void updatePhoneP(string updatePhoneP)
        {
            this.phoneProv = updatePhoneP;
        }

        public void addComputer(List<string> Hardware, string user, string av, string OS, string update )
        {
            this.computersOnSite.Add(new Computer(Hardware, DateTime.Now, user, av, OS, update));
        }

    }
}
