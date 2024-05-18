using Microsoft.Management.Infrastructure;
using System.Diagnostics;

namespace CSPL
{
    public partial class MI
    {
        static void PrintCimInstance(CimInstance cimInstance)
        {
            Debug.WriteLine("{0} properties", cimInstance.CimSystemProperties.ClassName);

            Debug.WriteLine(String.Format("{0,-5}{1,-30}{2,-15}{3,-10}",
                                            "Key?", "Property", "Type", "Value"));

            foreach (var enumeratedProperty in cimInstance.CimInstanceProperties)
            {
                bool isKey = ((enumeratedProperty.Flags & CimFlags.Key) == CimFlags.Key);

                if (enumeratedProperty.Value != null)
                {
                    Debug.WriteLine(
                        "{0,-5}{1,-30}{2,-15}{3,-10}",
                        isKey == true ? "Y" : string.Empty,
                        enumeratedProperty.Name,
                        enumeratedProperty.CimType,
                        enumeratedProperty.Value);
                }
            }
        }

        public static void QueryInstance(string query)
        {
            try
            {
                CimSession cimSession = CimSession.Create("localhost");

                IEnumerable<CimInstance> queryInstances =
                  cimSession.QueryInstances(@"root\cimv2", "WQL", query);
                foreach (CimInstance cimInstance in queryInstances)
                {
                    //Use the current instance. This example prints the instance. 
                    PrintCimInstance(cimInstance);
                }
            }
            catch (CimException ex)
            {
                // Handle the exception as appropriate.
                // This example prints the message.
                Debug.WriteLine(ex.Message);
            }
        }
    }

}
