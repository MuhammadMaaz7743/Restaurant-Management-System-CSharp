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
    public partial class Menu_Module_List_Staff : Form
    {
        public Menu_Module_List_Staff()
        {
            InitializeComponent();
        }

        private void Menu_Module_List_Staff_Load(object sender, EventArgs e)
        {

            Menu_Module_All_Query_Staff view = new Menu_Module_All_Query_Staff();
            DataTable t1 = new DataTable();
            t1 = view.ViewData();
            Menu_dataGridView.DataSource = t1;
        }
        private void Main_Back_btn_Click_1(object sender, EventArgs e)
        {
            Staff_Main_Page admin = new Staff_Main_Page();
            this.Hide();
            admin.Show();
        }

        private void Exit_btn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOut_btn_Click_1(object sender, EventArgs e)
        {
            LOGIN_FORM login = new LOGIN_FORM();
            this.Hide();
            login.Show();
        }
    }
}
