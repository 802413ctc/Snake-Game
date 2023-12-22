using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    public static class GameSettings
    {
        public static int BoostSpeed { get; set; } = 50;
        public static double WallDensity { get; set; } = .03;
        public static bool WallFatality { get; set; } = true;
    }
}
