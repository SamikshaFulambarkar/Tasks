using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.Loops_Conditional
{
    class DemoClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age");
            int age = int.Parse(Console.ReadLine());
            if ((age < 19) && (age > 13))
            {
                Console.WriteLine("Teenager");
            }
            else
            {
                Console.WriteLine("Not");
            }
            Console.ReadKey();
        }
    }
    class Automorphic_no
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any num");
            int num = int.Parse(Console.ReadLine());
            int sqr = 1, count = 0;
            int temp = num;
            while (num > 0)
            {
                int digit = num % 10;
                count++;
                num = num / 10;
            }
            Console.WriteLine(count);
            num = temp;
            int power = 1;
            int Base = 10;
            sqr = num * num;
            for (int i = 1; i <= count; i++)
            {
                power = power * Base;
            }
            int last = sqr * power;
            if (num == last)
            {
                Console.WriteLine("Automorphic no.");
            }
            else
            {
                Console.WriteLine("Not automorphic no.");
            }
            Console.ReadKey();
        }
    }
    class Kaprekar_no
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any num");
            int num = int.Parse(Console.ReadLine());
            int count = 0, sum = 0;
            int temp = num;
            int sqr = num * num;
            {
                Console.WriteLine(sqr);
            }
            while (num > 0)
            {
                count++;
            }
            Console.WriteLine(count);
            num = temp;
            int power = 1;
            int Base = 10;
            for (int i = 1; i <= count; i++)
            {
                power = power * Base;
            }
            int digit = num % 10;
            int a = sum + digit;
            if (num == a)
            {
                Console.WriteLine("Kaprekar no.");
            }
            else
            {
                Console.WriteLine("Not Kaprekar no.");
            }
            Console.ReadKey();
        }
    }
    class harshad_no
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any num");
            int num = int.Parse(Console.ReadLine());
            int rem = 0, sum = 0;
            int temp = num;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            if (temp % sum == 0)
            {
                Console.WriteLine("Harshad no.");
            }
            else
            {
                Console.WriteLine("Not harshad no.");
            }
            Console.ReadKey();
        }
    }
    class plus_pattern
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == ((5 / 2) + 1))
                {
                    Console.Write("+");
                }
                else
                {
                    for (int j = 1; j <= 5 / 2; j++)
                        Console.Write(" ");
                    Console.Write("+");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
    class series_1
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = (sum * 10) + 1;
                int t = sum + 10;
                Console.Write(" ");
                Console.Write(sum);
            }
            Console.Write(" ");
            Console.ReadKey();
        }
    }
    class demo_12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                if (num > 2 && num < 8)
                {
                    Console.WriteLine("green color");
                }
                else
                {
                    Console.WriteLine("red color");
                }
            }
            else
            {
                if (num > 8)
                {
                    Console.WriteLine("white color");
                }
                else
                {
                    Console.WriteLine("black color");
                }
            }
            Console.ReadKey();
        }
    }
    class combo_pattern
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                if (i % 2 == 0)
                {
                    char ch = 'A';
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(ch);
                        ch++;
                    }
                }
                else
                {
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(k);
                    }
                }
            }
            Console.WriteLine(" ");
            Console.ReadKey();
        }
    }
    class Trimorphic
    {
        static void Main(string[] args)
        {
            int cube, LD;
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            cube = num * num * num;
            LD = cube % 10;
            if (num == LD)
            {
                Console.WriteLine("Trimorphic");
            }
            else
            {
                Console.WriteLine("Not Trimorphic");
            }
            Console.ReadKey();
        }
    }
    class Average
    {
        static void Main(string[] args)
        {
            int x = 0;
            int sum = 0;
            int count = 0;
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                x = num % 10;
                num = num / 10;
                Console.WriteLine(num);
                sum = sum + num;
                count++;
            }
            Console.WriteLine(sum);
            Console.WriteLine(count);
            Console.WriteLine("Average" + (sum / count));
            Console.ReadKey();
        }
    }
    class Table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any num");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num * i);
            }
            Console.ReadKey();
        }
    }
}
