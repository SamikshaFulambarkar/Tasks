using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.Loops_Conditional
{
    class SwitchCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Monday\n2.Tuesday\n3.Wednesday\n4.Thursday\n5.Friday\n6.Saturday\n7.Sunday");
            Console.WriteLine("Enter the choice from above menu");
            int days = int.Parse(Console.ReadLine());
            switch (days)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.ReadKey();
        }
    }

    class SwitchCase_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C.Area of Circle\nR.Area of Rectangle\nS.Area of Square\nT.Area of Triangle");
            Console.WriteLine("Enter the char from above menu");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
