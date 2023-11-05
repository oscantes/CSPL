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
            viewRowsSplitter = new TableLayoutPanel();
            readRowsBtn = new Button();
            listBox2 = new ListBox();
            tabPage2 = new TabPage();
            CreateTabMainSplit = new SplitContainer();
            CreateTabTable1 = new TableLayoutPanel();
            tab2Templates = new ListBox();
            tab2usernamebox = new TextBox();
            label5 = new Label();
            CreateTabTable2 = new TableLayoutPanel();
            CreateRowBtn = new Button();
            label6 = new Label();
            tab2Notes = new ListBox();
            tab2StatusDescription = new ListBox();
            label7 = new Label();
            button7 = new Button();
            tab2NotesTxtBox = new TextBox();
            tab2StatusDescriptionTxtBox = new TextBox();
            tabPage1 = new TabPage();
            button8 = new Button();
            label8 = new Label();
            morningBtn = new Button();
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
            tabPage4 = new TabPage();
            listView1 = new ListView();
            columnHeader0 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            statusStrip1 = new StatusStrip();
            StatusLabel1 = new ToolStripStatusLabel();
            tabPage3.SuspendLayout();
            viewRowsSplitter.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CreateTabMainSplit).BeginInit();
            CreateTabMainSplit.Panel1.SuspendLayout();
            CreateTabMainSplit.Panel2.SuspendLayout();
            CreateTabMainSplit.SuspendLayout();
            CreateTabTable1.SuspendLayout();
            CreateTabTable2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage4.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(viewRowsSplitter);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(976, 561);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Kayıt Görüntüleyici";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // viewRowsSplitter
            // 
            viewRowsSplitter.ColumnCount = 1;
            viewRowsSplitter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            viewRowsSplitter.Controls.Add(readRowsBtn, 0, 0);
            viewRowsSplitter.Controls.Add(listBox2, 0, 1);
            viewRowsSplitter.Dock = DockStyle.Fill;
            viewRowsSplitter.Location = new Point(0, 0);
            viewRowsSplitter.Name = "viewRowsSplitter";
            viewRowsSplitter.RowCount = 2;
            viewRowsSplitter.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            viewRowsSplitter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            viewRowsSplitter.Size = new Size(976, 561);
            viewRowsSplitter.TabIndex = 4;
            // 
            // readRowsBtn
            // 
            readRowsBtn.AutoSize = true;
            readRowsBtn.Dock = DockStyle.Fill;
            readRowsBtn.Location = new Point(3, 3);
            readRowsBtn.Name = "readRowsBtn";
            readRowsBtn.Size = new Size(970, 24);
            readRowsBtn.TabIndex = 1;
            readRowsBtn.Text = "Kayıtları Çek";
            readRowsBtn.UseVisualStyleBackColor = true;
            readRowsBtn.Click += readRowsBtn_Click;
            // 
            // listBox2
            // 
            listBox2.Dock = DockStyle.Fill;
            listBox2.FormattingEnabled = true;
            listBox2.HorizontalScrollbar = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(3, 33);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(970, 525);
            listBox2.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(CreateTabMainSplit);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(976, 561);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kayıt Oluşturucu";
            // 
            // CreateTabMainSplit
            // 
            CreateTabMainSplit.Dock = DockStyle.Fill;
            CreateTabMainSplit.Location = new Point(0, 0);
            CreateTabMainSplit.Name = "CreateTabMainSplit";
            // 
            // CreateTabMainSplit.Panel1
            // 
            CreateTabMainSplit.Panel1.Controls.Add(CreateTabTable1);
            // 
            // CreateTabMainSplit.Panel2
            // 
            CreateTabMainSplit.Panel2.Controls.Add(CreateTabTable2);
            CreateTabMainSplit.Size = new Size(976, 561);
            CreateTabMainSplit.SplitterDistance = 363;
            CreateTabMainSplit.TabIndex = 21;
            // 
            // CreateTabTable1
            // 
            CreateTabTable1.ColumnCount = 1;
            CreateTabTable1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            CreateTabTable1.Controls.Add(tab2Templates, 0, 2);
            CreateTabTable1.Controls.Add(tab2usernamebox, 0, 0);
            CreateTabTable1.Controls.Add(label5, 0, 1);
            CreateTabTable1.Dock = DockStyle.Fill;
            CreateTabTable1.Location = new Point(0, 0);
            CreateTabTable1.Name = "CreateTabTable1";
            CreateTabTable1.RowCount = 3;
            CreateTabTable1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            CreateTabTable1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CreateTabTable1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            CreateTabTable1.Size = new Size(363, 561);
            CreateTabTable1.TabIndex = 0;
            // 
            // tab2Templates
            // 
            tab2Templates.Dock = DockStyle.Fill;
            tab2Templates.FormattingEnabled = true;
            tab2Templates.ItemHeight = 15;
            tab2Templates.Items.AddRange(new object[] { "Bilgisayar Performans Sorunu", "BTM - Bilge:Uygulaması Üzerinde Yaşanan Sorun", "BTM - Bilgisayar Ağ Bağlantı Sorunu (IP alamama vb.)", "BTM - Bilgisayar Donanım Sorunu - İNNOVA", "BTM - Cisco Softphone Görüşme Sorunu", "CÜZDAN YAZICI SORUNU", "BTM - Çok Fonksiyonlu Yazıcı) Sorunu", "BTM - E - Faks Sorunu", "BTM - Elektronik İmza Uygulama Sorunları", "BTM - HALKA Uygulama Sorunları", "BTM - HalkAkademi Uygulama Sorunu", "BTM - Halkportal Erişim Sorunları", "BTM - Halkportal Üzerindeki Diğer Uygulama Sorunları", "BTM - HALKRAPOR Erişim ya da Raporlama Sorunu", "BTM - Internet Tarayıcı Sorunları", "BTM - Info (Ctrl - F12)", "BTM - IP telefon sorunu", "BTM - Kimyon Şifre ve Yetki Sorunları", "BTM - MDM Kullanıcı Bilgilendirme ( Telefon ayarları konusunda )", "BTM - Pulse Secure SSL VPN Uygulama Sorunu", "BTM - Office Program Sorunları", "BTM - Ortak Klasör Erişim Sorunu", "BTM - Uzak Bağlantı Sorunu", "Para Sayma Makinesi Sorunu", "Sıramatik Sorunu", "Tarayıcı Sorunu ", "YOP-Bankacılık Ekran Sorunları" });
            tab2Templates.Location = new Point(3, 53);
            tab2Templates.Name = "tab2Templates";
            tab2Templates.Size = new Size(357, 505);
            tab2Templates.TabIndex = 10;
            // 
            // tab2usernamebox
            // 
            tab2usernamebox.Dock = DockStyle.Fill;
            tab2usernamebox.Location = new Point(3, 3);
            tab2usernamebox.Name = "tab2usernamebox";
            tab2usernamebox.PlaceholderText = "Enter username";
            tab2usernamebox.Size = new Size(357, 23);
            tab2usernamebox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 30);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 9;
            label5.Text = "1- TEMPLATE";
            // 
            // CreateTabTable2
            // 
            CreateTabTable2.ColumnCount = 1;
            CreateTabTable2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            CreateTabTable2.Controls.Add(CreateRowBtn, 0, 7);
            CreateTabTable2.Controls.Add(label6, 0, 1);
            CreateTabTable2.Controls.Add(tab2Notes, 0, 2);
            CreateTabTable2.Controls.Add(tab2StatusDescription, 0, 5);
            CreateTabTable2.Controls.Add(label7, 0, 4);
            CreateTabTable2.Controls.Add(button7, 0, 0);
            CreateTabTable2.Controls.Add(tab2NotesTxtBox, 0, 3);
            CreateTabTable2.Controls.Add(tab2StatusDescriptionTxtBox, 0, 6);
            CreateTabTable2.Dock = DockStyle.Fill;
            CreateTabTable2.Location = new Point(0, 0);
            CreateTabTable2.Name = "CreateTabTable2";
            CreateTabTable2.RowCount = 8;
            CreateTabTable2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            CreateTabTable2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CreateTabTable2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            CreateTabTable2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            CreateTabTable2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CreateTabTable2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            CreateTabTable2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            CreateTabTable2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            CreateTabTable2.Size = new Size(609, 561);
            CreateTabTable2.TabIndex = 0;
            // 
            // CreateRowBtn
            // 
            CreateRowBtn.AutoSize = true;
            CreateRowBtn.Dock = DockStyle.Right;
            CreateRowBtn.Location = new Point(522, 533);
            CreateRowBtn.Name = "CreateRowBtn";
            CreateRowBtn.Size = new Size(84, 25);
            CreateRowBtn.TabIndex = 18;
            CreateRowBtn.Text = "Create Entry";
            CreateRowBtn.UseVisualStyleBackColor = true;
            CreateRowBtn.Click += CreateRowBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Location = new Point(3, 30);
            label6.Name = "label6";
            label6.Size = new Size(157, 20);
            label6.TabIndex = 12;
            label6.Text = "2- NOTES(ABOUT INCIDENT)";
            // 
            // tab2Notes
            // 
            tab2Notes.Dock = DockStyle.Fill;
            tab2Notes.FormattingEnabled = true;
            tab2Notes.ItemHeight = 15;
            tab2Notes.Items.AddRange(new object[] { "tarama yapılamıyor", "tarama yapılamıyor(çek tarayıcı)", "çıktı alınamıyor", "bord ekranında spool hatası alınıyor", "masaüstü telefona login olmak isteniyor", "mobil mail uygulaması kullanıcı kodu değişikliği sonrası şifre kabul etmiyor", "görüntülü görüşmede sorun yaşanıyor", "kullanıcı kodu değişikliği sonrası sorun yaşanıyor", "hücresel bağlantısı görünmemekte" });
            tab2Notes.Location = new Point(3, 53);
            tab2Notes.Name = "tab2Notes";
            tab2Notes.Size = new Size(603, 194);
            tab2Notes.TabIndex = 13;
            tab2Notes.SelectedIndexChanged += tab2listBox2_SelectedIndexChanged;
            // 
            // tab2StatusDescription
            // 
            tab2StatusDescription.Dock = DockStyle.Fill;
            tab2StatusDescription.FormattingEnabled = true;
            tab2StatusDescription.ItemHeight = 15;
            tab2StatusDescription.Items.AddRange(new object[] { "destek verildi", "müdahale edilerek sorun giderildi", "müdahale edildi fakat sorun giderilemedi. fiziksel müdahale için yönlendirme yapıldı", "kayıt açılarak ilgili birime iletildi", "masaüstü telefonda oturum açma dokümanına yönlendirildi", "ANKA'ya yapılan müdahale ile çözülmeyen sorun için yop'a kayıt açıldı", "yetkisel sorun, yönlendirme yapıldı", "kronik elitebook g9 hücresel bağlantı sorunu, müdahale edilerek geçici çözüm sağlandı" });
            tab2StatusDescription.Location = new Point(3, 303);
            tab2StatusDescription.Name = "tab2StatusDescription";
            tab2StatusDescription.Size = new Size(603, 194);
            tab2StatusDescription.TabIndex = 16;
            tab2StatusDescription.SelectedIndexChanged += tab2listBox3_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Left;
            label7.Location = new Point(3, 280);
            label7.Name = "label7";
            label7.Size = new Size(229, 20);
            label7.TabIndex = 15;
            label7.Text = "3- STATUS DESCRIPTION(ACTIONS TAKEN)";
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.Dock = DockStyle.Right;
            button7.Location = new Point(418, 3);
            button7.Name = "button7";
            button7.Size = new Size(188, 24);
            button7.TabIndex = 20;
            button7.Text = "Update Templates(not ready yet)";
            button7.UseVisualStyleBackColor = true;
            // 
            // tab2NotesTxtBox
            // 
            tab2NotesTxtBox.Dock = DockStyle.Fill;
            tab2NotesTxtBox.Location = new Point(3, 253);
            tab2NotesTxtBox.Name = "tab2NotesTxtBox";
            tab2NotesTxtBox.PlaceholderText = "Select any Notes from list or type here";
            tab2NotesTxtBox.Size = new Size(603, 23);
            tab2NotesTxtBox.TabIndex = 21;
            // 
            // tab2StatusDescriptionTxtBox
            // 
            tab2StatusDescriptionTxtBox.Dock = DockStyle.Fill;
            tab2StatusDescriptionTxtBox.Location = new Point(3, 503);
            tab2StatusDescriptionTxtBox.Name = "tab2StatusDescriptionTxtBox";
            tab2StatusDescriptionTxtBox.PlaceholderText = "Select any Status Description from list or type here";
            tab2StatusDescriptionTxtBox.Size = new Size(603, 23);
            tab2StatusDescriptionTxtBox.TabIndex = 22;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button8);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(morningBtn);
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
            tabPage1.Size = new Size(976, 561);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(490, 63);
            button8.Name = "button8";
            button8.Size = new Size(132, 23);
            button8.TabIndex = 14;
            button8.Text = "Restart Ivanti Service";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(754, 14);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 13;
            label8.Text = "Run As User";
            // 
            // morningBtn
            // 
            morningBtn.Location = new Point(490, 34);
            morningBtn.Name = "morningBtn";
            morningBtn.Size = new Size(132, 23);
            morningBtn.TabIndex = 12;
            morningBtn.Text = "Morning sunshine";
            morningBtn.UseVisualStyleBackColor = true;
            morningBtn.Click += morningBtn_Click;
            // 
            // button5
            // 
            button5.Location = new Point(266, 150);
            button5.Name = "button5";
            button5.Size = new Size(132, 23);
            button5.TabIndex = 11;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(266, 121);
            button4.Name = "button4";
            button4.Size = new Size(132, 23);
            button4.TabIndex = 11;
            button4.Text = "Hello Button";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(266, 92);
            button3.Name = "button3";
            button3.Size = new Size(132, 23);
            button3.TabIndex = 10;
            button3.Text = "Device Manager";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(266, 63);
            button2.Name = "button2";
            button2.Size = new Size(132, 23);
            button2.TabIndex = 9;
            button2.Text = "Task Manager";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(266, 34);
            button1.Name = "button1";
            button1.Size = new Size(132, 23);
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
            textBox1.Text = "localhost";
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
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(984, 589);
            tabControl1.TabIndex = 0;
            tabControl1.Tag = "";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(listView1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(976, 561);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Kayıt görüntüleyici beta";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.AccessibleName = "listview accessble name";
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader0, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.Dock = DockStyle.Fill;
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(970, 555);
            listView1.TabIndex = 1;
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
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusLabel1 });
            statusStrip1.Location = new Point(0, 589);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(984, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel1
            // 
            StatusLabel1.Name = "StatusLabel1";
            StatusLabel1.Size = new Size(0, 17);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 550);
            Name = "Form1";
            Text = "CSPL";
            tabPage3.ResumeLayout(false);
            viewRowsSplitter.ResumeLayout(false);
            viewRowsSplitter.PerformLayout();
            tabPage2.ResumeLayout(false);
            CreateTabMainSplit.Panel1.ResumeLayout(false);
            CreateTabMainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CreateTabMainSplit).EndInit();
            CreateTabMainSplit.ResumeLayout(false);
            CreateTabTable1.ResumeLayout(false);
            CreateTabTable1.PerformLayout();
            CreateTabTable2.ResumeLayout(false);
            CreateTabTable2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColumnHeader sütun1;
        private ColumnHeader sütun2;
        private ColumnHeader sütun3;
        private TabPage tabPage3;
        private Button readRowsBtn;
        private TabPage tabPage2;
        private Button button7;
        private Button CreateRowBtn;
        private TextBox tab2usernamebox;
        private ListBox tab2StatusDescription;
        private Label label7;
        private ListBox tab2Notes;
        private Label label6;
        private ListBox tab2Templates;
        private Label label5;
        private TabPage tabPage1;
        private Label label8;
        private Button morningBtn;
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
        private Button button8;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabel1;
        private ListBox listBox2;
        private TabPage tabPage4;
        private ListView listView1;
        private ColumnHeader columnHeader0;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TableLayoutPanel viewRowsSplitter;
        private SplitContainer CreateTabMainSplit;
        private TableLayoutPanel CreateTabTable1;
        private TableLayoutPanel CreateTabTable2;
        private TextBox tab2NotesTxtBox;
        private TextBox tab2StatusDescriptionTxtBox;
    }
}