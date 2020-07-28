using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{
    public class Locations
    {
        public long Count { get; set; }
        public object Next { get; set; }
        public object Previous { get; set; }
        public LocationsResult[] Results { get; set; }
    }

    public class LocationsResult
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
