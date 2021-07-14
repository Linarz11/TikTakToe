using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe
{
    public class CLI
    {
        public static void PrintBoard()
        {
            for (int i=0; i<Board.board.Length; i++)
            {
                Console.Write($'{i}')
            }
        }

        public static void PrintWin()
        {
            if (Board.winX)
            {
                Console.WriteLine("Win X");

            }
            else if (Board.winO)
            {
                Console.WriteLine("Win 0");

            }
            else 
        }
    }

}
