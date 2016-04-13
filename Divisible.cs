using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    public class Divisible
    {
        public Boolean DivisibleBy(int number)
        {
            if((number % 5 == 0) || (number % 7 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
