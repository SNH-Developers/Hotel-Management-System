using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_Hotel_Mangement_System
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            userControl_login1.show += new bedpanelshow(showw);
            userControl_login1.hide += new bedpanelhide(hidee);
            userControl_login1.userControl_cust_login1.usercustomerupdate += new Updatereserve(value_reserveupdate);
            timer2.Enabled = true;
            timer2.Interval = 1000;
        }
        void showw(string message)
        {
            bedpanel.Show();
            panel1.Location = new Point(97, 98);
        }
        void hidee(string message)
        {
            bedpanel.Hide();
            panel1.Location = new Point(390, 90);
        }
        void value_reserveupdate(string message)
        {
            bedpanel.Hide();
            panel1.Location = new Point(390, 90);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl_login1.Visible = false;
            userControl_cust_login1.Hide();
            panel1.Visible = false;
            main.Hide();
            bedpanel.Hide();
            slideshow();
        }
        public static int deletion = 0;
        private void Reservation_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(390, 90);
            label10.Hide();
            hidslideshow();
            bedpanel.Hide();
            deletion = 2;
            panel1.Show();
            userControl_login1.login_panel.Show();
            //userControl_login1.dataGridView1.Rows.Clear();
            userControl_login1.Editbutton.Hide();
            userControl_login1.dataGridView1.Hide();
            userControl_login1.Show();

            UserControl_login.position = 1;
            userControl_login1.userControl_cust_login1.Hide();
            userControl_login1.panel2.Location = new Point(22, 77);
            userControl_login1.panel2.Hide();
            if (UserControl_login.login_check == 0)
            {
                userControl_login1.panel1.Show();
                userControl_login1.panel1.BringToFront();

                if (UserControl_login.position == 0)
                {
                    userControl_login1.panel2.Show();
                    userControl_login1.panel2.BringToFront();
                }
                else
                {
                    userControl_login1.panel1.Show();
                    userControl_login1.panel2.Show();
                    userControl_login1.panel2.BringToFront();
                    userControl_login1.panel1.BringToFront();
                }
            }
            else
            {
                if (UserControl_login.ad_em == 1)
                {
                    userControl_login1.employee1.Show();
                    userControl_login1.logout.Show();
                }
                else if (UserControl_login.ad_em == 2)
                {
                    userControl_login1.admin1.Show();
                    userControl_login1.logout.Show();
                }

            }
            userControl_login1.back.Hide();
            main.Show();
            main.BringToFront();
        }
        public void mainkey()
        {
            panel1.Location = new Point(390, 90);
            bedpanel.Hide();
            userControl_login1.Visible = false;
            panel1.Visible = false;
            userControl_login1.userControl_cust_login1.confirmation();
            userControl_login1.Editbutton.Hide();
            main.Hide();
            userControl_login1.back.Hide();
            userControl_login1.logout.Hide();
            userControl_login1.textBox3.Clear();
            slideshow();
            label10.Show();
        }
        private void main_Click(object sender, EventArgs e)
        {
            if (UserControl_login.login_check == 1)
            {
                
                DialogResult home = MessageBox.Show("Account is not logged out!\nproceeding to Home page.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (home == DialogResult.OK)
                {
                    mainkey();
                }
            }
            else
            {
                
                mainkey();
            }
            if (userControl_login1.userControl_cust_login1.txtbox_name.Text != "Enter Name:" || userControl_login1.userControl_cust_login1.phonenum.Text != "03######" || userControl_login1.userControl_cust_login1.cnictxtbox.Text != "42301####" || userControl_login1.userControl_cust_login1.txtbox_carddetails.Text != "Card number:" || userControl_login1.userControl_cust_login1.textemail.Text != "......@gamil.com")
            {
                DialogResult home = MessageBox.Show("You are are about to leave credential page\nAll data here will be lost!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (home == DialogResult.OK)
                {
                    mainkey();
                    
                }
            }
            else
            {
                mainkey();
                
            }

        }
        
        private void label2_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(390, 90);
            label10.Hide();
            hidslideshow();
            deletion = 1;
            bedpanel.Hide();
            //userControl_login1.dataGridView1.Rows.Clear();
            
            userControl_login1.dataGridView1.Hide();
            userControl_login1.Editbutton.Hide();
            userControl_login1.login_panel.Hide();
            UserControl_login.position = 0;
            userControl_login1.Show();
            panel1.Show();
            
            
            main.Show();
            main.BringToFront();
            userControl_login1.panel2.Location = new Point(176, 77);
            userControl_login1.panel1.Hide();
            if (UserControl_login.position == 0)
                userControl_login1.panel2.Show();
            else
            {
                userControl_login1.panel1.Show();
                userControl_login1.panel2.Show();
            }
        }

        private void userControl_login1_Load(object sender, EventArgs e)
        {

        }
        public void hidslideshow()
        {
            timer1.Enabled = false;
            ext.Visible = false;
            interior.Visible = false;
            gym.Visible = false;
            pool1.Visible = false;
            pool2.Visible = false;
        }

        public void slideshow()
        {
            ext.Visible = true;
            interior.Visible = false;
            gym.Visible = false;
            pool1.Visible = false;
            pool2.Visible = false;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ext.Visible == true)
            {
                ext.Visible = false;
                interior.Visible = true;
            }
            else if (interior.Visible == true)
            {
                interior.Visible = false;
                gym.Visible = true;
            }
            else if (gym.Visible == true)
            {
                gym.Visible = false;
                pool1.Visible = true;
            }
            else if (pool1.Visible == true)
            {
                pool1.Visible = false;
                pool2.Visible = true;
            }
            else if (pool2.Visible == true)
            {
                pool2.Visible = false;
                ext.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            developers dev = new developers();
            dev.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToLongTimeString();
        }

        private void pool1_Click(object sender, EventArgs e)
        {

        }
    }
}
