using Dream11Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIGatewayService.Services
{
    public interface IDream11ContestService
    {
        Task<List<Contest>> Get(int id);
        Task<Contest> GetRandom();
        Task<List<Contest>> GetAll();
        Task<Contest> Add(Player player);
    }
}
