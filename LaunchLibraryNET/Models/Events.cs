using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{
    public class Events
    {
        public long Count { get; set; }
        public Uri Next { get; set; }
        public object Previous { get; set; }
        public EventsResult[] Results { get; set; }
    }

    public class EventsResult
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public EventsType Type { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public Uri NewsUrl { get; set; }
        public Uri VideoUrl { get; set; }
        public Uri FeatureImage { get; set; }
        public DateTimeOffset? Date { get; set; }
        public EventsLaunch[] Launches { get; set; }
        public EventsExpedition[] Expeditions { get; set; }
        public EventsSpacestation[] Spacestations { get; set; }
    }

    public class EventsExpedition
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset? End { get; set; }
        public EventsSpacestation Spacestation { get; set; }
    }

    public class EventsSpacestation
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public EventsType Status { get; set; }
        public string Orbit { get; set; }
        public Uri ImageUrl { get; set; }
        public DateTimeOffset? Founded { get; set; }
        public string Description { get; set; }
    }

    public class EventsType
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class EventsLaunch
    {
        public Guid Id { get; set; }
        public Uri Url { get; set; }
        public long? LaunchLibraryId { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public EventsType Status { get; set; }
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
        public EventsLaunchServiceProvider LaunchServiceProvider { get; set; }
        public EventsRocket Rocket { get; set; }
        public EventsMission Mission { get; set; }
        public EventsPad Pad { get; set; }
        public bool WebcastLive { get; set; }
        public Uri Image { get; set; }
        public Uri Infographic { get; set; }
    }

    public class EventsLaunchServiceProvider
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class EventsMission
    {
        public long Id { get; set; }
        public long? LaunchLibraryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public object LaunchDesignator { get; set; }
        public string Type { get; set; }
        public EventsOrbit Orbit { get; set; }
    }

    public class EventsOrbit
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Abbrev { get; set; }
    }

    public class EventsPad
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
        public EventsLocation Location { get; set; }
        public Uri MapImage { get; set; }
        public long TotalLaunchCount { get; set; }
    }

    public class EventsLocation
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public Uri MapImage { get; set; }
        public long TotalLaunchCount { get; set; }
        public long TotalLandingCount { get; set; }
    }

    public class EventsRocket
    {
        public long Id { get; set; }
        public EventsConfiguration Configuration { get; set; }
    }

    public class EventsConfiguration
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
