namespace CheckStatus.Api.Entities
{
    public class SiteStatus
    {
        public int Id { get; set; }
        public string SiteName { get; set; }
        public string IpAddress { get; set; }
        public bool IsOnline { get; set; }

    }
}
