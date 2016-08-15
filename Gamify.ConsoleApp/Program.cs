using Gamify.Logic.Concrete;
using Gamify.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gamify.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You can use U, D, L or R to move your piece up, down, left, or right.");
            Console.WriteLine("Press Enter after pressing the key.");
            while (true)
            {
                string e = Console.ReadLine().ToUpper();

                if (e == "U")
                {
                    PlayGame.MoveUp();
                }
                else if (e == "D")
                {
                    PlayGame.MoveDown();
                }

                else if (e == "L")
                {
                    PlayGame.MoveLeft();
                }
                else if (e == "R")
                {
                    PlayGame.MoveRight();
                }
                else
                {
                    Console.WriteLine("Wrong Move! You can use U, D, L or R to move your piece up, down, left, or right.");
                }
            }
        }
    }
}
