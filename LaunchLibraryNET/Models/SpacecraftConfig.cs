using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{
    public class SpacecraftConfig
    {
        public int Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public SpacecraftConfigType Type { get; set; }
        public SpacecraftConfigAgency Agency { get; set; }
        public bool InUse { get; set; }
        public string Capability { get; set; }
        public string History { get; set; }
        public string Details { get; set; }
        public DateTimeOffset MaidenFlight { get; set; }
        public long Height { get; set; }
        public double Diameter { get; set; }
        public bool HumanRated { get; set; }
        public long CrewCapacity { get; set; }
        public long PayloadCapacity { get; set; }
        public string FlightLife { get; set; }
        public Uri ImageUrl { get; set; }
        public Uri NationUrl { get; set; }
        public Uri WikiLink { get; set; }
        public string InfoLink { get; set; }
    }

    public class SpacecraftConfigAgency
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

    public class SpacecraftConfigType
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
