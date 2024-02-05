namespace Steam.Models.SteamCommunity
{
    public class CheckAppOwnershipModel
    {
        public bool OwnsApp { get; set; }
        public bool Permanent { get; set; }
        public string Timestamp { get; set; }
        public ulong OwnerSteamId { get; set; }
        public bool SiteLicense { get; set; }
    }
}
