using Dream11Model.Model;
using GraphQL.Types;
using GraphQLAPIGatewayService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIGatewayService.GraphQLModel
{
    public class PlayerType : ObjectGraphType<Player>
    {
        public PlayerType(IDream11TeamService teamService)
        {
            Field(x => x.PlayerId);
            Field(x => x.FirstName);
            Field(x => x.LastName);
            Field(x => x.Points);
            Field(x => x.Credits);
            Field(x => x.TeamId);
            Field(x => x.Image);
            Field(x => x.IsCaptain);
            Field(x => x.IsSelected);
            Field(x => x.IsViceCaptain);
            Field(x => x.PlayerRoleName);
            Field<TeamType>("team",
             arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
             resolve: context => teamService.GetPlayerTeam(context.Source.TeamId), description: "Get player team");


        }
    }
}
