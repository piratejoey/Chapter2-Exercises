using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// provides you with the 3rd from the last digit of your input
/// </summary>
namespace EvenOdd
{
    class ThirdDigit
    {
        public string Reverse(int number)
        {
            //convert number to a string named strNumber
            string strNumber = number.ToString();
            //get string length
            int i = strNumber.Length;
            //take Substring of string that consists of (length of string - 3, length of output)
            string reverse = strNumber.Substring(i - 3,1);
            return reverse;
        }
    }
}
