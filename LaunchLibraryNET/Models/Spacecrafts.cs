using System;

namespace LaunchLibraryNET.Models
{
    public class Spacecrafts
    {
        public long Count { get; set; }
        public Uri Next { get; set; }
        public object Previous { get; set; }
        public SpacecraftsResult[] Results { get; set; }
    }

    public class SpacecraftsResult
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public SpacecraftsStatus Status { get; set; }
        public string Description { get; set; }
        public SpacecraftsSpacecraftConfig SpacecraftConfig { get; set; }
    }

    public class SpacecraftsSpacecraftConfig
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public SpacecraftsStatus Type { get; set; }
        public SpacecraftsAgency Agency { get; set; }
        public bool InUse { get; set; }
        public Uri ImageUrl { get; set; }
    }

    public class SpacecraftsAgency
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class SpacecraftsStatus
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
