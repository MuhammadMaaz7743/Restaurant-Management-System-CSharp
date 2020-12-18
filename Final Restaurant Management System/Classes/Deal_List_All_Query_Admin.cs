using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Final_Restaurant_Management_System
{
    class Deal_List_All_Query_Admin :Inheritance_Deal_List_All_Query_Admin
    {
        public Deal_List_All_Query_Admin()
        {

        }
        public Deal_List_All_Query_Admin(string _Deal_Code, string _Deal_Name, string _Food_Names, string _Deal_Rate)
        {
            Deal_Code = _Deal_Code;
            Deal_Name = _Deal_Name;
            Food_Names = _Food_Names;
            Deal_Rate = _Deal_Rate;
        }

        public Deal_List_All_Query_Admin(string _Deal_Code)
        {
            Deal_Code = _Deal_Code;
        }
        public DataTable ViewData()
        {
            All_DataBase_Con connection = new All_DataBase_Con();
            connection.getAllConnect();

            string query = "SELECT * FROM Deal_List";
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
            InsertQuery = string.Format("Insert into `Deal_List`(`Deal_Code`,`Deal_Name`,`Food_Names`,`Deal_Rate`) values ('{0}','{1}','{2}','{3}')", Deal_Code, Deal_Name, Food_Names, Deal_Rate);
            OleDbCommand cmd = new OleDbCommand(InsertQuery, connection.getAllConnect());
            cmd.ExecuteNonQuery();
        }

        public override void DeleteData()
        {
            All_DataBase_Con connection = new All_DataBase_Con();
            connection.getAllConnect();
            string DeleteQuery;
            DeleteQuery = "Delete * From Deal_List Where Deal_Code = '" + Deal_Code + "'";
            OleDbCommand cmd = new OleDbCommand(DeleteQuery, connection.getAllConnect());
            cmd.ExecuteNonQuery();
        }
        public DataTable ReterieveData()
        {
            All_DataBase_Con connection = new All_DataBase_Con();
            connection.getAllConnect();
            string RetreiveQuery;
            RetreiveQuery = "Select * From Deal_List Where Deal_Code = '" + Deal_Code + "'";
            OleDbCommand cmd = new OleDbCommand(RetreiveQuery, connection.getAllConnect());
            DataTable table = new DataTable("Restaurant Management System Project");
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
    }
}
