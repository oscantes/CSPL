namespace CSPL
{
    public class User
    {
        public string? Username { get; set; }
        public string? SicilNo { get; set; }
        public string? DisplayName { get; set; }
        public string? Department { get; set; }
        public string? Office { get; set; }
        public string? Title { get; set; }
        public DateTime PasswordLastSet { get; set; }
        public DateTime PasswordExpire { get; set; }
        public int PasswordExpiresIn { get; set; }
        public string? telephoneNumber { get; set; }
        public string? extensionAttribute5 { get; set; }
        public bool isBlocked { get; set; }
        public bool hasVPN { get; set; }

    }
}