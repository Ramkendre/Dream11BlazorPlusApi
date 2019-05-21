using Dream11Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIGatewayService.Services
{

    public interface IDream11TeamService
    {
        Task<List<Team>> Get(int id);
        Task<Match> GetRandom();
        Task<List<Match>> GetAll();
        Task<Team> Add(Team team);
        Task<Team> GetPlayerTeam(int id);

    }

}
