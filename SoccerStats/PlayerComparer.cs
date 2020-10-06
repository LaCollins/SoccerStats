using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SoccerStats
{
    public class PlayerComparer : IComparer<Player>
    {
        public int Compare(Player x, Player y)
        {
            return y.PointsPerGame.CompareTo(x.PointsPerGame);
        }
    }
}
