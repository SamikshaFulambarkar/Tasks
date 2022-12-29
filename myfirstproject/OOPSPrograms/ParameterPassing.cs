using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.OOPSPrograms
{
    class ParameterPassing
    {
        /*int a, b;
        public ParameterPassing()
        {
            a = b = 0;
        }
        public ParameterPassing(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Display()
        {
            Console.WriteLine("First : "+a+" Second : "+b);
        }*/
        static void Swap(int x, int y)
        {
            int t = x;
            x = y;
            y = t;
            Console.WriteLine("Inside function : First: " + x + " Second: " + y);
        }
        static void Swap1(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
            Console.WriteLine("Inside function : First: " + x + " Second: " + y);
        }
        public static void CallByRef(double r, ref double a, ref double p)
        {
            a = 3.14 * r * r;
            p = 2 * 3.14 * r;
        }
        static void Main(string[] args)
        {
            // ParameterPassing P = new ParameterPassing(4, 7);
            /*int a = 8, b = 4;
            Console.WriteLine("Call by Value");
            Console.WriteLine("Before function: First: " + a + " Second: " + b);
            Swap(a, b);
            Console.WriteLine("After function: First: " + a + " Second: " + b);
            Console.WriteLine("\nCall by Reference");
            Console.WriteLine("Before function: First: "+a+" Second: "+b);
            Swap1(ref a, ref b);
            Console.WriteLine("After function: First: "+a+" Second: "+b);*/
            double r = 2.5, area = 0.0, perimeter = 0.0;
            CallByRef(r, ref area, ref perimeter);
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
            Console.ReadKey();
        }
    }
    class Age
    {
        public static void AcceptAge(ref int age, int year)
        {
            age = year + age;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year");
            int year = int.Parse(Console.ReadLine());
            AcceptAge(ref age, year);
            Console.WriteLine("Age" + age);
            Console.ReadKey();
        }
    }
}
