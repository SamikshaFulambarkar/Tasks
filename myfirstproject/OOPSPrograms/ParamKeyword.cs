using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.OOPSPrograms
{
    class ParamKeyword
    {
        public static void Add(params int[] nos)
        {
            int sum = 0;
            foreach (int n in nos)
                sum = sum + n;
            Console.WriteLine("Addition of " + nos.Length + " Parameters is " + sum);
        }
        public static void AddName(params string[] names)
        {
            string s = "";
            foreach (string str in names)
                s = s + str;
            Console.WriteLine("Concatinates string is " + s);
        }
        static void Main(string[] args)
        {
            Add();
            Add(1, 2);
            Add(1, 2, 3);
            Add(1, 2, 3, 4, 5);
            Add(1, 2, 3, 12, 50, 18, 10);
            AddName("Hello");
            Console.ReadKey();
        }
    }
    class ParamKeyword2
    {
        public static void Add(params int[] nos)
        {
            int sum = 0;
            foreach (int n in nos)
                sum = sum + n;
            int Avg = sum / nos.Length;
            Console.WriteLine("Average " + Avg);
        }
        static void Main(string[] args)
        {
            Add(1, 2);
            Add(1, 2, 3);
            Add(1, 2, 3, 4, 5);
            Add(1, 2, 3, 12, 50, 18, 10);
            Console.ReadKey();
        }
    }
}
