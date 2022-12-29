using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace myfirstproject.CollectionPrograms
{
    class ArrList1
    // write code to display even position element from the array list
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Pune");
            al.Add(86);
            al.Add(82.20);
            al.Add('S');
            al.Add("Samiksha");
            al.Add(23);
            al.Add("Maharashtra");
            int count = 0;
            Console.WriteLine("Display even position element from the arraylist :");
            for (int i = 0; i < al.Count; i = i + 2)
            {
                Console.Write(al[i] + "   ");
                count++;
            }
            Console.WriteLine("\n" + count);
            Console.ReadKey();
        }
    }
    class SortStringArr1
    // Ascending Sorting
    {
        static void Main(string[] args)
        {
            int i, j;
            string t;
            Console.WriteLine("Enter size for array:");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter string array:");
            string[] str = new string[s];
            for (i = 0; i < s; i++)
            {
                str[i] = Console.ReadLine();
            }
            for (i = 0; i < s; i++)
            {
                for (j = 0; j < s - 1; j++)
                {
                    if (str[j].CompareTo(str[j + 1]) > 0)
                    {
                        t = str[j];
                        str[j] = str[j + 1];
                        str[j + 1] = t;
                    }
                }
            }
            Console.WriteLine("Sorted string array is:");
            for (i = 0; i < s; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.ReadKey();
        }
    }
    class SortStringArr2
    // Descending Sorting
    {
        static void Main(string[] args)
        {
            int i, j;
            string t;
            Console.WriteLine("Enter size for array:");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter string array:");
            string[] str = new string[s];
            for (i = 0; i < s; i++)
            {
                str[i] = Console.ReadLine();
            }
            for (i = 0; i < s; i++)
            {
                for (j = 0; j < s - 1; j++)
                {
                    if (str[j + 1].CompareTo(str[j]) > 0)
                    {
                        t = str[j + 1];
                        str[j + 1] = str[j];
                        str[j] = t;
                    }
                }
            }
            Console.WriteLine("Sorted string array is:");
            for (i = 0; i < s; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.ReadKey();
        }
    }
    class ArrayList2
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Pune");
            al.Add(86);
            al.Add(82.20);
            al.Add('S');
            al.Add("Samiksha");
            al.Add(23);
            al.Add("Maharashtra");
            Console.WriteLine(al.Count);
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
            Console.WriteLine(".................");
            foreach (var x in al)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(al[1]);
            Console.ReadKey();
        }
    }
    class ArrayList3
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Pune");
            al.Add(86);
            al.Add(82.20);
            al.Add('S');
            al.Add("Samiksha");
            al.Add(23);
            al.Add("Maharashtra");
            al.Insert(1, "Goa");
            Console.WriteLine(".............");
            foreach (var x in al)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
    class ArrayList4
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Pune");
            al.Add(86);
            al.Add(82.20);
            al.Add('S');
            al.Add("Samiksha");
            al.Add(23);
            al.Add("Maharashtra");

            ArrayList al2 = new ArrayList();
            al2.Add("Wardha");
            al2.Add(56);
            al2.Add(89.50);
            al2.InsertRange(0, al);
            foreach (var x in al2)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
    class ArrayList5
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Pune");
            al.Add(86);
            al.Add(82.20);
            al.Add('S');
            al.Add("Samiksha");
            al.Add(23);
            al.Add("Maharashtra");

            al.Remove('S');
            foreach (var x in al)
            {
                Console.WriteLine(x);
            }
            al.RemoveAt(2);
            foreach (var x in al)
            {
                Console.WriteLine(x);
            }
            al.RemoveRange(0, 2);
            foreach (var x in al)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
    class ArrayList6
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Pune");
            al.Add(86);
            al.Add(82.20);
            al.Add('S');
            al.Add("Samiksha");
            al.Add(23);
            al.Add("Maharashtra");
            Console.WriteLine(al.Contains(86));

            ArrayList al2 = new ArrayList();
            al2.AddRange(al);
            foreach (var x in al2)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("................");
            Console.WriteLine(al.Count);
            al.Clear();
            Console.WriteLine(al.Count);
            Console.ReadKey();
        }
    }
}
