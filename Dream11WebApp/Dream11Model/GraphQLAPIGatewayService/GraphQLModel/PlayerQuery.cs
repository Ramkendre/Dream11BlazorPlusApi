using GraphQL.Types;
using GraphQLAPIGatewayService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIGatewayService.GraphQLModel
{
    public class PlayerQuery:ObjectGraphType
    {
        public PlayerQuery(IDream11PlayerService dream11PlayerService)
        {
            Field<ListGraphType<PlayerType>>(
               "players",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => dream11PlayerService.Get(context.GetArgument("id",0)));
        }
    }
}
