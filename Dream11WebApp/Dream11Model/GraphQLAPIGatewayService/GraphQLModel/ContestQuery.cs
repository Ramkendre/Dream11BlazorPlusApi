using GraphQL.Types;
using GraphQLAPIGatewayService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIGatewayService.GraphQLModel
{
    public class ContestQuery:ObjectGraphType
    {
        public ContestQuery(IDream11ContestService dream11ContestService )
        {
            Field<ListGraphType<ContestType>>(
              "contests",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => dream11ContestService.Get(context.GetArgument("id", 0)));

        }
    }
}
