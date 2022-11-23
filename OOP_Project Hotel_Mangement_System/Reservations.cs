using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace OOP_Project_Hotel_Mangement_System
{
    public partial class Reservations : UserControl
    {
        public Reservations()
        {
            InitializeComponent();
        }

        string[] Naam = new string[101];
        string[] Phone = new string[101];
        string[] EmaiL = new string[101];
        string[] Gender = new string[101];
        string[] Enterdate = new string[101];
        string[] Exitdate = new string[101];
        string[] Birthdate = new string[101];
        string[] Guestnum = new string[101];
        string[] Roomtype = new string[101];
        string[] Room = new string[101];
        string[] floor = new string[101];
        string[] CNIC = new string[101];
        string[] mode = new string[101];
        string[] paid = new string[101];
        string[] card = new string[101];
        string[] uid = new string[101];

        public void set()
        {
            uid = UserControl_login.uid;
            Naam = UserControl_login.Naam;
            Phone = UserControl_login.Phone;
            EmaiL = UserControl_login.EmaiL;
            Gender = UserControl_login.Gender;
            Enterdate = UserControl_login.Enterdate;
            Exitdate = UserControl_login.Exitdate;
            Birthdate = UserControl_login.Birthdate;
            Guestnum = UserControl_login.Guestnum;
            Roomtype = UserControl_login.Roomtype;
            Room = UserControl_login.Room;
            floor = UserControl_login.floor;
            CNIC = UserControl_login.CNIC;
            mode = UserControl_login.mode;
            paid = UserControl_login.paid;
            card = UserControl_login.card;


            String sqlconnection = "Data Source=LAPTOP-DKGF8JK3\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True";
            SqlConnection con = new SqlConnection(sqlconnection);
            con.Open();


            //String Insert = "insert into test_table01(id,name) values(" + textBox1.Text + ",'" + textBox2.Text + "')";
            //SqlCommand cmd = new SqlCommand(Insert, con);
            //cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter("select * from booking_details1", con);
            DataTable databasetable = new DataTable();
            sqlData.Fill(databasetable);
            dataGridView1.DataSource = databasetable;


            //dataGridView1.Rows.Clear();
            //dataGridView1.Show();
            //dataGridView1.ColumnCount = 16;
            //dataGridView1.Columns[0].Name = "UID.No.";
            //dataGridView1.Columns[1].Name = "Name";
            //dataGridView1.Columns[2].Name = "Birthday";
            //dataGridView1.Columns[3].Name = "Phone No.";
            //dataGridView1.Columns[4].Name = "CNIC";
            //dataGridView1.Columns[5].Name = "E-mail Address";
            //dataGridView1.Columns[6].Name = "Gender";
            //dataGridView1.Columns[7].Name = "Floor";
            //dataGridView1.Columns[8].Name = "Room";
            //dataGridView1.Columns[9].Name = "Guests";
            //dataGridView1.Columns[10].Name = "Romm Type";
            //dataGridView1.Columns[11].Name = "Reserved Date";
            //dataGridView1.Columns[12].Name = "Departure Date";
            //dataGridView1.Columns[13].Name = "Payment Mode";
            //dataGridView1.Columns[14].Name = "Paid";
            //dataGridView1.Columns[15].Name = "Card Number";

            //for (int a = 1; a < 101; a++)
            //{

            //    if (UserControl_login.Room[a] == a.ToString())
            //    {
            //        string[] row = new string[] { uid[a], Naam[a], Birthdate[a], Phone[a], CNIC[a], EmaiL[a], Gender[a], floor[a], Room[a], Guestnum[a], Roomtype[a], Enterdate[a], Exitdate[a], mode[a], paid[a], card[a] };
            //        dataGridView1.Rows.Add(row);
            //    }
            //}

        }

        private void Reservations_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
