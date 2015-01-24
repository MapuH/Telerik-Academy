using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.WriteLine("Please, enter an integer: ");
            string input = Console.ReadLine();
            bool thirdDigit;

            if (input.Length < 3)
            {
                thirdDigit = false;
            }
            else
            {
               thirdDigit = input[(input.Length - 3)] == '7';
            }

            Console.WriteLine(thirdDigit);
        }
    }
}
