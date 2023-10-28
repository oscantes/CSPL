namespace CSPL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "1", "b7lwbto", "bilgisaayr perofmns sorunu", "yavaş çalışkyor", "destek erildi", "dün" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "2", "usneram", "jabbe sorunu", "açılmyıor", "müdajal edildi", "bugün" }, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabPage3 = new TabPage();
            listBox2 = new ListBox();
            entryviewtabbtn1 = new Button();
            listView1 = new ListView();
            columnHeader0 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            tabPage2 = new TabPage();
            button7 = new Button();
            label9 = new Label();
            tab2button1 = new Button();
            tab2richTextBox3 = new RichTextBox();
            tab2richTextBox2 = new RichTextBox();
            tab2usernamebox = new TextBox();
            tab2listBox3 = new ListBox();
            label7 = new Label();
            tab2listBox2 = new ListBox();
            label6 = new Label();
            tab2listBox1 = new ListBox();
            label5 = new Label();
            tabPage1 = new TabPage();
            label8 = new Label();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            richTextBox2 = new RichTextBox();
            tab1username = new TextBox();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(listBox2);
            tabPage3.Controls.Add(entryviewtabbtn1);
            tabPage3.Controls.Add(listView1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1008, 557);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Kayıt Görüntüleyici";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(8, 53);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(992, 349);
            listBox2.TabIndex = 2;
            // 
            // entryviewtabbtn1
            // 
            entryviewtabbtn1.AutoSize = true;
            entryviewtabbtn1.Location = new Point(8, 22);
            entryviewtabbtn1.Name = "entryviewtabbtn1";
            entryviewtabbtn1.Size = new Size(82, 25);
            entryviewtabbtn1.TabIndex = 1;
            entryviewtabbtn1.Text = "Kayıtları Çek";
            entryviewtabbtn1.UseVisualStyleBackColor = true;
            entryviewtabbtn1.Click += entryviewtabbtn1_Click;
            // 
            // listView1
            // 
            listView1.AccessibleName = "listview accessble name";
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader0, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(8, 414);
            listView1.Name = "listView1";
            listView1.Size = new Size(992, 135);
            listView1.TabIndex = 0;
            listView1.Tag = "listviewtag";
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader0
            // 
            columnHeader0.Text = "sıra";
            columnHeader0.Width = 40;
            // 
            // columnHeader1
            // 
            columnHeader1.Tag = "";
            columnHeader1.Text = "username";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Tag = "";
            columnHeader2.Text = "template";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "notes";
            columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "status description";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "date";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(tab2button1);
            tabPage2.Controls.Add(tab2richTextBox3);
            tabPage2.Controls.Add(tab2richTextBox2);
            tabPage2.Controls.Add(tab2usernamebox);
            tabPage2.Controls.Add(tab2listBox3);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(tab2listBox2);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(tab2listBox1);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1008, 557);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kayıt Oluşturucu";
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.Location = new Point(792, 20);
            button7.Name = "button7";
            button7.Size = new Size(188, 25);
            button7.TabIndex = 20;
            button7.Text = "Update Templates(not ready yet)";
            button7.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 511);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 19;
            label9.Text = "Son işlem: ";
            // 
            // tab2button1
            // 
            tab2button1.AutoSize = true;
            tab2button1.Location = new Point(896, 506);
            tab2button1.Name = "tab2button1";
            tab2button1.Size = new Size(84, 25);
            tab2button1.TabIndex = 18;
            tab2button1.Text = "Create Entry";
            tab2button1.UseVisualStyleBackColor = true;
            tab2button1.Click += tab2button1_Click;
            // 
            // tab2richTextBox3
            // 
            tab2richTextBox3.Location = new Point(408, 472);
            tab2richTextBox3.Multiline = false;
            tab2richTextBox3.Name = "tab2richTextBox3";
            tab2richTextBox3.Size = new Size(572, 23);
            tab2richTextBox3.TabIndex = 17;
            tab2richTextBox3.Text = "";
            // 
            // tab2richTextBox2
            // 
            tab2richTextBox2.Location = new Point(408, 246);
            tab2richTextBox2.Multiline = false;
            tab2richTextBox2.Name = "tab2richTextBox2";
            tab2richTextBox2.Size = new Size(572, 23);
            tab2richTextBox2.TabIndex = 14;
            tab2richTextBox2.Text = "";
            // 
            // tab2usernamebox
            // 
            tab2usernamebox.Location = new Point(8, 22);
            tab2usernamebox.Name = "tab2usernamebox";
            tab2usernamebox.PlaceholderText = "Enter username";
            tab2usernamebox.Size = new Size(200, 23);
            tab2usernamebox.TabIndex = 8;
            // 
            // tab2listBox3
            // 
            tab2listBox3.FormattingEnabled = true;
            tab2listBox3.ItemHeight = 15;
            tab2listBox3.Items.AddRange(new object[] { "destek verildi", "müdahale edilerek sorun giderildi", "müdahale edildi fakat sorun giderilemedi. fiziksel müdahale için yönlendirme yapıldı", "kayıt açılarak ilgili birime iletildi", "masaüstü telefonda oturum açma dokümanına yönlendirildi", "ANKA'ya yapılan müdahale ile çözülmeyen sorun için yop'a kayıt açıldı", "yetkisel sorun, yönlendirme yapıldı", "kronik elitebook g9 hücresel bağlantı sorunu, müdahale edilerek geçici çözüm sağlandı" });
            tab2listBox3.Location = new Point(408, 312);
            tab2listBox3.Name = "tab2listBox3";
            tab2listBox3.Size = new Size(572, 154);
            tab2listBox3.TabIndex = 16;
            tab2listBox3.SelectedIndexChanged += tab2listBox3_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(408, 294);
            label7.Name = "label7";
            label7.Size = new Size(229, 15);
            label7.TabIndex = 15;
            label7.Text = "3- STATUS DESCRIPTION(ACTIONS TAKEN)";
            // 
            // tab2listBox2
            // 
            tab2listBox2.FormattingEnabled = true;
            tab2listBox2.ItemHeight = 15;
            tab2listBox2.Items.AddRange(new object[] { "tarama yapılamıyor", "tarama yapılamıyor(çek tarayıcı)", "çıktı alınamıyor", "bord ekranında spool hatası alınıyor", "masaüstü telefona login olmak isteniyor", "mobil mail uygulaması kullanıcı kodu değişikliği sonrası şifre kabul etmiyor", "görüntülü görüşmede sorun yaşanıyor", "kullanıcı kodu değişikliği sonrası sorun yaşanıyor", "hücresel bağlantısı görünmemekte" });
            tab2listBox2.Location = new Point(408, 86);
            tab2listBox2.Name = "tab2listBox2";
            tab2listBox2.Size = new Size(572, 154);
            tab2listBox2.TabIndex = 13;
            tab2listBox2.SelectedIndexChanged += tab2listBox2_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(408, 68);
            label6.Name = "label6";
            label6.Size = new Size(157, 15);
            label6.TabIndex = 12;
            label6.Text = "2- NOTES(ABOUT INCIDENT)";
            // 
            // tab2listBox1
            // 
            tab2listBox1.FormattingEnabled = true;
            tab2listBox1.ItemHeight = 15;
            tab2listBox1.Items.AddRange(new object[] { "Bilgisayar Performans Sorunu", "BTM - Bilge:Uygulaması Üzerinde Yaşanan Sorun", "BTM - Bilgisayar Ağ Bağlantı Sorunu (IP alamama vb.)", "BTM - Bilgisayar Donanım Sorunu - İNNOVA", "BTM - Cisco Softphone Görüşme Sorunu", "CÜZDAN YAZICI SORUNU", "BTM - Çok Fonksiyonlu Yazıcı) Sorunu", "BTM - E - Faks Sorunu", "BTM - Elektronik İmza Uygulama Sorunları", "BTM - HALKA Uygulama Sorunları", "BTM - HalkAkademi Uygulama Sorunu", "BTM - Halkportal Erişim Sorunları", "BTM - Halkportal Üzerindeki Diğer Uygulama Sorunları", "BTM - HALKRAPOR Erişim ya da Raporlama Sorunu", "BTM - Internet Tarayıcı Sorunları", "BTM - Info (Ctrl - F12)", "BTM - IP telefon sorunu", "BTM - Kimyon Şifre ve Yetki Sorunları", "BTM - MDM Kullanıcı Bilgilendirme ( Telefon ayarları konusunda )", "BTM - Pulse Secure SSL VPN Uygulama Sorunu", "BTM - Office Program Sorunları", "BTM - Ortak Klasör Erişim Sorunu", "BTM - Uzak Bağlantı Sorunu", "Para Sayma Makinesi Sorunu", "Sıramatik Sorunu", "Tarayıcı Sorunu", "YOP-Bankacılık Ekran Sorunları" });
            tab2listBox1.Location = new Point(8, 86);
            tab2listBox1.Name = "tab2listBox1";
            tab2listBox1.Size = new Size(394, 409);
            tab2listBox1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 68);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 9;
            label5.Text = "1- TEMPLATE";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(richTextBox2);
            tabPage1.Controls.Add(tab1username);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1008, 557);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(778, 14);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 13;
            label8.Text = "Run As User";
            // 
            // button6
            // 
            button6.Location = new Point(266, 179);
            button6.Name = "button6";
            button6.Size = new Size(110, 23);
            button6.TabIndex = 12;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(266, 150);
            button5.Name = "button5";
            button5.Size = new Size(110, 23);
            button5.TabIndex = 11;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(266, 121);
            button4.Name = "button4";
            button4.Size = new Size(110, 23);
            button4.TabIndex = 11;
            button4.Text = "Hello Button";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(266, 92);
            button3.Name = "button3";
            button3.Size = new Size(110, 23);
            button3.TabIndex = 10;
            button3.Text = "Device Manager";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(266, 63);
            button2.Name = "button2";
            button2.Size = new Size(110, 23);
            button2.TabIndex = 9;
            button2.Text = "Task Manager";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(266, 34);
            button1.Name = "button1";
            button1.Size = new Size(110, 23);
            button1.TabIndex = 8;
            button1.Text = "CMD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(266, 301);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(260, 155);
            richTextBox2.TabIndex = 7;
            richTextBox2.Text = "";
            // 
            // tab1username
            // 
            tab1username.Location = new Point(266, 272);
            tab1username.Name = "tab1username";
            tab1username.PlaceholderText = "Enter username";
            tab1username.Size = new Size(260, 23);
            tab1username.TabIndex = 6;
            tab1username.TextChanged += textBox2_TextChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(8, 301);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(252, 155);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 272);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter computername or IP";
            textBox1.Size = new Size(252, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 252);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 252);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 2;
            label2.Text = "Computername or IP";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "connect_with_DW", "create_mistlog", "delete_ANKA_cache", "delete_jabber_cache", "get_OS_info", "get_USER_info", "prep_for_Psexec", "get_Installed_programs", "get_Administrators", "query_VPN_group", "TEST_runspace", "INTF_get_computername_from_DW", "INTF_Query_session" });
            listBox1.Location = new Point(8, 34);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(252, 199);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 14);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "İşlem Menüsü";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1016, 585);
            tabControl1.TabIndex = 0;
            tabControl1.Tag = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 585);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "CSPL";
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ColumnHeader sütun1;
        private ColumnHeader sütun2;
        private ColumnHeader sütun3;
        private TabPage tabPage3;
        private ListBox listBox2;
        private Button entryviewtabbtn1;
        private ListView listView1;
        private ColumnHeader columnHeader0;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TabPage tabPage2;
        private Button button7;
        private Label label9;
        private Button tab2button1;
        private RichTextBox tab2richTextBox3;
        private RichTextBox tab2richTextBox2;
        private TextBox tab2usernamebox;
        private ListBox tab2listBox3;
        private Label label7;
        private ListBox tab2listBox2;
        private Label label6;
        private ListBox tab2listBox1;
        private Label label5;
        private TabPage tabPage1;
        private Label label8;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private RichTextBox richTextBox2;
        private TextBox tab1username;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private ListBox listBox1;
        private Label label1;
        private TabControl tabControl1;
    }
}