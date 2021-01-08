using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEAapp
{
    static class LogEvent
    {

        public static void LogStaffLogin(int staffID, string staffName)
        {
            var stdQuery = "INSERT INTO LogInformationTable ([UserId], [Information], [When]) " +
                "VALUES(?, ?, ?)";
            //             "INSERT INTO StaffTable (StaffUsername, StaffName, [DOB]) VALUES(@username, @name, @Dob)";
            OleDbConnection myConn3 = new OleDbConnection(Program.strDSN);       // Connects to database
            OleDbCommand myComm3 = new OleDbCommand(stdQuery, myConn3);     // Takes in connection and query
            myComm3.Parameters.Add("?", OleDbType.Integer).Value = staffID;
            myComm3.Parameters.Add("?", OleDbType.VarChar).Value = staffName + " Logged into System";
            myComm3.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;

            myConn3.Open();
            if (myComm3.ExecuteNonQuery() != 0)
            {
                //MessageBox.Show($"Login Successfully Logged ", "Login Added to log system");

            }
            else
            {
                MessageBox.Show("unknown Error", "SQL ERROR");
                return;
            }
            myConn3.Close();
        }

        public static void AddNotice(int staffID, string staffName, string NoticeInfo)
        {
            var stdQuery = "INSERT INTO LogInformationTable ([UserId], [Information], [When]) " +
                "VALUES(?, ?, ?)";
            //             "INSERT INTO StaffTable (StaffUsername, StaffName, [DOB]) VALUES(@username, @name, @Dob)";
            OleDbConnection myConn3 = new OleDbConnection(Program.strDSN);       // Connects to database
            OleDbCommand myComm3 = new OleDbCommand(stdQuery, myConn3);     // Takes in connection and query
            myComm3.Parameters.Add("?", OleDbType.Integer).Value = staffID;
            myComm3.Parameters.Add("?", OleDbType.VarChar).Value = staffName + " Added A Notice To The Notice Board System Saying '" + NoticeInfo + "'";
            myComm3.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;

            myConn3.Open();
            if (myComm3.ExecuteNonQuery() != 0)
            {
            }
            else
            {
                MessageBox.Show("unknown Error", "SQL ERROR");
                return;
            }
            myConn3.Close();
        }

        public static void RemovedNotice(int staffID, string staffName, string NoticeInfo)
        {
            var stdQuery = "INSERT INTO LogInformationTable ([UserId], [Information], [When]) " +
                "VALUES(?, ?, ?)";
            //             "INSERT INTO StaffTable (StaffUsername, StaffName, [DOB]) VALUES(@username, @name, @Dob)";
            OleDbConnection myConn3 = new OleDbConnection(Program.strDSN);       // Connects to database
            OleDbCommand myComm3 = new OleDbCommand(stdQuery, myConn3);     // Takes in connection and query
            myComm3.Parameters.Add("?", OleDbType.Integer).Value = staffID;
            myComm3.Parameters.Add("?", OleDbType.VarChar).Value = staffName + " Removed A NoticeBoard Item Saying '" + NoticeInfo + "'";
            myComm3.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;

            myConn3.Open();
            if (myComm3.ExecuteNonQuery() != 0)
            {
            }
            else
            {
                MessageBox.Show("unknown Error", "SQL ERROR");
                return;
            }
            myConn3.Close();
        }

        public static void LogStaffCreateAccount(int staffID, string staffName)
        {
            var stdQuery = "INSERT INTO LogInformationTable ([UserId], [Information], [When]) " +
                "VALUES(?, ?, ?)";
            //             "INSERT INTO StaffTable (StaffUsername, StaffName, [DOB]) VALUES(@username, @name, @Dob)";
            OleDbConnection myConn3 = new OleDbConnection(Program.strDSN);       // Connects to database
            OleDbCommand myComm3 = new OleDbCommand(stdQuery, myConn3);     // Takes in connection and query
            myComm3.Parameters.Add("?", OleDbType.Integer).Value = staffID;
            myComm3.Parameters.Add("?", OleDbType.VarChar).Value = staffName + " Created on System";
            myComm3.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;

            myConn3.Open();
            if (myComm3.ExecuteNonQuery() != 0)
            {
                //MessageBox.Show($"Login creation Successfully Logged ", "Login creation Added to log system");

            }
            else
            {
                MessageBox.Show("unknown Error", "SQL ERROR");
                return;
            }
            myConn3.Close();
        }




    }
}
