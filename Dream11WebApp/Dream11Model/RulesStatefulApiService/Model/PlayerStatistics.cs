using System;
using System.Collections.Generic;
using System.Text;

namespace RulesStatefulServiceApiService.Model
{
    public class PlayerStatistics
    {
        public int MatchPlayerPerformaId { get; set; }
        public int UserId { get; set; }
        public int PlayerId { get; set; }
        public int Strike { get; set; }
        public bool HasWicketTaken { get; set; }
        public bool IsCaughtAndBowled { get; set; }
        public bool IsRunout { get; set; }
        public bool IsStumped { get; set; }
        public bool IsHalfCentury { get; set; }
        public bool IsCentury { get; set; }
        public bool IsFourWickets { get; set; }
        public bool IsEightWickets { get; set; }
        public bool IsMaidenOver { get; set; }
        public bool IsDismissalOnDuck { get; set; }
    }
}
