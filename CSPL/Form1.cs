using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
using System.Management.Automation;
using System.Net.NetworkInformation;
using System.Speech.Synthesis;
using System.Text;
using static System.Windows.Forms.LinkLabel;

namespace CSPL
{
    public partial class Form1 : Form
    {
        //statusbarnotifier() için gerekli
        bool isCancelled;
        bool isFormActive;

        public Form1()
        {
            InitializeComponent();

            //to have an empty properties view of Host class in GridHostInfo
            PropGridHost.SelectedObject = new Host();

            //Welcomes user
            label8.Text = $"Welcome {Environment.UserName}!" + Environment.NewLine + Environment.MachineName;
            if (HostHandler.IsPingable("pbtmepap01").pingable) //açýlýþta bekletmemesi için kurum aðýna eriþim kontrolü
            {
                runasuserPictureBox.Image = UserHandler.GetUserPicture(Environment.UserName);
            }

            //writes launch time to statusbar
            StatusLabel1.Text = $"{DateTime.Now.ToString(format: "G")}";
        }

        async Task StatusbarNotifier()
        {
            //starts loading animation
            StatusLabel1.Text = $"{DateTime.Now.ToString(format: "G")} - {"Ýþlem baþlatýldý, lütfen bekleyin"}";
            isCancelled = false;
            //þu an sadece griden baþlamayý destekliyor yani 240,240,240
            Color newcolor0 = Color.FromArgb(240, 240, 240);
            statusStrip1.BackColor = newcolor0;
            int r = statusStrip1.BackColor.R;
            int g = statusStrip1.BackColor.G;
            int b = statusStrip1.BackColor.B;
            int i = 1;
            for (; ; )
            {
                Color newcolor = Color.FromArgb(r, g, b);
                statusStrip1.BackColor = newcolor;
                //bug: if'teki statement saðlýklý deðil,  geliþtirilmeli
                if (b == 240 || b == 0)
                {
                    i *= -1;
                }
                b += i * 16;
                await Task.Delay(50);
                if (isCancelled)
                {
                    break;
                }
            }
        }

