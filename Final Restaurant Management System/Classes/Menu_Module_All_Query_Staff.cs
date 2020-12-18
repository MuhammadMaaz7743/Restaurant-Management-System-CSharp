using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Final_Restaurant_Management_System
{
    class Menu_Module_All_Query_Staff
    {
        public Menu_Module_All_Query_Staff()
        {

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
    }
}
