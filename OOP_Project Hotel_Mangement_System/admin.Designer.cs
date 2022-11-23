
namespace OOP_Project_Hotel_Mangement_System
{
    partial class admin
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
            this.reservation = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.admininfo = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.employee1info = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.employee2info = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.employee_panel = new System.Windows.Forms.Panel();
            this.employee1 = new OOP_Project_Hotel_Mangement_System.Employee();
            this.reservations1 = new OOP_Project_Hotel_Mangement_System.Reservations();
            this.employeinfo = new System.Windows.Forms.FlowLayoutPanel();
            this.reservation.SuspendLayout();
            this.admininfo.SuspendLayout();
            this.employee1info.SuspendLayout();
            this.employee2info.SuspendLayout();
            this.employee_panel.SuspendLayout();
            this.employeinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // reservation
            // 
            this.reservation.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.reservation.Controls.Add(this.label3);
            this.reservation.Location = new System.Drawing.Point(430, 29);
            this.reservation.Name = "reservation";
            this.reservation.Size = new System.Drawing.Size(214, 28);
            this.reservation.TabIndex = 4;
            this.reservation.Click += new System.EventHandler(this.flowLayoutPanel2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "RESERVATIONS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.flowLayoutPanel2_Click);
            // 
            // admininfo
            // 
            this.admininfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.admininfo.Controls.Add(this.label1);
            this.admininfo.Location = new System.Drawing.Point(0, 28);
            this.admininfo.Name = "admininfo";
            this.admininfo.Size = new System.Drawing.Size(214, 29);
            this.admininfo.TabIndex = 1;
            this.admininfo.Click += new System.EventHandler(this.flowLayoutPanel3_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "INFORMATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.flowLayoutPanel3_Click);
            // 
            // employee1info
            // 
            this.employee1info.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.employee1info.Controls.Add(this.label4);
            this.employee1info.Location = new System.Drawing.Point(0, 0);
            this.employee1info.Name = "employee1info";
            this.employee1info.Size = new System.Drawing.Size(322, 29);
            this.employee1info.TabIndex = 2;
            this.employee1info.Click += new System.EventHandler(this.flowLayoutPanel4_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "MUHAMMAD MUBASHIR";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.flowLayoutPanel4_Click);
            // 
            // employee2info
            // 
            this.employee2info.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.employee2info.Controls.Add(this.label5);
            this.employee2info.Location = new System.Drawing.Point(322, 0);
            this.employee2info.Name = "employee2info";
            this.employee2info.Size = new System.Drawing.Size(322, 29);
            this.employee2info.TabIndex = 5;
            this.employee2info.Click += new System.EventHandler(this.flowLayoutPanel5_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "TALHA IMRAN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.flowLayoutPanel5_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "EMPLOYEE INFORMATION";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.flowLayoutPanel1_Click);
            // 
            // employee_panel
            // 
            this.employee_panel.Controls.Add(this.employee1);
            this.employee_panel.Controls.Add(this.employee2info);
            this.employee_panel.Controls.Add(this.employee1info);
            this.employee_panel.Controls.Add(this.reservations1);
            this.employee_panel.Location = new System.Drawing.Point(0, 59);
            this.employee_panel.Name = "employee_panel";
            this.employee_panel.Size = new System.Drawing.Size(644, 504);
            this.employee_panel.TabIndex = 5;
            // 
            // employee1
            // 
            this.employee1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.employee1.Location = new System.Drawing.Point(0, -2);
            this.employee1.Name = "employee1";
            this.employee1.Size = new System.Drawing.Size(644, 503);
            this.employee1.TabIndex = 0;
            this.employee1.Load += new System.EventHandler(this.employee1_Load);
            // 
            // reservations1
            // 
            this.reservations1.Location = new System.Drawing.Point(0, -2);
            this.reservations1.Name = "reservations1";
            this.reservations1.Size = new System.Drawing.Size(644, 534);
            this.reservations1.TabIndex = 6;
            this.reservations1.Load += new System.EventHandler(this.reservations1_Load);
            // 
            // employeinfo
            // 
            this.employeinfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.employeinfo.Controls.Add(this.label2);
            this.employeinfo.Location = new System.Drawing.Point(215, 28);
            this.employeinfo.Name = "employeinfo";
            this.employeinfo.Size = new System.Drawing.Size(214, 29);
            this.employeinfo.TabIndex = 0;
            this.employeinfo.Click += new System.EventHandler(this.flowLayoutPanel1_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.employee_panel);
            this.Controls.Add(this.admininfo);
            this.Controls.Add(this.reservation);
            this.Controls.Add(this.employeinfo);
            this.Name = "admin";
            this.Size = new System.Drawing.Size(644, 563);
            this.reservation.ResumeLayout(false);
            this.admininfo.ResumeLayout(false);
            this.employee1info.ResumeLayout(false);
            this.employee2info.ResumeLayout(false);
            this.employee_panel.ResumeLayout(false);
            this.employeinfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel reservation;
        private System.Windows.Forms.FlowLayoutPanel admininfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel employee1info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel employee2info;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel employee_panel;
        private Employee employee1;
        private System.Windows.Forms.FlowLayoutPanel employeinfo;
        private Reservations reservations1;
    }
}
