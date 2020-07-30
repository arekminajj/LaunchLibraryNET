using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{

    public class SpacecraftConfigs
        {
            public long Count { get; set; }
            public object Next { get; set; }
            public object Previous { get; set; }
            public SpacecraftConfigsResult[] Results { get; set; }
        }

        public class SpacecraftConfigsResult
    {
            public int Id { get; set; }
            public Uri Url { get; set; }
            public string Name { get; set; }
            public SpacecraftConfigsAgency Agency { get; set; }
            public bool InUse { get; set; }
            public string Capability { get; set; }
            public DateTimeOffset? MaidenFlight { get; set; }
            public bool HumanRated { get; set; }
            public long? CrewCapacity { get; set; }
            public Uri ImageUrl { get; set; }
            public Uri NationUrl { get; set; }
            public string WikiLink { get; set; }
            public string InfoLink { get; set; }
        }

        public class SpacecraftConfigsAgency
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