        async Task StatusbarNotifier(bool success, string? message)
        {
            isCancelled = true;
            //herhangi bir renkten yeþile veya kýrmýzýya gidebilen bir method
            //mevcut renk tespiti yapalým
            int r1 = statusStrip1.BackColor.R;
            int g1 = statusStrip1.BackColor.G;
            int b1 = statusStrip1.BackColor.B;

            //renklerin hedef renge ulaþma hedefleri
            bool rayarlandý = false;
            bool gayarlandý = false;
            bool bayarlandý = false;

            switch (success)
            {
                case true:
                    if (message == null)
                    { StatusLabel1.Text = $"{DateTime.Now.ToString(format: "G")} - {"Ýþlem baþarýyla tamamlandý"}"; }
                    else { StatusLabel1.Text = $"{DateTime.Now.ToString(format: "G")} - {message}"; };

                    //baþarýlý durumda hedef renk Color.LightGreen yani 144,238,144
                    int rdone = 144;
                    int gdone = 238;
                    int bdone = 144;
                    for (; ; )
                    {
                        if (r1 > rdone) { r1--; };
                        if (rdone > r1) { r1++; };
                        if (rdone == r1) { rayarlandý = true; };
                        if (g1 > gdone) { g1--; };
                        if (gdone > g1) { g1++; };
                        if (gdone == g1) { gayarlandý = true; };
                        if (b1 > bdone) { b1--; };
                        if (bdone > b1) { b1++; };
                        if (bdone == b1) { bayarlandý = true; };
                        if (rayarlandý == true && gayarlandý == true && bayarlandý == true) { break; }
                        Color newcolordone = Color.FromArgb(r1, g1, b1);
                        statusStrip1.BackColor = newcolordone;
                        await Task.Delay(1); //bug: 1ms'ten çok bekliyor, deðiþtirilmeli
                    }
                    break;

                case false:
                    if (message == null)
                    { StatusLabel1.Text = $"{DateTime.Now.ToString(format: "G")} - {"Ýþlem baþarýsýz"}"; }
                    else { StatusLabel1.Text = $"{DateTime.Now.ToString(format: "G")} - {message}"; };


                    //baþarýsýz durumda hedef Color.PaleVioletRed yani 219,112,147
                    int rerror = 219;
                    int gerror = 112;
                    int berror = 147;
                    for (; ; )
                    {
                        if (r1 > rerror) { r1--; };
                        if (rerror > r1) { r1++; };
                        if (rerror == r1) { rayarlandý = true; };
                        if (g1 > gerror) { g1--; };
                        if (gerror > g1) { g1++; };
                        if (gerror == g1) { gayarlandý = true; };
                        if (b1 > berror) { b1--; };
                        if (berror > b1) { b1++; };
                        if (berror == b1) { bayarlandý = true; };
                        if (rayarlandý == true && gayarlandý == true && bayarlandý == true) { break; }
                        Color newcolordone = Color.FromArgb(r1, g1, b1);
                        statusStrip1.BackColor = newcolordone;
                        await Task.Delay(5);
                    }
                    break;
            }

            //herhangi bir renkten tekrar default renge(gri hardcoded) dönüþ

            //renklerin hedef renge ulaþma hedefleri 
            rayarlandý = false;
            gayarlandý = false;
            bayarlandý = false;

            //hedef için default renk hedefi 240, 240, 240
            int rdef = 240;
            int gdef = 240;
            int bdef = 240;

            //window focus olana kadar bildirim rengini beklet, focus sonrasý tekrar beklet
            for (; ; )
            {
                if (isFormActive == true)
                {
                    await Task.Delay(1500);
                    break;
                }
                await Task.Delay(1); //Form1_Deactivate() sonrasý programýn donmamasýný saðlýyor, o kadar önemli ki..
            }

            //griye dönüþ mekanizmasý
            for (; ; )
            {
                if (r1 > rdef) { r1--; };
                if (rdef > r1) { r1++; };
                if (rdef == r1) { rayarlandý = true; };
                if (g1 > gdef) { g1--; };
                if (gdef > g1) { g1++; };
                if (gdef == g1) { gayarlandý = true; };
                if (b1 > bdef) { b1--; };
                if (bdef > b1) { b1++; };
                if (bdef == b1) { bayarlandý = true; };
                if (rayarlandý == true && gayarlandý == true && bayarlandý == true) { break; }
                Color newcolordone = Color.FromArgb(r1, g1, b1);
                statusStrip1.BackColor = newcolordone;
                await Task.Delay(5);
            }

            //log to file
            string logFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"CSPL_logs");
            string logFileName = $"log_{DateTime.Now.ToString(format: "dd.MM.yyyy")}.txt";
            string logFilePath = Path.Combine(logFolderPath, logFileName);
            if (!Directory.Exists(logFolderPath))
            {
                Directory.CreateDirectory(logFolderPath);
            };
            using (StreamWriter logger = new StreamWriter(logFilePath, append: true))
            {
                logger.WriteLine(StatusLabel1.Text);
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            isFormActive = true;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            isFormActive = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bug: fixed width value
            int defaultformheight = Height;

            if (tabControl1.SelectedTab.Text == "Kayýt Görüntüleyici")
            {
                Size = new Size(1321, defaultformheight);
            }
            else
            {
                Size = new Size(1000, defaultformheight);
            }
        }

        private void tab2listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tab2NotesTxtBox.Text = (string)tab2Notes.SelectedItem;
        }

