using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Serialization;
using System.Management.Automation;


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

        }

        private void tab2listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tab2richTextBox2.Text = (string)tab2listBox2.SelectedItem;
        }

        private void tab2listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            tab2richTextBox3.Text = (string)tab2listBox3.SelectedItem;
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

        private void tab2button1_Click(object sender, EventArgs e)
        {

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(Environment.GetFolderPath(0), "incident_new.txt"), append: true)) //(0) for desktop; true: append
            {
                //tarih damgasý þimdilik mevcutta(excel)de oluþturulan formatta eklendi
                //string.Join() de kullanýlabilir
                string entry_to_file = $"{tab2usernamebox.Text};{tab2listBox1.SelectedItem};{tab2richTextBox2.Text};{tab2richTextBox3.Text};{DateTime.Now.ToString(format: "G")}";
                outputFile.WriteLine(entry_to_file);
                label9.Text = $"Son kayýt: {entry_to_file}";
                tab2usernamebox.Text = String.Empty;
                tab2richTextBox2.Text = String.Empty;
                tab2richTextBox3.Text = String.Empty;
                tab2listBox1.SelectedIndex = -1;
                tab2listBox2.SelectedIndex = -1;
                tab2listBox3.SelectedIndex = -1;
                //var t = Task.Run(async delegate
                //{
                //    await Task.Delay(3000);
                //    label9.Text = String.Empty;
                //});
            }
        }

        private void entryviewtabbtn1_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the text file using a streamreader(with using statement, why though?), read the stream as a string
                //StreamReader'ýn ilginç bir yapýsý var, bir kere akýyor ve while içinde deðeri deðiþiyor
                using (var sr = new StreamReader(Path.Combine(Environment.GetFolderPath(0), "incident_new.txt")))
                {
                    listBox2.Items.Clear();
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        listBox2.Items.Add(line);
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

        private void button6_Click(object sender, EventArgs e)
        {
            //starting bunch of programs

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
            //powershell komutu ile denenecek

            //AddCommand çalýþmýyor, belki console'da çalýþýyordur
            //AddParameter da etki etmedi nedense
            PowerShell restartPS = PowerShell.Create();
            restartPS.AddScript("Restart-Service -Name \"PulseSecureService\"");
            restartPS.Invoke();
        }
    }
}