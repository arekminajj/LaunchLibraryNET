using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{
    public class AstronautsStatus
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class AstronautsType
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class AstronautsAgency
    {
        public int id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public bool featured { get; set; }
        public string type { get; set; }
        public string country_code { get; set; }
        public string abbrev { get; set; }
        public string description { get; set; }
        public string administrator { get; set; }
        public string founding_year { get; set; }
        public string launchers { get; set; }
        public string spacecraft { get; set; }
        public object parent { get; set; }
        public string image_url { get; set; }
    }

    public class AstronautsResult
    {
        public int id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public AstronautsStatus status { get; set; }
        public AstronautsType type { get; set; }
        public string date_of_birth { get; set; }
        public string date_of_death { get; set; }
        public string nationality { get; set; }
        public string bio { get; set; }
        public string twitter { get; set; }
        public string instagram { get; set; }
        public string wiki { get; set; }
        public AstronautsAgency agency { get; set; }
        public string profile_image { get; set; }
        public string profile_image_thumbnail { get; set; }
        public DateTime? last_flight { get; set; }
        public DateTime? first_flight { get; set; }
    }

    public class Astronauts
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public IList<AstronautsResult> results { get; set; }
    }
}
