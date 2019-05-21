using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIGatewayService.GraphQLModel
{
    public class MatchInputType : InputObjectGraphType
    {
        public MatchInputType()
        {
            Name = "MatchInput";
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<StringGraphType>("birthPlace");
            Field<StringGraphType>("height");
            Field<IntGraphType>("weightLbs");
            Field<DateGraphType>("birthDate");
        }
    }
}
   
