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
    public partial class Staff_List_Admin : Form
    {
        Staff_All_Query view;
        public Staff_List_Admin()
        {
            InitializeComponent();
        }

        private void Staff_List_Admin_Load(object sender, EventArgs e)
        {

            Staff_Name_txt.Enabled = false;
            Shift_Timming_txt.Enabled = false;
            Salaray_Details_txt.Enabled = false;
            Attendence_Total_txt.Enabled = false;

            Staff_All_Query view = new Staff_All_Query();
            DataTable t1 = new DataTable();
            t1 = view.ViewData();
            Staff_List_dataGridView.DataSource = t1;
        }

        private void Main_Back_btn_Click(object sender, EventArgs e)
        {
            Admin_Main_Page admin = new Admin_Main_Page();
            this.Hide();
            admin.Show();
        }

        private void LogOut_btn_Click(object sender, EventArgs e)
        {
            LOGIN_FORM login = new LOGIN_FORM();
            this.Hide();
            login.Show();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Staff_List_dataGridView_Click(object sender, EventArgs e)
        {

            string Name = Staff_List_dataGridView.Rows[Staff_List_dataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();


            All_DataBase_Con connection = new All_DataBase_Con();
            connection.getAllConnect();

            string query = "SELECT * FROM Maaz_Attendence WHERE Staff_Name='"+ Name  +"'" ;
            OleDbCommand command = new OleDbCommand(query, connection.getAllConnect());
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Staff_Name_txt.Text = "";
            Shift_Timming_txt.Text = "";
            Salaray_Details_txt.Text = "";
            Attendence_Total_txt.Text = "";
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            Staff_Name_txt.Enabled = true;
            Shift_Timming_txt.Enabled = true;
            Salaray_Details_txt.Enabled = true;
            Attendence_Total_txt.Enabled = true;

        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                view = new Staff_All_Query(Staff_Name_txt.Text, Shift_Timming_txt.Text, Salaray_Details_txt.Text, Attendence_Total_txt.Text);
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
            view = new Staff_All_Query(Staff_Name_txt.Text);
            view.DeleteData();
            MessageBox.Show("Data Deleted Successfully.........");
        }

        private void Retrive_Click(object sender, EventArgs e)
        {
            view = new Staff_All_Query(Staff_Name_txt.Text);
            DataTable t1 = new DataTable();
            t1 = view.ReterieveData();
            Shift_Timming_txt.Text = t1.Rows[0]["Shift_Timming"].ToString();
            Salaray_Details_txt.Text = t1.Rows[0]["Salaray_Details"].ToString();
            Attendence_Total_txt.Text = t1.Rows[0]["Attendence"].ToString();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                view = new Staff_All_Query(Staff_Name_txt.Text, Shift_Timming_txt.Text, Salaray_Details_txt.Text, Attendence_Total_txt.Text);
                view.UpdateData();
                MessageBox.Show("Data is Updated");
            }
            catch (Exception excep)
            {

                throw excep;
            }
        }

        private void Staff_List_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void Staff_List_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                Console.WriteLine("madsa");
            }
            if (e.ColumnIndex == 2)
            {
                Console.WriteLine("2");
            }
            if (e.ColumnIndex == 2)
            {
                Console.WriteLine("3");
            }
        }
    }
}
