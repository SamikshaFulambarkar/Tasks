using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.PropertyPrograms
{
    class StudentD
    {
        int Sid;
        String name;
        int Phy;
        int Chem;
        int Bio;
        double per;
        public void Accept_Details(int Id, string sname, int P, int C, int B)
        {
            Sid = Id;
            name = sname;
            Phy = P;
            Chem = C;
            Bio = B;
        }
        public void Percentage(int P, int C, int B)
        {
            per = (P + C + B) / 3;
            Console.WriteLine("Percentage=" + per + "%");
        }
        public void Display()
        {
            Console.WriteLine(Sid + " " + name + " " + Phy + " " + Chem + " " + Bio + " " + per);
        }
        static void Main(string[] args)
        {
            StudentD Ms = new StudentD();
            Ms.Accept_Details(26, "Shreya", 75, 82, 86);
            Ms.Percentage(75, 82, 86);
            Ms.Display();
            Console.ReadKey();
        }
    }
    class Shopping
    {
        String Pname;
        int Quantity;
        int Price;
        int Bill;
        public void Accept_Details(string name, int Q, int P, int B)
        {
            Pname = name;
            Quantity = Q;
            Price = P;
            Bill = B;
        }
        public void Calculate_Bill(int Q, int B)
        {
            if (Q > 0)
            {
                Console.WriteLine("Bill=" + B);
            }
            else
            {
                Console.WriteLine("Error Message");
            }
        }
        public void Display()
        {
            Console.WriteLine(Pname + " " + Quantity + " " + Price + " " + Bill);
        }
        static void Main(string[] args)
        {
            Shopping Sg = new Shopping();
            Sg.Accept_Details("JeansTop", 2, 1050, 997);
            Sg.Calculate_Bill(2, 997);
            Sg.Display();
            Console.ReadKey();
        }
    }
    class Parameter
    {
        int i;
        public void Factors(int num)
        {
            int sum = 0;
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }
                Console.WriteLine(sum);
            }
        }
        static void Main(string[] args)
        {
            Parameter P = new Parameter();
            P.Factors(12);
            Console.ReadKey();
        }
    }
}
