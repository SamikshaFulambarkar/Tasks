using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.Loops_Conditional
{
    class Condition_Check
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
            Console.ReadKey();
        }
    }

    class Condition_Check1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("number is positive");
            }
            else if (num == 0)
            {
                Console.WriteLine("number is zero");
            }
            else
            {
                Console.WriteLine("number is negative");
            }
            Console.ReadKey();
        }
    }

    class Condition_Check2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + "is an Alphabet");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + "is a Digit");
            }
            else
            {
                Console.WriteLine(ch + "is a Special Character");
            }
            Console.ReadKey();
        }
    }
}
