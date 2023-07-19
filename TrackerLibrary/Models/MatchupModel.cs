﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        public List<MatchingEntryModel> Entries { get; set; } = new List<MatchingEntryModel>();

        public TeamModel Winner { get; set; }
        public int MatchingRound { get; set; }
    }
}