using System.ComponentModel;

namespace CSPL
{
    public class Host
    {
        [Category("Device")]
        public string? Hostname { get; set; }
        [Category("Device")]
        public string? IPAddress { get; set; }
        [Category("Device")]
        public string? Manufacturer { get; set; }
        [Category("Device")]
        public string? Model { get; set; }
        [Category("Device")]
        public string? SystemFamily { get; set; }

        [Category("OS")]
        public string? Caption { get; set; }
        [Category("OS")]
        public string? Version { get; set; }
        [Category("OS")]
        public string? Build { get; set;}
        [Category("OS")]
        public string? InstallDate { get; set; }
        [Category("OS")]
        public string? LastBootUpTime { get; set; }
    }
}