using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{
    public class Spacestations
    {
        public long Count { get; set; }
        public object Next { get; set; }
        public object Previous { get; set; }
        public SpacestationsResult[] Results { get; set; }
    }

    public class SpacestationsResult
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public SpacestationsStatus Status { get; set; }
        public SpacestationsStatus Type { get; set; }
        public DateTimeOffset Founded { get; set; }
        public DateTimeOffset? Deorbited { get; set; }
        public string Description { get; set; }
        public string Orbit { get; set; }
        public SpacestationsOwner[] Owners { get; set; }
        public Uri ImageUrl { get; set; }
    }

    public class SpacestationsOwner
    {
        public long Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string Abbrev { get; set; }
    }

    public class SpacestationsStatus
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
