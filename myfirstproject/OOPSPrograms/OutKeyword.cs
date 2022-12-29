using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.OOPSPrograms
{
    class OutKeyword
    {
        public static void arithmetic(int x, int y, out int a, out int s, out int m, out int d)
        {
            a = x + y;
            s = x - y;
            m = x * y;
            d = x / y;
        }
        static void Main(string[] args)
        {
            int a, b, add, sub, mul, div;
            Console.WriteLine("Enter first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b = int.Parse(Console.ReadLine());
            arithmetic(a, b, out add, out sub, out mul, out div);
            Console.WriteLine("Addition: " + add);
            Console.WriteLine("Subtraction: " + sub);
            Console.WriteLine("Multiplication: " + mul);
            Console.WriteLine("Division: " + div);
            Console.ReadKey();
        }
    }
}
