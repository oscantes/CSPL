using Markdig.Helpers;
using System.Diagnostics;
using System.DirectoryServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CSPL
{
    internal class UserHandler
    {
        public static (bool isUSer, string message) isUser(string username)
        {
            if (PowerShellHandler.Command($"Get-ADUser -Filter \"sAMAccountName -eq '{username}'\"") != String.Empty)
            {
                return (true, "Böyle bir kullanıcı mevcut");
            }
            else if (username.Length <= 6 && username.All(Char.IsDigit))
            {
                return (true, "Sicil no girildi, kullanıcı koduna dönüştürülecek"); //no extra query here
            }
            else
            {
                return (false, "Böyle bir kullanıcı mevcut değil");
            }
        }

        //interface objects for UI: isUser()
        public static (bool gotuserinfo, string message, User user_obj) GetUserInfo(string username)
        {
            User _ = new();

            if (username.Length <= 6 && username.All(Char.IsDigit))
            {
                //sicil no > username çevrimi
                username = PowerShellHandler.Command($"(Get-ADUser -Filter \"initials -like '{username}*'\" -property *).samaccountname");
            }

            _.Username = username;

            _.SicilNo = PowerShellHandler.Command($"(get-aduser -identity {username} -properties *).Initials");

            _.DisplayName = PowerShellHandler.Command($"(get-aduser -identity {username} -properties *).DisplayName");
            _.Department = PowerShellHandler.Command($"(get-aduser -identity {username} -properties *).Department");
            _.Office = PowerShellHandler.Command($"(get-aduser -identity {username} -properties *).Office");
            _.Title = PowerShellHandler.Command($"(get-aduser -identity {username} -properties *).Title");

            _.PasswordLastSet = Convert.ToDateTime(PowerShellHandler.Command($"(get-aduser -identity {username} -properties *).PasswordLastSet"));

            _.PasswordExpire = _.PasswordLastSet.AddDays(100);

            _.PasswordExpiresIn = (_.PasswordExpire - DateTime.Now).Days;

            _.telephoneNumber = PowerShellHandler.Command($"(get-aduser -identity {username} -properties *).telephoneNumber");

            _.extensionAttribute5 = PowerShellHandler.Command($"(get-aduser -identity {username} -properties *).extensionAttribute5");

            string isBlocked = PowerShellHandler.Command($"(Get-ADUser -identity {username} -properties *).lockedout");
            if (isBlocked == "True") { _.isBlocked = true; } else { _.isBlocked = false; }

            return (true, "Kullanıcı bilgileri getirildi", _);
        }

        public static (bool gotuserinfo, string message, User user_obj) GetUserInfo(string username, string vpnquery)
        {
            User _ = new();

            string queryVPN = PowerShellHandler.Command($"Get-ADPrincipalGroupMembership {username} | Out-String");
            if (queryVPN.Contains("PYSSLVPNAccountBaseGRP")) { _.hasVPN = true; } else { _.hasVPN = false; }

            return (true, "Kullanıcı bilgileri getirildi", _);
        }

        public static string JGetUsername(string nameorphone)
        {
            if (char.IsDigit(nameorphone[0]))
            {
                return PowerShellHandler.Command($"(Get-ADUser -Filter \"extensionAttribute5 -like '*{nameorphone}'\" -property *).samaccountname\r\n");
            }
            else //char.IsLetter(nameorphone[0])
            {
                return PowerShellHandler.Command($"(Get-ADUser -Filter \"DisplayName -like '{nameorphone}*'\" -property *).samaccountname\r\n");
            }
        }

        public static Image GetUserPicture(string username)
        {
            //bug: needs code cleaning
            DirectoryEntry rootEntry = new DirectoryEntry("LDAP://ldaps.gen.halkbank.local");
            rootEntry.AuthenticationType = AuthenticationTypes.None; //needed?
            DirectorySearcher searcher = new DirectorySearcher(rootEntry);
            searcher.Filter = $"(&(objectClass=user)(objectCategory=person)(SAMAccountName=*{username}*))";
            Image? adphoto = null;
            foreach (SearchResult result in searcher.FindAll())
            {
                try
                {
                    byte[] temp2 = (byte[])result.Properties["thumbnailPhoto"][0]; //had to use explicit data type byte[]
                    adphoto = (Bitmap)((new ImageConverter()).ConvertFrom(temp2));
                    //File.WriteAllBytes($"z:\\{UsernameBoxTab1.Text}.jpg", temp2); //if wanted to save to file //will this work in userahndler.cs?
                }
                catch (Exception err)
                {
                    Debug.WriteLine(err.Message);
                }
            }
            return adphoto;
        }
    }
}
