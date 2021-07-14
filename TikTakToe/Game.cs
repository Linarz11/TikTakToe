using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe
{
   public static class Game
    {
        public static bool CheckMove(Board board, int position)
        {
            return Board.board[position] != 'X' || Board.board[position] != '0';

        }


    }
}
