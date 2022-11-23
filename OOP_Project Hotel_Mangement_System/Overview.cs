using System;
using System.Windows.Forms;

namespace OOP_Project_Hotel_Mangement_System
{
    public partial class Overview : Form
    {

        public static string tt_bill;

        public Overview()
        {
            InitializeComponent(); 
        }
        public void set()
        {
            UserControl_cust_login uc = new UserControl_cust_login();
            Overview ov = new Overview();
            label9.Text = UserControl_cust_login.cs_name ;
            label10.Text =UserControl_cust_login.cs_phone;
            label11.Text = UserControl_cust_login.cs_roomtype;
            
            label14.Text = UserControl_cust_login.cs_floor;                       

            if (UserControl_cust_login.cs_roomtype == "Single")
            {
                label12.Text = "Rs.8,000";
                label13.Text = "Rs.560";
                label15.Text = "Rs.8,560";
                tt_bill = "Rs.8,560";
            }
            else if (UserControl_cust_login.cs_roomtype == "Double")
            {
                label12.Text = "Rs.12,000";
                label13.Text = "Rs.840";
                label15.Text = "Rs.12,840";
                tt_bill = "Rs.12,840";
            }
            else if (UserControl_cust_login.cs_roomtype == "Triple")
            {
                label12.Text = "Rs.15,000";
                label13.Text = "Rs.1,050";
                label15.Text = "Rs.16,050";
                tt_bill = "Rs.16,050";
            }
            else if (UserControl_cust_login.cs_roomtype == "Queen")
            {
                label12.Text = "Rs.22,000";
                label13.Text = "Rs.1,540";
                label15.Text = "Rs.23,540";
                tt_bill = "Rs.23,540";
            }
            else if (UserControl_cust_login.cs_roomtype == "King")
            {
                label12.Text = "Rs.28,000";
                label13.Text = "Rs.1,960";
                label15.Text = "Rs.29,960";
                tt_bill = "Rs.29,960";
            }

        }
        private void Overview_Load(object sender, EventArgs e)
        {           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
