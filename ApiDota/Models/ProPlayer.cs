namespace ApiDota.Models
{
    public class ProPlayer
    {
        public object tracked_until { get; set; }
        public Profile profile { get; set; }
        public object rank_tier { get; set; }
        public object competitive_rank { get; set; }
        public int solo_competitive_rank { get; set; }
        public Mmr_Estimate mmr_estimate { get; set; }
        public object leaderboard_rank { get; set; }
    }

    public class Profile
    {
        public int account_id { get; set; }
        public string personaname { get; set; }
        public string name { get; set; }
        public object plus { get; set; }
        public int cheese { get; set; }
        public string steamid { get; set; }
        public string avatar { get; set; }
        public string avatarmedium { get; set; }
        public string avatarfull { get; set; }
        public string profileurl { get; set; }
        public object last_login { get; set; }
        public string loccountrycode { get; set; }
        public bool is_contributor { get; set; }
    }

    public class Mmr_Estimate
    {
        public int estimate { get; set; }
    }
}
