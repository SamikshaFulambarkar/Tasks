using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.All_Assignments
{
    class Assgn_3_1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 5 == 0) || (i % 10 == 0))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
    class Assgn_3_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
    class Assgn_3_3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Even no.=" + i);
                }
                else
                {
                    Console.WriteLine("Odd no.=" + i * i);
                }
            }
            Console.ReadKey();
        }
    }
    class Assgn_3_4
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, trm;
            for (int i = 0; i <= 20; i++)
            {
                trm = a + b;
                Console.Write(trm + " ");
                a = b;
                b = trm;
            }
            Console.Write("\n");
            Console.ReadKey();
        }
    }
    class Assgn_3_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            int rem = 0, sum = 0, n;
            n = num;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            if (n % sum == 0)
            {
                Console.WriteLine(n + "is a Harshad Number");
            }
            else
            {
                Console.WriteLine(n + "is not a Harshad Number");
            }
            Console.ReadKey();
        }
    }
    class Assgn_3_6
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.Write("3&5=RedBlue");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("3=red");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("5=blue");
                }
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
    class Order
    {
        public int Order_Id;
        public String City_name;
        public String Cust_name;
        static void Main(string[] args)
        {
            Order O1 = new Order();
            O1.Order_Id = 147;
            O1.City_name = "Pune";
            O1.Cust_name = "Shreya Sharma";
            Console.WriteLine("Order No.=" + O1.Order_Id + " " + "City name=" + O1.City_name + " " + "Customer name=" + O1.Cust_name);
            Console.WriteLine("is delivered");
            Console.ReadKey();
        }
    }
    class Assgn_3_8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = num;
            while (num > 0)
            {
                int n = num % 10;
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                num = num / 10;
            }
            Console.WriteLine(sum);
            if (temp == sum)
            {
                Console.WriteLine("Krishnamurthy Number");
            }
            else
            {
                Console.WriteLine("Not Krishnamurthy Number");
            }
            Console.ReadKey();
        }
    }
}
