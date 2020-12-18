using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Final_Restaurant_Management_System
{
    class Practice
    {
         public Practice()
        {
 
        }
         //public DataTable ReterieveData()
         //{
         //    All_DataBase_Con connection = new All_DataBase_Con();
         //    connection.getAllConnect();
             
         //    string query = "SELECT * FROM Deal_List";
         //    OleDbCommand command = new OleDbCommand(query, connection.getAllConnect());
         //    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
         //    DataTable table = new DataTable();
         //    adapter.Fill(table);
         //    return table;
         //}

        public DataTable RD()
         {
             All_DataBase_Con Con = new All_DataBase_Con();
             Con.getAllConnect();

             string q = "SELECT * FROM Home_Delivery";
             OleDbCommand com = new OleDbCommand(q, Con.getAllConnect());
             OleDbDataAdapter ad = new OleDbDataAdapter(com);
             DataTable tab = new DataTable();
             ad.Fill(tab);
             return tab;

         }
        public DataTable RDd()
        {
            All_DataBase_Con Con = new All_DataBase_Con();
            Con.getAllConnect();

            string q = "SELECT * FROM Menu_Mobule";
            OleDbCommand com = new OleDbCommand(q, Con.getAllConnect());
            OleDbDataAdapter ad = new OleDbDataAdapter(com);
            DataTable tab = new DataTable();
            ad.Fill(tab);
            return tab;

        }
    }
}
