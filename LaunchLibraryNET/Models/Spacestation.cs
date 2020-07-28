using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{
    public class Spacestation
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public SpacestationStatus Status { get; set; }
        public SpacestationStatus Type { get; set; }
        public DateTimeOffset Founded { get; set; }
        public object Deorbited { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Mass { get; set; }
        public long Volume { get; set; }
        public string Description { get; set; }
        public string Orbit { get; set; }
        public long OnboardCrew { get; set; }
        public SpacestationOwner[] Owners { get; set; }
        public SpacestationActiveExpedition[] ActiveExpeditions { get; set; }
        public SpacestationDockingLocation[] DockingLocation { get; set; }
        public Uri ImageUrl { get; set; }
    }

    public class SpacestationActiveExpedition
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public DateTimeOffset Start { get; set; }
        public object End { get; set; }
        public SpacestationCrew[] Crew { get; set; }
    }

    public class SpacestationCrew
    {
        public long Id { get; set; }
        public string Role { get; set; }
        public SpacestationAstronaut Astronaut { get; set; }
    }

    public class SpacestationAstronaut
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public SpacestationStatus Status { get; set; }
        public SpacestationAgency Agency { get; set; }
        public Uri ProfileImage { get; set; }
        public Uri ProfileImageThumbnail { get; set; }
    }

    public class SpacestationAgency
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class SpacestationStatus
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class SpacestationDockingLocation
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public SpacestationDocked Docked { get; set; }
    }

    public class SpacestationDocked
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public DateTimeOffset Docking { get; set; }
        public object Departure { get; set; }
        public SpacestationFlightVehicle FlightVehicle { get; set; }
    }

    public class SpacestationFlightVehicle
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public SpacestationSpacecraft Spacecraft { get; set; }
        public SpacestationLaunch Launch { get; set; }
    }

    public class SpacestationLaunch
    {
        public Guid Id { get; set; }
        public Uri Url { get; set; }
        public long LaunchLibraryId { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public SpacestationStatus Status { get; set; }
        public DateTimeOffset Net { get; set; }
        public DateTimeOffset WindowEnd { get; set; }
        public DateTimeOffset WindowStart { get; set; }
        public bool Inhold { get; set; }
        public bool Tbdtime { get; set; }
        public bool Tbddate { get; set; }
        public long Probability { get; set; }
        public object Holdreason { get; set; }
        public object Failreason { get; set; }
        public string Hashtag { get; set; }
        public SpacestationAgency LaunchServiceProvider { get; set; }
        public SpacestationRocket Rocket { get; set; }
        public SpacestationMission Mission { get; set; }
        public SpacestationPad Pad { get; set; }
        public bool WebcastLive { get; set; }
        public Uri Image { get; set; }
        public Uri Infographic { get; set; }
    }

    public class SpacestationMission
    {
        public long Id { get; set; }
        public long LaunchLibraryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public object LaunchDesignator { get; set; }
        public string Type { get; set; }
        public SpacestationOrbit Orbit { get; set; }
    }

    public class SpacestationOrbit
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Abbrev { get; set; }
    }

    public class SpacestationPad
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
        public SpacestationLocation Location { get; set; }
        public Uri MapImage { get; set; }
        public long TotalLaunchCount { get; set; }
    }

    public class SpacestationLocation
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public Uri MapImage { get; set; }
        public long TotalLaunchCount { get; set; }
        public long TotalLandingCount { get; set; }
    }

    public class SpacestationRocket
    {
        public long Id { get; set; }
        public SpacestationConfiguration Configuration { get; set; }
    }

    public class SpacestationConfiguration
    {
        public long Id { get; set; }
        public long LaunchLibraryId { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string FullName { get; set; }
        public string Variant { get; set; }
    }

    public class SpacestationSpacecraft
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public SpacestationStatus Status { get; set; }
        public string Description { get; set; }
        public SpacestationSpacecraftConfig SpacecraftConfig { get; set; }
    }

    public class SpacestationSpacecraftConfig
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public SpacestationStatus Type { get; set; }
        public SpacestationOwner Agency { get; set; }
        public bool InUse { get; set; }
        public string Capability { get; set; }
        public string History { get; set; }
        public string Details { get; set; }
        public DateTimeOffset MaidenFlight { get; set; }
        public double? Height { get; set; }
        public double? Diameter { get; set; }
        public bool HumanRated { get; set; }
        public long? CrewCapacity { get; set; }
        public long? PayloadCapacity { get; set; }
        public string FlightLife { get; set; }
        public Uri ImageUrl { get; set; }
        public Uri NationUrl { get; set; }
        public Uri WikiLink { get; set; }
        public string InfoLink { get; set; }
    }

    public class SpacestationOwner
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
