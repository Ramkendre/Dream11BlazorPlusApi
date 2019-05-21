using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dream11Model.Model;

namespace GraphQLAPIGatewayService.GraphQLModel
{
    public class TeamType : ObjectGraphType<Team>
    {
        public TeamType()
        {
            Field(x => x.TeamId);
            Field(x => x.Logo);
            Field(x => x.MatchId);
            Field(x => x.TeamName);
         
        }
    }
}
