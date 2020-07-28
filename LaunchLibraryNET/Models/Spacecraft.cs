using System;

namespace LaunchLibraryNET.Models
{
    public class Spacecraft
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public long SerialNumber { get; set; }
        public SpacecraftStatus Status { get; set; }
        public string Description { get; set; }
        public SpacecraftSpacecraftSpacecraftConfigClass SpacecraftConfig { get; set; }
        public SpacecraftFlight[] Flights { get; set; }
    }

    public class SpacecraftFlight
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Destination { get; set; }
        public DateTimeOffset MissionEnd { get; set; }
        public SpacecraftSpacecraftClass Spacecraft { get; set; }
        public SpacecraftLaunch Launch { get; set; }
    }

    public class SpacecraftLaunch
    {
        public Guid Id { get; set; }
        public Uri Url { get; set; }
        public object LaunchLibraryId { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public SpacecraftStatus Status { get; set; }
        public DateTimeOffset Net { get; set; }
        public DateTimeOffset WindowEnd { get; set; }
        public DateTimeOffset WindowStart { get; set; }
        public bool Inhold { get; set; }
        public bool Tbdtime { get; set; }
        public bool Tbddate { get; set; }
        public long Probability { get; set; }
        public string Holdreason { get; set; }
        public string Failreason { get; set; }
        public object Hashtag { get; set; }
        public object LaunchServiceProvider { get; set; }
        public SpacecraftRocket Rocket { get; set; }
        public SpacecraftMission Mission { get; set; }
        public SpacecraftPad Pad { get; set; }
        public bool WebcastLive { get; set; }
        public Uri Image { get; set; }
        public object Infographic { get; set; }
    }

    public class SpacecraftMission
    {
        public long Id { get; set; }
        public object LaunchLibraryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public object LaunchDesignator { get; set; }
        public string Type { get; set; }
        public SpacecraftOrbit Orbit { get; set; }
    }

    public class SpacecraftOrbit
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Abbrev { get; set; }
    }

    public class SpacecraftPad
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public long AgencyId { get; set; }
        public string Name { get; set; }
        public object InfoUrl { get; set; }
        public Uri WikiUrl { get; set; }
        public Uri MapUrl { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public SpacecraftLocation Location { get; set; }
        public Uri MapImage { get; set; }
        public long TotalLaunchCount { get; set; }
    }

    public class SpacecraftLocation
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public Uri MapImage { get; set; }
        public long TotalLaunchCount { get; set; }
        public long TotalLandingCount { get; set; }
    }

    public class SpacecraftRocket
    {
        public long Id { get; set; }
        public SpacecraftConfiguration Configuration { get; set; }
    }

    public class SpacecraftConfiguration
    {
        public long Id { get; set; }
        public long LaunchLibraryId { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string FullName { get; set; }
        public string Variant { get; set; }
    }

    public class SpacecraftStatus
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class SpacecraftSpacecraftClass
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public long SerialNumber { get; set; }
        public SpacecraftStatus Status { get; set; }
        public string Description { get; set; }
        public SpacecraftSpacecraftSpacecraftConfig SpacecraftConfig { get; set; }
    }

    public class SpacecraftSpacecraftSpacecraftConfig
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public SpacecraftStatus Type { get; set; }
        public SpacecraftPurpleAgency Agency { get; set; }
        public bool InUse { get; set; }
        public Uri ImageUrl { get; set; }
    }

    public class SpacecraftPurpleAgency
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class SpacecraftSpacecraftSpacecraftConfigClass
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public SpacecraftStatus Type { get; set; }
        public SpacecraftFluffyAgency Agency { get; set; }
        public bool InUse { get; set; }
        public string Capability { get; set; }
        public string History { get; set; }
        public string Details { get; set; }
        public DateTimeOffset MaidenFlight { get; set; }
        public double Height { get; set; }
        public double Diameter { get; set; }
        public bool HumanRated { get; set; }
        public long CrewCapacity { get; set; }
        public object PayloadCapacity { get; set; }
        public string FlightLife { get; set; }
        public Uri ImageUrl { get; set; }
        public Uri NationUrl { get; set; }
        public Uri WikiLink { get; set; }
        public string InfoLink { get; set; }
    }

    public class SpacecraftFluffyAgency
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public bool Featured { get; set; }
        public string Type { get; set; }
        public string CountryCode { get; set; }
        public string Abbrev { get; set; }
        public string Description { get; set; }
        public string Administrator { get; set; }
        public long FoundingYear { get; set; }
        public string Launchers { get; set; }
        public string Spacecraft { get; set; }
        public object Parent { get; set; }
        public Uri ImageUrl { get; set; }
    }
}
