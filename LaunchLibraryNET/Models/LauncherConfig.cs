using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{
    public class LauncherConfig
    {
        public long Id { get; set; }
        public long LaunchLibraryId { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Family { get; set; }
        public string FullName { get; set; }
        public LauncherConfigManufacturer Manufacturer { get; set; }
        public string Variant { get; set; }
        public string Alias { get; set; }
        public long MinStage { get; set; }
        public long MaxStage { get; set; }
        public double Length { get; set; }
        public double Diameter { get; set; }
        public DateTimeOffset MaidenFlight { get; set; }
        public long LaunchMass { get; set; }
        public long LeoCapacity { get; set; }
        public object GtoCapacity { get; set; }
        public long ToThrust { get; set; }
        public object Apogee { get; set; }
        public object VehicleRange { get; set; }
        public Uri ImageUrl { get; set; }
        public Uri InfoUrl { get; set; }
        public Uri WikiUrl { get; set; }
    }

    public class LauncherConfigManufacturer
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
        public Uri LogoUrl { get; set; }
        public object ImageUrl { get; set; }
        public object NationUrl { get; set; }
    }
}
