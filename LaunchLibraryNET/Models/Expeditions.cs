using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{
    public class Expeditions
    {
        public long Count { get; set; }
        public Uri Next { get; set; }
        public object Previous { get; set; }
        public ExpeditionsResult[] Results { get; set; }
    }

    public class ExpeditionsResult
    {
        public int Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset End { get; set; }
        public ExpeditionsSpacestation Spacestation { get; set; }
    }

    public class ExpeditionsSpacestation
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public ExpeditionsStatus Status { get; set; }
        public string Orbit { get; set; }
        public Uri ImageUrl { get; set; }
    }

    public class ExpeditionsStatus
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
