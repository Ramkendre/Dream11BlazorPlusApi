using GraphQL.Types;
using GraphQLAPIGatewayService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIGatewayService.GraphQLModel
{
    public partial class MatchQuery : ObjectGraphType
    {
        public MatchQuery()
        {

        }
        public MatchQuery(IDream11MatchService dream11MatchService)
        {
            Field<ListGraphType<MatchType>>(
               "matches",
                resolve: context => dream11MatchService.GetAll());
        }
    }
}
