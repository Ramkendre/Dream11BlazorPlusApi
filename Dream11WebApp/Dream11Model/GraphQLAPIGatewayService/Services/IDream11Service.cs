using Dream11Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIGatewayService.Services
{
    public interface IDream11MatchService
    {
        Task<Match> Get(int id);
        Task<Match> GetRandom();
        Task<List<Match>> GetAll();
        Task<Match> Add(Match match);

    }
}
