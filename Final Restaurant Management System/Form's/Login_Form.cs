using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Restaurant_Management_System
{
    public partial class LOGIN_FORM : Form
    {
        Admin_Login admin_login;
        Staff_Login staff_login;
       
        public LOGIN_FORM()
        {
            InitializeComponent();
        }
        int i, j;
        Button[] bt;
        bool itor = true;
        private void Exit_PictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Login_As.Text == "ADMIN" && UserName_txt.Text != "" && Password_Txt.Text != "")
                {
                    admin_login = new Admin_Login(UserName_txt.Text, Password_Txt.Text);
                    bool adminLogin = admin_login.getAdminLogin();
                    if (adminLogin == true)
                    {
                        Admin_Main_Page adminmainpage = new Admin_Main_Page();
                        adminmainpage.Show();
                        this.Hide();
                    }
                    else
                    {
                        label1.Visible = true;
                        label2.Text = "Wrong Password";
                        MessageBox.Show("Invalid User Name or Password");
                        UserName_txt.Clear();
                        Password_Txt.Clear();
                        label2.Hide();
                    }
                }

                    if (Login_As.Text == "STAFF" && UserName_txt.Text != "" && Password_Txt.Text != "")
                    {
                        staff_login = new Staff_Login(UserName_txt.Text, Password_Txt.Text);
                        bool staffLogin = staff_login.getStaffLogin();
                        if (staffLogin == true)
                        {
                            Staff_Main_Page staffmainpage = new Staff_Main_Page();
                            staffmainpage.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid User Name or Password");
                            UserName_txt.Clear();
                            Password_Txt.Clear();
                        }
                    }
                
                if(UserName_txt.Text == "" && Password_Txt.Text == "")
                {
                    MessageBox.Show("Enter User_Name & Password");
                }

                if (UserName_txt.Text != "" && Password_Txt.Text == "")
                {
                    MessageBox.Show("Enter Password");
                }

                if (UserName_txt.Text == "" && Password_Txt.Text != "")
                {
                    MessageBox.Show("Enter User_Name");
                }

                if (Login_As.Text == "" && UserName_txt.Text == "" && Password_Txt.Text == "")
                {
                    MessageBox.Show("ERROR" + "\n" + "Please Input Your User Name, Password And Login Type");
                }
                
                if (Login_As.Text == "" && UserName_txt.Text != "" && Password_Txt.Text != "")
                {
                    MessageBox.Show("ERROR" + "\n" + "Please Select Login Type");
                }

            }
            catch (Exception excep)
            {

                throw excep;
            }


        }
        //private void setFullScreen()
        //{
        //int x = Screen.PrimaryScreen.Bounds.Width;
        //int y = Screen.PrimaryScreen.Bounds.Height;
        //Location = new Point(0, 0);
        //Size = new Size(x, y);
        //}
        private void LOGIN_FORM_Load(object sender, EventArgs e)
        {
            //setFullScreen();
            bt = new Button[3] { button1,Exit_btn,Login_btn};
            i = 0;
            timer2.Start();
            label1.Visible = false;
        }

        private void UserName_txt_Click(object sender, EventArgs e)
        {
            UserName_txt.Text = string.Empty;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (itor)
            {
                Login_Screen_Txt.Location = new Point(Login_Screen_Txt.Location.X + 5, Login_Screen_Txt.Location.Y);
            }
            else 
            {
                Login_Screen_Txt.Location = new Point(Login_Screen_Txt.Location.X - 5, Login_Screen_Txt.Location.Y);
            }
            if (Login_Screen_Txt.Location.X + Login_Screen_Txt.Width >= this.Width)
            {
                itor = false;
            }
            if (Login_Screen_Txt.Location.X <= 0)
            {
                itor = true;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Password_Txt.UseSystemPasswordChar = false;
            }

            else
            {
                Password_Txt.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shake(this);
        }
        public static void shake(Form form)
        {
            var original = form.Location;
            var rmd = new Random(13374);
            const int shake_amplitute = 10;
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(original.X + rmd.Next(shake_amplitute,shake_amplitute),original.Y +rmd.Next(shake_amplitute,shake_amplitute));
                System.Threading.Thread.Sleep(20);
                form.Location = original;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (i < bt.Length)
            {
                bt[i].BackColor = Color.Azure;
                i += 1;
            }
            else
            {
                timer2.Stop();
                for (j = 0; j < bt.Length; j++)
                {
                    bt[j].BackColor = Color.Aqua;
                    bt[j].Font = new Font(this.Font.FontFamily, 15);
                }
            }
        }
    }
}