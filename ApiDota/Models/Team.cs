﻿namespace ApiDota.Models
{
    public class Team
    {
        public int team_id { get; set; }
        public float rating { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public int last_match_time { get; set; }
        public string name { get; set; }
        public string tag { get; set; }
        public string logo_url { get; set; }
    }

}
