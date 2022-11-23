using System;
using System.Windows.Forms;

namespace OOP_Project_Hotel_Mangement_System
{
    public partial class developers : Form
    {
        public developers()
        {
            InitializeComponent();
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void button1_Move(object sender, EventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void developers_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
