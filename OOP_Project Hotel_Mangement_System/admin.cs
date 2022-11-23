using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Project_Hotel_Mangement_System
{
    public partial class admin : UserControl
    {
        public admin()
        {
            InitializeComponent();
        }

        public static System.Drawing.Color GradientInactiveCaption { get; }
        

        public void set()
        {
            employee1.adm.Show();
            employee1.emp1.Hide();
            employee1.Size = new Size(644, 534);
            employee1.Location = new Point(0, 0);
            admininfo.BackColor = GradientInactiveCaption;
            Employee.log = 2;
            employee1.timer1.Enabled = true;
            employee1.flowLayoutPanel1.Hide();
            employee1.flowLayoutPanel4.Hide();

            reservation.BackColor = Color.White;
            employeinfo.BackColor = Color.White;
            reservations1.Hide();
            employee1.label16.Hide();
            employee1.label17.Hide();
            employee1.info_panel.BringToFront();
            employee1.info_panel.Location = new Point(0, 0);
        }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            reservation.BackColor = GradientInactiveCaption;
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            //reservations1.dataGridView1.Rows.Clear();
            employee1.Size = new Size(644, 503);
            employee1.Location = new Point(0, 31);
            reservation.BackColor = Color.White;
            employeinfo.BackColor = GradientInactiveCaption;
            employee1.adm.Hide();
            employee1.emp1.Show();
            admininfo.BackColor = Color.White;
            employee1info.BackColor = GradientInactiveCaption;
            employee2info.BackColor = Color.White;
            Employee.log = 0;
            employee1.timer1.Enabled = true;
            reservations1.Hide();

        }

        private void flowLayoutPanel3_Click(object sender, EventArgs e)
        {
            //reservations1.dataGridView1.Rows.Clear();
            reservations1.Hide();
            employee1.Size = new Size(644, 534);
            employee1.Location = new Point(0, 0);
            reservation.BackColor = Color.White;
            employeinfo.BackColor = Color.White;
            admininfo.BackColor = GradientInactiveCaption;
            employee1.adm.Show();
            employee1.emp1.Hide();
            Employee.log = 2;
            employee1.timer1.Enabled = true;

        }

        private void flowLayoutPanel2_Click(object sender, EventArgs e)
        {

            reservations1.set();
            reservations1.Show();
            reservations1.BringToFront();
            employee1.Size = new Size(644, 534);
            employee1.Location = new Point(0, 0);
            reservation.BackColor = GradientInactiveCaption;
            employeinfo.BackColor = Color.White;
            admininfo.BackColor = Color.White;            
        }

        private void flowLayoutPanel4_Click(object sender, EventArgs e)
        {
            employee1info.BackColor = GradientInactiveCaption;
            employee2info.BackColor = Color.White;
            Employee.log = 0;
            employee1.timer1.Enabled = true;
        }

        private void flowLayoutPanel5_Click(object sender, EventArgs e)
        {
            employee1info.BackColor = Color.White;
            employee2info.BackColor = GradientInactiveCaption;
            Employee.log = 1;
            employee1.timer1.Enabled = true;
        }

        private void admin_Load(object sender, EventArgs e)
        {
            
        }

        private void reservations1_Load(object sender, EventArgs e)
        {

        }

        private void employee1_Load(object sender, EventArgs e)
        {

        }
    }
}
