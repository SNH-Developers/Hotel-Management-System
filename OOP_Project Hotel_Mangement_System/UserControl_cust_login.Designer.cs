
namespace OOP_Project_Hotel_Mangement_System
{
    partial class UserControl_cust_login
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.conbogender = new System.Windows.Forms.ComboBox();
            this.lbl_phnum = new System.Windows.Forms.Label();
            this.phonenum = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.textemail = new System.Windows.Forms.TextBox();
            this.cobox_guestnum = new System.Windows.Forms.ComboBox();
            this.comboroomtype = new System.Windows.Forms.ComboBox();
            this.lbl_choice = new System.Windows.Forms.Label();
            this.lbl_arrival = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.lbl_deperture = new System.Windows.Forms.Label();
            this.lbl_paymethod = new System.Windows.Forms.Label();
            this.chkbox_cash = new System.Windows.Forms.CheckBox();
            this.chkbox_card = new System.Windows.Forms.CheckBox();
            this.lbl_card_del = new System.Windows.Forms.Label();
            this.txtbox_carddetails = new System.Windows.Forms.TextBox();
            this.cobox_mm = new System.Windows.Forms.ComboBox();
            this.cobox_yy = new System.Windows.Forms.ComboBox();
            this.lbl_exp = new System.Windows.Forms.Label();
            this.txtbox_cvc = new System.Windows.Forms.TextBox();
            this.buton_nxt = new System.Windows.Forms.Button();
            this.buton_billview = new System.Windows.Forms.Button();
            this.picbox_captche = new System.Windows.Forms.PictureBox();
            this.buton_gen = new System.Windows.Forms.Button();
            this.txtbox_entercaptche = new System.Windows.Forms.TextBox();
            this.buton_ok = new System.Windows.Forms.Button();
            this.lbl_captcheresult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cnictxtbox = new System.Windows.Forms.TextBox();
            this.combofloor = new System.Windows.Forms.ComboBox();
            this.comboroom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Delete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_captche)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(75, 17);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(49, 18);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name:";
            // 
            // txtbox_name
            // 
            this.txtbox_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbox_name.Location = new System.Drawing.Point(78, 38);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(248, 20);
            this.txtbox_name.TabIndex = 1;
            this.txtbox_name.Text = "Enter Name:";
            this.txtbox_name.Click += new System.EventHandler(this.txtbox_name_click);
            // 
            // lbl
            // 
            this.lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(75, 66);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(64, 18);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Birthday:";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lbl_gender
            // 
            this.lbl_gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(75, 118);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(58, 18);
            this.lbl_gender.TabIndex = 3;
            this.lbl_gender.Text = "Gender:";
            // 
            // conbogender
            // 
            this.conbogender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.conbogender.FormattingEnabled = true;
            this.conbogender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.conbogender.Location = new System.Drawing.Point(78, 139);
            this.conbogender.Name = "conbogender";
            this.conbogender.Size = new System.Drawing.Size(248, 21);
            this.conbogender.TabIndex = 4;
            this.conbogender.Text = "Select";
            // 
            // lbl_phnum
            // 
            this.lbl_phnum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_phnum.AutoSize = true;
            this.lbl_phnum.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phnum.Location = new System.Drawing.Point(75, 174);
            this.lbl_phnum.Name = "lbl_phnum";
            this.lbl_phnum.Size = new System.Drawing.Size(106, 18);
            this.lbl_phnum.TabIndex = 5;
            this.lbl_phnum.Text = "Phone Number:";
            // 
            // phonenum
            // 
            this.phonenum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phonenum.Location = new System.Drawing.Point(78, 190);
            this.phonenum.Multiline = true;
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(248, 21);
            this.phonenum.TabIndex = 6;
            this.phonenum.Text = "03######";
            this.phonenum.Click += new System.EventHandler(this.OnKeyDownHandler_click);
            this.phonenum.Leave += new System.EventHandler(this.OnKeyDownHandler_leave);
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(75, 276);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(47, 18);
            this.lbl_email.TabIndex = 7;
            this.lbl_email.Text = "E-mail";
            // 
            // textemail
            // 
            this.textemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textemail.Location = new System.Drawing.Point(78, 297);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(248, 20);
            this.textemail.TabIndex = 8;
            this.textemail.Text = "......@gamil.com";
            // 
            // cobox_guestnum
            // 
            this.cobox_guestnum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cobox_guestnum.FormattingEnabled = true;
            this.cobox_guestnum.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04"});
            this.cobox_guestnum.Location = new System.Drawing.Point(378, 38);
            this.cobox_guestnum.Name = "cobox_guestnum";
            this.cobox_guestnum.Size = new System.Drawing.Size(121, 21);
            this.cobox_guestnum.TabIndex = 9;
            this.cobox_guestnum.Text = "Guest Numbers";
            // 
            // comboroomtype
            // 
            this.comboroomtype.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboroomtype.FormattingEnabled = true;
            this.comboroomtype.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple",
            "Queen",
            "King"});
            this.comboroomtype.Location = new System.Drawing.Point(505, 38);
            this.comboroomtype.Name = "comboroomtype";
            this.comboroomtype.Size = new System.Drawing.Size(121, 21);
            this.comboroomtype.TabIndex = 10;
            this.comboroomtype.Text = "Room Type";
            this.comboroomtype.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lbl_choice
            // 
            this.lbl_choice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_choice.AutoSize = true;
            this.lbl_choice.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choice.Location = new System.Drawing.Point(375, 17);
            this.lbl_choice.Name = "lbl_choice";
            this.lbl_choice.Size = new System.Drawing.Size(50, 18);
            this.lbl_choice.TabIndex = 11;
            this.lbl_choice.Text = "Choice";
            // 
            // lbl_arrival
            // 
            this.lbl_arrival.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_arrival.AutoSize = true;
            this.lbl_arrival.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arrival.Location = new System.Drawing.Point(376, 113);
            this.lbl_arrival.Name = "lbl_arrival";
            this.lbl_arrival.Size = new System.Drawing.Size(53, 18);
            this.lbl_arrival.TabIndex = 12;
            this.lbl_arrival.Text = "Arrival:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 87);
            this.dateTimePicker1.MaxDate = new System.DateTime(2002, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2002, 12, 31, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(378, 134);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(248, 20);
            this.dateTimePicker2.TabIndex = 14;
            this.dateTimePicker2.Value = new System.DateTime(2022, 7, 14, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker3.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(378, 187);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(248, 20);
            this.dateTimePicker3.TabIndex = 15;
            // 
            // lbl_deperture
            // 
            this.lbl_deperture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_deperture.AutoSize = true;
            this.lbl_deperture.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deperture.Location = new System.Drawing.Point(376, 166);
            this.lbl_deperture.Name = "lbl_deperture";
            this.lbl_deperture.Size = new System.Drawing.Size(76, 18);
            this.lbl_deperture.TabIndex = 16;
            this.lbl_deperture.Text = "Deperture:";
            // 
            // lbl_paymethod
            // 
            this.lbl_paymethod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_paymethod.AutoSize = true;
            this.lbl_paymethod.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paymethod.Location = new System.Drawing.Point(375, 220);
            this.lbl_paymethod.Name = "lbl_paymethod";
            this.lbl_paymethod.Size = new System.Drawing.Size(119, 18);
            this.lbl_paymethod.TabIndex = 17;
            this.lbl_paymethod.Text = "Payment Method:";
            // 
            // chkbox_cash
            // 
            this.chkbox_cash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkbox_cash.AutoSize = true;
            this.chkbox_cash.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbox_cash.Location = new System.Drawing.Point(570, 219);
            this.chkbox_cash.Name = "chkbox_cash";
            this.chkbox_cash.Size = new System.Drawing.Size(56, 22);
            this.chkbox_cash.TabIndex = 18;
            this.chkbox_cash.Text = "Cash";
            this.chkbox_cash.UseVisualStyleBackColor = true;
            this.chkbox_cash.CheckedChanged += new System.EventHandler(this.chkbox_cash_CheckedChanged);
            // 
            // chkbox_card
            // 
            this.chkbox_card.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkbox_card.AutoSize = true;
            this.chkbox_card.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbox_card.Location = new System.Drawing.Point(505, 219);
            this.chkbox_card.Name = "chkbox_card";
            this.chkbox_card.Size = new System.Drawing.Size(55, 22);
            this.chkbox_card.TabIndex = 19;
            this.chkbox_card.Text = "Card";
            this.chkbox_card.UseVisualStyleBackColor = true;
            this.chkbox_card.CheckedChanged += new System.EventHandler(this.chkbox_card_CheckedChanged);
            // 
            // lbl_card_del
            // 
            this.lbl_card_del.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_card_del.AutoSize = true;
            this.lbl_card_del.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_card_del.Location = new System.Drawing.Point(375, 263);
            this.lbl_card_del.Name = "lbl_card_del";
            this.lbl_card_del.Size = new System.Drawing.Size(122, 18);
            this.lbl_card_del.TabIndex = 20;
            this.lbl_card_del.Text = "Enter Card Details:\r\n";
            // 
            // txtbox_carddetails
            // 
            this.txtbox_carddetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbox_carddetails.Location = new System.Drawing.Point(378, 284);
            this.txtbox_carddetails.Name = "txtbox_carddetails";
            this.txtbox_carddetails.Size = new System.Drawing.Size(248, 20);
            this.txtbox_carddetails.TabIndex = 21;
            this.txtbox_carddetails.Text = "Card number:";
            this.txtbox_carddetails.Click += new System.EventHandler(this.txtbox_carddetails_Click);
            this.txtbox_carddetails.Leave += new System.EventHandler(this.txtbox_carddetails_Leave);
            // 
            // cobox_mm
            // 
            this.cobox_mm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cobox_mm.FormattingEnabled = true;
            this.cobox_mm.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cobox_mm.Location = new System.Drawing.Point(509, 322);
            this.cobox_mm.Name = "cobox_mm";
            this.cobox_mm.Size = new System.Drawing.Size(57, 21);
            this.cobox_mm.TabIndex = 22;
            this.cobox_mm.Text = "MM";
            // 
            // cobox_yy
            // 
            this.cobox_yy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cobox_yy.FormattingEnabled = true;
            this.cobox_yy.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031"});
            this.cobox_yy.Location = new System.Drawing.Point(572, 322);
            this.cobox_yy.Name = "cobox_yy";
            this.cobox_yy.Size = new System.Drawing.Size(54, 21);
            this.cobox_yy.TabIndex = 23;
            this.cobox_yy.Text = "YY";
            // 
            // lbl_exp
            // 
            this.lbl_exp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_exp.AutoSize = true;
            this.lbl_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exp.Location = new System.Drawing.Point(375, 325);
            this.lbl_exp.Name = "lbl_exp";
            this.lbl_exp.Size = new System.Drawing.Size(72, 18);
            this.lbl_exp.TabIndex = 24;
            this.lbl_exp.Text = "Exp Date:";
            // 
            // txtbox_cvc
            // 
            this.txtbox_cvc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbox_cvc.Location = new System.Drawing.Point(509, 349);
            this.txtbox_cvc.Name = "txtbox_cvc";
            this.txtbox_cvc.Size = new System.Drawing.Size(117, 20);
            this.txtbox_cvc.TabIndex = 27;
            this.txtbox_cvc.Text = "CVC";
            // 
            // buton_nxt
            // 
            this.buton_nxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buton_nxt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buton_nxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_nxt.Location = new System.Drawing.Point(378, 479);
            this.buton_nxt.Name = "buton_nxt";
            this.buton_nxt.Size = new System.Drawing.Size(248, 23);
            this.buton_nxt.TabIndex = 28;
            this.buton_nxt.Text = "Next";
            this.buton_nxt.UseVisualStyleBackColor = false;
            this.buton_nxt.Visible = false;
            this.buton_nxt.Click += new System.EventHandler(this.buton_nxt_Click);
            // 
            // buton_billview
            // 
            this.buton_billview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buton_billview.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buton_billview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_billview.Location = new System.Drawing.Point(378, 450);
            this.buton_billview.Name = "buton_billview";
            this.buton_billview.Size = new System.Drawing.Size(248, 23);
            this.buton_billview.TabIndex = 29;
            this.buton_billview.Text = "Get Bill Overview";
            this.buton_billview.UseVisualStyleBackColor = false;
            this.buton_billview.Click += new System.EventHandler(this.buton_billview_Click);
            // 
            // picbox_captche
            // 
            this.picbox_captche.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbox_captche.Location = new System.Drawing.Point(78, 342);
            this.picbox_captche.Name = "picbox_captche";
            this.picbox_captche.Size = new System.Drawing.Size(248, 68);
            this.picbox_captche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_captche.TabIndex = 30;
            this.picbox_captche.TabStop = false;
            this.picbox_captche.Visible = false;
            // 
            // buton_gen
            // 
            this.buton_gen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buton_gen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buton_gen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_gen.Location = new System.Drawing.Point(78, 416);
            this.buton_gen.Name = "buton_gen";
            this.buton_gen.Size = new System.Drawing.Size(248, 23);
            this.buton_gen.TabIndex = 31;
            this.buton_gen.Text = "Generate Code";
            this.buton_gen.UseVisualStyleBackColor = false;
            this.buton_gen.Click += new System.EventHandler(this.buton_gen_Click);
            // 
            // txtbox_entercaptche
            // 
            this.txtbox_entercaptche.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbox_entercaptche.Location = new System.Drawing.Point(78, 450);
            this.txtbox_entercaptche.Name = "txtbox_entercaptche";
            this.txtbox_entercaptche.Size = new System.Drawing.Size(248, 20);
            this.txtbox_entercaptche.TabIndex = 32;
            this.txtbox_entercaptche.Text = "Enter";
            this.txtbox_entercaptche.Click += new System.EventHandler(this.txtbox_entercache_click);
            // 
            // buton_ok
            // 
            this.buton_ok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buton_ok.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buton_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buton_ok.Location = new System.Drawing.Point(78, 479);
            this.buton_ok.Name = "buton_ok";
            this.buton_ok.Size = new System.Drawing.Size(248, 23);
            this.buton_ok.TabIndex = 33;
            this.buton_ok.Text = "Ok";
            this.buton_ok.UseVisualStyleBackColor = false;
            this.buton_ok.Visible = false;
            this.buton_ok.Click += new System.EventHandler(this.buton_ok_Click);
            // 
            // lbl_captcheresult
            // 
            this.lbl_captcheresult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_captcheresult.AutoSize = true;
            this.lbl_captcheresult.BackColor = System.Drawing.Color.Transparent;
            this.lbl_captcheresult.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_captcheresult.Location = new System.Drawing.Point(389, 417);
            this.lbl_captcheresult.Name = "lbl_captcheresult";
            this.lbl_captcheresult.Size = new System.Drawing.Size(139, 30);
            this.lbl_captcheresult.TabIndex = 34;
            this.lbl_captcheresult.Text = "captche result will print\r\n\r\n";
            this.lbl_captcheresult.Visible = false;
            this.lbl_captcheresult.Click += new System.EventHandler(this.lbl_captcheresult_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Verify that You Are Human:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "CNIC:";
            // 
            // cnictxtbox
            // 
            this.cnictxtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cnictxtbox.Location = new System.Drawing.Point(78, 244);
            this.cnictxtbox.Multiline = true;
            this.cnictxtbox.Name = "cnictxtbox";
            this.cnictxtbox.Size = new System.Drawing.Size(248, 21);
            this.cnictxtbox.TabIndex = 37;
            this.cnictxtbox.Text = "42301####";
            this.cnictxtbox.Click += new System.EventHandler(this.CNIC_formate_click);
            this.cnictxtbox.Leave += new System.EventHandler(this.CNIC_format);
            // 
            // combofloor
            // 
            this.combofloor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combofloor.FormattingEnabled = true;
            this.combofloor.Location = new System.Drawing.Point(378, 86);
            this.combofloor.Name = "combofloor";
            this.combofloor.Size = new System.Drawing.Size(121, 21);
            this.combofloor.TabIndex = 38;
            this.combofloor.Text = "Select Floor";
            this.combofloor.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboroom
            // 
            this.comboroom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboroom.FormattingEnabled = true;
            this.comboroom.Location = new System.Drawing.Point(505, 86);
            this.comboroom.Name = "comboroom";
            this.comboroom.Size = new System.Drawing.Size(121, 21);
            this.comboroom.TabIndex = 39;
            this.comboroom.Text = "Select Room";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Choice:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(187, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(129, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 42;
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // update
            // 
            this.update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update.Location = new System.Drawing.Point(378, 387);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(121, 23);
            this.update.TabIndex = 43;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Visible = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Location = new System.Drawing.Point(505, 387);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(121, 23);
            this.Delete.TabIndex = 44;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(496, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 14);
            this.label6.TabIndex = 45;
            // 
            // UserControl_cust_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboroom);
            this.Controls.Add(this.combofloor);
            this.Controls.Add(this.cnictxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_captcheresult);
            this.Controls.Add(this.buton_ok);
            this.Controls.Add(this.txtbox_entercaptche);
            this.Controls.Add(this.buton_gen);
            this.Controls.Add(this.picbox_captche);
            this.Controls.Add(this.buton_billview);
            this.Controls.Add(this.buton_nxt);
            this.Controls.Add(this.txtbox_cvc);
            this.Controls.Add(this.lbl_exp);
            this.Controls.Add(this.cobox_yy);
            this.Controls.Add(this.cobox_mm);
            this.Controls.Add(this.txtbox_carddetails);
            this.Controls.Add(this.lbl_card_del);
            this.Controls.Add(this.chkbox_card);
            this.Controls.Add(this.chkbox_cash);
            this.Controls.Add(this.lbl_paymethod);
            this.Controls.Add(this.lbl_deperture);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_arrival);
            this.Controls.Add(this.lbl_choice);
            this.Controls.Add(this.comboroomtype);
            this.Controls.Add(this.cobox_guestnum);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.phonenum);
            this.Controls.Add(this.lbl_phnum);
            this.Controls.Add(this.conbogender);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.lbl_name);
            this.Name = "UserControl_cust_login";
            this.Size = new System.Drawing.Size(656, 519);
            this.Load += new System.EventHandler(this.UserControl_cust_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_captche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        public System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_phnum;
        public System.Windows.Forms.TextBox phonenum;
        private System.Windows.Forms.Label lbl_email;
        public System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.Label lbl_choice;
        private System.Windows.Forms.Label lbl_arrival;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label lbl_deperture;
        private System.Windows.Forms.Label lbl_paymethod;
        private System.Windows.Forms.CheckBox chkbox_cash;
        private System.Windows.Forms.CheckBox chkbox_card;
        private System.Windows.Forms.Label lbl_card_del;
        private System.Windows.Forms.ComboBox cobox_mm;
        private System.Windows.Forms.ComboBox cobox_yy;
        private System.Windows.Forms.Label lbl_exp;
        private System.Windows.Forms.TextBox txtbox_cvc;
        public System.Windows.Forms.Button buton_nxt;
        private System.Windows.Forms.Button buton_billview;
        private System.Windows.Forms.PictureBox picbox_captche;
        private System.Windows.Forms.Button buton_gen;
        private System.Windows.Forms.TextBox txtbox_entercaptche;
        private System.Windows.Forms.Button buton_ok;
        private System.Windows.Forms.Label lbl_captcheresult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button update;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ComboBox conbogender;
        public System.Windows.Forms.ComboBox cobox_guestnum;
        public System.Windows.Forms.ComboBox comboroomtype;
        public System.Windows.Forms.TextBox cnictxtbox;
        public System.Windows.Forms.ComboBox combofloor;
        public System.Windows.Forms.ComboBox comboroom;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtbox_carddetails;
    }
}
