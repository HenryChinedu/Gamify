using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamify.Model.Concrete
{
    public class BoardGame
    {     
        public static int[,] CreateBoard()
        {
            //my data structure takes the form of an 8 by 8  2 dimentional array populated by randomly generated numbers between 0 and 10
            //with this I take any cell with a "2" as containing a landmine
            Random rnd = new Random();

            int[,] matrix = new int[8, 8];      

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    matrix[row, col] = rnd.Next(10);
                }
            }
         
            return matrix;
        }   
    }
}
