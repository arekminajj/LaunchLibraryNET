using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{
    public class LauncherConfigs
    {
        public long Count { get; set; }
        public Uri Next { get; set; }
        public object Previous { get; set; }
        public LauncherConfigsResult[] Results { get; set; }
    }

    public class LauncherConfigsResult
    {
        public long Id { get; set; }
        public long? LaunchLibraryId { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public LauncherConfigsManufacturer Manufacturer { get; set; }
        public string Family { get; set; }
        public string FullName { get; set; }
        public string Variant { get; set; }
        public bool Reusable { get; set; }
        public Uri ImageUrl { get; set; }
        public string InfoUrl { get; set; }
        public string WikiUrl { get; set; }
    }

    public class LauncherConfigsManufacturer
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
        public long? FoundingYear { get; set; }
        public string Launchers { get; set; }
        public string Spacecraft { get; set; }
        public string Parent { get; set; }
        public Uri ImageUrl { get; set; }
    }
}
