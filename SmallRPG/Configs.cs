using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallRPG
{
    internal struct Configs
    {
        public static readonly int[] LEVELS_EXP = { 0, 300, 600, 1000, 1500, 2000, 2800, 3500 };
        public static readonly int MAX_LEVEL = LEVELS_EXP.Length;
        public static readonly int MAX_EXP = LEVELS_EXP[MAX_LEVEL - 1];
        public static readonly int MAX_HP = int.MaxValue;

        public static readonly int PLAYER_EXP = 0;
        public static readonly int RAT_EXP = 30;
    }
}
