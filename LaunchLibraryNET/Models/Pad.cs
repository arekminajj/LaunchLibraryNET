using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{
    public class Pad
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public object AgencyId { get; set; }
        public string Name { get; set; }
        public object InfoUrl { get; set; }
        public string WikiUrl { get; set; }
        public Uri MapUrl { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public PadLocation Location { get; set; }
        public Uri MapImage { get; set; }
        public long TotalLaunchCount { get; set; }
    }

    public class PadLocation
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
