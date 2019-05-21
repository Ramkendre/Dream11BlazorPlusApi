using Dream11Model.Model;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIGatewayService.GraphQLModel
{
    public class ContestType : ObjectGraphType<Contest>
    {

        public ContestType()
        {
            Field(x => x.ContestId);
            Field(x => x.EntryFee);
            Field(x => x.NoOfSpots);
            Field(x => x.NoOfSpotsLeft);
            Field(x => x.PrizeAmount);
            Field(x => x.WinningPercent);
           
        }
    }
}
