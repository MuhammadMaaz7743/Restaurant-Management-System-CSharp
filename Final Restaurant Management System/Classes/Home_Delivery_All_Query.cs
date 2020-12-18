using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Final_Restaurant_Management_System
{
    class Home_Delivery_All_Query :Inheritance_Home_Delivery_Admin
    {
        public Home_Delivery_All_Query()
        { 
        }
        public Home_Delivery_All_Query(string _Enter_City, string _Enter_Address, string _Order_Number, string _Order_Details)
        {
            Enter_City = _Enter_City;
            Enter_Address = _Enter_Address;
            Order_Number = _Order_Number;
            Order_Details = _Order_Details;
        }
        public Home_Delivery_All_Query(string _Order_Number)
        {
            Order_Number = _Order_Number;
        }
        public DataTable ViewData()
        {
            All_DataBase_Con connection = new All_DataBase_Con();
            connection.getAllConnect();

            string query = "SELECT * FROM Home_Delivery";
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
            InsertQuery = string.Format("Insert into `Home_Delivery`(`Enter_City`,`Enter_Address`,`Order_Number`,`Order_Details`) values ('{0}','{1}','{2}','{3}')", Enter_City, Enter_Address, Order_Number, Order_Details);
            OleDbCommand cmd = new OleDbCommand(InsertQuery, connection.getAllConnect());
            cmd.ExecuteNonQuery();
        }
        public override void DeleteData()
        {
            All_DataBase_Con connection = new All_DataBase_Con();
            connection.getAllConnect();
            string DeleteQuery;
            DeleteQuery = "Delete * From Home_Delivery Where Order_Number = '" + Order_Number + "'";
            OleDbCommand cmd = new OleDbCommand(DeleteQuery, connection.getAllConnect());
            cmd.ExecuteNonQuery();
        }
        public DataTable ReterieveData()
        {
            All_DataBase_Con connection = new All_DataBase_Con();
            connection.getAllConnect();
            string RetreiveQuery;
            RetreiveQuery = "Select * From Home_Delivery Where Order_Number = '" + Order_Number + "'";
            OleDbCommand cmd = new OleDbCommand(RetreiveQuery, connection.getAllConnect());
            DataTable table = new DataTable("Restaurant Management System Project");
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }
    }
}
