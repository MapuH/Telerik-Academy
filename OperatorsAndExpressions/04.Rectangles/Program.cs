using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("Please, enter width of the rectangle:");
            string input = Console.ReadLine();
            double width = Convert.ToDouble(input);

            Console.WriteLine("Please, enter height of the rectangle:");
            input = Console.ReadLine();
            double height = Convert.ToDouble(input);

            double perimeter = (width + height) * 2;
            double area = width * height;

            Console.WriteLine("This rectangle has a perimeter {0} and its area is {1}.", perimeter, area);
        }
    }
}
