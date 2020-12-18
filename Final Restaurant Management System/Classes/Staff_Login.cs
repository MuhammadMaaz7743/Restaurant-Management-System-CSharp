using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Final_Restaurant_Management_System
{
    class Staff_Login
    {
        Staff_Connection StaffCon;
        string UserName;
        string Password;

        public Staff_Login()
        {
 
        }

        public Staff_Login(string _UserName , string _Password)
        {
            this.UserName = _UserName;
            this.Password = _Password;
        }

        public bool getStaffLogin()
        {
           StaffCon = new Staff_Connection();
            bool check;
            string query = "SELECT User_Name, Password FROM StaffLogin WHERE User_Name ='" + UserName + "' AND Password ='" + Password + "'";
            OleDbCommand cmd = new OleDbCommand(query, StaffCon.getStaffConnect());
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }
    }
}
