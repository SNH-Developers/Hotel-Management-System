using System;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOP_Project_Hotel_Mangement_System
{
    public partial class Employee : UserControl
    {
        string[] name = new string[3] { "Nehal Ahmed", "Muhammad Mubashir","Shareyar Farooqi" } ;
        long[] id = new long[3] {250495,250498,003234 };
        string[] phone = new string[3] { "(+92)33-22244308", "(+92)33-23865966","(+92)33-32245436" };
        string[] address = new string[3] { "DHA Phase 2 EXT", "Gulshan-e-Iqbal Blk 13D", "Gulshan-e-Iqbal Blk 3" };
        string[] email = new string[3] { "nehalahead@gmail.com", "mubashir","Shareyar" };
        string[] cnic = new string[3] { "42301-5645663-8","42301-5468779-1","42301-4655346-3" };
        int[] year = new int[3] { 2014, 2015,2010 };
        int[] day = new int[3] { 15, 6 ,5};
        int[] month = new int[3] { 4, 6 ,1};        
        string[] position = new string[3] { "HOD", "Manager","Admin" };
        public static int log;

        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            panel2.Hide();
            flowLayoutPanel4.BackColor = Color.DimGray;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sno = log;
            String sqlconnection = "Data Source=LAPTOP-DKGF8JK3\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True";
            SqlConnection con = new SqlConnection(sqlconnection);
            con.Open();
            String datalog = "select * from staff_details1 where s_no = "+sno+"";
            SqlCommand cmd = new SqlCommand(datalog,con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
    

            if (log == 2) //admin
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        
                        label6.Text = dr[2].ToString();
                        label7.Text = dr[1].ToString();
                        label11.Text = dr[3].ToString();
                        label12.Text = dr[6].ToString();
                        label13.Text = dr[5].ToString();
                        label14.Text = dr[4].ToString();
                        label15.Text = dr[7].ToString();
                    }
                }

                dateTimePicker1.Value = new DateTime(year[log], month[log], day[log]);
                timer1.Enabled = false;
            }
            else if (log == 0) //emp1
            {
                while (dr.Read())
                {
                    label6.Text = dr[2].ToString();
                    label7.Text = dr[1].ToString();
                    label11.Text = dr[3].ToString();
                    label12.Text = dr[6].ToString();
                    label13.Text = dr[5].ToString();
                    label14.Text = dr[4].ToString();
                    label15.Text = dr[7].ToString();
                }
                dateTimePicker1.Value = new DateTime(year[log], month[log], day[log]);
                timer1.Enabled = false;

            }
            else if (log == 1) //emp2
            {
                while (dr.Read())
                {
                    label6.Text = dr[2].ToString();
                    label7.Text = dr[1].ToString();
                    label11.Text = dr[3].ToString();
                    label12.Text = dr[6].ToString();
                    label13.Text = dr[5].ToString();
                    label14.Text = dr[4].ToString();
                    label15.Text = dr[7].ToString();
                }
                dateTimePicker1.Value = new DateTime(year[log], month[log], day[log]);
                timer1.Enabled = false;

            }
        }
      

        private void flowLayoutPanel4_Click(object sender, EventArgs e)
        {
            //reservations1.dataGridView1.Rows.Clear();
            panel2.Hide();
            reservations1.Hide();
            flowLayoutPanel4.BackColor = Color.DimGray;
            flowLayoutPanel1.BackColor = Color.White;
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            panel2.Show();
            reservations1.Show();
            reservations1.set();
            flowLayoutPanel1.BackColor = Color.DimGray;
            flowLayoutPanel4.BackColor = Color.White;            
        }

        private void reservations1_Load(object sender, EventArgs e)
        {

        }
    }
}
