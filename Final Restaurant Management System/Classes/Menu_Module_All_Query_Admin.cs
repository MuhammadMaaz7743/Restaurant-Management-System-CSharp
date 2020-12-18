using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Final_Restaurant_Management_System
{
    class Menu_Module_All_Query_Admin : Inheritance_Menu_Module_All_Query_Admin
    {

        public Menu_Module_All_Query_Admin()
        {

        }
        public Menu_Module_All_Query_Admin(string _FOOD_NUMBER, string _FOOD_PRICE, string _FOOD_CATEGORY, string _FOOD_NAME)
        {
            FOOD_NUMBER = _FOOD_NUMBER;
            FOOD_PRICE = _FOOD_PRICE;
            FOOD_CATEGORY = _FOOD_CATEGORY;
            FOOD_NAME = _FOOD_NAME;
        }

        public Menu_Module_All_Query_Admin(string _FOOD_NUMBER)
        {
            FOOD_NUMBER = _FOOD_NUMBER;
        }
        public DataTable ViewData()
        {
            All_DataBase_Con connection = new All_DataBase_Con();
            connection.getAllConnect();

            string query = "SELECT * FROM Menu_Mobule";
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
            InsertQuery = string.Format("Insert into `Menu_Mobule`(`FOOD_NUMBER`,`FOOD_PRICE`,`FOOD_CATEGORY`,`FOOD_NAME`) values ('{0}','{1}','{2}','{3}')", FOOD_NUMBER, FOOD_PRICE, FOOD_CATEGORY, FOOD_NAME);
            OleDbCommand cmd = new OleDbCommand(InsertQuery, connection.getAllConnect());
            cmd.ExecuteNonQuery();
        }

        public override void DeleteData()
        {
            All_DataBase_Con connection = new All_DataBase_Con();
            connection.getAllConnect();
            string DeleteQuery;
            DeleteQuery = "Delete * From Menu_Mobule Where FOOD_NUMBER = '" + FOOD_NUMBER + "'";
            OleDbCommand cmd = new OleDbCommand(DeleteQuery, connection.getAllConnect());
            cmd.ExecuteNonQuery();
        }
        public DataTable ReterieveData()
        {
            All_DataBase_Con connection = new All_DataBase_Con();
            connection.getAllConnect();
            string RetreiveQuery;
            RetreiveQuery = "Select * From Menu_Mobule Where FOOD_NUMBER = '" + FOOD_NUMBER + "'";
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
            UpdateQuery = string.Format("Update `Menu_Mobule` SET FOOD_PRICE = '"+ FOOD_PRICE,"'FOOD_CATEGORY = '"+ FOOD_CATEGORY,"'FOOD_CATEGORY = '"+ FOOD_CATEGORY,"'FOOD_NAME = '"+ FOOD_NAME, "Where FOOD_NUMBER = '" + FOOD_NUMBER +"'");
                //(`FOOD_NUMBER`,`FOOD_PRICE`,`FOOD_CATEGORY`,`FOOD_NAME`) values ('{0}','{1}','{2}','{3}')", FOOD_NUMBER, FOOD_PRICE, FOOD_CATEGORY, FOOD_NAME);
            OleDbCommand cmd = new OleDbCommand(UpdateQuery, connection.getAllConnect());
            cmd.ExecuteNonQuery();
        }
    }
}
