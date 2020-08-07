using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{
    public class Launchers
    {
        public long Count { get; set; }
        public object Next { get; set; }
        public object Previous { get; set; }
        public LaunchersResult[] Results { get; set; }
    }

    public class LaunchersResult
    {
        public int Id { get; set; }
        public Uri Url { get; set; }
        public bool FlightProven { get; set; }
        public string serial_number { get; set; }
        public string Status { get; set; }
        public string Details { get; set; }
        public LaunchersLauncherConfig LauncherConfig { get; set; }
        public Uri ImageUrl { get; set; }
        public long Flights { get; set; }
        public DateTimeOffset? LastLaunchDate { get; set; }
        public DateTimeOffset? FirstLaunchDate { get; set; }
    }

    public class LaunchersLauncherConfig
    {
        public long Id { get; set; }
        public long? LaunchLibraryId { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string FullName { get; set; }
        public string Variant { get; set; }
    }
}
