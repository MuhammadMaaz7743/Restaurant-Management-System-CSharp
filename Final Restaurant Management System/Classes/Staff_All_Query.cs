using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Final_Restaurant_Management_System
{
    class Staff_All_Query : Inheritance_Staff_All_Query
    {
        public Staff_All_Query()
        { 
        }

        public Staff_All_Query(string _Staff_Name, string _Shift_Timming, string _Salary_Details, string _Attendence)
        {
            Staff_Name = _Staff_Name;
            Shift_Timming = _Shift_Timming;
            Salary_Details = _Salary_Details;
            Attendence = _Attendence;
        }
        public Staff_All_Query(string _Staff_Name)
        {
            Staff_Name = _Staff_Name;
        }
        public DataTable ViewData()
        {
            All_DataBase_Con connection = new All_DataBase_Con();
            connection.getAllConnect();

            string query = "SELECT * FROM Staff_List";
            OleDbCommand command = new OleDbCommand(query, connection.getAllConnect());
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public override void InsertData()
        {
            All_DataBase_Con connection = new All_DataBase_Con();
            connection.getAllConnect();
            string InsertQuery;
            InsertQuery = string.Format("Insert into `Staff_List`(`Staff_Name`,`Shift_Timming`,`Salary_Details`,`Attendence`) values ('{0}','{1}','{2}','{3}')", Staff_Name, Shift_Timming, Salary_Details, Attendence);
            OleDbCommand cmd = new OleDbCommand(InsertQuery, connection.getAllConnect());
            cmd.ExecuteNonQuery();
        }

        public override void DeleteData()
        {
            All_DataBase_Con connection = new All_DataBase_Con();
            connection.getAllConnect();
            string DeleteQuery;
            DeleteQuery = "Delete * From Menu_Mobule Where Staff_Name = '" + Staff_Name + "'";
            OleDbCommand cmd = new OleDbCommand(DeleteQuery, connection.getAllConnect());
            cmd.ExecuteNonQuery();
        }
        public DataTable ReterieveData()
        {
            All_DataBase_Con connection = new All_DataBase_Con();
            connection.getAllConnect();
            string RetreiveQuery;
            RetreiveQuery = "Select * From Staff_List Where Staff_Name = '" + Staff_Name + "'";
            OleDbCommand cmd = new OleDbCommand(RetreiveQuery, connection.getAllConnect());
            DataTable table = new DataTable("Restaurant Management System Project");
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
        public override void UpdateData()
        {
            All_DataBase_Con connection = new All_DataBase_Con();
            connection.getAllConnect();
            string UpdateQuery;
            UpdateQuery = string.Format("Update `Staff_List` Where (`Staff_Name`,`Shift_Timming`,`Salary_Details`,`Attendence`) values ('{0}','{1}','{2}','{3}')", Staff_Name, Shift_Timming, Salary_Details, Attendence);
            OleDbCommand cmd = new OleDbCommand(UpdateQuery, connection.getAllConnect());
            cmd.ExecuteNonQuery();
        }
    }
}
