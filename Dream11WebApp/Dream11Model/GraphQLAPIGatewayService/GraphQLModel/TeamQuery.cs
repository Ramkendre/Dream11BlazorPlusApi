using GraphQL.Types;
using GraphQLAPIGatewayService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIGatewayService.GraphQLModel
{
    public class TeamQuery :ObjectGraphType
    {
        public TeamQuery()
        {

        }
        public TeamQuery(IDream11TeamService teamService)
        {
            Field<ListGraphType<TeamType>>(
               "teams",
                resolve: context => teamService.GetAll());
        }
    }
}
