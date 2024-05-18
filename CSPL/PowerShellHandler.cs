using System.Diagnostics;
using System.Management.Automation;
using System.Text;

namespace CSPL
{
    public static class PowerShellHandler
    {
        private static PowerShell ps = PowerShell.Create();

        public static string Command(string script)
        {
            string errorMsg = string.Empty;
            PSDataCollection<PSObject> outputCollection = new();

            ps.AddScript(script);
            //make sure return values are outputted to the stream captured by c#
            ps.AddCommand("Out-String");
            ps.Streams.Error.DataAdded += (s, e) =>
            {
                errorMsg = ((PSDataCollection<ErrorRecord>)s)[e.Index].ToString();
            };

            IAsyncResult result = ps.BeginInvoke<PSObject, PSObject>(null, outputCollection);
            //wait for powershell command/script to finish executing
            ps.EndInvoke(result);

            StringBuilder sb = new();
            foreach (var outputItem in outputCollection)
            {
                sb.AppendLine(outputItem.BaseObject.ToString());
            }

            //Clears the commands we added to the powershell runspace so it's empty the next time we use it
            ps.Commands.Clear();

            if (!string.IsNullOrEmpty(errorMsg))
                //fix here
                //return errorMsg;
                Debug.WriteLine(errorMsg);

            return sb.ToString().Trim();
        }
    }
}