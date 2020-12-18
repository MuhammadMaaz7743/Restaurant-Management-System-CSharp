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
    public partial class Menu_Module_List_Admin : Form
    {
        Menu_Module_All_Query_Admin view;
        //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Mohammad Maaz\Documents\Visual Studio 2013\Projects\Final Restaurant Management System\Access DataBase\Restaurant Management System Project.accdb");
        //OleDbCommand com;
        public Menu_Module_List_Admin()
        {
            InitializeComponent();
        }

        private void Menu_Module_List_Admin_Load(object sender, EventArgs e)
        {
            Food_Number_txt.Enabled=false;
            Food_Price_txt.Enabled=false;
            Food_Cate_txt.Enabled = false;
            Food_Name_txt.Enabled = false;
            Menu_Module_All_Query_Admin view = new Menu_Module_All_Query_Admin();
            DataTable t1 = new DataTable();
            t1 = view.ViewData();
            Menu_dataGridView.DataSource = t1;
        }

        private void Main_Back_btn_Click(object sender, EventArgs e)
        {
            Admin_Main_Page admin = new Admin_Main_Page();
            this.Hide();
            admin.Show();
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

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                view = new Menu_Module_All_Query_Admin(Food_Number_txt.Text, Food_Price_txt.Text, Food_Cate_txt.Text, Food_Name_txt.Text);
                view.InsertData();
                MessageBox.Show("Data is Inserted");
            }
            catch (Exception excep)
            {

                throw excep;
            }
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {

            view = new Menu_Module_All_Query_Admin(Food_Number_txt.Text);
            view.DeleteData();
            MessageBox.Show("Data Deleted Successfully.........");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Food_Number_txt.Text = "";
            Food_Price_txt.Text = "";
            Food_Cate_txt.Text = "";
            Food_Name_txt.Text = "";
        }

        private void Retrive_btn_Click(object sender, EventArgs e)
        {
            view = new Menu_Module_All_Query_Admin(Food_Number_txt.Text);
            DataTable t1 = new DataTable();
            t1 = view.ReterieveData();
            Food_Price_txt.Text = t1.Rows[0]["FOOD_PRICE"].ToString();
            Food_Cate_txt.Text = t1.Rows[0]["FOOD_CATEGORY"].ToString();
            Food_Name_txt.Text = t1.Rows[0]["FOOD_NAME"].ToString();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            Food_Number_txt.Enabled = true;
            Food_Price_txt.Enabled = true;
            Food_Cate_txt.Enabled = true;
            Food_Name_txt.Enabled = true;
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                view = new Menu_Module_All_Query_Admin(Food_Number_txt.Text, Food_Price_txt.Text, Food_Cate_txt.Text, Food_Name_txt.Text);
                view.UpdateData();
                MessageBox.Show("Data is Update");
            }
            catch (Exception excep)
            {

                throw excep;
            }




            //if (Food_Number_txt.Text != "" && Food_Price_txt.Text != "" && Food_Cate_txt.Text != "" && Food_Name_txt.Text != "")
            //{
            //    com = new OleDbCommand("update Menu_Mobule set FOOD_NAME=@FOOD_NAME,FOOD_PRICE=@FOOD_PRICE,FOOD_CATEGORY=@FOOD_CATEGORY where FOOD_NUMBER=@FOOD_NUMBER", con);
            //    con.Open();
            //    com.Parameters.AddWithValue("@FOOD_NAME", Food_Name_txt);
            //    com.Parameters.AddWithValue("@FOOD_PRICE", Food_Price_txt);
            //    com.Parameters.AddWithValue("@FOOD_CATEGORY", Food_Cate_txt);
            //    com.ExecuteNonQuery();
            //    MessageBox.Show("Record Updated Successfully");
            //    con.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Please Select Record to Update");
            //}  
        }
    }
}
