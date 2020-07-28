using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{
    public class UpcomingLaunches
    {
        public long Count { get; set; }
        public Uri Next { get; set; }
        public object Previous { get; set; }
        public UpcomingLaunchesResult[] Results { get; set; }
    }

    public class UpcomingLaunchesResult
    {
        public Guid Id { get; set; }
        public Uri Url { get; set; }
        public long? LaunchLibraryId { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public UpcomingLaunchesStatus Status { get; set; }
        public DateTimeOffset Net { get; set; }
        public DateTimeOffset WindowEnd { get; set; }
        public DateTimeOffset WindowStart { get; set; }
        public bool Inhold { get; set; }
        public bool Tbdtime { get; set; }
        public bool Tbddate { get; set; }
        public long? Probability { get; set; }
        public string Holdreason { get; set; }
        public string Failreason { get; set; }
        public object Hashtag { get; set; }
        public UpcomingLaunchesLaunchServiceProvider LaunchServiceProvider { get; set; }
        public UpcomingLaunchesRocket Rocket { get; set; }
        public UpcomingLaunchesMission Mission { get; set; }
        public UpcomingLaunchesPad Pad { get; set; }
        public bool WebcastLive { get; set; }
        public Uri Image { get; set; }
        public Uri Infographic { get; set; }
    }

    public class UpcomingLaunchesLaunchServiceProvider
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class UpcomingLaunchesMission
    {
        public long Id { get; set; }
        public long? LaunchLibraryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public object LaunchDesignator { get; set; }
        public string Type { get; set; }
        public UpcomingLaunchesOrbit Orbit { get; set; }
    }

    public class UpcomingLaunchesOrbit
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Abbrev { get; set; }
    }

    public class UpcomingLaunchesPad
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
        public UpcomingLaunchesLocation Location { get; set; }
        public Uri MapImage { get; set; }
        public long TotalLaunchCount { get; set; }
    }

    public class UpcomingLaunchesLocation
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public Uri MapImage { get; set; }
        public long TotalLaunchCount { get; set; }
        public long TotalLandingCount { get; set; }
    }

    public class UpcomingLaunchesRocket
    {
        public long Id { get; set; }
        public UpcomingLaunchesConfiguration Configuration { get; set; }
    }

    public class UpcomingLaunchesConfiguration
    {
        public long Id { get; set; }
        public long? LaunchLibraryId { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string FullName { get; set; }
        public string Variant { get; set; }
    }

    public class UpcomingLaunchesStatus
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
