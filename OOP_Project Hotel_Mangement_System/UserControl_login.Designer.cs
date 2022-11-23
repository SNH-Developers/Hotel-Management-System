
namespace OOP_Project_Hotel_Mangement_System
{
    partial class UserControl_login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_emp_log = new System.Windows.Forms.Label();
            this.login_buton = new System.Windows.Forms.Button();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.Shw_pass = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Editbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.login_panel = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.admin1 = new OOP_Project_Hotel_Mangement_System.admin();
            this.employee1 = new OOP_Project_Hotel_Mangement_System.Employee();
            this.userControl_cust_login1 = new OOP_Project_Hotel_Mangement_System.UserControl_cust_login();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.login_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_emp_log
            // 
            this.lbl_emp_log.AutoSize = true;
            this.lbl_emp_log.Location = new System.Drawing.Point(124, 8);
            this.lbl_emp_log.Name = "lbl_emp_log";
            this.lbl_emp_log.Size = new System.Drawing.Size(85, 13);
            this.lbl_emp_log.TabIndex = 2;
            this.lbl_emp_log.Text = "Employee Login:";
            // 
            // login_buton
            // 
            this.login_buton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.login_buton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_buton.Location = new System.Drawing.Point(65, 125);
            this.login_buton.Name = "login_buton";
            this.login_buton.Size = new System.Drawing.Size(204, 23);
            this.login_buton.TabIndex = 3;
            this.login_buton.Text = "Login";
            this.login_buton.UseVisualStyleBackColor = false;
            this.login_buton.Click += new System.EventHandler(this.login_buton_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(24, 24);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "E-mail";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(6, 68);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(53, 13);
            this.lbl_pass.TabIndex = 5;
            this.lbl_pass.Text = "Password";
            // 
            // Shw_pass
            // 
            this.Shw_pass.AutoSize = true;
            this.Shw_pass.Location = new System.Drawing.Point(65, 102);
            this.Shw_pass.Name = "Shw_pass";
            this.Shw_pass.Size = new System.Drawing.Size(102, 17);
            this.Shw_pass.TabIndex = 6;
            this.Shw_pass.Text = "Show Password";
            this.Shw_pass.UseVisualStyleBackColor = true;
            this.Shw_pass.Click += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Shw_pass);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.lbl_pass);
            this.panel1.Controls.Add(this.lbl_emp_log);
            this.panel1.Controls.Add(this.lbl_email);
            this.panel1.Controls.Add(this.login_buton);
            this.panel1.Location = new System.Drawing.Point(339, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 157);
            this.panel1.TabIndex = 7;
            // 
            // back
            // 
            this.back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Location = new System.Drawing.Point(470, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 8;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Visible = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.Editbutton);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(22, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 157);
            this.panel2.TabIndex = 9;
            // 
            // Editbutton
            // 
            this.Editbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Editbutton.Location = new System.Drawing.Point(50, 68);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(204, 23);
            this.Editbutton.TabIndex = 7;
            this.Editbutton.Text = "Edit Reservation";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(50, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Check Reservation";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Didn\'t make Reservation yet?\r\nMake Reservation Now!";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(50, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 20);
            this.textBox3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reservation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Check";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(50, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reserve Now!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(598, 96);
            this.dataGridView1.TabIndex = 10;
            // 
            // login_panel
            // 
            this.login_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_panel.Controls.Add(this.logout);
            this.login_panel.Controls.Add(this.admin1);
            this.login_panel.Controls.Add(this.employee1);
            this.login_panel.Controls.Add(this.back);
            this.login_panel.Controls.Add(this.userControl_cust_login1);
            this.login_panel.Location = new System.Drawing.Point(0, 0);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(644, 528);
            this.login_panel.TabIndex = 11;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logout.Location = new System.Drawing.Point(459, 0);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 12;
            this.logout.Text = "LOGOUT";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Visible = false;
            this.logout.Click += new System.EventHandler(this.button3_Click);
            // 
            // admin1
            // 
            this.admin1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.admin1.Location = new System.Drawing.Point(-3, 0);
            this.admin1.Name = "admin1";
            this.admin1.Size = new System.Drawing.Size(647, 522);
            this.admin1.TabIndex = 13;
            this.admin1.Load += new System.EventHandler(this.admin1_Load);
            // 
            // employee1
            // 
            this.employee1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employee1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.employee1.Location = new System.Drawing.Point(3, 3);
            this.employee1.Name = "employee1";
            this.employee1.Size = new System.Drawing.Size(641, 551);
            this.employee1.TabIndex = 1;
            // 
            // userControl_cust_login1
            // 
            this.userControl_cust_login1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userControl_cust_login1.Location = new System.Drawing.Point(19, 3);
            this.userControl_cust_login1.Name = "userControl_cust_login1";
            this.userControl_cust_login1.Size = new System.Drawing.Size(607, 507);
            this.userControl_cust_login1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControl_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.login_panel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_login";
            this.Size = new System.Drawing.Size(650, 531);
            this.Load += new System.EventHandler(this.UserControl_login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.login_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_emp_log;
        private System.Windows.Forms.Button login_buton;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.CheckBox Shw_pass;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button Editbutton;
        public System.Windows.Forms.Panel login_panel;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        public UserControl_cust_login userControl_cust_login1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Button back;
        public System.Windows.Forms.Button logout;
        public Employee employee1;
        public admin admin1;
    }
}
