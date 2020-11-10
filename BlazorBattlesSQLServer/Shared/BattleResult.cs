﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBattlesSQLServer.Shared
{
    public class BattleResult
    {
        public IList<string> Log { get; set; } = new List<string>();
        public int AttackerDamageSum { get; set; }
        public int OpponentDamageSum { get; set; }
        public bool IsVictory { get; set; }
        public int RoundsFought { get; set; }
    }
}

