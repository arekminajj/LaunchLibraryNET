using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{

    public class Astronaut
    {
            public long Id { get; set; }
            public Uri Url { get; set; }
            public string Name { get; set; }
            public AstronautStatus Status { get; set; }
            public AstronautStatus Type { get; set; }
            public Agency Agency { get; set; }
            public DateTimeOffset DateOfBirth { get; set; }
            public object DateOfDeath { get; set; }
            public string Nationality { get; set; }
            public object Twitter { get; set; }
            public object Instagram { get; set; }
            public string Bio { get; set; }
            public Uri ProfileImage { get; set; }
            public Uri ProfileImageThumbnail { get; set; }
            public Uri Wiki { get; set; }
            public AstronautFlight[] Flights { get; set; }
            public AstronautLanding[] Landings { get; set; }
            public DateTimeOffset LastFlight { get; set; }
            public DateTimeOffset FirstFlight { get; set; }
    }

        public class AstronautAgency
        {
            public long Id { get; set; }
            public Uri Url { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
        }

        public class AstronautFlight
        {
            public Guid Id { get; set; }
            public Uri Url { get; set; }
            public long LaunchLibraryId { get; set; }
            public string Slug { get; set; }
            public string Name { get; set; }
            public AstronautStatus Status { get; set; }
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
            public AstronautAgency LaunchServiceProvider { get; set; }
            public AstronautRocket Rocket { get; set; }
            public AstronautMission Mission { get; set; }
            public AstronautPad Pad { get; set; }
            public bool WebcastLive { get; set; }
            public Uri Image { get; set; }
            public object Infographic { get; set; }
        }

        public class AstronautMission
        {
            public long Id { get; set; }
            public long LaunchLibraryId { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public object LaunchDesignator { get; set; }
            public string Type { get; set; }
            public AstronautOrbit Orbit { get; set; }
        }

        public class AstronautOrbit
        {
            public long Id { get; set; }
            public string Name { get; set; }
            public string Abbrev { get; set; }
        }

        public class AstronautPad
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
            public AstronautLocation Location { get; set; }
            public Uri MapImage { get; set; }
            public long TotalLaunchCount { get; set; }
        }

        public class AstronautLocation
        {
            public long Id { get; set; }
            public Uri Url { get; set; }
            public string Name { get; set; }
            public string CountryCode { get; set; }
            public Uri MapImage { get; set; }
            public long TotalLaunchCount { get; set; }
            public long TotalLandingCount { get; set; }
        }

        public class AstronautRocket
        {
            public long Id { get; set; }
            public AstronautConfiguration Configuration { get; set; }
        }

        public class AstronautConfiguration
        {
            public long Id { get; set; }
            public long LaunchLibraryId { get; set; }
            public Uri Url { get; set; }
            public string Name { get; set; }
            public string Family { get; set; }
            public string FullName { get; set; }
            public long Variant { get; set; }
        }

        public class AstronautStatus
        {
            public long Id { get; set; }
            public string Name { get; set; }
        }

        public class AstronautLanding
        {
            public long Id { get; set; }
            public Uri Url { get; set; }
            public string Destination { get; set; }
            public DateTimeOffset MissionEnd { get; set; }
            public AstronautSpacecraft Spacecraft { get; set; }
            public AstronautFlight Launch { get; set; }
        }

        public class AstronautSpacecraft
        {
            public long Id { get; set; }
            public Uri Url { get; set; }
            public string Name { get; set; }
            public string SerialNumber { get; set; }
            public AstronautStatus Status { get; set; }
            public string Description { get; set; }
            public AstronautSpacecraftConfig SpacecraftConfig { get; set; }
        }

        public class AstronautSpacecraftConfig
        {
            public long Id { get; set; }
            public Uri Url { get; set; }
            public string Name { get; set; }
            public AstronautStatus Type { get; set; }
            public AstronautAgency Agency { get; set; }
            public bool InUse { get; set; }
            public Uri ImageUrl { get; set; }
        }
}
