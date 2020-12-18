using NEAapp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NEAapp
{
    class StaffProfile
    {

        private int ValidId; // ID link in SQL TABLE
        private string Name; // users name
        private DateTime DOB; // users DOB
        private DateTime workedSince; // users worked since
        private List<Roles> aquiredRoles = new List<Roles>(); // Roles Aquired By User
        private bool isAdmin = false; // If user is Admin
        private string Contract; // Either Link to Persons contract or copy/paste of contract
        private double wage; // users wage
        private string email; // users email
        private string contactDetails; //users contact details
        private DateTime[,] timeOff = new DateTime[1000, 1]; //users time off    [Beginning of time off, End of time off] .:   [x,1] - [x,0] = TotalTimeOff
        private string emergencyContact; // users Emergency Contact
        private bool isMedicallyTrained; // if users is medically trained
        private double hoursWorkedInLastWeek; // the hours the user has worked in the last week


        // Initilising Object
        public StaffProfile(string Name, DateTime DOB, DateTime workedSince, bool admin, string contract,
            double acceptedWage, string email, string contactDetails, string emergencycontact, bool medical, List<int> givenRoles = null)
        {

            this.Name = Name;
            this.DOB = DOB;
            this.workedSince = workedSince;

            this.wage = acceptedWage;
            this.email = email;
            this.contactDetails = contactDetails;
            this.emergencyContact = emergencycontact;
            this.isMedicallyTrained = medical;

            this.isAdmin = admin;
            this.Contract = contract;

            if (givenRoles != null)
            {

                var SortedRoles = new List<Roles>();

                foreach (var item in givenRoles)
                {
                    SortedRoles.Add(new Roles(IntToRole(int.Parse(item.ToString())))); //Change numbers to roleTypes
                }

                foreach (var role in SortedRoles)
                {
                    this.aquiredRoles.Add(role);
                }
            }

            if (this.isAdmin && !this.aquiredRoles.Contains(new Roles(roleTypes.ADMIN, 1)))
            {
                this.aquiredRoles.Add(new Roles(roleTypes.ADMIN, 1));
            }

        }

        public StaffProfile()
        {

        }

        public void InitProfile(string Name, DateTime DOB, DateTime workedSince, bool admin, string contract,
            double acceptedWage, string email, string contactDetails, string emergencycontact, bool medical, List<int> givenRoles = null)
        {
            this.Name = Name;
            this.DOB = DOB;
            this.workedSince = workedSince;

            this.wage = acceptedWage;
            this.email = email;
            this.contactDetails = contactDetails;
            this.emergencyContact = emergencycontact;
            this.isMedicallyTrained = medical;

            this.isAdmin = admin;
            this.Contract = contract;



            if (givenRoles != null)
            {

                var SortedRoles = new List<Roles>();

                foreach (var item in givenRoles)
                {
                    SortedRoles.Add(new Roles(IntToRole(int.Parse(item.ToString())))); //Change numbers to roleTypes
                }

                foreach (var role in SortedRoles)
                {
                    this.aquiredRoles.Add(role);
                }
            }

            if (this.isAdmin && !this.aquiredRoles.Contains(new Roles(roleTypes.ADMIN, 1)))
            {
                this.aquiredRoles.Add(new Roles(roleTypes.ADMIN, 1));
            }
        }


        //Getting and Setting All basic vars
        //Name
        public string getName()
        {
            return this.Name;
        }
        public void setName(string Name)
        {
            this.Name = Name;
        }

        // date of birth
        public DateTime getDOB()
        {
            return this.DOB;
        }
        public void setDOB(DateTime newDOB)
        {
            this.DOB = newDOB;
        }

        // Start date / worked since
        public DateTime getStartDate()
        {
            return this.workedSince;
        }

        // Roles
        public bool checkRole(roleTypes role)
        {
            foreach (var Role in this.aquiredRoles)
            {
                if (Role.getRole() == role)
                {
                    return true;
                }
            }
            return false;
        }
        public bool addRole(roleTypes role, int Level)
        {

            if (this.checkRole(role))
                return false;

            this.aquiredRoles.Add(new Roles(role, Level));
            return true;

        }
        public bool updateRoleLevel(roleTypes role, int newLevel)
        {

            if (this.checkRole(role))
            {

                foreach (var Role in this.aquiredRoles)
                {
                    if (Role.getRole() == role)
                    {
                        if (Role.getRoleLevel() == newLevel)
                            return false;            // Returns false if the User already has this role level
                    }
                }

                this.aquiredRoles.Find(aRole => aRole.getRole() == role).setRoleLevel(newLevel); // finds role in the 
                return true;
            }
            return false;
        }
        public bool removeRole(roleTypes role)
        {
            if (!this.checkRole(role))
                return false;

            this.aquiredRoles.Remove(   //Removing the role that has the given role using the find function
                this.aquiredRoles.Find(aRole => aRole.getRole() == role));
            return true;
        }

        // Admin role
        public bool checkAdmin()
        {
            return this.isAdmin;
        }
        public void setAdmin(bool SET)
        {
            if (this.checkRole(roleTypes.ADMIN) && !SET)
            {
                this.removeRole(roleTypes.ADMIN);
                this.isAdmin = SET;
            }
            else if (!this.checkRole(roleTypes.ADMIN) && SET)
            {
                this.addRole(roleTypes.ADMIN, 1);
                this.isAdmin = SET;
            }
        }

        // Users contract
        public string getContract()
        {
            return this.Contract;
        }
        public bool updateContract(string newContract)
        {
            try
            {
                this.Contract = newContract;
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Users wage
        public double getWage()
        {
            return this.wage;
        }
        public void updateWage(double wage)
        {
            this.wage = wage;
        }

        // Users email
        public string getEmail()
        {
            return this.email;
        }
        public void setEmail(string newEmail)
        {
            this.email = newEmail;
        }

        // users contract details
        public string getContactDetails()
        {
            return this.contactDetails;
        }
        public void updateContactDetails(string newContactDetails)
        {
            this.contactDetails = newContactDetails;
        }

        // users used time off
        public bool addTimeOff(DateTime Start, DateTime End)
        {
            int endIndex = this.timeOff.Length;
            try
            {
                this.timeOff[endIndex, 0] = Start;
                this.timeOff[endIndex, 1] = End;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int getTotalTimeOff()
        {
            int sumOfTimeOff = 0;

            for (int i = 0; i < this.timeOff.Length - 1; i++)
            {
                sumOfTimeOff += (this.timeOff[i, 1] - this.timeOff[i, 0]).Hours;
            }

            return sumOfTimeOff;   //returns Total Time off in hours

        }
        public string[] getTimeOffDetialed()
        {
            string[] timeOffInfo = new string[1000];
            int counter = 0;
            for (int i = 0; i < this.timeOff.Length - 1; i++)
            {

                timeOffInfo[i] = ($"Start: {this.timeOff[i, 0]}   End: {this.timeOff[i, 1]}    Time: {(this.timeOff[i, 1] - this.timeOff[i, 0]).Hours.ToString()}");

                counter = i;
            }
            timeOffInfo[counter + 1] = ($"Total Time off: {this.getTotalTimeOff()}");

            return timeOffInfo;
        }

        // Users emergency contract
        public string getEmergencyContact()
        {
            return this.emergencyContact;
        }
        public void setEmergencyContact(string newcontact)
        {
            this.emergencyContact = newcontact;
        }

        // if user is medically trianed
        public bool isMedic()
        {
            return this.isMedicallyTrained;
        }
        public void setmedical(bool SET)
        {
            this.isMedicallyTrained = SET;
        }

        // hours user has worked in last the Last wekk
        public double hoursWorked()
        {
            return this.hoursWorkedInLastWeek;
        }
        public void resetHoursWorked()
        {
            this.hoursWorkedInLastWeek = 0f;
        }
        public void addHoursWorked(double Hours)
        {
            this.hoursWorkedInLastWeek += Hours;
        }


        public roleTypes IntToRole(int enumNumber)
        {
            switch (enumNumber)
            {
                case 0:
                    return roleTypes.GENERALSTAFF;
                    break;
                case 1:
                    return roleTypes.ENGINEER;
                    break;
                case 2:
                    return roleTypes.ACCOUNTANT;
                    break;
                case 3:
                    return roleTypes.MANAGER;
                    break;
                case 4:
                    return roleTypes.SUPERVISOR;
                    break;
                case 5:
                    return roleTypes.NOTICEBOARDACCESS;
                    break;
                case 6:
                    return roleTypes.INVOICEACCESS;
                    break;
                case 7:
                    return roleTypes.PROJECTSACCESS;
                    break;
                case 8:
                    return roleTypes.QUERYACCESS;
                    break;
                case 9:
                    return roleTypes.ADMIN;
                default:
                    return roleTypes.GENERALSTAFF;
                    break;

            }
        }

    }
}
