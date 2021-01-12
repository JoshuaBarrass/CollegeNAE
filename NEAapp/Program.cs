using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEAapp
{
    static class Program
    {

        //             ::::    :::   ::::::::::       ::::                ::::        :::::::::     ::::::::: 
        //            :+:+:   :+:   :+:             :+: :+:             :+: :+:      :+:    :+:    :+:    :+: 
        //           :+:+:+  +:+   +:+            +:+   +:+           +:+   +:+     +:+    +:+    +:+    +:+  
        //          +#+ +:+ +#+   +#++:++#      +#++:++#++:         +#++:++#++:    +#++:++#+     +#++:++#+    
        //         +#+  +#+#+#   +#+           +#+     +#+         +#+     +#+    +#+           +#+           
        //        #+#   #+#+#   #+#           #+#     #+#         #+#     #+#    #+#           #+#            
        //       ###    ####   ##########    ###     ###         ###     ###    ###           ###    

        /*
         * Version 1.0.15 - Added Small Functions to StaffProfile
         *                - Added And built on Staff Accounts window
         *                - Made Staff userControl For Window
         *                - Made new Staff Overview window for each staff account
         *                
         * 
         * Version 1.0.14 - Made the NoticeBoardmanager Form
         *                - Made New Usercontrol For ManageNoticeBoardItem
         *                - Fixed Issue With Log System Menu
         *                
         * Version 1.0.13 - Log System Beginning
         * Version 1.0.12 - Email system started and tested, can send an email from gmail account reliably
         * Version 1.0.11 - Made all classes currently needed for the Customer system and Project system to be put in place
         * Version 1.0.10 - made roles work with notice board
         *                - Made Notice board correctly add new notices
         *                - Added responce button to notice board without functionality : will use either email or seperate system
         *                
         * Version 1.0.7  - Began Redesign of main screen using panels - Allows for it to be adaptive to screen movement
         * Version 1.0.6  - Made main screen - to be redone just for testing at current point
         * Version 1.0.5  - Login and Creation of accounts is created and works with SQL databases
         * Version 1.0.4  - Made all currently needed databases for systems in place, more will be needed but small steps
         * 
         * 
         * 
         */

        /*  TODO:
         *   - Allow for a Project to exists : Will take multiple different databases but will be worth it
         *   : Will need a class of its own, an adaptive Usercontrol so it can be created on the main screen and work  
         *   : Needs to be interactive on main screen a little bit - Or just redirect to whole project page idk might be lazy
         *   : 
         *   - So customers shouldn't have a logon bc fuck doing that, all controlled through staff and staff Roles
         *   : a customer control panel will have their info only allowed to be viewed by a certain role though
         *   - Billing class is b-tec honestly, would do it properly aka: Account numebr sort code actual info but nut being intergrated with anything so nahh
         *   - I am 1000% overlooking something that will be a massive oversight when i try to do something but as long as i code everything to be very modular and not
         *   : really need anything else should be fine i guess
         * 
         */

        // Global variables visiable throught the whole program - used sparingly for only needed variables
        public static StaffProfile globalCurrentUser = new StaffProfile();
        public static string strDSN = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ..\..\Database\ProjectDatabase1.accdb"); //PLEASE DONT EVER TOUCH 
        public static string UPDATE = "1.0.15";
        internal static string Company = " Our Company";   // company name
        internal static string CompanyContactNumber = "07437758799"; // cmpoany number

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
