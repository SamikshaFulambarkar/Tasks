using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.All_Assignments
{
    class HomeWork
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 5 Subjects Name");
            Console.WriteLine("Eng = ");
            int Eng = int.Parse(Console.ReadLine());
            Console.WriteLine("Math = ");
            int Math = int.Parse(Console.ReadLine());
            Console.WriteLine("Phy = ");
            int Phy = int.Parse(Console.ReadLine());
            Console.WriteLine("Chem = ");
            int Chem = int.Parse(Console.ReadLine());
            Console.WriteLine("Bio = ");
            int Bio = int.Parse(Console.ReadLine());
            Console.WriteLine((Eng + Math + Phy + Chem + Bio) / 5 + "%");
            int Per = int.Parse(Console.ReadLine());
            if (Per > 70)
            {
                Console.WriteLine("Distinction");
            }
            else if (Per >= 60 && Per <= 70)
            {
                Console.WriteLine("First Class");
            }
            else if (Per >= 50 && Per <= 60)
            {
                Console.WriteLine("Second Class");
            }
            else if (Per >= 35 && Per < 50)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            Console.ReadKey();
        }
    }

    class HW_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your friend age");
            int FAge = int.Parse(Console.ReadLine());
            if (Age > FAge)
            {
                Console.WriteLine("Hi");
            }
            else if (Age < FAge)
            {
                Console.WriteLine("Good Morning");
            }
            else
            {
                Console.WriteLine("How are you?");
            }
            Console.ReadKey();
        }
    }

    class HW_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num % 3 == 0 && num % 9 == 0)
            {
                Console.WriteLine("Divisible by 3 & 9");
            }
            else if (num % 3 != 0 && num % 9 != 9)
            {
                Console.WriteLine(" not divisible by 3 & 9");
            }
            else
            {
                Console.WriteLine("Divisible by 3");
            }
            Console.ReadKey();
        }
    }
}
