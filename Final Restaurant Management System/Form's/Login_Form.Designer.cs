namespace Final_Restaurant_Management_System
{
    partial class LOGIN_FORM
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN_FORM));
            this.Login_Form_Panel = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_PictureBox = new System.Windows.Forms.PictureBox();
            this.Admin_Picture = new System.Windows.Forms.PictureBox();
            this.Login_Screen_Txt = new System.Windows.Forms.Label();
            this.Password_Txt = new System.Windows.Forms.TextBox();
            this.User_Password = new System.Windows.Forms.Label();
            this.User_Name = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Label();
            this.Login_As = new System.Windows.Forms.ComboBox();
            this.UserName_txt = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Login_Form_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_Form_Panel
            // 
            this.Login_Form_Panel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Login_Form_Panel.Controls.Add(this.button1);
            this.Login_Form_Panel.Controls.Add(this.maskedTextBox1);
            this.Login_Form_Panel.Controls.Add(this.label1);
            this.Login_Form_Panel.Controls.Add(this.Exit_PictureBox);
            this.Login_Form_Panel.Controls.Add(this.Admin_Picture);
            this.Login_Form_Panel.Controls.Add(this.Login_Screen_Txt);
            this.Login_Form_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Login_Form_Panel.Location = new System.Drawing.Point(0, 0);
            this.Login_Form_Panel.Name = "Login_Form_Panel";
            this.Login_Form_Panel.Size = new System.Drawing.Size(603, 306);
            this.Login_Form_Panel.TabIndex = 0;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(473, 166);
            this.maskedTextBox1.Mask = "00000-0000000-0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Restaurant Management System ";
            // 
            // Exit_PictureBox
            // 
            this.Exit_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Exit_PictureBox.Image")));
            this.Exit_PictureBox.Location = new System.Drawing.Point(550, 12);
            this.Exit_PictureBox.Name = "Exit_PictureBox";
            this.Exit_PictureBox.Size = new System.Drawing.Size(41, 34);
            this.Exit_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit_PictureBox.TabIndex = 10;
            this.Exit_PictureBox.TabStop = false;
            this.Exit_PictureBox.Click += new System.EventHandler(this.Exit_PictureBox_Click);
            // 
            // Admin_Picture
            // 
            this.Admin_Picture.Image = ((System.Drawing.Image)(resources.GetObject("Admin_Picture.Image")));
            this.Admin_Picture.Location = new System.Drawing.Point(221, 94);
            this.Admin_Picture.Name = "Admin_Picture";
            this.Admin_Picture.Size = new System.Drawing.Size(146, 149);
            this.Admin_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Admin_Picture.TabIndex = 9;
            this.Admin_Picture.TabStop = false;
            // 
            // Login_Screen_Txt
            // 
            this.Login_Screen_Txt.AutoSize = true;
            this.Login_Screen_Txt.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Screen_Txt.ForeColor = System.Drawing.Color.White;
            this.Login_Screen_Txt.Location = new System.Drawing.Point(144, 246);
            this.Login_Screen_Txt.Name = "Login_Screen_Txt";
            this.Login_Screen_Txt.Size = new System.Drawing.Size(299, 42);
            this.Login_Screen_Txt.TabIndex = 8;
            this.Login_Screen_Txt.Text = "LOGIN SCREEN";
            // 
            // Password_Txt
            // 
            this.Password_Txt.BackColor = System.Drawing.Color.White;
            this.Password_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password_Txt.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Txt.Location = new System.Drawing.Point(262, 363);
            this.Password_Txt.Name = "Password_Txt";
            this.Password_Txt.Size = new System.Drawing.Size(231, 32);
            this.Password_Txt.TabIndex = 12;
            this.Password_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password_Txt.UseSystemPasswordChar = true;
            // 
            // User_Password
            // 
            this.User_Password.AutoSize = true;
            this.User_Password.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Password.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.User_Password.Location = new System.Drawing.Point(144, 366);
            this.User_Password.Name = "User_Password";
            this.User_Password.Size = new System.Drawing.Size(115, 24);
            this.User_Password.TabIndex = 10;
            this.User_Password.Text = "Password :";
            // 
            // User_Name
            // 
            this.User_Name.AutoSize = true;
            this.User_Name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Name.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.User_Name.Location = new System.Drawing.Point(94, 321);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(165, 24);
            this.User_Name.TabIndex = 9;
            this.User_Name.Text = "User Name / ID :";
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.Exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("Exit_btn.Image")));
            this.Exit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_btn.Location = new System.Drawing.Point(344, 453);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(113, 39);
            this.Exit_btn.TabIndex = 8;
            this.Exit_btn.Text = "&Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Login_btn
            // 
            this.Login_btn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.Login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Login_btn.Image = ((System.Drawing.Image)(resources.GetObject("Login_btn.Image")));
            this.Login_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login_btn.Location = new System.Drawing.Point(197, 453);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(108, 39);
            this.Login_btn.TabIndex = 7;
            this.Login_btn.Text = "&Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Login.Location = new System.Drawing.Point(154, 413);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(102, 24);
            this.Login.TabIndex = 13;
            this.Login.Text = "Login As :";
            // 
            // Login_As
            // 
            this.Login_As.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Login_As.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_As.FormattingEnabled = true;
            this.Login_As.Items.AddRange(new object[] {
            "ADMIN",
            "STAFF"});
            this.Login_As.Location = new System.Drawing.Point(262, 409);
            this.Login_As.Name = "Login_As";
            this.Login_As.Size = new System.Drawing.Size(231, 33);
            this.Login_As.TabIndex = 14;
            // 
            // UserName_txt
            // 
            this.UserName_txt.BackColor = System.Drawing.Color.White;
            this.UserName_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserName_txt.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_txt.ForeColor = System.Drawing.Color.LightGray;
            this.UserName_txt.Location = new System.Drawing.Point(262, 318);
            this.UserName_txt.Name = "UserName_txt";
            this.UserName_txt.Size = new System.Drawing.Size(231, 32);
            this.UserName_txt.TabIndex = 15;
            this.UserName_txt.Text = "Enter User Name";
            this.UserName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserName_txt.Click += new System.EventHandler(this.UserName_txt_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(12, 363);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 23);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(515, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 250;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // LOGIN_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 508);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.UserName_txt);
            this.Controls.Add(this.Login_As);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password_Txt);
            this.Controls.Add(this.User_Password);
            this.Controls.Add(this.User_Name);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.Login_Form_Panel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "LOGIN_FORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LOGIN_FORM_Load);
            this.Login_Form_Panel.ResumeLayout(false);
            this.Login_Form_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Login_Form_Panel;
        private System.Windows.Forms.TextBox Password_Txt;
        private System.Windows.Forms.Label User_Password;
        private System.Windows.Forms.Label User_Name;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.PictureBox Admin_Picture;
        private System.Windows.Forms.Label Login_Screen_Txt;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.ComboBox Login_As;
        private System.Windows.Forms.PictureBox Exit_PictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserName_txt;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer2;
    }
}

