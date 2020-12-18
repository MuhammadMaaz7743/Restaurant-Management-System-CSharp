using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Final_Restaurant_Management_System
{
    class All_DataBase_Con
    {
        public OleDbConnection getAllConnect()
        {
            try
            {
                string path = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\All Work's\Object Oriented Programing\Projects all\Final Restaurant Management System\Access DataBase\Restaurant Management System Project.accdb";

                OleDbConnection con = new OleDbConnection(path);
                con.Open();
                return con;
            }
            catch (Exception excep)
            {
                throw excep;
            }
        }
    }
}
