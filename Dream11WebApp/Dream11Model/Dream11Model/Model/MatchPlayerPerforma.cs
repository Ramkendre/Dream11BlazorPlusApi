using System;
using System.Collections.Generic;
using System.Text;

namespace Dream11Model.Model
{
    public class MatchPlayerPerforma
    {
        public int MatchPlayerPerformaId { get; set; }
        public int UserId { get; set; }
        public int PlayerId { get; set; }
        public int MatchId { get; set; }
        public int Strike { get; set; }
        public bool IsCaughtAndBowled { get; set; }
        public bool HasWicketTaken { get; set; }
        public bool IsStumped { get; set; }
        public bool IsRunOut { get; set; }
        public bool IsHalfCentury { get; set; }
        public bool IsCentury { get; set; }
        public bool IsFourWickets { get; set; }
        public bool IsEightWickets { get; set; }
        public bool IsMaidenOver { get; set; }
        public bool IsDismissalOnDuck { get; set; }
        public int TotalRun { get; set; }
        public int TotalWicket { get; set; }
        public decimal Over { get; set; }
    }
}
