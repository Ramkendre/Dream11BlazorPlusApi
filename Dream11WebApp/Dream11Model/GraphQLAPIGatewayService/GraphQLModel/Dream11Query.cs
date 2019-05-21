using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIGatewayService.GraphQLModel
{
    public class Dream11Query :ObjectGraphType
    {
        public Dream11Query()
        {
            Name = "Query";
            Field<MatchQuery>("matches", resolve: context => new MatchQuery() { });
            Field<TeamQuery>("teams", resolve: context => new TeamQuery(){ });
            Field<PlayerQuery>("players",resolve: context => new { });
            Field<ContestQuery>("contests", resolve: context => new { });
        }
    
    }
}
