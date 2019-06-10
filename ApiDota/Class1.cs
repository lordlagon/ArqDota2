using System;
using System.Threading.Tasks;
using ApiDota.Models;

namespace ApiDota
{
    public class RestApiDota : IApi
    {
        public Task<Leagues> GetLeagues()
        {
            throw new NotImplementedException();
        }

        public Task<ProPlayer> GetPlayers()
        {
            throw new NotImplementedException();
        }

        public Task<ProMatche> GetProMatches()
        {
            throw new NotImplementedException();
        }

        public Task<Team> GetTeams()
        {
            throw new NotImplementedException();
        }
    }
}
