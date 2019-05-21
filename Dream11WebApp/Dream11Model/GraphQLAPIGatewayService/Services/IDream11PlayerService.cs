using Dream11Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIGatewayService.Services
{
    public interface IDream11PlayerService
    {
        Task<List<Player>> Get(int id);
        Task<Player> GetRandom();
        Task<List<Player>> GetAll();
        Task<Player> Add(Player player);
    }
}
