namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Represents one team in the Matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this particular team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the Matchup that this team came
        /// from as winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }


    }
}
