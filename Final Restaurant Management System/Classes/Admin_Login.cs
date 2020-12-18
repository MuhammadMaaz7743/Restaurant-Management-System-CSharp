using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Final_Restaurant_Management_System
{
    class Admin_Login
    {
        Admin_Connection AdminCon;
        string UserName;
        string Password;

        public Admin_Login()
        {
 
        }

        public Admin_Login(string _UserName , string _Password)
        {
            this.UserName = _UserName;
            this.Password = _Password;
        }

        public bool getAdminLogin()
        {
            AdminCon = new Admin_Connection();
            bool check;
            string query = "SELECT User_Name, Password FROM AdminLogin WHERE User_Name ='" + UserName + "' AND Password ='" + Password + "'";
            OleDbCommand cmd = new OleDbCommand(query, AdminCon.getAdminConnect());
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
