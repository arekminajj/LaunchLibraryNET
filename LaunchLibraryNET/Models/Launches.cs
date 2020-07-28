using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{
    public class Launches
    {
        public long Count { get; set; }
        public Uri Next { get; set; }
        public object Previous { get; set; }
        public LaunchesResult[] Results { get; set; }
    }

    public class LaunchesResult
    {
        public Guid Id { get; set; }
        public Uri Url { get; set; }
        public long? LaunchLibraryId { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public LaunchesStatus Status { get; set; }
        public DateTimeOffset Net { get; set; }
        public DateTimeOffset WindowEnd { get; set; }
        public DateTimeOffset WindowStart { get; set; }
        public bool Inhold { get; set; }
        public bool Tbdtime { get; set; }
        public bool Tbddate { get; set; }
        public long? Probability { get; set; }
        public string Holdreason { get; set; }
        public string Failreason { get; set; }
        public string Hashtag { get; set; }
        public LaunchesLaunchServiceProvider LaunchServiceProvider { get; set; }
        public LaunchesRocket Rocket { get; set; }
        public LaunchesMission Mission { get; set; }
        public LaunchesPad Pad { get; set; }
        public bool WebcastLive { get; set; }
        public Uri Image { get; set; }
        public object Infographic { get; set; }
    }

    public class LaunchesLaunchServiceProvider
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class LaunchesMission
    {
        public long Id { get; set; }
        public long? LaunchLibraryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public object LaunchDesignator { get; set; }
        public string Type { get; set; }
        public LaunchesOrbit Orbit { get; set; }
    }

    public class LaunchesOrbit
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Abbrev { get; set; }
    }

    public class LaunchesPad
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public long? AgencyId { get; set; }
        public string Name { get; set; }
        public object InfoUrl { get; set; }
        public string WikiUrl { get; set; }
        public Uri MapUrl { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public LaunchesLocation Location { get; set; }
        public Uri MapImage { get; set; }
        public long TotalLaunchCount { get; set; }
    }

    public class LaunchesLocation
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public Uri MapImage { get; set; }
        public long TotalLaunchCount { get; set; }
        public long TotalLandingCount { get; set; }
    }

    public class LaunchesRocket
    {
        public long Id { get; set; }
        public LaunchesConfiguration Configuration { get; set; }
    }

    public class LaunchesConfiguration
    {
        public long Id { get; set; }
        public long? LaunchLibraryId { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string FullName { get; set; }
        public string Variant { get; set; }
    }

    public class LaunchesStatus
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
