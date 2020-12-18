namespace Final_Restaurant_Management_System
{
    partial class Staff_List_Staff
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
            this.Staff_List_dataGridView = new System.Windows.Forms.DataGridView();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.LogOut_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_List_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Staff_List_dataGridView
            // 
            this.Staff_List_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Staff_List_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Staff_List_dataGridView.Location = new System.Drawing.Point(41, 26);
            this.Staff_List_dataGridView.Name = "Staff_List_dataGridView";
            this.Staff_List_dataGridView.Size = new System.Drawing.Size(837, 226);
            this.Staff_List_dataGridView.TabIndex = 50;
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
            this.Exit_btn.Location = new System.Drawing.Point(193, 271);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(127, 41);
            this.Exit_btn.TabIndex = 51;
            this.Exit_btn.Text = "EXIT";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
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
            this.LogOut_btn.Location = new System.Drawing.Point(326, 271);
            this.LogOut_btn.Name = "LogOut_btn";
            this.LogOut_btn.Size = new System.Drawing.Size(127, 41);
            this.LogOut_btn.TabIndex = 52;
            this.LogOut_btn.Text = "LOG OUT";
            this.LogOut_btn.UseVisualStyleBackColor = false;
            this.LogOut_btn.Click += new System.EventHandler(this.LogOut_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(563, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Restaurant Management System";
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.White;
            this.Back_btn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Back_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.Back_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Back_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Back_btn.Location = new System.Drawing.Point(60, 271);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(127, 41);
            this.Back_btn.TabIndex = 53;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Staff_List_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(890, 319);
            this.ControlBox = false;
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Staff_List_dataGridView);
            this.Controls.Add(this.LogOut_btn);
            this.Controls.Add(this.Exit_btn);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Staff_List_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Staff_List_Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Staff_List_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Staff_List_dataGridView;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button LogOut_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Back_btn;
    }
}