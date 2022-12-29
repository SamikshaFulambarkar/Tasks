using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.Loops_Conditional
{
    class Loops
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }

    class Loops_1
    {
        static void Main(string[] args)
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }

    class Loops_2
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 20; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }

    class Loops_3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }

    class Loops_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the exponent number");
            int num2 = int.Parse(Console.ReadLine());
            int power = 1;
            for (int i = 1; i <= num2; i++)
            {
                Console.WriteLine(power = power * num1);
            }
            Console.ReadKey();
        }
    }

    class Loops_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
            Console.ReadKey();
        }
    }
}
