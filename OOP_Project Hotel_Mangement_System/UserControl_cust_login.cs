using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace OOP_Project_Hotel_Mangement_System
{
    
    
    public delegate void Updatereserve(string message);
    public delegate void initialize(string message);
    public partial class UserControl_cust_login : UserControl
    {
        
        public event initialize usercustomerinitialize;
        public event Updatereserve usercustomerupdate;

        int r;
        string[] roomdelete = new string[101];
        int[] check = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public string num;
        public static string name, phone, email, gender, enterdate, exitdate, birthdate, guestnum, roomtype, floor, room,cnic,mode,paid,card,uid;
        public static int initialcheck=0;
        public static string cs_name, cs_phone, cs_floor, cs_roomtype;
        int pcheck = 0, cniccheck = 0, cardcheck = 0,totalbill=0;
        string[] cvc = new string[101];
        string[] mm = new string[101];
        string[] yy = new string[101];


        private void OnKeyDownHandler_leave(object sender, EventArgs e)
        {
            long p;

            if (phonenum.TextLength == 11)
            {
                p = Int64.Parse(phonenum.Text);
                phonenum.Text = "(+92)" + String.Format("{0:#####-#######}", p);
                label4.Text = "";
                phonenum.ForeColor = Color.Green;
                pcheck = 1;
            }
            else
            {
                label4.Text = "Invalid Phone number!";
                phonenum.ForeColor = Color.Red;
                pcheck = 0;
            }

        }
        private void OnKeyDownHandler_click(object sender, EventArgs e)
        {
            phonenum.Clear();
            phonenum.ForeColor = Color.Black;
        }
        public void confirmation()
        {           
            label5.Text = "";
            label4.Text = "";
            label6.Text = "";
            txtbox_carddetails.ForeColor = Color.Black;
            phonenum.ForeColor = Color.Black;
            cnictxtbox.ForeColor = Color.Black;
            txtbox_name.Text = "Enter Name:";
            phonenum.Text = "03######";
            textemail.Text = "......@gamil.com";
            cnictxtbox.Text = "42301####";           
            chkbox_card.Checked = false;
            chkbox_cash.Checked = false;
            txtbox_carddetails.Text = "Card number:";
            txtbox_cvc.Text = "CVC";
            cobox_mm.Text ="MM";
            cobox_yy.Text="YY";
            picbox_captche.Hide();
            buton_nxt.Hide();
            buton_ok.Hide();
            update.Hide();
            combofloor.Items.Clear();
            comboroom.Items.Clear();
            lbl_captcheresult.Text = "";
            txtbox_entercaptche.Text = "Enter";
            cobox_guestnum.Text = "Guest Numbers";
            comboroomtype.Text = "Room Type";
            combofloor.Text = "Select Floor";
            comboroom.Text = "Select Room";
            txtbox_name.Enabled = true;
            txtbox_carddetails.Enabled = true;
            chkbox_card.Enabled = true;
            cobox_mm.Enabled = true;
            cobox_yy.Enabled = true;
            txtbox_cvc.Enabled = true;
            chkbox_cash.Enabled = true;
            textemail.Enabled = true;

            for (int i = 0; i < 10; i++)
                check[i] = 0;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.MinDate = dateTimePicker2.Value.AddDays(1);
            
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void lbl_captcheresult_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_carddetails_Click(object sender, EventArgs e)
        {
            txtbox_carddetails.Clear();
            txtbox_carddetails.ForeColor = Color.Black;
        }

        private void txtbox_carddetails_Leave(object sender, EventArgs e)
        {
            if (txtbox_carddetails.TextLength == 16)
            {
                long p;
                p = Int64.Parse(txtbox_carddetails.Text);
                txtbox_carddetails.Text = string.Format("{0:####-####-####-####}", p);
                label6.Text = "";
                txtbox_carddetails.ForeColor = Color.Green;
                cardcheck = 1;
            }
            else
            {
                label6.Text = "Invalid CARD Number!";
                txtbox_carddetails.ForeColor = Color.Red;
                cardcheck = 0;
            }

        }

        private void CNIC_format(object sender, EventArgs e)
        {
            if (cnictxtbox.TextLength == 13)
            {               
                long p;
                p = Int64.Parse(cnictxtbox.Text);
                cnictxtbox.Text = String.Format("{0:#####-#######-#}", p);
                label5.Text = "";
                cnictxtbox.ForeColor = Color.Green;
                cniccheck = 1;
            }
            else
            {
                label5.Text = "Invalid CNIC Number!";
                cnictxtbox.ForeColor = Color.Red;
                cniccheck = 0;
            }
        }
        private void CNIC_formate_click(object sender, EventArgs e)
        {
            cnictxtbox.Clear();
            cnictxtbox.ForeColor = Color.Black;
        }


       
        private void txtbox_name_click(object sender, EventArgs e)
        {
            txtbox_name.Clear();
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (txtbox_name.TextLength > 4 && pcheck == 1 && cniccheck == 1 && cardcheck==1 && textemail.TextLength > 10 && cobox_guestnum.Text != "Guest Numbers" && comboroomtype.Text != "Room Type" && combofloor.Text != "Select Floor" && comboroom.Text != "Select Room" && textemail.Text.Contains(".com"))
            {
                DialogResult confirm = MessageBox.Show("Update Reservation?", "Reservation will be updated.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (confirm == DialogResult.Yes)
                {
                    string update_uid = uid;
                    name = txtbox_name.Text;
                    phone = phonenum.Text;
                    email = textemail.Text;
                    gender = conbogender.Text;
                    birthdate = dateTimePicker1.Text;
                    enterdate = dateTimePicker2.Text;
                    exitdate = dateTimePicker3.Text;
                    guestnum = cobox_guestnum.Text;
                    roomtype = comboroomtype.Text;
                    floor = combofloor.Text;
                    room = comboroom.Text;
                    cnic = cnictxtbox.Text;
                    cvc[Int32.Parse(comboroom.Text)] = txtbox_cvc.Text;
                    mm[Int32.Parse(comboroom.Text)] = cobox_mm.Text;
                    yy[Int32.Parse(comboroom.Text)] = cobox_yy.Text;

                    if (chkbox_card.Checked == true)
                    {
                        mode = "Card";
                        paid = "Yes";
                        card = txtbox_carddetails.Text;
                    }

                   

                    if (roomdelete[r] != comboroom.Text)
                    {
                        roomdelete[r] = "";
                        uid = ((951 * Int32.Parse(comboroom.Text)).ToString());
                    }

                    int ro = Int32.Parse(comboroom.Text);
                    roomdelete[ro] = comboroom.Text;


                    if (roomdelete[r] != comboroom.Text)
                    {
                        DialogResult success = MessageBox.Show("Reservation Updated!\nYour new UID:" + uid + "\nYour updated reservation info has been sent to your Email.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        if (success == DialogResult.OK)
                        {
                            //update sql data here...
                            String sqlconnection = "Data Source=LAPTOP-DKGF8JK3\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True";
                            SqlConnection con = new SqlConnection(sqlconnection);
                            con.Open();

                            string delete_query = "delete from booking_details1 where uid = " + update_uid /*uid variable*/;
                            SqlCommand cmd = new SqlCommand(delete_query, con);
                            cmd.ExecuteNonQuery();


                            String Insert_query = "insert into booking_details1 values( '" + uid + "' , '" + name + "', '" + birthdate + "','" + phone + "' , '" + cnic + "', '" + email + "', '" + gender + "', '" + floor + "', '" + room + "', '" + guestnum + "', '" + roomtype + "', '" + enterdate + "', '" + exitdate + "', '" + mode + "', '" + paid + "', '" + card + "'); )";
                            cmd = new SqlCommand(Insert_query, con);
                            cmd.ExecuteNonQuery();

                            txtbox_name.Clear();
                            phonenum.Clear();
                            textemail.Clear();
                            cnictxtbox.Clear();
                            txtbox_entercaptche.Clear();
                            combofloor.Items.Clear();
                            comboroom.Items.Clear();
                            buton_ok.Hide();
                            cobox_guestnum.Text = "Guest Numbers";
                            comboroomtype.Text = "Room Type";
                            combofloor.Text = "Select Floor";
                            comboroom.Text = "Select Room";
                            picbox_captche.Hide();
                            UserControl_login.edit = 0;
                            emailupdate();
                            if (usercustomerupdate != null)
                                usercustomerupdate("Hello");
                            if (usercustomerinitialize != null)
                                usercustomerinitialize("Hello");


                            for (int i = 0; i < 10; i++)
                                check[i] = 0;

                        }
                    }
                    else
                    {
                        DialogResult success = MessageBox.Show("Reservation Updated!\nYour updated reservation info has been sent to your Email.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        if (success == DialogResult.OK)
                        {
                            confirmation();
                            UserControl_login.edit = 0;

                            emailupdate();

                            if (usercustomerupdate != null)
                                usercustomerupdate("Hello");
                            if (usercustomerinitialize != null)
                                usercustomerinitialize("Hello");
                            
                        }
                    }
                }



            }
            else
            {
                MessageBox.Show("Information is missing or entered wrong.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        public void emailupdate()
        {
            //try
            //{

            //    Overview ov = new Overview();
            //    MailMessage mess = new MailMessage();
            //    mess.To.Add(email);
            //    mess.From = new MailAddress("shareyar8@gmail.com");
            //    string mess_body = "HELLO! YOU HAVE JUST MADE CHANGES IN YOUR RESERVATION IN ROYAL PALACE HOTEL.\n\nRESERVATION DETAILS:\n\t01.UID: " + uid + "\n\t02.NAME: " + name + "\n\t03.PHONE NO: " + phone + "\n\t04.CNIC NO.: " + cnic + "\n\t05.GUEST NO: " + guestnum + "\n\t06.ROOM TYPE: " + roomtype + "\n\t07.ROOM NO: " + room + "\n\t08.FLOOR NO: " + floor + "\n\t09.TOTAL BILL: " + Overview.tt_bill + "\n\n\nTHIS IS AN AUTOMATIC RESERVATION SUMMARY SENT TO " + email + " BY A C# PROGRAM :)";
            //    mess.Body = mess_body;
            //    SmtpClient smtp = new SmtpClient("Smtp.gmail.com");
            //    smtp.Port = 25;
            //    smtp.EnableSsl = true;
            //    smtp.Credentials = new NetworkCredential("shareyar8@gmail.com", "shareyarps4!");
            //    smtp.Send(mess.From.ToString(), mess.To.ToString(), "YOU MADE A RESERVATION", mess.Body);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        private void txtbox_entercache_click(object sender, EventArgs e)
        {
            txtbox_entercaptche.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(initialcheck.ToString());
        }

        private void buton_billview_Click(object sender, EventArgs e)
        {
            Overview bill = new Overview();
            bill.Show();
            bill.timer1.Enabled = true;
            cs_name = txtbox_name.Text;
            cs_phone = phonenum.Text;
            cs_floor = combofloor.Text;
            cs_roomtype = comboroomtype.Text;
            bill.set();
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            int deleting_uid = Int32.Parse(uid);

            //MessageBox.Show(uid);
            DialogResult confirm = MessageBox.Show("Confirm Deletion?\nYour Resevation will be deleted.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirm == DialogResult.Yes)
            {
                room = "";                
                roomdelete[r] = "";

                DialogResult success = MessageBox.Show("Reservation Deleted!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (success == DialogResult.OK)
                {
                    confirmation();
                    //delete data here.....
                    String sqlconnection = "Data Source=LAPTOP-DKGF8JK3\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True";
                    SqlConnection con = new SqlConnection(sqlconnection);
                    con.Open();

                    string delete_query = "delete from booking_details1 where uid_no = " + deleting_uid/*uid variable*/;
                    SqlCommand cmd = new SqlCommand(delete_query, con);
                    cmd.ExecuteNonQuery();

                    UserControl_login.edit = 0;
                    
                    if (usercustomerupdate != null)
                        usercustomerupdate("Hello");
                    //try
                    //{

                    //    Overview ov = new Overview();
                    //    MailMessage mess = new MailMessage();
                    //    mess.To.Add(email);
                    //    mess.From = new MailAddress("shareyar8@gmail.com");
                    //    string mess_body = "HELLO! YOU HAVE JUST DELETED YOUR RESERVATION IN ROYAL PALACE HOTEL.\n\n\nTHIS IS AN AUTOMATIC RESERVATION SUMMARY SENT TO " + email + " BY A C# PROGRAM :)";
                    //    mess.Body = mess_body;
                    //    SmtpClient smtp = new SmtpClient("Smtp.gmail.com");
                    //    smtp.Port = 25;
                    //    smtp.EnableSsl = true;
                    //    smtp.Credentials = new NetworkCredential("shareyar8@gmail.com", "shareyarps4!");
                    //    smtp.Send(mess.From.ToString(), mess.To.ToString(), "YOU MADE A RESERVATION", mess.Body);
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(ex.Message);
                    //}

                }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            r = Int32.Parse(room);
            for (int i = 0; i < 10; i++)
                check[i] = 0;
            txtbox_name.Text = name;
            phonenum.Text = phone;
            textemail.Text = email;
            conbogender.Text = gender;
            //dateTimePicker1.Text = birthdate;
            //dateTimePicker2.Text = enterdate;
            //dateTimePicker3.Text = exitdate;
            cobox_guestnum.Text = guestnum;
            comboroomtype.Text = roomtype;
            combofloor.Text = floor;
            comboroom.Text = room;
            txtbox_name.Enabled = false;
            cnictxtbox.Enabled = false;
            textemail.Enabled = false;
            cobox_mm.Text = mm[Int32.Parse(room)];
            cobox_yy.Text = yy[Int32.Parse(room)];
            txtbox_cvc.Text = cvc[Int32.Parse(room)];

            if (mode == "Card")
            {
                chkbox_card.Checked = true;
                txtbox_carddetails.Enabled = false;                
                cobox_mm.Enabled = false;
                cobox_yy.Enabled = false;
                txtbox_cvc.Enabled = false;
                chkbox_cash.Enabled = false;
                txtbox_carddetails.Text = card;
                chkbox_card.Enabled = false;
                
                cardcheck = 1;
            }      
            else if(mode == "Cash")
            {
                txtbox_carddetails.Enabled = false;
                txtbox_carddetails.Text = "Cash mode choosen.";
                chkbox_card.Checked = false;
                cobox_mm.Enabled = false;
                cobox_yy.Enabled = false;
                txtbox_cvc.Enabled = false;
                cardcheck = 1;
            }
            phonenum.Enabled = false;
            dateTimePicker1.Enabled = false;
            cnictxtbox.Text = cnic;
            timer1.Enabled = false;
            
        }

        private void chkbox_cash_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_cash.Checked == true)
            {
                txtbox_carddetails.Enabled = false;
                txtbox_carddetails.Text = "Cash mode choosen.";
                chkbox_card.Checked = false;
                cobox_mm.Enabled = false;
                cobox_yy.Enabled = false;
                txtbox_cvc.Enabled = false;
                cardcheck = 1;
            }
        }

        private void chkbox_card_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_card.Checked == true)
            {
                txtbox_carddetails.Text = "Card number:";
                txtbox_carddetails.Enabled = true;               
                chkbox_cash.Checked = false;
                cobox_mm.Enabled = true;
                cobox_yy.Enabled = true;
                txtbox_cvc.Enabled = true;
            }
        }

        private void buton_nxt_Click(object sender, EventArgs e)
        {
            if (txtbox_name.TextLength > 4 && pcheck == 1 && cniccheck == 1 && cardcheck == 1 && textemail.TextLength > 10 && cobox_guestnum.Text != "Guest Numbers" && comboroomtype.Text != "Room Type" && combofloor.Text != "Select Floor" && comboroom.Text != "Select Room" && textemail.Text.Contains(".com"))
            {

                DialogResult confirm = MessageBox.Show("Confirm Reservation?\nNo changes will be made later.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    name = txtbox_name.Text;
                    phone = phonenum.Text;
                    email = textemail.Text;
                    gender = conbogender.Text;
                    birthdate = dateTimePicker1.Text;
                    enterdate = dateTimePicker2.Text;
                    exitdate = dateTimePicker3.Text;
                    guestnum = cobox_guestnum.Text;
                    roomtype = comboroomtype.Text;
                    floor = combofloor.Text;
                    room = comboroom.Text;
                    cnic = cnictxtbox.Text;
                    uid = ((951 * Int32.Parse(comboroom.Text)).ToString());
                    cvc[Int32.Parse(comboroom.Text)] = txtbox_cvc.Text;
                    mm[Int32.Parse(comboroom.Text)] = cobox_mm.Text;
                    yy[Int32.Parse(comboroom.Text)] = cobox_yy.Text;

                    if (chkbox_card.Checked == true)
                    {
                        mode = "Card";
                        paid = "Yes";
                        card = txtbox_carddetails.Text;
                    }
                    else if (chkbox_cash.Checked == true)
                    {
                        mode = "Cash";
                        paid = "No";
                        card = "-";
                    }
                    initialcheck = 1;

                    if (usercustomerinitialize != null)
                        usercustomerinitialize("Hello");

                    int ro = Int32.Parse(comboroom.Text);
                    roomdelete[ro] = comboroom.Text;

                    DialogResult success = MessageBox.Show("Reservation Complete!\nYour UID:" + uid +"\nYour reservation info has been sent to your Email.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (success == DialogResult.OK)
                    {
                        confirmation();

                        if (chkbox_card.Checked == true)
                        { //insert data here.....
                            String sqlconnection = "Data Source=LAPTOP-DKGF8JK3\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True";
                            SqlConnection con = new SqlConnection(sqlconnection);
                            con.Open();
                            String Insert = "insert into booking_details1 values( '" + uid + "' , '" + name + "', '" + birthdate + "','" + phone + "' , '" + cnic + "', '" + email + "', '" + gender + "', '" + floor + "', '" + room + "', '" + guestnum + "', '" + roomtype + "', '" + enterdate + "', '" + exitdate + "', '" + mode + "', '" + paid + "', '" + card + "'); ";
                            SqlCommand cmd = new SqlCommand(Insert, con);
                            cmd.ExecuteNonQuery();
                        }
                        else if(chkbox_card.Checked == false)
                        {

                            String sqlconnection = "Data Source=LAPTOP-DKGF8JK3\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True";
                            SqlConnection con = new SqlConnection(sqlconnection);
                            con.Open();
                            String Insert = "insert into booking_details1 values( '" + uid + "' , '" + name + "', '" + birthdate + "','" + phone + "' , '" + cnic + "', '" + email + "', '" + gender + "', '" + floor + "', '" + room + "', '" + guestnum + "', '" + roomtype + "', '" + enterdate + "', '" + exitdate + "', '" + mode + "', '" + paid + "', '" + card + "'); ";
                            SqlCommand cmd = new SqlCommand(Insert, con);
                            cmd.ExecuteNonQuery();
                        }
                    
                        //try
                        //{

                        //    Overview ov = new Overview();                            
                        //    MailMessage mess = new MailMessage();
                        //    mess.To.Add(email);
                        //    mess.From = new MailAddress("shareyar8@gmail.com");
                        //    string mess_body = "HELLO! YOU HAVE JUST MADE A RESERVATION IN ROYAL PALACE HOTEL.\n\nRESERVATION DETAILS:\n\t01.UID: " + uid + "\n\t02.NAME: " + name + "\n\t03.PHONE NO: " + phone + "\n\t04.CNIC NO.: "+cnic+"\n\t05.GUEST NO: " + guestnum + "\n\t06.ROOM TYPE: " + roomtype + "\n\t07.ROOM NO: " + room + "\n\t08.FLOOR NO: " + floor + "\n\t09.TOTAL BILL: " + Overview.tt_bill + "\n\n\nTHIS IS AN AUTOMATIC RESERVATION SUMMARY SENT TO "+email+" BY A C# PROGRAM :)";
                        //    mess.Body = mess_body;
                        //    SmtpClient smtp = new SmtpClient("Smtp.gmail.com");
                        //    smtp.Port = 25;
                        //    smtp.EnableSsl = true;
                        //    smtp.Credentials = new NetworkCredential("shareyar8@gmail.com", "shareyar820!");
                        //    smtp.Send(mess.From.ToString(), mess.To.ToString(), "YOU MADE A RESERVATION", mess.Body);
                        //}
                        //catch (Exception ex)
                        //{
                        //    MessageBox.Show(ex.Message);
                        //}

                    }
                }
            }
            else
            {
                MessageBox.Show("Information is missing or entered wrong.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

        }

        public UserControl_cust_login()
        {
            InitializeComponent();
            txtbox_name.Enabled = true;
        }

        

        public void buton_gen_Click(object sender, EventArgs e)
        {
            picbox_captche.Show();
            Random ran01 = new Random();
            num  = Convert.ToString(ran01.Next(69,200));
            var image = new Bitmap(picbox_captche.Width,picbox_captche.Height);
            var font = new Font("wELCoMe t0 HOtel", 28,FontStyle.Underline);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(num,font,Brushes.AliceBlue, new Point(0,0));
            picbox_captche.Image = image;
            buton_ok.Visible = true;
        }

        private void buton_ok_Click(object sender, EventArgs e)
        {
            if (UserControl_login.edit == 0)
            {
                if (txtbox_entercaptche.Text == num)
                {
                    lbl_captcheresult.Text = "CAPTCHE MATCHED, PLEASE PROSEED";
                    lbl_captcheresult.Visible = true;
                    buton_nxt.Visible = true;
                }
                else if (txtbox_entercaptche.Text != num)
                {
                    lbl_captcheresult.Text = "CAPTCHE NOT MATCHED, PLEASE TRY AGAIN!";
                    buton_nxt.Visible = false;
                }
            }
            else if(UserControl_login.edit == 1)
            {
                if (txtbox_entercaptche.Text == num)
                {
                    lbl_captcheresult.Text = "CAPTCHE MATCHED, PLEASE PROSEED";
                    lbl_captcheresult.Visible = true;
                    update.Visible = true;
                }
                else if (txtbox_entercaptche.Text != num)
                {
                    lbl_captcheresult.Text = "CAPTCHE NOT MATCHED, PLEASE TRY AGAIN!";
                    update.Visible = false;
                }
            }
        }

        private void UserControl_cust_login_Load(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = DateTime.Today;
            dateTimePicker3.MinDate = DateTime.Today.AddDays(1);
            txtbox_name.Enabled = true;

            
        }
       
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboroomtype.SelectedItem == "Single")
            {
                combofloor.Items.Clear();
                combofloor.Text = "Select Floor";
                string[] s = { "01", "02" };
                combofloor.Items.AddRange(s);
                comboroom.Items.Clear();
                comboroom.Text = "Select Room";
            }
            else if (comboroomtype.SelectedItem == "Double")
            {
                combofloor.Items.Clear();
                combofloor.Text = "Select Floor";
                string[] s = { "03", "04" };
                combofloor.Items.AddRange(s);
                comboroom.Items.Clear();
                comboroom.Text = "Select Room";
            }
            else if (comboroomtype.SelectedItem == "Triple")
            {
                combofloor.Items.Clear();
                combofloor.Text = "Select Floor";
                string[] s = { "05", "06" };
                combofloor.Items.AddRange(s);
                comboroom.Items.Clear();
                comboroom.Text = "Select Room";
            }
            else if (comboroomtype.SelectedItem == "Queen")
            {
                combofloor.Items.Clear();
                combofloor.Text = "Select Floor";
                string[] s = { "07", "08" };
                combofloor.Items.AddRange(s);
                comboroom.Items.Clear();
                comboroom.Text = "Select Room";
            }
            else if (comboroomtype.SelectedItem == "King")
            {
                combofloor.Items.Clear();
                combofloor.Text = "Select Floor";
                string[] s = { "09", "10" };
                combofloor.Items.AddRange(s);
                comboroom.Items.Clear();
                comboroom.Text = "Select Room";
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofloor.Text == "01")
            {

                for (int i = 1; i < 10; i++)
                    check[i] = 0;

                if (check[0] == 0)
                {
                    comboroom.Items.Clear();
                    for (int i = 1; i <= 10; i++)
                    {
                        if(roomdelete[i] == UserControl_login.roomupdate)
                            comboroom.Items.Add(i);
                        else if (roomdelete[i] != i.ToString())
                            comboroom.Items.Add(i);
                        
                    }
                   
                    check[0] = 1;
                }
                
                
            }
            if (combofloor.Text == "02")
            {
                check[0] = 0;

                for (int i = 2; i < 10; i++)
                    check[i] = 0;

                if (check[1] == 0)
                {
                    comboroom.Items.Clear();
                    for (int i = 11; i <= 20; i++)
                    {
                        if (roomdelete[i] != i.ToString())
                            comboroom.Items.Add(i);

                    }
                    check[1] = 1;
                }
                
            }
            if (combofloor.Text == "03")
            {
                check[1] = 0; check[0] = 0;
                for (int i = 3; i < 10; i++)
                    check[i] = 0;

                if (check[2] == 0)
                {
                    comboroom.Items.Clear();
                    for (int i = 21; i <= 30; i++)
                    {
                        if (roomdelete[i] != i.ToString())
                            comboroom.Items.Add(i);

                    }
                    check[2] = 1;
                }
                
            }
            if (combofloor.Text == "04")
            {
                for (int i = 0; i < 3; i++)
                    check[i] = 0;
                for (int i = 4; i < 10; i++)
                    check[i] = 0;

                if (check[3] == 0)
                {
                    comboroom.Items.Clear();
                    for (int i = 31; i <= 40; i++)
                    {
                        if (roomdelete[i] != i.ToString())
                            comboroom.Items.Add(i);

                    }
                    check[3] = 1;
                }
                
            }
            if (combofloor.Text == "05")
            {
                for (int i = 0; i < 4; i++)
                    check[i] = 0;
                for (int i = 5; i < 10; i++)
                    check[i] = 0;

                if (check[4] == 0)
                {
                    comboroom.Items.Clear();
                    for (int i = 41; i <= 50; i++)
                    {
                        if (roomdelete[i] != i.ToString())
                            comboroom.Items.Add(i);

                    }
                    check[4] = 1;
                }
               
            }
            if (combofloor.Text == "06")
            {
                for (int i = 0; i < 5; i++)
                    check[i] = 0;
                for (int i = 6; i < 10; i++)
                    check[i] = 0;


                if (check[5] == 0)
                {        
                        comboroom.Items.Clear();
                    for (int i = 51; i <= 60; i++)
                    {
                        if (roomdelete[i] != i.ToString())
                            comboroom.Items.Add(i);

                    }
                    check[5] = 1;
                }
                
            }
            if (combofloor.Text == "07")
            {
                for (int i = 0; i < 6; i++)
                    check[i] = 0;
                for (int i = 7; i < 10; i++)
                    check[i] = 0;


                if (check[6] == 0)
                {
                    comboroom.Items.Clear();
                    for (int i = 61; i <= 70; i++)
                    {
                        if (roomdelete[i] != i.ToString())
                            comboroom.Items.Add(i);

                    }
                    check[6] = 1;
                }
                
            }
            if (combofloor.Text == "08")
            {
                for (int i = 0; i < 7; i++)
                    check[i] = 0;
                check[9] = 0; check[8] = 0;

                if (check[7] == 0)
                {
                    comboroom.Items.Clear();
                    for (int i = 71; i <= 80; i++)
                    {
                        if (roomdelete[i] != i.ToString())
                            comboroom.Items.Add(i);

                    }
                    check[7] = 1;
                }
                
            }
            if (combofloor.Text == "09")
            {
                for (int i = 0; i < 8; i++)
                    check[i] = 0;
                check[9] = 0;

                if (check[8] == 0)
                {
                    comboroom.Items.Clear();
                    for (int i = 81; i <= 90; i++)
                    {
                        if (roomdelete[i] != i.ToString())
                            comboroom.Items.Add(i);

                    }
                    check[8] = 1;
                }
                
            }
            if (combofloor.Text == "10")
            {
                for (int i = 0; i < 9; i++)
                    check[i] = 0;

                if (check[9] == 0)
                {
                    comboroom.Items.Clear();
                    for (int i = 91; i <= 100; i++)
                    {
                        if (roomdelete[i] != i.ToString())
                            comboroom.Items.Add(i);

                    }
                    check[9] = 1;
                }
                
            }
        }
    }
}
