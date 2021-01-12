using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEAapp.Classes
{

    public enum roleTypes : int
    {
        GENERALSTAFF = 0,
        ENGINEER,
        ACCOUNTANT,
        MANAGER,
        SUPERVISOR,
        NOTICEBOARDACCESS,
        INVOICEACCESS,
        PROJECTSACCESS,
        QUERYACCESS,
        ADMIN

    }



    public class Roles
    {
        private roleTypes role;
        private int roleLevel;

        public Roles(roleTypes type, int roleLevel = 0)
        {
            this.role = type;
            this.roleLevel = roleLevel;
        }

        public void setRoleLevel(int Level)
        {
            this.roleLevel = Level;
        }

        public roleTypes getRole()
        {
            return this.role;
        }

        public int getRoleLevel()
        {
            return this.roleLevel;
        }


    }
}
