using ApiDota.Models;
using System.Threading.Tasks;

namespace ApiDota.Interfaces
{
    public interface IApi
    {
        Task<ProPlayer> GetPlayers();
        Task<Leagues> GetLeagues();
        Task<ProMatche> GetProMatches();
        Task<Team> GetTeams();

    }
}