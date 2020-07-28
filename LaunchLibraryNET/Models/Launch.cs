using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{
    public class Launch
    {
        public Guid Id { get; set; }
        public Uri Url { get; set; }
        public long LaunchLibraryId { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public LaunchStatus Status { get; set; }
        public DateTimeOffset Net { get; set; }
        public DateTimeOffset WindowEnd { get; set; }
        public DateTimeOffset WindowStart { get; set; }
        public bool Inhold { get; set; }
        public bool Tbdtime { get; set; }
        public bool Tbddate { get; set; }
        public long Probability { get; set; }
        public string Holdreason { get; set; }
        public string Failreason { get; set; }
        public string Hashtag { get; set; }
        public LaunchLaunchServiceProvider LaunchServiceProvider { get; set; }
        public LaunchRocket Rocket { get; set; }
        public object Mission { get; set; }
        public LaunchPad Pad { get; set; }
        public object[] InfoUrLs { get; set; }
        public object[] VidUrLs { get; set; }
        public bool WebcastLive { get; set; }
        public object Image { get; set; }
        public object Infographic { get; set; }
        public long LocationLaunchAttemptCount { get; set; }
        public long PadLaunchAttemptCount { get; set; }
        public long AgencyLaunchAttemptCount { get; set; }
        public long LocationLaunchAttemptCountYear { get; set; }
        public long PadLaunchAttemptCountYear { get; set; }
        public long AgencyLaunchAttemptCountYear { get; set; }
    }

    public class LaunchLaunchServiceProvider
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public bool Featured { get; set; }
        public string Type { get; set; }
        public string CountryCode { get; set; }
        public string Abbrev { get; set; }
        public object Description { get; set; }
        public object Administrator { get; set; }
        public object FoundingYear { get; set; }
        public string Launchers { get; set; }
        public string Spacecraft { get; set; }
        public Uri LaunchLibraryUrl { get; set; }
        public long TotalLaunchCount { get; set; }
        public long ConsecutiveSuccessfulLaunches { get; set; }
        public long SuccessfulLaunches { get; set; }
        public long FailedLaunches { get; set; }
        public long PendingLaunches { get; set; }
        public long ConsecutiveSuccessfulLandings { get; set; }
        public long SuccessfulLandings { get; set; }
        public long FailedLandings { get; set; }
        public long AttemptedLandings { get; set; }
        public Uri InfoUrl { get; set; }
        public Uri WikiUrl { get; set; }
        public object LogoUrl { get; set; }
        public object ImageUrl { get; set; }
        public object NationUrl { get; set; }
    }

    public class LaunchPad
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public long AgencyId { get; set; }
        public string Name { get; set; }
        public object InfoUrl { get; set; }
        public string WikiUrl { get; set; }
        public Uri MapUrl { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public LaunchLocation Location { get; set; }
        public Uri MapImage { get; set; }
        public long TotalLaunchCount { get; set; }
    }

    public class LaunchLocation
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public Uri MapImage { get; set; }
        public long TotalLaunchCount { get; set; }
        public long TotalLandingCount { get; set; }
    }

    public class LaunchRocket
    {
        public long Id { get; set; }
        public LaunchConfiguration Configuration { get; set; }
        public object[] LauncherStage { get; set; }
        public object SpacecraftStage { get; set; }
    }

    public class LaunchConfiguration
    {
        public long Id { get; set; }
        public long LaunchLibraryId { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Family { get; set; }
        public string FullName { get; set; }
        public LaunchLaunchServiceProvider Manufacturer { get; set; }
        public string Variant { get; set; }
        public string Alias { get; set; }
        public object MinStage { get; set; }
        public object MaxStage { get; set; }
        public double Length { get; set; }
        public double Diameter { get; set; }
        public object MaidenFlight { get; set; }
        public long LaunchMass { get; set; }
        public object LeoCapacity { get; set; }
        public object GtoCapacity { get; set; }
        public long ToThrust { get; set; }
        public object Apogee { get; set; }
        public object VehicleRange { get; set; }
        public object ImageUrl { get; set; }
        public Uri InfoUrl { get; set; }
        public object WikiUrl { get; set; }
    }

    public class LaunchStatus
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
