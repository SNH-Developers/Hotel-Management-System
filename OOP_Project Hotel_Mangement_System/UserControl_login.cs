using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOP_Project_Hotel_Mangement_System
{
    public delegate void bedpanelshow(string message);
    public delegate void bedpanelhide(string message);

    public partial class UserControl_login : UserControl
    {
        public event bedpanelshow show;
        public event bedpanelhide hide;

        public static string[] Naam = new string[101];
        public static string[] Phone = new string[101];
        public static string[] EmaiL = new string[101];
        public static string[] Gender = new string[101];
        public static string[] Enterdate = new string[101];
        public static string[] Exitdate = new string[101];
        public static string[] Birthdate = new string[101];
        public static string[] Guestnum = new string[101];
        public static string[] Roomtype = new string[101];
        public static string[] Room = new string[101];
        public static string[] floor = new string[101];
        public static string[] CNIC = new string[101];
        public static string[] mode = new string[101];
        public static string[] paid = new string[101];
        public static string[] card = new string[101];
        public static string[] uid = new string[101];
        public static string roomupdate;
        public static int login_check=0,ad_em=0, position=0, edit = 0,login;

        public void initialize()
        {
            int i = Int32.Parse(UserControl_cust_login.room);

            Naam[i] = UserControl_cust_login.name;
            Phone[i] = UserControl_cust_login.phone;
            EmaiL[i] = UserControl_cust_login.email;
            Gender[i] = UserControl_cust_login.gender;
            Enterdate[i] = UserControl_cust_login.enterdate;
            Exitdate[i] = UserControl_cust_login.exitdate;
            Birthdate[i] = UserControl_cust_login.birthdate;
            Guestnum[i] = UserControl_cust_login.guestnum;
            Roomtype[i] = UserControl_cust_login.roomtype;
            Room[i] = UserControl_cust_login.room;
            floor[i] = UserControl_cust_login.floor;
            CNIC[i] = UserControl_cust_login.cnic;
            mode[i] = UserControl_cust_login.mode;
            paid[i] = UserControl_cust_login.paid;
            card[i] = UserControl_cust_login.card;
            uid[i] = UserControl_cust_login.uid;
            Editbutton.Text = "Delete Reservation";
        }
        
        public UserControl_login()
        {
            InitializeComponent();
            userControl_cust_login1.usercustomerinitialize += new initialize(value_initialization);
            userControl_cust_login1.usercustomerupdate += new Updatereserve(value_reserveupdate);
        }

        void value_reserveupdate(string message)
        {
            userControl_cust_login1.Hide();         
            back.Hide();
            if (Form1.deletion == 2)
            {
                panel1.Show();
                panel2.Show();
            }
            else if(Form1.deletion == 1)
            {
                panel2.Show();
            }

            Editbutton.Hide();
            textBox3.Clear();
            dataGridView1.Hide();
            
            if(roomupdate != UserControl_cust_login.room)
            {
                int roomchecker = Int32.Parse(roomupdate);
                Naam[roomchecker] = "";
                Phone[roomchecker] = "";
                EmaiL[roomchecker] = "";
                Gender[roomchecker] = "";
                Room[roomchecker] = "";
                uid[roomchecker] = "";
            }

        }

        void value_initialization(string message)
        {
            initialize();
        }

        private void login_buton_Click(object sender, EventArgs e)
        {
            string emp_email = textBox1.Text;
            string emp_pass = textBox2.Text;

            if (emp_email == "emp1" && emp_pass == "emp1pass")
            {
                employee1.emp1.Show();
                userControl_cust_login1.Hide();
                employee1.adm.Hide();
                Employee.log = 1;
                admin1.Hide();
                login_panel.Show();
                employee1.Show();
                employee1.timer1.Enabled = true;
                logout.Show();
                logout.BringToFront();
                panel1.Hide();
                panel2.Hide();
                dataGridView1.Hide();
                Editbutton.Hide();
                textBox3.Clear();
                login_check = 1;
                ad_em = 1;

            }
            else if(emp_email == "emp2" && emp_pass == "emp2pass")
            {
                employee1.emp1.Show();
                userControl_cust_login1.Hide();
                employee1.adm.Hide();
                Employee.log = 0;
                admin1.Hide();
                login_panel.Show();
                employee1.Show();
                employee1.timer1.Enabled = true;
                logout.Show();
                logout.BringToFront();
                panel1.Hide();
                panel2.Hide();
                dataGridView1.Hide();
                Editbutton.Hide();
                textBox3.Clear();
                login_check = 1;
                ad_em = 1;
            }
            else if (emp_email == "admin" && emp_pass == "adminpass")
            {
                login = 2;
                logout.Show();
                userControl_cust_login1.Hide();
                logout.BringToFront();
                login_panel.Show();
                employee1.Hide();
                admin1.Show();
                admin1.set();
                panel1.Hide();
                panel2.Hide();
                dataGridView1.Hide();
                Editbutton.Hide();
                textBox3.Clear();
                login_check = 1;
                ad_em = 2;
            }
            else
            {
                MessageBox.Show("Invailed Email Or Password! \nTry Again!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string txt = textBox2.Text;

            if (Shw_pass.Checked == true)
            {
                textBox2.PasswordChar = '\0';
            }
            if (Shw_pass.Checked == false)
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void UserControl_login_Load(object sender, EventArgs e)
        {
            login_panel.Visible = false;
            employee1.Hide();
            admin1.Hide();
            dataGridView1.Hide();
            Editbutton.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (userControl_cust_login1.txtbox_name.Text != "Enter Name:" || userControl_cust_login1.phonenum.Text != "03######" || userControl_cust_login1.cnictxtbox.Text != "42301####" || userControl_cust_login1.txtbox_carddetails.Text != "Card number:"||userControl_cust_login1.textemail.Text != "......@gamil.com")
            {
                Editbutton.Hide();
                DialogResult home = MessageBox.Show("You have some information which hasn't been saved yet.\nAll entered data here will be lost!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (home == DialogResult.OK)
                {
                    
                    login_panel.Hide();
                    back.Hide();

                    if (position == 0)
                        panel2.Show();
                    else
                    {
                        panel1.Show();
                        panel2.Show();
                    }
                    if (hide != null)
                        hide("Hello");
                    textBox3.Clear();                   
                    userControl_cust_login1.confirmation();
                    userControl_cust_login1.Delete.Hide();

                }
            }
            else
            {
                login_panel.Hide();
                back.Hide();
                if (position == 0)
                    panel2.Show();
                else
                {
                    panel1.Show();
                    panel2.Show();
                }
                userControl_cust_login1.confirmation();
                if (hide != null)
                    hide("Hello");
                userControl_cust_login1.Delete.Hide();
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            String sqlconnection = "Data Source=LAPTOP-DKGF8JK3\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True";
            SqlConnection con = new SqlConnection(sqlconnection);
            con.Open();

            int room_check_reserve;
            //String Insert = "insert into test_table01(id,name) values(" + textBox1.Text + ",'" + textBox2.Text + "')";
            //SqlCommand cmd = new SqlCommand(Insert, con);
            //cmd.ExecuteNonQuery();
            //String room_check_db = "select * from booking_details1 where uid_no = " + (Int32.Parse(textBox3.Text) / 951);      
            //SqlCommand cmd = new SqlCommand(room_check_db, con);
            //cmd.ExecuteNonQuery();
            //SqlDataReader sqldata = cmd.ExecuteReader();
            
            try
            {
                room_check_reserve = Int32.Parse(textBox3.Text);
            }
            catch (Exception ex)
            {
                Editbutton.Hide();
                dataGridView1.Hide();
                MessageBox.Show("Text BOX is empty or wrong format");
                
                return;
            }
            
            String edit_db = "Select * from Booking_Details1 where uid_no = " + room_check_reserve;
            SqlCommand cmd = new SqlCommand(edit_db, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();

            if(!dr.HasRows)
            {
                Editbutton.Hide();
                dataGridView1.Hide();
                MessageBox.Show("No reservation found!", "Error", MessageBoxButtons.OK);
                return;
            }

            con.Close();
            con.Open();
            dataGridView1.Show();
            dataGridView1.BringToFront();
            SqlDataAdapter sqlData = new SqlDataAdapter("select * from booking_details1 where uid_no = "+room_check_reserve, con);
            DataTable databasetable = new DataTable();
            sqlData.Fill(databasetable);
            dataGridView1.DataSource = databasetable;
            //MessageBox.Show(room_check_reserve.ToString());
            int room_check = 1;
            Editbutton.Show();

            if (Int32.TryParse(textBox3.Text, out int value))
            {

                
                //    if (sqldata.HasRows)
                //    {


                //        for (int a = 0; a < 101; a++)

                //        {
                //            if (Room[a] == (Int32.Parse(textBox3.Text) / 951).ToString())
                //            {
                //                    //dataGridView1.Rows.Clear();
                //                    dataGridView1.Show();
                //                    dataGridView1.BringToFront();
                //                    dataGridView1.ColumnCount = 16;
                //                    dataGridView1.Columns[0].Name = "UID.No.";
                //                    dataGridView1.Columns[1].Name = "Name";
                //                    dataGridView1.Columns[2].Name = "Birthday";
                //                    dataGridView1.Columns[3].Name = "Phone No.";
                //                    dataGridView1.Columns[4].Name = "CNIC";
                //                    dataGridView1.Columns[5].Name = "E-mail Address";
                //                    dataGridView1.Columns[6].Name = "Gender";
                //                    dataGridView1.Columns[7].Name = "Floor";
                //                    dataGridView1.Columns[8].Name = "Room";
                //                    dataGridView1.Columns[9].Name = "Guests";
                //                    dataGridView1.Columns[10].Name = "Romm Type";
                //                    dataGridView1.Columns[11].Name = "Reserved Date";
                //                    dataGridView1.Columns[12].Name = "Departure Date";
                //                    dataGridView1.Columns[13].Name = "Payment Mode";
                //                    dataGridView1.Columns[14].Name = "Paid";
                //                    dataGridView1.Columns[15].Name = "Card Number";

                //                while (sqldata.Read())
                //                {
                //                    string[] row = new string[] { sqldata[0].ToString(), sqldata[1].ToString(), sqldata[2].ToString(), sqldata[3].ToString(), sqldata[4].ToString(), sqldata[5].ToString(), sqldata[6].ToString(), sqldata[7].ToString(), sqldata[8].ToString(), sqldata[9].ToString(), sqldata[10].ToString(), sqldata[11].ToString(), sqldata[12].ToString(), sqldata[13].ToString(), sqldata[14].ToString(), sqldata[15].ToString() };
                //                    dataGridView1.Rows.Add(row);
                //                }
                //                room_check = 1;
                //                
                //            }
                //        }
                //    }
                //    else
                //    {
                //        dataGridView1.Rows.Clear();
                //        dataGridView1.Hide();
                //        MessageBox.Show("No room reserved at the given uid");
                //    }
                //}
                //else
                //    MessageBox.Show("Search box empty or invalid UID enter.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            login_panel.Visible = true;
            userControl_cust_login1.Show();
            if (show != null)
                show("Hello");
            userControl_cust_login1.BringToFront();
            employee1.Hide(); 
            admin1.Hide();
            back.Show();
            back.BringToFront();
            panel1.Hide();
            panel2.Hide();
            //dataGridView1.Rows.Clear();
            dataGridView1.Hide();
            userControl_cust_login1.phonenum.Enabled = true;
            userControl_cust_login1.cnictxtbox.Enabled = true;
            userControl_cust_login1.dateTimePicker1.Enabled = true;
            edit = 0;
            userControl_cust_login1.Delete.Hide();
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            Editbutton.Text = "Delete Reservation";
            if (Int32.TryParse(textBox3.Text, out int value))
            {
                int room_check_reserve = Int32.Parse(textBox3.Text);
                if (show != null)
                    show("Hello");
                login_panel.Visible = true;
                userControl_cust_login1.Show();
                userControl_cust_login1.Delete.Show();
                admin1.Hide();
                employee1.Hide();
                back.Show();
                back.BringToFront();
                panel1.Hide();
                panel2.Hide();
                //dataGridView1.Rows.Clear();
                dataGridView1.Hide();

                edit = 1;
                int i = (Int32.Parse(textBox3.Text) / 951);
                //sql database
                String sqlconnection = "Data Source=LAPTOP-DKGF8JK3\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True";
                SqlConnection con = new SqlConnection(sqlconnection);
                con.Open();
                String edit_db = "Select * from Booking_Details1 where uid_no = " + room_check_reserve;
                SqlCommand cmd = new SqlCommand(edit_db, con);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        UserControl_cust_login.uid = dr[0].ToString();
                        UserControl_cust_login.name = dr[1].ToString();
                        UserControl_cust_login.phone = dr[3].ToString();
                        UserControl_cust_login.email = dr[5].ToString();
                        UserControl_cust_login.gender = dr[6].ToString();
                        UserControl_cust_login.enterdate = dr[11].ToString();
                        UserControl_cust_login.exitdate = dr[12].ToString();
                        UserControl_cust_login.birthdate = dr[2].ToString();
                        UserControl_cust_login.guestnum = dr[9].ToString();
                        UserControl_cust_login.roomtype = dr[10].ToString();
                        UserControl_cust_login.room = dr[8].ToString();
                        UserControl_cust_login.floor = dr[7].ToString();
                        UserControl_cust_login.cnic = dr[4].ToString();
                        UserControl_cust_login.mode = dr[13].ToString();
                    }
                }
                roomupdate = i.ToString();

                userControl_cust_login1.timer1.Enabled = true;
            }
            else
                MessageBox.Show("Search box empty or invalid UID enter.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void admin1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            employee1.Hide();
            admin1.Hide();
            login_panel.Hide();
            login_check = 0;
            panel1.Show();
            panel2.Show();
            textBox1.Clear();
            textBox2.Clear();
            logout.Hide();

        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            initialize();
        }
    }
      
}
