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
using System.Media;

namespace Final_Restaurant_Management_System
{
    public partial class Deal_List_Admin : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        Deal_List_All_Query_Admin view;
        
        public Deal_List_Admin()
        {
            InitializeComponent();
            Deal_Code_txt.Enabled = false;
            toolTip.InitialDelay = 0;
            player.SoundLocation = @"C:\Users\Mohammad Maaz\Downloads\cell-phone-flip-1.wav";
        }

        private void Deal_List_Admin_Load(object sender, EventArgs e)
        {
            Deal_Code_txt.Enabled = false;
            Deal_Name_txt.Enabled = false;
            Food_Names_txt.Enabled = false;
            Deal_Rate_txt.Enabled = false;

            Deal_List_All_Query_Admin view = new Deal_List_All_Query_Admin();
            DataTable t1 = new DataTable();
            t1 = view.ViewData();
            Deal_Admin_dataGridView.DataSource = t1;
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            player.Play();
            Application.Exit();
        }

        private void LogOut_btn_Click(object sender, EventArgs e)
        {
            player.Play();
            LOGIN_FORM login = new LOGIN_FORM();
            this.Hide();
            login.Show();
        }

        private void Main_Back_btn_Click(object sender, EventArgs e)
        {
            //player.Play();
            SystemSounds.Beep.Play();
            Admin_Main_Page admin = new Admin_Main_Page();
            this.Hide();
            admin.Show();
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                view = new Deal_List_All_Query_Admin(Deal_Code_txt.Text, Deal_Name_txt.Text, Food_Names_txt.Text, Deal_Rate_txt.Text);
                view.InsertData();
                MessageBox.Show("Data is Inserted");
            }
            catch (Exception excep)
            {

                throw excep;
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            view = new Deal_List_All_Query_Admin(Deal_Code_txt.Text);
            DataTable t1 = new DataTable();
            t1 = view.ReterieveData();
            Deal_Name_txt.Text = t1.Rows[0]["Deal_Name"].ToString();
            Food_Names_txt.Text = t1.Rows[0]["Food_Names"].ToString();
            Deal_Rate_txt.Text = t1.Rows[0]["Deal_Rate"].ToString();
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            view = new Deal_List_All_Query_Admin(Deal_Code_txt.Text);
            view.DeleteData();
            MessageBox.Show("Data Deleted Successfully.........");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            player.Play();
            Deal_Code_txt.Text = "";
            Deal_Name_txt.Text = "";
            Food_Names_txt.Text = "";
            Deal_Rate_txt.Text = "";
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            player.Play();
            Deal_Code_txt.Enabled = true;
            Deal_Name_txt.Enabled = true;
            Food_Names_txt.Enabled = true;
            Deal_Rate_txt.Enabled = true;
        }

        private void Deal_Rate_txt_MouseMove(object sender, MouseEventArgs e)
        {
            if (Deal_Code_txt == this.GetChildAtPoint(e.Location))
            {
                if (!isShown)
                {
                    toolTip.Show("MyToolTip", this, e.Location);
                    isShown = true;
                }
            }
            else
            {
                toolTip.Hide(Deal_Code_txt);
                isShown = false;
            }
        }
        private ToolTip toolTip = new ToolTip();
        private bool isShown = false;
        private void Deal_List_Admin_MouseMove(object sender, MouseEventArgs e)
        {
            if (Deal_Code_txt == this.GetChildAtPoint(e.Location))
            {
                if (!isShown)
                {
                    toolTip.Show("MyToolTip", this, e.Location);
                    isShown = true;
                }
            }
            else
            {
                toolTip.Hide(Deal_Code_txt);
                isShown = false;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void Deal_Admin_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                MessageBox.Show("1");
                Practice vi = new Practice();
                DataTable t2 = new DataTable();
                t2 = vi.RD();
                Deal_Admin_dataGridView.DataSource = t2;
            }
            else if (e.RowIndex == 1)
            {
                MessageBox.Show("2");
                Practice vi1 = new Practice();
                DataTable t3 = new DataTable();
                t3 = vi1.RDd();
                Deal_Admin_dataGridView.DataSource = t3;
            }
            if (e.RowIndex == 2)
            {
                MessageBox.Show("3");
            }
            //if (Deal_Admin_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    MessageBox.Show(Deal_Admin_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            //}
        }

        private void Deal_Admin_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //if (e.ColumnIndex == 1)
            //{
            //    //Program view = new Program();
            //    //DataTable t1 = new DataTable();
            //    //t1 = view.1ReterieveData();
            //    //dataGridView1.DataSource = t1;

            //    Practice vi = new Practice();
            //    DataTable t2 = new DataTable();
            //    t2 = vi.RD();
            //    Deal_Admin_dataGridView.DataSource = t2;
            //}
            //if (e.ColumnIndex == 2)
            //{
            //    MessageBox.Show("2");
            //}
            //if (e.ColumnIndex == 3)
            //{
            //    MessageBox.Show("3");
            //}
        }
    }
}
   
