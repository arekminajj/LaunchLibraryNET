using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{
    public class Event
    {
        public int Id { get; set; }
        public Uri Url { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public EventType Type { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public Uri NewsUrl { get; set; }
        public Uri VideoUrl { get; set; }
        public Uri FeatureImage { get; set; }
        public DateTimeOffset Date { get; set; }
        public EventLaunch[] Launches { get; set; }
        public object[] Expeditions { get; set; }
        public object[] Spacestations { get; set; }
    }

    public class EventLaunch
    {
        public Guid Id { get; set; }
        public Uri Url { get; set; }
        public long LaunchLibraryId { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public EventType Status { get; set; }
        public DateTimeOffset Net { get; set; }
        public DateTimeOffset WindowEnd { get; set; }
        public DateTimeOffset WindowStart { get; set; }
        public bool Inhold { get; set; }
        public bool Tbdtime { get; set; }
        public bool Tbddate { get; set; }
        public long Probability { get; set; }
        public object Holdreason { get; set; }
        public object Failreason { get; set; }
        public object Hashtag { get; set; }
        public EventLaunchServiceProvider LaunchServiceProvider { get; set; }
        public EventRocket Rocket { get; set; }
        public EventMission Mission { get; set; }
        public EventPad Pad { get; set; }
        public bool WebcastLive { get; set; }
        public Uri Image { get; set; }
        public object Infographic { get; set; }
    }

    public class EventLaunchServiceProvider
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class EventMission
    {
        public long Id { get; set; }
        public long LaunchLibraryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public object LaunchDesignator { get; set; }
        public string Type { get; set; }
        public EventOrbit Orbit { get; set; }
    }

    public class EventOrbit
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Abbrev { get; set; }
    }

    public class EventPad
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public object AgencyId { get; set; }
        public string Name { get; set; }
        public object InfoUrl { get; set; }
        public Uri WikiUrl { get; set; }
        public Uri MapUrl { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public EventLocation Location { get; set; }
        public Uri MapImage { get; set; }
        public long TotalLaunchCount { get; set; }
    }

    public class EventLocation
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public Uri MapImage { get; set; }
        public long TotalLaunchCount { get; set; }
        public long TotalLandingCount { get; set; }
    }

    public class EventRocket
    {
        public long Id { get; set; }
        public EventConfiguration Configuration { get; set; }
    }

    public class EventConfiguration
    {
        public long Id { get; set; }
        public long LaunchLibraryId { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string FullName { get; set; }
        public string Variant { get; set; }
    }

    public class EventType
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
