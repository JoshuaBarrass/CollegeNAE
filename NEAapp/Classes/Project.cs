using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEAapp.Classes
{
    class Project
    {
        // Projects need to be fully dynamic - X amount of any section 
        // Have any amount of staff on a simgle project
        // Projects need to be stored on an sql data base
        // Must store the following:
        //      Customer Data
        //      Logs of Customer Reports
        //      Current Staff on project - Using the ID's of their staff accounts
        //      Reports made on projects with every entry update
        //      An Entry system for when we work with them
        //      store of all reports ever created for the Customer project

        Customer projectCustomer = new Customer();
        List<int> currentStaffOnProject = new List<int>();
        




    }
}
