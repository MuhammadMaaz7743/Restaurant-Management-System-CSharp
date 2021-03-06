﻿using System;
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
    public partial class Admin_Main_Page : Form
    {
        public Admin_Main_Page()
        {
            InitializeComponent();
        }
        private void Exit_Picture_Box_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Log_Out_Btn_Click(object sender, EventArgs e)
        {
            LOGIN_FORM login = new LOGIN_FORM();
            this.Hide();
            login.Show();
        }

        private void Food_Item_btn_Click(object sender, EventArgs e)
        {
            Menu_Module_List_Admin menumodule = new Menu_Module_List_Admin();
            this.Hide();
            menumodule.Show();
        }

        private void Order_btn_Click(object sender, EventArgs e)
        {
            Order_List_Admin order_list = new Order_List_Admin();
            this.Hide();
            order_list.Show();
        }

        private void Deal_btn_Click(object sender, EventArgs e)
        {
            Deal_List_Admin deal_list = new Deal_List_Admin();
            this.Hide();
            deal_list.Show();
        }

        private void Home_Delivery_btn_Click(object sender, EventArgs e)
        {
            Home_Delivery_Admin home_delivery = new Home_Delivery_Admin();
            this.Hide();
            home_delivery.Show();
        }

        private void Staff_btn_Click(object sender, EventArgs e)
        {
            Staff_List_Admin staff_list = new Staff_List_Admin();
            this.Hide();
            staff_list.Show();
        }
    }
}
