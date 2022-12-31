using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.DelegatesProgram
{
    public delegate T allareas<T>(T param1);
    class GenericDelDemo
    {
        public static double AreaOfCircle(double r)
        {
            return 3.14 * r * r;
        }
        public static int AreaOfSquare(int side)
        {
            return side * side;
        }

        static void Main(string[] args)
        {
            allareas<double> aoc = GenericDelDemo.AreaOfCircle;
            Console.WriteLine("Area of Circle :");
            Console.WriteLine(aoc(2.6));
            allareas<int> aos = GenericDelDemo.AreaOfSquare;
            Console.WriteLine("Area of Square :");
            Console.WriteLine(aoc(2.6));
            Console.ReadKey();
        }
    }
    public delegate T add<T>(T param1, T param2);
    class GenericDelDemo2
    {
        public static int Addition(int x, int y)
        {
            return x + y;
        }
        public static string JoinString(string fname, string lname)
        {
            return fname + "  " + lname;
        }
        static void Main(string[] args)
        {
            add<int> sum = GenericDelDemo2.Addition;
            Console.WriteLine("Sum :");
            Console.WriteLine(sum(23, 56));
            add<string> fullname = GenericDelDemo2.JoinString;
            Console.WriteLine("Name :");
            Console.WriteLine(fullname.Invoke("Samiksha", "Agarkar"));
            Console.ReadKey();
        }
    }
}
