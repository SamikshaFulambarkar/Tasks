using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.All_Assignments
{
    class Assignment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year");
            int y = int.Parse(Console.ReadLine());
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                Console.WriteLine(y + "is a leap year");
            }
            else
            {
                Console.WriteLine(y + "is not a leap year");
            }
            Console.ReadKey();
        }
    }

    class Assignment_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            if ((num % 5 == 0) && (num % 11 == 0))
            {
                Console.WriteLine("Divisible by 5 & 11 ");
            }
            else
            {
                Console.WriteLine("is neither divisible by 5 nor 11");
            }
            Console.ReadKey();
        }
    }

    class Assignment_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the three numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int max = 0;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    max = num1;
                }
                else
                {
                    max = num3;
                }
            }
            else if (num2 > num3)
            {
                max = num2;
            }
            else
            {
                max = num3;
            }
            Console.WriteLine("Greater number is =" + max);
            Console.ReadKey();
        }
    }

    class Assignment_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the character");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + " is an uppercase vowel");
            }
            else if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine(ch + "is lowercase vowel");
            }
            else
            {
                Console.WriteLine(ch + "is a consonant");
            }
            Console.ReadKey();
        }
    }


}
