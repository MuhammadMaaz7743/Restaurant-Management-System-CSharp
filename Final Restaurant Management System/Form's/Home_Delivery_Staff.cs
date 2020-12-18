using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Final_Restaurant_Management_System
{
    public partial class Home_Delivery_Staff : Form
    {
        public Home_Delivery_Staff()
        {
            InitializeComponent();
        }

        private void Home_Delivery_Staff_Load(object sender, EventArgs e)
        {
            All_DataBase_Con connection = new All_DataBase_Con();
            connection.getAllConnect();

            string query = "SELECT * FROM Home_Delivery";
            OleDbCommand command = new OleDbCommand(query, connection.getAllConnect());
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Home_Admin_dataGridView.DataSource = table;
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOut_btn_Click(object sender, EventArgs e)
        {
            LOGIN_FORM login = new LOGIN_FORM();
            this.Hide();
            login.Show();
        }

        private void Main_Back_btn_Click(object sender, EventArgs e)
        {
            Staff_Main_Page admin = new Staff_Main_Page();
            this.Hide();
            admin.Show();
        }
    }
}