        private void tab2listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            tab2StatusDescriptionTxtBox.Text = (string)tab2StatusDescription.SelectedItem;
        }

        private void ConnectDwBtn_Click(object sender, EventArgs e)
        {
            HostHandler.ConnectWithDW(txtbxHostnameTab1.Text);
        }

        private void txtbxHostnameTab1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                ConnectDwBtn_Click(sender, e);
            }
        }

        private void cmdBtn_Click(object sender, EventArgs e)
        {
            PowerShellHandler.Command(@$"psexec ""\\{txtbxHostnameTab1.Text}"" /accepteula -s -i cmd.exe /C ""start cmd""");
        }

        private void taskmgrBtn_Click(object sender, EventArgs e)
        {
            PowerShellHandler.Command(@$"psexec ""\\{txtbxHostnameTab1.Text}"" /accepteula -s -i cmd.exe /C ""start taskmgr""");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello {Environment.UserName}");
        }

        private void devmgmtBtn_Click(object sender, EventArgs e)
        {
            //PowerShellHandler harici bir yöntem
            ProcessStartInfo devmgmtpsexec = new();
            devmgmtpsexec.FileName = "psexec.exe";
            devmgmtpsexec.Arguments = @$"""\\{txtbxHostnameTab1.Text}"" /accepteula -s -i cmd.exe /C ""start devmgmt""";
            Process.Start(devmgmtpsexec);
        }

        private void BtnBrowseC_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", $"\\\\{txtbxHostnameTab1.Text}\\c$");
        }

        private void BtnBrowseZ_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", $"\\\\{txtbxHostnameTab1.Text}\\z$");
        }

        private void BtnOpenHostsFile_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", $"\\\\{txtbxHostnameTab1.Text}\\c$\\Windows\\System32\\drivers\\etc\\hosts");
        }

        private async void BtnGetPrograms_Click(object sender, EventArgs e)
        {
            _ = StatusbarNotifier();
            (bool reachable, string message) isr()
            {
                return HostHandler.IsReachable(txtbxHostnameTab1.Text);
            }
            var isrr = await Task.Run(isr);
            if (isrr.reachable)
            {
                (bool gothostname, string hostname, string message) gh()
                {
                    return HostHandler.GetHostname(txtbxHostnameTab1.Text);
                }
                var ghh = await Task.Run(gh);
                if (ghh.gothostname)
                {
                    txtbxHostnameTab1.Text = ghh.hostname;
                    (bool gotprograms, string message) ghi()
                    {
                        return HostHandler.GetInstalledPrograms(txtbxHostnameTab1.Text); //ip ile çalýþmýyor
                    }
                    var ghii = await Task.Run(ghi);

                    //log to file
                    string logFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"CSPL_logs");
                    string logFileName = $"programs_{txtbxHostnameTab1.Text}_{DateTime.Now.ToString(format: "dd_MM_yyyy_HH_mm_ss")}.txt";
                    string logFilePath = Path.Combine(logFolderPath, logFileName);
                    if (!Directory.Exists(logFolderPath))
                    {
                        Directory.CreateDirectory(logFolderPath);
                    };
                    using (StreamWriter logger = new StreamWriter(logFilePath, append: true))
                    {
                        logger.WriteLine(ghii.message);
                    }
                    Process.Start("explorer.exe", logFilePath);
                    _ = StatusbarNotifier(ghii.gotprograms, "Yüklü programlar getirildi");
                }
                else
                {
                    _ = StatusbarNotifier(ghh.gothostname, ghh.message);
                }
            }
            else
            {
                _ = StatusbarNotifier(isrr.reachable, isrr.message);
            }
        }

        private void UsernameBoxTab1_TextChanged(object sender, EventArgs e)
        {
            UsernameBoxTab2.Text = UsernameBoxTab1.Text;
            //listViewUser.Items.Clear();
        }

        private void UsernameBoxTab1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                BtnGetUserInfo_Click(sender, e);
            }
        }

        private void CreateRowBtn_Click(object sender, EventArgs e)
        {
            bool mandUsername = UsernameBoxTab2.Text != "";
            bool mandTemplate = tab2Templates.SelectedItem != null;
            bool mandNote = tab2NotesTxtBox.Text != "";
            bool mandStatus = tab2StatusDescriptionTxtBox.Text != "";

            if (mandUsername & mandTemplate & mandNote & mandStatus)
            {
                string IncNEWFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"UiPath\incident_NEW.txt");
                //dosyada son satýr boþ-dolu kontrolü streamreader while içinde son satýr kontrolü ile de yapýlabilirdi
                string readFile = File.ReadAllText(IncNEWFolderPath);
                string[] satýrlar = readFile.Split('\n');
                string sonsatýr = satýrlar[satýrlar.Length - 1];

                using (StreamWriter outputFile = new StreamWriter(IncNEWFolderPath, append: true))
                {
                    //string.Join() de kullanýlabilir
                    string entry_to_file = $"{UsernameBoxTab2.Text};{tab2Templates.SelectedItem};{tab2NotesTxtBox.Text};{tab2StatusDescriptionTxtBox.Text};{DateTime.Now.ToString(format: "dd.MM.yyyy")}";
                    if (sonsatýr == "")
                    {
                        outputFile.WriteLine(entry_to_file);
                    }
                    if (sonsatýr != "")
                    {
                        outputFile.WriteLine(Environment.NewLine + entry_to_file);
                    }
                }

                _ = StatusbarNotifier(true, $"{UsernameBoxTab2.Text} kullanýcýsý için {tab2Templates.SelectedItem} girdisi oluþturuldu");
                UsernameBoxTab2.Text = String.Empty;
                tab2NotesTxtBox.Text = String.Empty;
                tab2StatusDescriptionTxtBox.Text = String.Empty;
                tab2Templates.SelectedIndex = -1;
                tab2Notes.SelectedIndex = -1;
                tab2StatusDescription.SelectedIndex = -1;
            }
            else
            {
                _ = StatusbarNotifier(false, "Girdi oluþturulmasý için gerekli alanlarý kontrol edin");
            }
        }

        private void readRowsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                listViewINC.Items.Clear();
                // Open the text file using a streamreader(with using statement, why though?), read the stream as a string
                //StreamReader'ýn ilginç bir yapýsý var, bir kere akýyor ve while içinde deðeri deðiþiyor
                string IncFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $@"UiPath\{ReadRowsComboBox.Text}");
                using (var sr = new StreamReader(IncFolderPath))
                {
                    string line = String.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var props = line.Split(';');
                        listViewINC.Items.Add(new ListViewItem(props));
                    }
                    if (listViewINC.Items.Count == 0)
                    {
                        _ = StatusbarNotifier(false, "Kayýt mevcut deðil");
                    }
                    else
                    {
                        _ = StatusbarNotifier(true, "Kayýtlar getirildi");
                    }
                }
            }
            catch (IOException err)
            {
                Debug.WriteLine(err.Message);
            }
        }

        private void openRowsFileBtn_Click(object sender, EventArgs e)
        {
            string IncFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $@"UiPath\{ReadRowsComboBox.Text}");
            Process.Start("explorer.exe", $"{IncFolderPath}");
        }

        private void searchRowsBtn_Click(object sender, EventArgs e)
        {
            //aranan item en üstte görünene kadar listeyi scroll ediyor
            ListViewItem founditem = listViewINC.FindItemWithText(searchRowsBox.Text, true, 0, true);
            if (founditem != null)
            {
                listViewINC.TopItem = founditem;
            }
        }

        private void listViewINC_DoubleClick(object sender, EventArgs e)
        {
            if (listViewINC.SelectedItems.Count >= 0)
            {
                var indexitems = listViewINC.SelectedItems[0].SubItems;
                tab2Templates.SelectedItem = indexitems[1].Text; //bug: item selection is done by item text. if text not found, doesn't give an error, why?
                tab2NotesTxtBox.Text = indexitems[2].Text;
                tab2StatusDescriptionTxtBox.Text = indexitems[3].Text;
                tabControl1.SelectedTab = tabPage2;
            }
        }

        private void morningBtn_Click(object sender, EventArgs e)
        {
            string finesse_url = @"https://gtuccx01.gen.halkbank.local:8445/desktop/container/?locale=en_US";
            Process.Start("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe", finesse_url);
            Process.Start("C:\\Program Files (x86)\\Cisco Systems\\Cisco Jabber\\CiscoJabber.exe");
            Process.Start("C:\\Program Files\\Notepad++\\notepad++.exe");
            Process.Start("C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\OUTLOOK.EXE");
            Process.Start(@"C:\Program Files (x86)\Microsoft Office\root\Office16\lync.exe");
            Process.Start("Z:\\ProgramFiles\\ToolsForBTM\\ToolsForBTM.exe");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PowerShell restartPS = PowerShell.Create();
            restartPS.AddScript("Restart-Service -Name \"PulseSecureService\"");
            restartPS.Invoke();
        }

        private void txtbxHostnameTab1_TextChanged(object sender, EventArgs e)
        {
            UsernameBoxTab1.Text = String.Empty;
        }

        private async void txtbxHostnameTab1_DoubleClick(object sender, EventArgs e)
        {
            _ = StatusbarNotifier();
            (bool reachable, string message) isr()
            {
                return HostHandler.IsReachable(txtbxHostnameTab1.Text);
            }
            var isrr = await Task.Run(isr);
            if (isrr.reachable)
            {
                (bool gothostname, string hostname, string message) ghn()
                {
                    return HostHandler.GetHostname(txtbxHostnameTab1.Text);
                }
                var ghnn = await Task.Run(ghn);
                if (ghnn.gothostname)
                {
                    txtbxHostnameTab1.Text = ghnn.hostname;
                }
                _ = StatusbarNotifier(ghnn.gothostname, ghnn.message);
            }
            else
            {
                _ = StatusbarNotifier(isrr.reachable, isrr.message);
            }
        }

        private async void BtnGetUsername_Click(object sender, EventArgs e)
        {
            _ = StatusbarNotifier();
            (bool reachable, string message) isr()
            {
                return HostHandler.IsReachable(txtbxHostnameTab1.Text);
            }
            var isrr = await Task.Run(isr);
            if (isrr.reachable)
            {
                (bool gothostname, string hostname, string message) gh()
                {
                    return HostHandler.GetHostname(txtbxHostnameTab1.Text);
                }
                var ghh = await Task.Run(gh);
                if (ghh.gothostname)
                {
                    txtbxHostnameTab1.Text = ghh.hostname;
                    (bool gotusername, string username, string message) gu()
                    {
                        return HostHandler.GetUsername(txtbxHostnameTab1.Text);
                    }
                    var guu = await Task.Run(gu);
                    UsernameBoxTab1.Text = guu.username;
                    LblUsernameBoxTab1.Text = "Kaynak: Bilgisayar";
                    _ = StatusbarNotifier(guu.gotusername, guu.message);
                }
                else
                {
                    _ = StatusbarNotifier(ghh.gothostname, ghh.message);
                }
            }
            else
            {
                _ = StatusbarNotifier(isrr.reachable, isrr.message);
            }
        }

        private void BtnGetHostDW_Click(object sender, EventArgs e)
        {
            var ghd = HostHandler.GetHostfromDW();
            if (ghd.gothostname == true)
            {
                txtbxHostnameTab1.Text = ghd.hostname;
            }
            _ = StatusbarNotifier(ghd.gothostname, ghd.message);
        }

        private async void BtnGetHostInfo_Click(object sender, EventArgs e)
        {
            _ = StatusbarNotifier();
            (bool reachable, string message) isr()
            {
                return HostHandler.IsReachable(txtbxHostnameTab1.Text);
            }
            var isrr = await Task.Run(isr);
            if (isrr.reachable)
            {
                (bool gothostname, string hostname, string message) gh()
                {
                    return HostHandler.GetHostname(txtbxHostnameTab1.Text);
                }
                var ghh = await Task.Run(gh);
                if (ghh.gothostname)
                {
                    txtbxHostnameTab1.Text = ghh.hostname;
                    (bool gothostinfo, string message, Host host_obj) ghi()
                    {
                        return HostHandler.GetHostInfo(txtbxHostnameTab1.Text);
                    }
                    var ghii = await Task.Run(ghi);
                    PropGridHost.SelectedObject = ghii.host_obj;
                    _ = StatusbarNotifier(ghii.gothostinfo, ghii.message);
                }
                else
                {
                    _ = StatusbarNotifier(ghh.gothostname, ghh.message);
                }
            }
            else
            {
                _ = StatusbarNotifier(isrr.reachable, isrr.message);
            }
        }

        private async void BtnGetUserInfo_Click(object sender, EventArgs e)
        {
            _ = StatusbarNotifier();

            (bool isUser, string message) isu()
            {
                return UserHandler.isUser(UsernameBoxTab1.Text);
            }
            var isuu = await Task.Run(isu);
            if (isuu.isUser)
            {
                (bool gotuserinfo, string message, User user_obj) gui()
                {
                    return UserHandler.GetUserInfo(UsernameBoxTab1.Text);
                }
                var guii = await Task.Run(gui);
                User user_objj = guii.user_obj;
                listViewUser.Items.Clear();
                listViewUser.Items.Add(new ListViewItem(new[] { "Username", user_objj.Username }));
                listViewUser.Items.Add(new ListViewItem(new[] { "SicilNo", user_objj.SicilNo }));
                listViewUser.Items.Add(new ListViewItem(new[] { "DisplayName", user_objj.DisplayName }));
                listViewUser.Items.Add(new ListViewItem(new[] { "Department", user_objj.Department }));
                listViewUser.Items.Add(new ListViewItem(new[] { "Office", user_objj.Office }));
                listViewUser.Items.Add(new ListViewItem(new[] { "Title", user_objj.Title }));
                listViewUser.Items.Add(new ListViewItem(new[] { "PasswordLastSet", user_objj.PasswordLastSet.ToString() }));
                listViewUser.Items.Add(new ListViewItem(new[] { "PasswordExpire", user_objj.PasswordExpire.ToString() }));
                listViewUser.Items.Add(new ListViewItem(new[] { "PasswordExpiresIn", user_objj.PasswordExpiresIn.ToString() }));
                listViewUser.Items.Add(new ListViewItem(new[] { "Sabit No", user_objj.telephoneNumber }));
                listViewUser.Items.Add(new ListViewItem(new[] { "Cep No", user_objj.extensionAttribute5 }));
                listViewUser.Items.Add(new ListViewItem(new[] { "isBlocked", user_objj.isBlocked.ToString() }));
                listViewUser.Items.Add(new ListViewItem(new[] { "hasVPN", "Sonucu görmek için soldaki alana çift týklayýn" }));

                Image gup()
                {
                    return UserHandler.GetUserPicture(UsernameBoxTab1.Text);
                }
                var gupp = await Task.Run(gup);
                queryuserpictureBox.Image = gupp;

                _ = StatusbarNotifier(guii.gotuserinfo, guii.message);
            }
            else
            {
                _ = StatusbarNotifier(isuu.isUser, isuu.message);
            }
        }

        private async void listViewUser_DoubleClick(object sender, EventArgs e)
        {
            if (listViewUser.SelectedItems[0].Text == "hasVPN")
            {
                _ = StatusbarNotifier();

                (bool gotuserinfo, string message, User user_obj) gui()
                {
                    return UserHandler.GetUserInfo(UsernameBoxTab1.Text, "queryVPN");
                }
                var guii = await Task.Run(gui);

                User user_objj = guii.user_obj;
                //hasVPN satýrýný siler ve yeni satýr ekler
                listViewUser.Items.RemoveAt(listViewUser.FindItemWithText("hasVPN").Index);
                listViewUser.Items.Add(new ListViewItem(new[] { "hasVPN", user_objj.hasVPN.ToString() }));

                _ = StatusbarNotifier(guii.gotuserinfo, guii.message);
            }
            else if (listViewUser.SelectedItems[0].Text == "Sabit No")
            {
                Process.Start("explorer.exe", $"tel://{listViewUser.FindItemWithText("Sabit No").SubItems[1].Text}");
            }
            else if (listViewUser.SelectedItems[0].Text == "Cep No")
            {
                Process.Start("explorer.exe", $"tel://{listViewUser.FindItemWithText("Cep No").SubItems[1].Text}");
            }
        }

        private void TestBtn1_Click(object sender, EventArgs e)
        {

        }

        private async void TestBtn2_Click(object sender, EventArgs e)
        {



        }

        private async void TestBtn3_Click(object sender, EventArgs e)
        {
            //_ = StatusbarNotifier();
            //(string "etc") asdd() { return "asýl method"; }
            //var ghn = await Task.Run(asdd);
            //_ = StatusbarNotifier(false, "message");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnJStartSniff_Click(sender, e);
        }

        private void BtnJStopSniff_Click(object sender, EventArgs e)
        {
            stop_sniff = true;
            listViewJLogSniff.Items.Add(new ListViewItem(new[] { DateTime.Now.ToString(), "JLogSniff durduruldu" }));
        }

        private async void BtnGetUsrnameJbbr_Click(object sender, EventArgs e)
        {
            if (TxtBxJFullnameorP.Text != String.Empty)
            {
                UsernameBoxTab1.Text = "Kullanýcý kodu getiriliyor..";

                _ = StatusbarNotifier();
                string jgu()
                {
                    return UserHandler.JGetUsername(TxtBxJFullnameorP.Text);
                }
                UsernameBoxTab1.Text = await Task.Run(jgu);
                LblUsernameBoxTab1.Text = "Kaynak: Jabber";
                _ = StatusbarNotifier(true, "Kullanýcý kodu getirildi");
            }
        }

        private void TxtBxJFullnameorP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                BtnGetUsrnameJbbr_Click(sender, e);
            }
        }

        private void listViewJLogSniff_DoubleClick(object sender, EventArgs e)
        {
            if (listViewJLogSniff.SelectedItems.Count >= 0)
            {
                var indexitems = listViewJLogSniff.SelectedItems[0].SubItems[listViewJLogSniff.Columns.IndexOf(queryValue)].Text; //var adý deðiþ
                TxtBxJFullnameorP.Text = indexitems;
            }
        }

        private void Jlogfarkkontrolu(DateTime date, string path, string[] splits, List<string> users, string logfilesource)
        {
            if (date != File.GetLastWriteTime(path))
            {
                try
                {
                    using (var sr = new StreamReader(path))
                    {
                        string line = String.Empty;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.Contains("Remote-Party-ID: ") && !line.Contains("Bilgi Teknoloji Masasý") && !line.Contains("Bilgi ve Teknoloji Masasi") && !line.Contains("Call Manager")) //burasý iyi filtre edilmesi lazým
                            {
                                var afterRPID = line.Split("Remote-Party-ID: ")[1];
                                var prep_sipnumber = afterRPID.Split("sip:")[1];
                                var sipnumber = prep_sipnumber.Substring(0, prep_sipnumber.IndexOf('@'));
                                var queryValue = sipnumber; //will be used for queries

                                var fullname = String.Empty;
                                char afterRPIDchar = afterRPID[0]; // '"' yada '<' char'ýnýn olduðu index
                                if (afterRPIDchar == '"') //fullname bilgisi var demektir
                                {
                                    splits = line.Split('"');
                                    fullname = splits[1];
                                    queryValue = fullname;
                                }

                                if (!users.Contains(queryValue)) //bug: contains deðil de son index'le eþleþme kontrolü yaptýrýlabilir?, eþleþmiyorsa true
                                {
                                    users.Add(queryValue);
                                    TxtBxJFullnameorP.Text = queryValue;
                                    LblJLogTime.Text = "Log saati: " + DateTime.Now.ToString(format: "HH:mm");
                                    listViewJLogSniff.Items.Add(new ListViewItem(new[] { DateTime.Now.ToString(), logfilesource, fullname, sipnumber, queryValue }));
                                }
                            }
                        }
                    }
                }
                catch (IOException err)
                {
                    Debug.WriteLine(err.Message);
                }
            }
        }

        bool stop_sniff;
        private async void BtnJStartSniff_Click(object sender, EventArgs e)
        {
            stop_sniff = false;
            listViewJLogSniff.Items.Add(new ListViewItem(new[] { DateTime.Now.ToString(), "JLogSniff baþlatýldý" }));
            string[] splits = Array.Empty<string>();
            List<string> users = new();
            string jabber_log_file_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Cisco\\Unified Communications\\Jabber\\CSF\\Logs\\jabber.log");
            string jabber_log_file_path1 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Cisco\\Unified Communications\\Jabber\\CSF\\Logs\\jabber.log.1");
            var a = File.GetLastWriteTime(jabber_log_file_path);
            var b = File.GetLastWriteTime(jabber_log_file_path1);
            for (; ; )
            {
                while (a == File.GetLastWriteTime(jabber_log_file_path) && b == File.GetLastWriteTime(jabber_log_file_path1))
                {
                    await Task.Delay(1000);
                }

                //jabber.log genelde daha güncel veriye sahip olduðundan son çaðýrýlýr
                Jlogfarkkontrolu(b, jabber_log_file_path1, splits, users, "jabber.log.1");
                Jlogfarkkontrolu(a, jabber_log_file_path, splits, users, "jabber.log");

                a = File.GetLastWriteTime(jabber_log_file_path);
                b = File.GetLastWriteTime(jabber_log_file_path1);
                if (stop_sniff == true)
                {
                    break;
                }
            }
        }

        private void btnGünlük_tab5_Click(object sender, EventArgs e)
        {
            filedirtxt_tab5.Text = @"\\an" + filedirtxt_tab5.Text + @"\gunluk";
            btnGo_tab5_Click(sender, e);
        }

        private void btnBrowseUp_tab5_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(filedirtxt_tab5.Text);
            try
            {
                filedirtxt_tab5.Text = dir.Parent.FullName;
            }
            catch (NullReferenceException err)
            {
                Debug.WriteLine(err.Message);
            }
            btnGo_tab5_Click(sender, e);
        }

        private void filedirtxt_tab5_TextChanged(object sender, EventArgs e)
        {
            filesizetxt_tab5.Text = String.Empty;
        }

        private void filedirtxt_tab5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnGo_tab5_Click(sender, e);
            }
        }

        private void btnGo_tab5_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(filedirtxt_tab5.Text);
            var subdir = dir.GetDirectories();
            listViewFolders_tab5.Items.Clear();
            foreach (var item in subdir)
            {
                listViewFolders_tab5.Items.Add(new ListViewItem(item.FullName));
            }
        }

        private void btnBrowse_tab5_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", $"{filedirtxt_tab5.Text}");
        }

        private async void btnGetSize_tab5_Click(object sender, EventArgs e)
        {
            _ = StatusbarNotifier();

            string sizecalc()
            {
                //works fast but needs computername, edit rest of the command
                //var a = PowerShellHandler.Command(@$" invoke-command -ComputerName an384 -ScriptBlock{{ (Get-ChildItem 'd:\gunluk\57027' -recurse | Measure-Object -Property Length -s).sum }} ");
                //var b = Convert.ToDecimal(a);
                //filesizetxt_tab5.Text = Math.Round(((b / 1024) / 1024), 2).ToString() + " MB";

                //works slow but stable
                decimal size = 0;
                DirectoryInfo dir = new DirectoryInfo(filedirtxt_tab5.Text);
                foreach (FileInfo fi in dir.GetFiles("*", SearchOption.AllDirectories))
                {
                    size += fi.Length;
                }
                return (Math.Round(((size / 1024) / 1024), 2).ToString() + " MB");
            }
            var calcc = await Task.Run(sizecalc); //bu komutla birlikte sizecalc'ý farklý bir thread'de çalýþtýrmýþ oluyorum, sizecalc'tan listview'a eriþemem..
            filesizetxt_tab5.Text = calcc;

            _ = StatusbarNotifier(true, "Klasör boyutu getirildi");
        }

        private void listViewFolders_tab5_DoubleClick(object sender, EventArgs e)
        {
            filedirtxt_tab5.Text = listViewFolders_tab5.SelectedItems[0].Text;
            btnGo_tab5_Click(sender, e);
        }

        private void fileCopyBtn_tab5_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", $"/K robocopy \"{filedirtxt_tab5.Text}\"  \"{filedesttxt_tab5.Text}\" /e /mt:10 /r:0 /w:0 "); // K carries out the command and keeps window open
        }

        private void folderControlBtn_tab5_Click(object sender, EventArgs e)
        {
            filedesttxt_tab5.BackColor = SystemColors.Window;
            if (Directory.Exists(filedesttxt_tab5.Text))
            {
                filedesttxt_tab5.BackColor = Color.Red;
            }
            else
            {
                filedesttxt_tab5.BackColor = Color.Green;
            }
        }
    }
}