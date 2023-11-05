using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Serialization;
using System.Management.Automation;
using System.ServiceModel.Syndication;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CSPL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Welcomes user
            label8.Text = $"Welcome {Environment.UserName}!\r\n" +
                $"{Environment.MachineName}\r\n" +
                $"Processor Count: {Environment.ProcessorCount}\r\n";

            //writes launch time to statusbar
            StatusLabel1.Text = $"{DateTime.Now.ToString(format: "G")}";
        }

        private void tab2listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tab2NotesTxtBox.Text = (string)tab2Notes.SelectedItem;
        }

        private void tab2listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            tab2StatusDescriptionTxtBox.Text = (string)tab2StatusDescription.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo cmdwindow = new("cmd.exe");
            Process.Start(cmdwindow);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo taskmgrwindow = new("taskmgr.exe");
            Process.Start(taskmgrwindow);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PowerShell openDvmgt = PowerShell.Create();
            openDvmgt.AddScript(@"psexec ""\\localhost"" /accepteula -s -i $sessionid cmd.exe /C ""start devmgmt""");
            openDvmgt.Invoke();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello {Environment.UserName}");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            tab2usernamebox.Text = tab1username.Text;
        }

        private void CreateRowBtn_Click(object sender, EventArgs e)
        {
            bool mandUsername = tab2usernamebox.Text != "";
            bool mandTemplate = tab2Templates.SelectedItem != null;
            bool mandNote = tab2NotesTxtBox.Text != "";
            bool mandStatus = tab2StatusDescriptionTxtBox.Text != "";


            if (mandUsername & mandTemplate & mandNote & mandStatus)
            {
                string IncNEWFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"UiPath\incident_NEW.txt");
                using (StreamWriter outputFile = new StreamWriter(IncNEWFolderPath, append: true)) //(0) for desktop; true: append
                {
                    //string.Join() de kullanýlabilir
                    string entry_to_file = $"{tab2usernamebox.Text};{tab2Templates.SelectedItem};{tab2NotesTxtBox.Text};{tab2StatusDescriptionTxtBox.Text};{DateTime.Now.ToString(format: "dd.MM.yyyy")}";
                    outputFile.WriteLine(entry_to_file);

                    StatusbarNotifier(true, $"{tab2usernamebox.Text} kullanýcýsý için {tab2Templates.SelectedItem} girdisi oluþturuldu");
                    tab2usernamebox.Text = String.Empty;
                    tab2NotesTxtBox.Text = String.Empty;
                    tab2StatusDescriptionTxtBox.Text = String.Empty;
                    tab2Templates.SelectedIndex = -1;
                    tab2Notes.SelectedIndex = -1;
                    tab2StatusDescription.SelectedIndex = -1;
                }
            }
            else
            {
                StatusbarNotifier(false, "Girdi oluþturulmasý için gerekli alanlarý kontrol edin");
            }

        }

        private void readRowsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the text file using a streamreader(with using statement, why though?), read the stream as a string
                //StreamReader'ýn ilginç bir yapýsý var, bir kere akýyor ve while içinde deðeri deðiþiyor
                string IncNEWFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"UiPath\incident_NEW.txt");
                using (var sr = new StreamReader(IncNEWFolderPath))
                {
                    listBox2.Items.Clear();
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        listBox2.Items.Add(line);
                    }
                    if (listBox2.Items.Count == 0)
                    {
                        StatusbarNotifier(true, "Kayýt mevcut deðil");
                    }
                    else
                    {
                        StatusbarNotifier(true, "Kayýtlar getirildi");

                    }
                }
                //selects last item(in order to scroll there) then unselects it
                listBox2.SelectedIndex = listBox2.Items.Count - 1;
                listBox2.SelectedIndex = -1;
            }
            catch (IOException err)
            {
                Debug.WriteLine(err.Message);
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
            //AddCommand çalýþmýyor, belki console'da çalýþýyordur
            //AddParameter da etki etmedi nedense
            PowerShell restartPS = PowerShell.Create();
            restartPS.AddScript("Restart-Service -Name \"PulseSecureService\"");
            restartPS.Invoke();
        }

        //birbirine baðlý bu iki methodun tek parça olaný vardýr kesin
        void StatusbarNotifier(bool success)
        {
            if (success)
            {
                StatusbarNotifier(success, "Ýþlem baþarýyla gerçekleþtirildi");
            }
            else
            {
                StatusbarNotifier(success, "Ýþlem gerçekleþtirilemedi");
            }
        }
        async void StatusbarNotifier(bool success, string message)
        {
            if (success)
            {
                StatusLabel1.Text = $"{DateTime.Now.ToString(format: "G")} - {message}";
                statusStrip1.BackColor = Color.LightGreen;
            }
            else
            {
                StatusLabel1.Text = $"{DateTime.Now.ToString(format: "G")} - {message}";
                statusStrip1.BackColor = Color.PaleVioletRed;
            }
            await Task.Delay(3000);
            statusStrip1.BackColor = SystemColors.Control;
        }
    }
}