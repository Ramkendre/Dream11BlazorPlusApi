using AutoMapper;
using FabricApplication.Models;
using FabricApplication.Models.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FabricApplication.App_Start
{
    public static class MapperConfig
    {
        public static void AutoMapperBootstrap()
        {
            //Mapper.Initialize(cfg =>
            //{
            //    cfg.CreateMap<Match, Matches>();
            //    cfg.CreateMap<Match, Matchs>();
            //    cfg.CreateMap<Match, MatchEntity>();

            //    //cfg.CreateMap<FabricApplication.Models.BAL.MatchEntity, Match>()
            //    //.ForMember(dest => dest.MatchPlayers, opt => opt.MapFrom(src => new Match
            //    //{
            //    //    MatchPlayers = src.MatchPlayers.Select(bs => Mapper.Map<MatchPlayer>(bs)).ToList()
            //    //}));

            //    cfg.CreateMap<userplayer, Player>()
            //     .ForMember(dest => dest.PlayerScores, opt => opt.MapFrom(src => new Player
            //     {
            //         PlayerScores = src.player.PlayerScores.Select(bs => Mapper.Map<PlayerScore>(bs)).ToList()
            //     }));
            //    cfg.CreateMap<User, Login>();
            //    cfg.CreateMap<User, User>();
            //    cfg.CreateMap<Player, PlayerEntity>();
            //    cfg.CreateMap<PlayerScore, PlayerEntity>();
            //});
            //}
        }
    }
}