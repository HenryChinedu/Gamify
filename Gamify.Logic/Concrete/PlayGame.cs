using Gamify.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamify.Logic.Concrete
{
    public class PlayGame
    {
        private static int row = 7;
        private static int col = 0;
        
        public static void MoveUp()
        {
            row--;
            col = col;
            Printing.PrintOut(row, col);
        }

        public static void MoveDown()
        {
            row++;
            col = col;
            Printing.PrintOut(row, col);
        }
        public static void MoveLeft()
        {
            row = row;
            col--;
            Printing.PrintOut(row, col);
        }
        public static void MoveRight()
        {
            row = row;
            col++;
            Printing.PrintOut(row, col);
        }
    }
}
