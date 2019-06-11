using ApiDota.Interfaces;
using ApiDota.Models;
using System;
using System.Threading.Tasks;

namespace ApiDota.Services
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
