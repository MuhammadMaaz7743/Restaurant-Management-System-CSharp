namespace Final_Restaurant_Management_System
{
    partial class Menu_Module_List_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Main_Back_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Food_Cate_txt = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Food_Name_txt = new System.Windows.Forms.TextBox();
            this.Food_Name = new System.Windows.Forms.Label();
            this.Food_Price_txt = new System.Windows.Forms.TextBox();
            this.Food_Price = new System.Windows.Forms.Label();
            this.Food_Category_txt = new System.Windows.Forms.Label();
            this.Food_Number_txt = new System.Windows.Forms.TextBox();
            this.Food_Num = new System.Windows.Forms.Label();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.LogOut_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Menu_dataGridView = new System.Windows.Forms.DataGridView();
            this.Retrive_btn = new System.Windows.Forms.Button();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Back_btn
            // 
            this.Main_Back_btn.BackColor = System.Drawing.Color.White;
            this.Main_Back_btn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Main_Back_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.Main_Back_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Main_Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Main_Back_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Back_btn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Main_Back_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_Back_btn.Location = new System.Drawing.Point(45, 436);
            this.Main_Back_btn.Name = "Main_Back_btn";
            this.Main_Back_btn.Size = new System.Drawing.Size(109, 41);
            this.Main_Back_btn.TabIndex = 33;
            this.Main_Back_btn.Text = "BACK";
            this.Main_Back_btn.UseVisualStyleBackColor = false;
            this.Main_Back_btn.Click += new System.EventHandler(this.Main_Back_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Update_btn);
            this.panel1.Controls.Add(this.Add_Btn);
            this.panel1.Controls.Add(this.Food_Cate_txt);
            this.panel1.Controls.Add(this.ClearBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Food_Name_txt);
            this.panel1.Controls.Add(this.Food_Name);
            this.panel1.Controls.Add(this.Food_Price_txt);
            this.panel1.Controls.Add(this.Food_Price);
            this.panel1.Controls.Add(this.Food_Category_txt);
            this.panel1.Controls.Add(this.Food_Number_txt);
            this.panel1.Controls.Add(this.Food_Num);
            this.panel1.Location = new System.Drawing.Point(44, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 165);
            this.panel1.TabIndex = 32;
            // 
            // Food_Cate_txt
            // 
            this.Food_Cate_txt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food_Cate_txt.Location = new System.Drawing.Point(201, 91);
            this.Food_Cate_txt.Name = "Food_Cate_txt";
            this.Food_Cate_txt.Size = new System.Drawing.Size(194, 26);
            this.Food_Cate_txt.TabIndex = 38;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClearBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ClearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.ClearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearBtn.Location = new System.Drawing.Point(414, 67);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(109, 41);
            this.ClearBtn.TabIndex = 37;
            this.ClearBtn.Text = "&Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(507, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Restaurant Management System";
            // 
            // Food_Name_txt
            // 
            this.Food_Name_txt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food_Name_txt.Location = new System.Drawing.Point(201, 129);
            this.Food_Name_txt.Name = "Food_Name_txt";
            this.Food_Name_txt.Size = new System.Drawing.Size(194, 26);
            this.Food_Name_txt.TabIndex = 8;
            // 
            // Food_Name
            // 
            this.Food_Name.AutoSize = true;
            this.Food_Name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food_Name.ForeColor = System.Drawing.Color.White;
            this.Food_Name.Location = new System.Drawing.Point(97, 132);
            this.Food_Name.Name = "Food_Name";
            this.Food_Name.Size = new System.Drawing.Size(88, 20);
            this.Food_Name.TabIndex = 7;
            this.Food_Name.Text = "FOOD NAME";
            // 
            // Food_Price_txt
            // 
            this.Food_Price_txt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food_Price_txt.Location = new System.Drawing.Point(201, 55);
            this.Food_Price_txt.Name = "Food_Price_txt";
            this.Food_Price_txt.Size = new System.Drawing.Size(194, 26);
            this.Food_Price_txt.TabIndex = 5;
            // 
            // Food_Price
            // 
            this.Food_Price.AutoSize = true;
            this.Food_Price.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food_Price.ForeColor = System.Drawing.Color.White;
            this.Food_Price.Location = new System.Drawing.Point(92, 58);
            this.Food_Price.Name = "Food_Price";
            this.Food_Price.Size = new System.Drawing.Size(90, 20);
            this.Food_Price.TabIndex = 4;
            this.Food_Price.Text = "FOOD PRICE";
            // 
            // Food_Category_txt
            // 
            this.Food_Category_txt.AutoSize = true;
            this.Food_Category_txt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food_Category_txt.ForeColor = System.Drawing.Color.White;
            this.Food_Category_txt.Location = new System.Drawing.Point(60, 97);
            this.Food_Category_txt.Name = "Food_Category_txt";
            this.Food_Category_txt.Size = new System.Drawing.Size(122, 20);
            this.Food_Category_txt.TabIndex = 3;
            this.Food_Category_txt.Text = "FOOD CATEGORY";
            // 
            // Food_Number_txt
            // 
            this.Food_Number_txt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food_Number_txt.Location = new System.Drawing.Point(201, 17);
            this.Food_Number_txt.Name = "Food_Number_txt";
            this.Food_Number_txt.Size = new System.Drawing.Size(194, 26);
            this.Food_Number_txt.TabIndex = 1;
            // 
            // Food_Num
            // 
            this.Food_Num.AutoSize = true;
            this.Food_Num.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food_Num.ForeColor = System.Drawing.Color.White;
            this.Food_Num.Location = new System.Drawing.Point(76, 17);
            this.Food_Num.Name = "Food_Num";
            this.Food_Num.Size = new System.Drawing.Size(106, 20);
            this.Food_Num.TabIndex = 2;
            this.Food_Num.Text = "FOOD NUMBER";
            // 
            // Insert_btn
            // 
            this.Insert_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Insert_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Insert_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.Insert_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_btn.ForeColor = System.Drawing.Color.White;
            this.Insert_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Insert_btn.Location = new System.Drawing.Point(449, 436);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(127, 41);
            this.Insert_btn.TabIndex = 30;
            this.Insert_btn.Text = "&INSERT";
            this.Insert_btn.UseVisualStyleBackColor = false;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Delete_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Delete_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.Delete_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Delete_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Btn.ForeColor = System.Drawing.Color.White;
            this.Delete_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete_Btn.Location = new System.Drawing.Point(755, 436);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(127, 41);
            this.Delete_Btn.TabIndex = 29;
            this.Delete_Btn.Text = "&DELETE";
            this.Delete_Btn.UseVisualStyleBackColor = false;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // LogOut_btn
            // 
            this.LogOut_btn.BackColor = System.Drawing.Color.White;
            this.LogOut_btn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.LogOut_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.LogOut_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.LogOut_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut_btn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LogOut_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOut_btn.Location = new System.Drawing.Point(297, 436);
            this.LogOut_btn.Name = "LogOut_btn";
            this.LogOut_btn.Size = new System.Drawing.Size(127, 41);
            this.LogOut_btn.TabIndex = 28;
            this.LogOut_btn.Text = "LOG OUT";
            this.LogOut_btn.UseVisualStyleBackColor = false;
            this.LogOut_btn.Click += new System.EventHandler(this.LogOut_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.White;
            this.Exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.Exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Exit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_btn.Location = new System.Drawing.Point(170, 436);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(109, 41);
            this.Exit_btn.TabIndex = 27;
            this.Exit_btn.Text = "EXIT";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Menu_dataGridView
            // 
            this.Menu_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Menu_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Menu_dataGridView.GridColor = System.Drawing.Color.White;
            this.Menu_dataGridView.Location = new System.Drawing.Point(44, 189);
            this.Menu_dataGridView.Name = "Menu_dataGridView";
            this.Menu_dataGridView.Size = new System.Drawing.Size(837, 226);
            this.Menu_dataGridView.TabIndex = 26;
            // 
            // Retrive_btn
            // 
            this.Retrive_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Retrive_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Retrive_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.Retrive_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Retrive_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Retrive_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retrive_btn.ForeColor = System.Drawing.Color.White;
            this.Retrive_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Retrive_btn.Location = new System.Drawing.Point(602, 436);
            this.Retrive_btn.Name = "Retrive_btn";
            this.Retrive_btn.Size = new System.Drawing.Size(127, 41);
            this.Retrive_btn.TabIndex = 34;
            this.Retrive_btn.Text = "&Retrive";
            this.Retrive_btn.UseVisualStyleBackColor = false;
            this.Retrive_btn.Click += new System.EventHandler(this.Retrive_btn_Click);
            // 
            // Add_Btn
            // 
            this.Add_Btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Add_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Add_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.Add_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Add_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Btn.ForeColor = System.Drawing.Color.White;
            this.Add_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_Btn.Location = new System.Drawing.Point(558, 67);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(109, 41);
            this.Add_Btn.TabIndex = 39;
            this.Add_Btn.Text = "&ADD";
            this.Add_Btn.UseVisualStyleBackColor = false;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Update_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Update_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.Update_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.ForeColor = System.Drawing.Color.White;
            this.Update_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update_btn.Location = new System.Drawing.Point(683, 67);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(127, 41);
            this.Update_btn.TabIndex = 35;
            this.Update_btn.Text = "&Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Menu_Module_List_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(921, 491);
            this.ControlBox = false;
            this.Controls.Add(this.Retrive_btn);
            this.Controls.Add(this.Main_Back_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.LogOut_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Menu_dataGridView);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Menu_Module_List_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Menu_Module_List_Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Main_Back_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Food_Name_txt;
        private System.Windows.Forms.Label Food_Name;
        private System.Windows.Forms.TextBox Food_Price_txt;
        private System.Windows.Forms.Label Food_Price;
        private System.Windows.Forms.Label Food_Category_txt;
        private System.Windows.Forms.TextBox Food_Number_txt;
        private System.Windows.Forms.Label Food_Num;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.Button LogOut_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.DataGridView Menu_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.TextBox Food_Cate_txt;
        private System.Windows.Forms.Button Retrive_btn;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button Update_btn;
    }
}