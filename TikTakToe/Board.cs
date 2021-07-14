using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe
{
    public static class Board
    {
        public static char[] board = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static bool draw = false;
        public static bool winX = false;
        public static bool winO = false;
    }
}
