using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{
    public class Expedition
    {
        public int Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset End { get; set; }
        public ExpeditionSpacestation Spacestation { get; set; }
        public ExpeditionCrew[] Crew { get; set; }
    }

    public class ExpeditionCrew
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public ExpeditionAstronaut Astronaut { get; set; }
    }

    public class ExpeditionAstronaut
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public ExpeditionStatus Status { get; set; }
        public ExpeditionOwner Agency { get; set; }
        public Uri ProfileImage { get; set; }
        public Uri ProfileImageThumbnail { get; set; }
    }

    public class ExpeditionOwner
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Abbrev { get; set; }
    }

    public class ExpeditionStatus
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class ExpeditionSpacestation
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public ExpeditionStatus Status { get; set; }
        public DateTimeOffset Founded { get; set; }
        public string Description { get; set; }
        public string Orbit { get; set; }
        public Uri ImageUrl { get; set; }
        public ExpeditionOwner[] Owners { get; set; }
    }
}
