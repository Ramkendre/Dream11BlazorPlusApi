using Dream11Model.Model;
using GraphQL.Types;
using GraphQLAPIGatewayService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIGatewayService.GraphQLModel
{
    public class MatchType :ObjectGraphType<Match>
   {
        public MatchType(IDream11TeamService teamService)
        {
            Field(x => x.MatchId);
            Field(x => x.Name, true);
            Field(x => x.SeriesName);
            Field(x => x.Sport);
            Field<ListGraphType<TeamType>>("teams",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => teamService.Get(context.Source.MatchId), description: "Get team matches");

        }

    }
}
