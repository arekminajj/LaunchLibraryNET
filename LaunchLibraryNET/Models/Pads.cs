using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{
    public class Pads
    {
        public long Count { get; set; }
        public Uri Next { get; set; }
        public object Previous { get; set; }
        public PadsResult[] Results { get; set; }
    }

    public class PadsResult
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public long? AgencyId { get; set; }
        public string Name { get; set; }
        public Uri InfoUrl { get; set; }
        public string WikiUrl { get; set; }
        public string MapUrl { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public PadsLocation Location { get; set; }
        public Uri MapImage { get; set; }
        public long TotalLaunchCount { get; set; }
    }

    public class PadsLocation
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public Uri MapImage { get; set; }
        public long TotalLaunchCount { get; set; }
        public long TotalLandingCount { get; set; }
    }
}
