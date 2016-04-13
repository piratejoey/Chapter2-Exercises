using System;
using EvenOdd;
using ChessBoard;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main()

      {
            int number;

            //class instances
            Program program = new Program();
            Divisible divisible = new Divisible();
            ThirdDigit thirdDigit = new ThirdDigit();
            IntToBinary intToBinary = new IntToBinary ();
            
            //convert user input from string to number
            string input = Console.ReadLine();
            int.TryParse(input, out number);
            
            //output when calling method
            Console.WriteLine(intToBinary.FindBit(number));
            Console.ReadLine();
            Console.ReadLine();
        }

        public Boolean IsEven(int number)
        {
            if (number % 2 == 0)
                {
                return true;
                }
            else
            {
                return false;
            }
        }
        public string Answer(int number)
        {
            
            if (IsEven(number) == true)
            {
                return ("Even");
            }
            else
            {
                return ("Odd");
            }
        }

    }
}
