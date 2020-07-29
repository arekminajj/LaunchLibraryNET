using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibraryNET.Models
{
    public class Agency
    {
        public int id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public bool featured { get; set; }
        public string type { get; set; }
        public string country_code { get; set; }
        public string abbrev { get; set; }
        public string description { get; set; }
        public object administrator { get; set; }
        public string founding_year { get; set; }
        public string launchers { get; set; }
        public string spacecraft { get; set; }
        public object parent { get; set; }
        public string launch_library_url { get; set; }
        public int total_launch_count { get; set; }
        public int successful_launches { get; set; }
        public int consecutive_successful_launches { get; set; }
        public int failed_launches { get; set; }
        public int pending_launches { get; set; }
        public int successful_landings { get; set; }
        public int failed_landings { get; set; }
        public int attempted_landings { get; set; }
        public int consecutive_successful_landings { get; set; }
        public string info_url { get; set; }
        public string wiki_url { get; set; }
        public string logo_url { get; set; }
        public object image_url { get; set; }
        public object nation_url { get; set; }
        public List<object> launcher_list { get; set; }
        public List<object> spacecraft_list { get; set; }
    }

}
