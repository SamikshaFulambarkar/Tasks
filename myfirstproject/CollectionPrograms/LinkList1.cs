using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.CollectionPrograms
{
    class LinkList1
    // write code to create int type of list and display only even element from that list.
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            {
                18,
                5,
                25,
                36,
                77,
                12,
                30
            };
            for (int i = 0; i < li.Count; i++)
            {
                if (li[i] % 2 == 0)
                {
                    Console.Write(li[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
    class LinkList2
    // write code to create int type of list & display prime no. from the list.
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            {
                1,
                5,
                25,
                36,
                7,
                11,
                30,
                9,
                15,
                17
            };
            Console.WriteLine("Prime numbers in List :");
            for (int i = 0; i < li.Count; i++)
            {
                int counter = 1;
                for (int j = 2; j <= li[i] / 2; j++)
                {
                    if (li[i] % j == 0)
                    {
                        counter = 0;
                        break;
                    }
                }
                if (counter == 1)
                {
                    Console.Write(li[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
    class LinkList3
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            {
                18,
                5,
                25,
                36,
                77,
                12,
                30
            };
            for (int i = 0; i < li.Count; i++)
            {
                Console.Write(li[i] + " ");
            }
            Console.ReadKey();
        }
    }
    class LinkList4
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            {
                18,
                5,
                25,
                36,
                77,
                12,
                30
            };
            Console.WriteLine(li.Count);
            for (int i = 0; i < li.Count; i++)
            {
                Console.WriteLine(li[i]);
            }
            Console.WriteLine(".................");
            foreach (var x in li)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(li[1]);
            Console.ReadKey();
        }
    }
    class LinkList5
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            {
                18,
                5,
                25,
                36,
                77,
                12,
                30
            };
            li.Insert(1, 35);
            Console.WriteLine(".............");
            foreach (var x in li)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
    class LinkList6
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>()
            {
                "Samiksha",
                "Shreya",
                "Neha"
            };
            List<string> li2 = new List<string>()
            {
                "Pune",
                "Goa",
                "Nagpur",
            };
            li2.InsertRange(0, li);
            foreach (var x in li2)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
    class LinkList7
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            {
                18,
                5,
                25,
                36,
                77,
                12,
                30
            };
            li.Remove(77);
            foreach (var x in li)
            {
                Console.WriteLine(x);
            }
            li.RemoveAt(2);
            foreach (var x in li)
            {
                Console.WriteLine(x);
            }
            li.RemoveRange(0, 2);
            foreach (var x in li)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
    class LinkList8
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            {
                18,
                5,
                25,
                36,
                77,
                12,
                30
            };
            Console.WriteLine(li.Contains(36));

            List<int> li2 = new List<int>();
            li2.AddRange(li);
            foreach (var x in li2)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("................");
            Console.WriteLine(li.Count);
            li.Clear();
            Console.WriteLine(li.Count);
            Console.ReadKey();
        }
    }
    class LinkList9
    // Ascending Sort list
    {
        static void Main(string[] args)
        {
            int i, j, t;
            List<int> li = new List<int>()
            {
                18,
                5,
                25,
                36,
                77,
                12,
                30
            };
            Console.WriteLine("Before Sorting");
            foreach (var x in li)
            {
                Console.Write(x + " ");
            }
            for (i = 0; i < li.Count - 1; i++)
            {
                for (j = i + 1; j < li.Count; j++)
                {
                    if (li[i] > li[j])
                    {
                        t = li[i];
                        li[i] = li[j];
                        li[j] = t;
                    }
                }
            }
            Console.WriteLine("\nAfter Sorted list is:");
            for (i = 0; i < li.Count; i++)
            {
                Console.Write(li[i] + " ");
            }
            Console.ReadKey();
        }
    }
    class LinkList10
    // Descending Sort list
    {
        static void Main(string[] args)
        {
            int i, j, t;
            List<int> li = new List<int>()
            {
                18,
                5,
                25,
                36,
                77,
                12,
                30
            };
            Console.WriteLine("Before Sorting");
            foreach (var x in li)
            {
                Console.Write(x + " ");
            }
            for (i = 0; i < li.Count - 1; i++)
            {
                for (j = i + 1; j < li.Count; j++)
                {
                    if (li[i] < li[j])
                    {
                        t = li[i];
                        li[i] = li[j];
                        li[j] = t;
                    }
                }
            }
            Console.WriteLine("\nAfter Sorted list is:");
            for (i = 0; i < li.Count; i++)
            {
                Console.Write(li[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
