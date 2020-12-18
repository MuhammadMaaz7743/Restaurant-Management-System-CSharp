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
    public partial class Home_Delivery_Admin : Form
    {
        Home_Delivery_All_Query view;
        public Home_Delivery_Admin()
        {
            InitializeComponent();
        }

        private void Home_Delivery_Admin_Load(object sender, EventArgs e)
        {
            OrderNumber_txt.Enabled = false;
            Enter_city_txt.Enabled =false;
            Enter_Address_txt.Enabled = false;
            Order_Details_txt.Enabled = false;

            Home_Delivery_All_Query view = new Home_Delivery_All_Query();
            DataTable t1 = new DataTable();
            t1 = view.ViewData();
            Home_Admin_dataGridView.DataSource = t1;
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
            Admin_Main_Page admin = new Admin_Main_Page();
            this.Hide();
            admin.Show();
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                view = new Home_Delivery_All_Query(Enter_city_txt.Text,Enter_Address_txt.Text,OrderNumber_txt.Text,Order_Details_txt.Text);
                view.InsertData();
                MessageBox.Show("Data is Inserted");
            }
            catch (Exception excep)
            {

                throw excep;
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            view = new Home_Delivery_All_Query(OrderNumber_txt.Text);
            view.DeleteData();
            MessageBox.Show("Data Deleted Successfully.........");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            OrderNumber_txt.Text = "";
            Enter_city_txt.Text = "";
            Enter_Address_txt.Text = "";
            Order_Details_txt.Text = "";
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            OrderNumber_txt.Enabled = true;
            Enter_city_txt.Enabled = true;
            Enter_Address_txt.Enabled = true;
            Order_Details_txt.Enabled = true;
        }

        private void Retrive_Click(object sender, EventArgs e)
        {
            view = new Home_Delivery_All_Query(OrderNumber_txt.Text);
            DataTable t1 = new DataTable();
            t1 = view.ReterieveData();
            Enter_Address_txt.Text = t1.Rows[0]["Enter_Address"].ToString();
            Enter_city_txt.Text = t1.Rows[0]["Enter_City"].ToString();
            Order_Details_txt.Text = t1.Rows[0]["Order_Details"].ToString();
        }
    }
}
