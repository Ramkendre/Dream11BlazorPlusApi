using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RulesStatefulServiceApiService.Model
{
    public class CalculatePoints
    {
        public static PlayerMatchStatistics CalculateStrikePoints<TEntityType>(TEntityType player, List<PlayerMatchStatistics> stats) where TEntityType : PlayerStatistics
        {
            PlayerMatchStatistics playerStats = new PlayerMatchStatistics();
            var rdPlayer = stats.Where(x => x.PlayerId == player.PlayerId).FirstOrDefault();
            rdPlayer = rdPlayer ?? new PlayerMatchStatistics();
            rdPlayer.PlayerId = player.PlayerId;
            rdPlayer.PlayerPoints += player.Strike;
            return rdPlayer;
        }

        public static PlayerMatchStatistics CalculateWicketsPoints<TEntityType>(TEntityType player, List<PlayerMatchStatistics> stats) where TEntityType : PlayerStatistics
        {
            var rdPlayer = stats.Where(x => x.PlayerId == player.PlayerId).FirstOrDefault();
            rdPlayer = rdPlayer ?? new PlayerMatchStatistics();
            rdPlayer.PlayerId = player.PlayerId;
            rdPlayer.PlayerPoints += 10;
            return rdPlayer;
        }
        public static PlayerMatchStatistics CalculateCaughtAndBowledPoints<TEntityType>(TEntityType player, List<PlayerMatchStatistics> stats) where TEntityType : PlayerStatistics
        {
            var rdPlayer = stats.Where(x => x.PlayerId == player.PlayerId).FirstOrDefault();
            rdPlayer = rdPlayer ?? new PlayerMatchStatistics();
            rdPlayer.PlayerId = player.PlayerId;
            rdPlayer.PlayerPoints += 20;
            return rdPlayer;
        }
        public static PlayerMatchStatistics CalculateRunoutPoints<TEntityType>(TEntityType player, List<PlayerMatchStatistics> stats) where TEntityType : PlayerStatistics
        {
            var rdPlayer = stats.Where(x => x.PlayerId == player.PlayerId).FirstOrDefault();
            rdPlayer = rdPlayer ?? new PlayerMatchStatistics();
            rdPlayer.PlayerId = player.PlayerId;
            rdPlayer.PlayerPoints += 10;
            return rdPlayer;
        }

        public static PlayerMatchStatistics CalculateHalfCenturyPoints<TEntityType>(TEntityType player, List<PlayerMatchStatistics> stats) where TEntityType : PlayerStatistics
        {
            var rdPlayer = stats.Where(x => x.PlayerId == player.PlayerId).FirstOrDefault();
            rdPlayer = rdPlayer ?? new PlayerMatchStatistics();
            rdPlayer.PlayerId = player.PlayerId;
            rdPlayer.PlayerPoints += 50;
            return rdPlayer;
        }

        public static PlayerMatchStatistics CalculateCenturyPoints<TEntityType>(TEntityType player, List<PlayerMatchStatistics> stats) where TEntityType : PlayerStatistics
        {
            var rdPlayer = stats.Where(x => x.PlayerId == player.PlayerId).FirstOrDefault();
            rdPlayer = rdPlayer ?? new PlayerMatchStatistics();
            rdPlayer.PlayerId = player.PlayerId;
            rdPlayer.PlayerPoints += 100;
            return rdPlayer;
        }

        public static PlayerMatchStatistics CalculateFourWicketsPoints<TEntityType>(TEntityType player, List<PlayerMatchStatistics> stats) where TEntityType : PlayerStatistics
        {
            var rdPlayer = stats.Where(x => x.PlayerId == player.PlayerId).FirstOrDefault();
            rdPlayer = rdPlayer ?? new PlayerMatchStatistics();
            rdPlayer.PlayerId = player.PlayerId;
            rdPlayer.PlayerPoints += 40;
            return rdPlayer;
        }
        public static PlayerMatchStatistics CalculateEightWicketsPoints<TEntityType>(TEntityType player, List<PlayerMatchStatistics> stats) where TEntityType : PlayerStatistics
        {
            var rdPlayer = stats.Where(x => x.PlayerId == player.PlayerId).FirstOrDefault();
            rdPlayer = rdPlayer ?? new PlayerMatchStatistics();
            rdPlayer.PlayerId = player.PlayerId;
            rdPlayer.PlayerPoints += 80;
            return rdPlayer;
        }

        public static PlayerMatchStatistics CalculateMaidenOverPoints<TEntityType>(TEntityType player, List<PlayerMatchStatistics> stats) where TEntityType : PlayerStatistics
        {
            var rdPlayer = stats.Where(x => x.PlayerId == player.PlayerId).FirstOrDefault();
            rdPlayer = rdPlayer ?? new PlayerMatchStatistics();
            rdPlayer.PlayerId = player.PlayerId;
            rdPlayer.PlayerPoints += 20;
            return rdPlayer;
        }

        public static PlayerMatchStatistics CalculateStumpedPoints<TEntityType>(TEntityType player, List<PlayerMatchStatistics> stats) where TEntityType : PlayerStatistics
        {
            var rdPlayer = stats.Where(x => x.PlayerId == player.PlayerId).FirstOrDefault();
            rdPlayer = rdPlayer ?? new PlayerMatchStatistics();
            rdPlayer.PlayerId = player.PlayerId;
            rdPlayer.PlayerPoints += 200;
            return rdPlayer;
        }

        public static PlayerMatchStatistics CalculateDissmisalOnDuckPoints<TEntityType>(TEntityType player, List<PlayerMatchStatistics> stats) where TEntityType : PlayerStatistics
        {
            var rdPlayer = stats.Where(x => x.PlayerId == player.PlayerId).FirstOrDefault();
            rdPlayer = rdPlayer ?? new PlayerMatchStatistics();
            rdPlayer.PlayerId = player.PlayerId;
            rdPlayer.PlayerPoints -= 2;
            return rdPlayer;
        }
        public static PlayerMatchStatistics FillEmptyPoints<TEntityType>(TEntityType playerPoints) where TEntityType : PlayerStatistics
        {
            return new PlayerMatchStatistics();
        } 
    }
}
