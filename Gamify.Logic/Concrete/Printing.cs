using Gamify.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamify.Logic.Concrete
{
    public class Printing
    {
        static int[,] lab = BoardGame.CreateBoard();
        private static int mine = 0;

        public static void PrintOut(int row, int col)
        {
            Console.WriteLine();

            Console.Write("Your current position is: Matrix[{0},{1}]", row, col);
            Console.WriteLine();

            if (lab[row, col] == 2)
            {
                Console.WriteLine("You have just hit a Landmine");
                mine++;
                Console.WriteLine("The total number of landmines hit so far is {0}", mine);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You did not  hit any Landmine!");
                Console.WriteLine("The total number of landmines hit so far is {0}", mine);
            }
            Console.WriteLine();

            if ((row == 0) && (mine > 2))
            {
                Console.WriteLine("Game over!");
                Console.WriteLine("You lost the game, better luck next time");
             
            }
            else if ((row == 0) && (mine <= 2))
            {
                Console.WriteLine("Game over!");
                Console.WriteLine("Congratulations, You won the game");
            }
            else if ((row > 0) && (mine <= 2))
            {
                Console.WriteLine("Its game on!");
            }
            else if ((row > 0) && (mine > 2))
            {
                Console.WriteLine("Game over!");
                Console.WriteLine("You lost the game, You have hit more than two landmines");
            }
            Console.WriteLine();
        }
    }
}
