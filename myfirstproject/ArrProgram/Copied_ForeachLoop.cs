using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.ArrProgram
{
    class Copied_ForeachLoop
    {
        static void Main(string[] args)
        {
            int[] List = { 34, 72, 13, 44, 25, 30, 10 };
            Console.WriteLine("Length of array is:" + List.Length);

            int[] temp = List;
            int[] t = new int[List.Length];
            Array.Copy(List, t, List.Length);
            Console.Write("Copied Array:");
            foreach (int i in t)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
    class Copied_from_second_Arr
    {
        static void Main(string[] args)
        {
            int[] List = { 34, 72, 13, 44, 25, 30, 10 };
            Console.WriteLine("Lenth of array is:" + List.Length);

            int[] temp = List;
            int[] t = { 1, 2, 0, 0, 0, 0, 0 };
            Array.Copy(List, 2, t, 2, 5);
            Console.Write("Array:");
            foreach (int i in t)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
    class reversed_Method_Arr
    {
        static void Main(string[] args)
        {
            int[] List = { 34, 72, 13, 44, 25, 30, 10 };
            Console.WriteLine("Length of array is:" + List.Length);
            int[] temp = List;
            Console.WriteLine("\n Original Array:");
            foreach (int i in List)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Array.Reverse(temp);
            Console.Write("Reversed Array:");
            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    class Sorted_Method_Arr
    {
        static void Main(string[] args)
        {
            int[] List = { 34, 72, 13, 44, 25, 30, 10 };
            Console.WriteLine("Length of array is:" + List.Length);
            int[] temp = List;
            Console.WriteLine("\n Original Array:");
            foreach (int i in List)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Array.Sort(List);
            Console.Write("Sorted Array:");
            foreach (int i in List)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    class Index_method_Arr
    {
        static void Main(string[] args)
        {
            int[] List = { 34, 72, 13, 44, 25, 30, 10 };
            Console.WriteLine("Length of array is:" + List.Length);
            int Index = Array.IndexOf(List, 44);
            Console.WriteLine("Index of element 44 is:" + Index);
            Console.ReadKey();
        }
    }
    class Clear_Method_Arr
    {
        static void Main(string[] args)
        {
            int[] List = { 34, 72, 13, 44, 25, 30, 10 };
            Console.WriteLine("Length of array is:" + List.Length);
            int[] temp = List;
            Console.WriteLine("Array:");
            foreach (int i in List)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Array.Clear(List, 3, 3);
            Console.Write("Cleared Array:");
            foreach (int i in List)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    class Method_Equal_Arr
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3, 4, 5 };
            int[] a2 = a1;

            if (Array.Equals(a1, a2))
                Console.WriteLine("Array are equal");
            else
                Console.WriteLine("Array not equal");
            Console.ReadKey();
        }
    }
}
