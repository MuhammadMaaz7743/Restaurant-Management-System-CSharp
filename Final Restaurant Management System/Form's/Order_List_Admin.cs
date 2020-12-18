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
using System.Diagnostics;

namespace Final_Restaurant_Management_System
{
    public partial class Order_List_Admin : Form
    {
        public Order_List_Admin()
        {
            InitializeComponent();
        }

        private void Order_List_Admin_Load(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://www.facebook.com/";
            linkLabel1.Links.Add(link);

            Total_txt.Enabled = false;
            Order_Number_txt.Enabled = false;
            Order_dateTime.Enabled = false;
            Random ran = new Random();
            int num = ran.Next(10000000, 99999999);
            Order_Number_txt.Text = num.ToString();

            All_DataBase_Con connection = new All_DataBase_Con();
            connection.getAllConnect();

            string query = "SELECT * FROM Order_List";
            OleDbCommand command = new OleDbCommand(query, connection.getAllConnect());
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Order_Admin_dataGridView.DataSource = table;
            Order_Admin_dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Purple;
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
        private void Reload_Btn_Click(object sender, EventArgs e)
        {
            Order_List_Admin order_list = new Order_List_Admin();
            this.Hide();
            order_list.Show();
        }

        private void Order_Admin_dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Copy By Net
            decimal qty = 0;
            decimal price = 0;
            //Trim method removes any characters from the current instance
            if (Order_Admin_dataGridView.CurrentRow.Cells["Quantity"].Value != null && Order_Admin_dataGridView.CurrentRow.Cells["Quantity"].Value.ToString().Trim() != "")
            {
                qty = Convert.ToDecimal(Order_Admin_dataGridView.CurrentRow.Cells["Quantity"].Value);
            }
            if (Order_Admin_dataGridView.CurrentRow.Cells["Rate"].Value != null && Order_Admin_dataGridView.CurrentRow.Cells["Rate"].Value.ToString().Trim() != "")
            {
                price = Convert.ToDecimal(Order_Admin_dataGridView.CurrentRow.Cells["Rate"].Value);
            }

            Order_Admin_dataGridView.CurrentRow.Cells["Amount"].Value = qty * price;
        }

        private void Total_Btn_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < Order_Admin_dataGridView.Rows.Count; i++)
            {
                sum += Convert.ToInt32(Order_Admin_dataGridView.Rows[i].Cells[5].Value);
            }
            int count_row = Order_Admin_dataGridView.Rows.Count;
            int add = sum + count_row;
            this.Total_txt.Text = sum.ToString();
        }

        private void Print_btn_Click(object sender, EventArgs e)
        {
            //Copy By Net
            PrintDialog dlg = new PrintDialog();
            dlg.ShowDialog();
        }
        private void AutoCalulateTotal()
        {
            double a = double.Parse(Total_txt.Text);
            double sum = a / 100 * 80;
            Total_txt.Text = sum.ToString();

        }
        private void Discount_btn_Click(object sender, EventArgs e)
        {
            AutoCalulateTotal();
        }

        private void AutoCalulateTotal1()
        {
            double a = double.Parse(Total_txt.Text);
            double b = double.Parse(textBox1.Text);
           // double c = double.Parse(textBox2.Text);
            double sum1 = b - a;
            textBox2.Text =sum1.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutoCalulateTotal1();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "Chrome.exe";
            proc.StartInfo.Arguments = "http://www.Facebook.com";
            proc.Start();
            proc.Close();
            proc.Dispose(); 
        }
    }
}
