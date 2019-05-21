using Dream11Model.Model;
using GraphQL.Types;
using GraphQLAPIGatewayService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIGatewayService.GraphQLModel
{
    public class Dream11Mutation : ObjectGraphType
    {

        public Dream11Mutation(IDream11MatchService matchService)
        {
            Name = "CreateMatchMutation";

            Field<MatchType>(
                "createMatch",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<MatchInputType>> { Name = "match" }
                ),
                resolve: context =>
                {
                    var match = context.GetArgument<Match>("match");
                    return matchService.Add(match);
                });
        }
       
    }
}
