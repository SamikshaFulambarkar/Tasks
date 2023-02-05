using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.MidTest
{
    class Mocktest1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            bool isprime = false;
            int count = 0;
            int sum = 0;
            double Average;
            while (num > 0)
            {
                int digit = num % 10;
                num = num / 10;
                for (int i = 2; i < digit; i++)
                {
                    if (digit % i != 0)
                    {
                        isprime = true;
                        break;
                    }
                }
                if (isprime)
                {
                    count++;
                    sum = sum + digit;
                }
            }
            Average = sum / count;
            Console.WriteLine(Average);

            Console.ReadKey();
        }
    }
    class prime_no
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i=1; i<=num; i++)
            {
                if(num%i==0)
                {
                    count++;
                }
            }
            if(count==2)
            {
                Console.WriteLine("prime no");
            }
            else
            {
                Console.WriteLine("Not prime number");
            }
            Console.ReadKey();
        }
    }
    // Create a list of employee and increment the salary of those employee whose salary is less than 15000
    class EmpList
    {
        public int ID;
        public string NAME;
        public int SALARY;

        public EmpList(int ID, string NAME, int SALARY)
        {
            this.ID = ID;
            this.NAME = NAME;
            this.SALARY = SALARY;
        }

        static void Main(string[] args)
        {
            List<EmpList> li = new List<EmpList>();
            li.Add(new EmpList(10, "Ankita", 12000));
            li.Add(new EmpList(20, "Shreya", 18000));
            li.Add(new EmpList(30, "Snehal", 11000));
            li.Add(new EmpList(40, "Pooja", 16000));
            li.Add(new EmpList(50, "Priyanka", 20000));
            foreach(EmpList e in li)
            {
                if(e.SALARY<15000)
                {
                    e.SALARY = (int)(e.SALARY + (e.SALARY * 0.10f));
                }
            }
            foreach (EmpList e in li)
            {
                Console.WriteLine(e.ID+"  "+e.NAME+"  "+e.SALARY);
            }
            Console.ReadKey();
        }
    }
}
