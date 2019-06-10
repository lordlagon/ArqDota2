using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArqDota2.Models
{
    public class Player
    {
            public int account_id { get; set; }
            public string avatar { get; set; }
            public string avatarmedium { get; set; }
            public string avatarfull { get; set; }
            public string personaname { get; set; }
            public int cheese { get; set; }
            public string loccountrycode { get; set; }
            public DateTime last_match_time { get; set; }
            public string name { get; set; }
            public string country_code { get; set; }
            public int fantasy_role { get; set; }
            public int team_id { get; set; }
            public string team_name { get; set; }
            public string team_tag { get; set; }
            public bool is_pro { get; set; }
        }
    
}
