using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.Loops_Conditional
{
    class ClassTask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
                int r = num % 10;
                if (r % 2 != 0)
                {
                    sum = sum + r;
                }
                num = num / 10;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
    class ClassTask_1
        // check whether palindrome or not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0, temp, r;
            temp = num;
            while (num > 0)
            {
                r = num % 10;
                sum = (sum * 10) + r;
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("palindrome number");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
            Console.ReadKey();
        }
    }
    class ClassTask_3
        // Tables
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
    class ClassTask_4
        // check whether prime no. or not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            if (num == 0 || num == 1)
                count = 1;
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        count = 1;
                        break;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("prime number");
            }
            else
            {
                Console.WriteLine("not prime number");
            }
            Console.ReadKey();
        }
    }
    class ClassTask_5
    {
        static void Main(string[] args)
        {
            int i, num = 1, count;
            while (num <= 100)
            {
                count = 0;
                i = 2;
                while (i <= num / 2)
                {
                    if (num % i == 0)
                    {
                        count++;
                        break;
                    }
                    i++;
                }
                if (count == 0 && num != 1)
                {
                    Console.WriteLine(num);
                }
                num++;
            }
            Console.ReadKey();
        }
    }
    class Percentage
    {
        static void Main(string[] args)
        {
            int eng, math, phy, chem, bio, total;
            double avg;
            eng = 75;
            math = 89;
            phy = 72;
            chem = 76;
            bio = 84;
            total = eng + math + phy + chem + bio;
            Console.WriteLine("Total of 5 Subjects=" + total);
            avg = total / 5;
            Console.WriteLine("\n Average of 5 Subjects=" + avg);
            Console.WriteLine("\nPercentage of 5 subject=" + avg + "%");
            Console.ReadKey();
        }
    }
    class Simple_Interest
    {
        static void Main(string[] args)
        {
            int P, R, T;
            double SI;
            P = 3600;
            R = 7;
            T = 5;
            SI = (P * R * T) / 100;
            Console.WriteLine("SI=" + SI);
            Console.ReadKey();
        }
    }

    class Conversion
    {
        static void Main(string[] args)
        {
            int cm;
            double m, km;
            cm = 6540;
            m = 6540 / 100;
            km = 6540 / 100000;
            Console.WriteLine("Enter Length in cm=" + cm + "cm");
            Console.WriteLine("\n Convert cm to m=" + m + "m");
            Console.WriteLine("\n Convert cm to km=" + km + "km");
            Console.ReadKey();
        }
    }

    class Convert_Demo
    {
        static void Main(string[] args)
        {
            int C;
            double F;
            C = 20;
            F = (C * 1.8) + 32;
            Console.WriteLine("Enter the temperature in celcius=" + C + "C");
            Console.WriteLine("\nConvert Celcius to Fahrenheit=" + F + "F");
            Console.ReadKey();
        }
    }

    class Convert_2
    {
        static void Main(string[] args)
        {
            int F;
            double C;
            F = 80;
            C = (F - 32) * 0.5556;
            Console.WriteLine("Enter the temperature in Fahrenheit=" + F + "F");
            Console.WriteLine("\nConvert Fahrenheit to celcius=" + C + "C");
            Console.ReadKey();
        }
    }

    class Convert_3
    {
        static void Main(string[] args)
        {
            int ndays, year, week, days, Days_in_week;
            Days_in_week = 7;
            Console.WriteLine("Enter the number of days");
            ndays = int.Parse(Console.ReadLine());
            year = ndays / 365;
            week = (ndays % 365) / Days_in_week;
            days = (ndays % 365) % Days_in_week;
            Console.WriteLine("{0} is equivalent to {1}years , {2}weeks and {3}days", ndays, year, week, days);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
