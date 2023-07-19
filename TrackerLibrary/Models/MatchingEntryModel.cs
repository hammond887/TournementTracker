using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchingEntryModel
    {
        /// <summary>
        /// Rep one team in matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// rep score for team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// rep matchup for previous win
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
