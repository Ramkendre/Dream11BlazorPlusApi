namespace RulesStatefulServiceApiService.Model
{
    public class PlayerMatchStatistics
    {
        public int PlayerId { get; set; }
        public int PlayerPoints { get; set; }

        private static PlayerMatchStatistics playerMatchStatistics;

        private PlayerMatchStatistics(bool HasWicketTaken, int Strike, bool IsStumped, bool IsCaughtAndBowled, bool IsRunOut)
        {

        }

        public PlayerMatchStatistics()
        {


        }

    }
}