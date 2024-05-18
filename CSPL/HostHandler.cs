using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CSPL
{
    internal class HostHandler
    {
        public static void ConnectWithDW(string ip)
        {
            ProcessStartInfo dw = new();
            dw.FileName = @"C:\Program Files (x86)\SolarWinds\DameWare Remote Support\DWRCC.exe";
            dw.Arguments = $" -c: -h: -m:{ip} -a:1 -x ";
            Process.Start(dw);
        }

        public static (bool gothostname, string hostname, string message) GetHostfromDW()
        {
            List<string> dw_windows = new List<string>();
            foreach (var item in Process.GetProcessesByName("DWRCC"))
            {
                dw_windows.Add(item.MainWindowTitle);
            }
            if (dw_windows.Count > 0)
            {
                string[] dw_windows_names = dw_windows[0].Split(' '); //bug: gets only one window name
                return (true, dw_windows_names[0], "Bilgisayar adı elde edildi");
                //"disconnected" dönme ihtimaline karşı kontrol ekle
            }
            else
            {
                return (false, "None", "Bilgisayar adı elde edilemedi, Dameware MRC kapalı");
            }
        }

        public static (bool pingable, string message) IsPingable(string ip) //used only in IsReachable()
        {
            Ping p1 = new();
            try
            {
                var PR = p1.Send(ip).Status.ToString();
                if (PR == "Success")
                {
                    return (true, "Bilgisayar açık");
                }
                else
                {
                    return (false, "Bilgisayar kapalı");
                }
            }
            catch (PingException)
            {
                return (false, "Böyle bir bilgisayar yok");
                throw;
            }
        }

        public static (bool reachable, string message) IsReachable(string ip)
        {
            var isP = IsPingable(ip);
            if (isP.pingable)
            {
                if (Directory.Exists(@$"\\{ip}\c$"))
                {
                    return (true, "Bilgisayar açık ve erişilebilir");
                }
                else
                {
                    return (false, "Bilgisayar açık fakat erişilemez durumda");
                }
            }
            else
            {
                return (isP.pingable, isP.message);
            }
        }

        //isPingable durumda da username çekilemez mi? duruma göre isReachable'ı değiş
        public static (bool gothostname, string hostname, string message) GetHostname(string ip)
        {
            string hostname;
            if (char.IsDigit(ip[0]))
            {
                //IP entered, will get hostname from IP
                if (ip.StartsWith("10."))
                {
                    //IP starting with 10 entered, getting hostname from IP
                    hostname = (PowerShellHandler.Command(@$"(([System.Net.DNS]::GetHostEntry('{ip}')).hostname)")).Split(".")[0];
                    return (true, hostname, "Bilgisayar adı getirildi");
                }
                else
                {
                    //IP not starting with 10 entered, getting hostname from IP
                    ProcessStartInfo psi = new();
                    psi.FileName = @$"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
                    psi.RedirectStandardOutput = true;
                    psi.RedirectStandardInput = true;
                    psi.RedirectStandardError = true;
                    psi.CreateNoWindow = true; //obsolete
                    var proc = Process.Start(psi);
                    proc.StandardInput.WriteLine(@$"(get-wmiobject win32_computersystem -computername {ip}).name");
                    proc.StandardInput.WriteLine("exit");
                    string errors = proc.StandardError.ReadToEnd();
                    //some string work to get hostname
                    string s = proc.StandardOutput.ReadToEnd();
                    string[] ss = s.Trim().Split(Environment.NewLine);
                    hostname = ss[ss.Length - 2];
                    if (errors == String.Empty)
                    {
                        return (true, hostname, "Bilgisayar adı getirildi");
                    }
                    else
                    {
                        hostname = ip;
                        Debug.WriteLine("OC, There are errors" + Environment.NewLine + errors);
                        return (false, hostname, "OC, There are errors, debug to find out");
                    }
                }
            }
            else
            {
                hostname = ip;
                //hostname already entered, returning input
                return (true, hostname, "Bilgisayar adı mevcut");
            }
        }

        //isPingable durumda da username çekilemez mi? duruma göre isReachable'ı değiş
        public static bool GetVPN(string username) //bug: bu neden hosthandler'da? hmm zaten daha düzgün çalışmıyor bu, deneme yapıyordum sanırım
        {
            //IP not starting with 10 entered, getting hostname from IP
            ProcessStartInfo psi = new();
            psi.FileName = @$"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardInput = true;
            psi.RedirectStandardError = true;
            psi.CreateNoWindow = true; //obsolete
            var proc = Process.Start(psi);
            proc.StandardInput.WriteLine(@$"(net user {username} /domain");
            proc.StandardInput.WriteLine("exit");
            //some string work to get hostname
            string s = string.Empty;
            while (proc.StandardOutput.Peek() > -1)
            {
                s = proc.StandardOutput.ReadToEnd();
            }
            bool hasvpn = s.Contains("PYSSLVPNAccountBaseGR");
            return hasvpn;
        }

        //interface objects for UI: isReachable() and gethostname()
        public static (bool gotusername, string username, string message) GetUsername(string hostname)
        {
            string username;
            string username_ps = PowerShellHandler.Command($"(Get-CIMInstance Win32_computerSystem -Computername {hostname}).Username");
            username = username_ps.Substring(username_ps.IndexOf(@"\") + 1);
            if (username != String.Empty)
            {
                return (true, username, "Kullanıcı kodu getirildi: " + username);
            }
            else
            {
                return (false, "N/A", "Oturumu açık kullanıcı yok");
            }
        }

        //interface objects for UI: isreachable() and gethostname()
        public static (bool gothostinfo, string message, Host host_obj) GetHostInfo(string hostname)
        {
            Host h = new();
            h.Hostname = hostname;
            Ping p1 = new(); h.IPAddress = p1.Send(hostname).Address.ToString();
            h.Manufacturer = PowerShellHandler.Command($"(Get-CIMInstance Win32_computerSystem -Computername {hostname}).Manufacturer");
            h.Model = PowerShellHandler.Command($"(Get-CIMInstance Win32_computerSystem -Computername {hostname}).Model");
            h.SystemFamily = PowerShellHandler.Command($"(Get-CIMInstance Win32_computerSystem -Computername {hostname}).SystemFamily");
            h.Caption = PowerShellHandler.Command($"(Get-CIMInstance Win32_OperatingSystem -Computername {hostname}).Caption");
            h.Build = PowerShellHandler.Command($"(Get-CIMInstance Win32_OperatingSystem -Computername {hostname}).BuildNumber");
            if (h.Build == "17763") { h.Version = "1809"; } else if (h.Build == "19044") { h.Version = "21H2"; }
            h.InstallDate = PowerShellHandler.Command($"(Get-CIMInstance Win32_OperatingSystem -Computername {hostname}).InstallDate");
            h.LastBootUpTime = PowerShellHandler.Command($"(Get-CIMInstance Win32_OperatingSystem -Computername {hostname}).LastBootUpTime");
            return (true, "Host bilgileri getirildi", h);
        }

        //interface objects for UI: isreachable() and gethostname()
        public static (bool gotprograms, string message) GetInstalledPrograms(string hostname)
        {
            string installed_programs = PowerShellHandler.Command($"invoke-command -ComputerName {hostname} -ScriptBlock{{ get-itemproperty 'HKLM:\\Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\*', 'HKLM:\\Software\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\*' | sort-object -property DisplayName | format-table -property displayname, displayversion, installdate | Out-String | ForEach-Object {{ $_.Trim() }} }}");
            return (true, installed_programs);
        }
    }
}