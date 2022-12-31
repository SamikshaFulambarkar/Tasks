using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace myfirstproject.All_Assignments
{
    class TaskCollectionArrayList1
    // 1.WAP to add elements to and print content of it where Integer is used. In the second arraylist String is used.
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(82);
            al.Add(86);
            al.Add(75);
            al.Add(25);
            al.Add(59);

            ArrayList al2 = new ArrayList();
            al2.Add("Pune");
            al2.Add("Nagpur");
            al2.Add("Goa");
            al2.Add("Chennai");
            al2.Add("Banglore");
            al2.InsertRange(4, al);
            foreach (var x in al2)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
    class TaskCollectionArrayList2
    /*  2.WAP to add elements to arraylist  0th location keep Integer,
         1st location String now print each element and display contents. */
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(86);
            al.Add("Pune");
            al.Add(82.20);
            al.Add('S');
            al.Add("Samiksha");
            al.Add(23);
            al.Add("Maharashtra");
            al.Insert(0, 82);
            al.Insert(1, "Shreya");
            foreach (var x in al)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
    class TaskCollectionArrayList3
    // 3. WAP to create a new ArrayList, add some colors (string) and print the collection.
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Yellow");
            al.Add("Pink");
            al.Add("Red");
            al.Add("Green");
            al.Add("Black");
            al.Add("White");
            al.Add("Voilet");
            al.Add("Indigo");
            al.Add("Orange");
            al.Add("Gray");
            foreach (var x in al)
            {
                Console.Write(x + "  ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    class TaskCollectionArrayList4
    // 4.WAP of swap two elements in an ArrayList
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Yellow");
            al.Add("Pink");
            al.Add("Red");
            al.Add("Green");
            al.Add("Black");
            al.Add("White");
            al.Add("Voilet");
            var temp1 = al[0];
            al[0] = al[1];
            al[1] = temp1;
            var temp2 = al[2];
            al[2] = al[3];
            al[3] = temp2;
            foreach (var x in al)
            {
                Console.Write(x + "  ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    class TaskCollectionArrayList5
    // 5.WAP to replace the second element of an ArrayList with the specified element
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(86);
            al.Add("Pune");
            al.Add(82.20);
            al.Add('S');
            al.Add("Samiksha");
            al.Add(23);
            al.Add("Maharashtra");
            al.Remove('S');
            al.Insert(3, 82);
            foreach (var x in al)
            {
                Console.Write(x + "  ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    class TaskCollectionList6
    // 6.WAP to create a List of Students and iterate over it.
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            Console.WriteLine("Enter the Student Name in list :");
            for (int i = 1; i <= 5; i++)
            {
                string s = Console.ReadLine();
                li.Add(s);
            }
            Console.WriteLine();
            li.ForEach(c => Console.Write(c + "  "));
            Console.ReadKey();
        }
    }
    class TaskCollectionList7
    // 7.WAP to convert an array to ArrayList.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Size of Array :");
            int s = int.Parse(Console.ReadLine());
            string[] str = new string[s];
            Console.WriteLine("Enter Elements in an Array :");
            for (int i = 0; i < s; i++)
            {
                str[i] = Console.ReadLine();
            }
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(str);
            foreach (var x in str)
            {
                Console.Write(x + " ");
            }
            Console.ReadKey();
        }
    }
    class TaskCollectionList8
    // 8.WAP to print list in reverse order .
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            Console.WriteLine("Enter size of List :");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Colors Name in list :");
            for (int i = 1; i <= s; i++)
            {
                string str = Console.ReadLine();
                li.Add(str);
            }
            Console.WriteLine();
            li.ForEach(c => Console.Write(c + "  "));
            li.Reverse();
            Console.WriteLine("................");
            li.ForEach(c => Console.Write(c + "  "));
            Console.ReadKey();
        }
    }
    class TaskCollectionArrayList9
    // 9.WAP to sort the elements of List that contain String objects. Print ArrayList.
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            Console.WriteLine("Enter size of List :");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements in list :");
            for (int i = 1; i <= s; i++)
            {
                string str = Console.ReadLine();
                li.Add(str);
            }
            li.ForEach(Lnum => Console.Write(Lnum + " "));
            for (int i = 0; i < li.Count; i++)
            {
                for (int j = i + 1; j < li.Count; j++)
                {
                    if (li[i].CompareTo(li[j]) > -1)
                    {
                        var temp = li[i];
                        li[i] = li[j];
                        li[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            li.ForEach(Lnum => Console.Write(Lnum + " "));
            Console.ReadKey();
        }
    }
    class TaskCollectionList10 : IComparable
    /* 10.WAP to create a class Employee with (name, designation and age).Now create and add Employee objects 
      elements to Arraylist. Sort the ArrayList by age in descending order and print ArrayList. */
    {
        public string name;
        public string designation;
        public int age;

        public TaskCollectionList10(string name, string designation, int age)
        {
            this.name = name;
            this.designation = designation;
            this.age = age;
        }
        public int CompareTo(Object obj)
        {
            TaskCollectionList10 e1 = (TaskCollectionList10)obj;
            return e1.age - this.age;
        }
    }
    class TaskCustomList10
    {
        static void Main(string[] args)
        {
            List<TaskCollectionList10> li = new List<TaskCollectionList10>();
            li.Add(new TaskCollectionList10("Shreya", "HR", 26));
            li.Add(new TaskCollectionList10("Neha", "RND", 28));
            li.Add(new TaskCollectionList10("Snehal", "Finance", 27));
            li.Add(new TaskCollectionList10("Samiksha", "Software Development", 25));
            li.Add(new TaskCollectionList10("Shweta", "Sales", 30));
            foreach (TaskCollectionList10 e1 in li)
            {
                Console.WriteLine(e1.name + "  " + e1.designation + "  " + e1.age);
            }
            Console.WriteLine(".............");
            li.Sort();
            foreach (TaskCollectionList10 e1 in li)
            {
                Console.WriteLine(e1.name + "  " + e1.designation + "  " + e1.age);
            }
            Console.ReadKey();
        }
    }
    class TaskCollectionHashtable11
    /* 11.	WAP to add elements to a Hashtable and print content of it. Use int as Key and String as Value.
        In the second Hashtable add elements of String type as Key and Int as Value. */
    {
        static void Main(string[] args)
        {
            Hashtable ht1 = new Hashtable()
            {
                {1, "Pune" },
                {2, "Mumbai" },
                {3, "Goa" },
                {4, "Chennai" },
                {5, "Hyderabad" },
                {6, "Banglore" },
                {7, "Nagpur" }
            };
            foreach (DictionaryEntry kv in ht1)
            {
                Console.WriteLine(kv.Key + "  " + kv.Value);
            }
            Hashtable ht2 = new Hashtable()
            {
                {"Pink", 8 },
                {"Yellow", 9 },
                {"Green", 10 },
                {"White", 11 },
                {"Red", 12 },
                {"Blue", 13 },
                {"Indigo", 14 }
            };
            foreach (DictionaryEntry kv in ht2)
            {
                Console.WriteLine(kv.Key + "  " + kv.Value);
            }
            Console.ReadKey();
        }
    }
    class TaskCollectionHashtable12
    // 12.	WAP to get only the Keys from a Hashtable.
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable()
            {
                {1, "Pune" },
                {2, "Mumbai" },
                {3, "Goa" },
                {4, "Chennai" },
                {5, "Hyderabad" },
                {6, "Banglore" },
                {7, "Nagpur" }
            };
            foreach (DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key);
            }
            Console.ReadKey();
        }
    }
    class TaskCollectionHashtable13
    // 13.	WAP to get only the Values from a Hashtable.
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable()
            {
                {1, "Pune" },
                {2, "Mumbai" },
                {3, "Goa" },
                {4, "Chennai" },
                {5, "Hyderabad" },
                {6, "Banglore" },
                {7, "Nagpur" }
            };
            foreach (DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Value);
            }
            Console.ReadKey();
        }
    }
    class TaskCollectionHashtable14
    // 14.	WAP to create a  Hashtable  using Custom class as key and any other object as value
    {
        static void Main(string[] args)
        {

        }
    }
    class TaskCollectionQueue15
    // WAP to create a Queue to add 5 objects and also remove the first two and iterate over it. 
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(5);
            q.Enqueue(56);
            q.Enqueue(89);
            q.Enqueue(23);
            q.Enqueue(20);
            foreach (var x in q)
            {
                Console.Write(x+"  ");
            }
            q.Dequeue();
            q.Dequeue();
            Console.WriteLine("\n......................");
            foreach (var x in q)
            {
                Console.Write(x+"  ");
            }
            Console.ReadKey();
        }
    }
    class TaskCollectionStack16
    // WAP to create a Stack to store some objects and iterate over it.Also show use of push,pop,peek.
    {
        static void Main(string[] args)
        {
            Stack<string> s = new Stack<string>();
            s.Push("red");
            s.Push("green");
            s.Push("blue");
            s.Push("White");
            s.Push("Pink");
            foreach (var st in s)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("..................POP.............");
            s.Pop();
            foreach (var st in s)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine(".............PEEK...........");
            s.Peek();
            foreach (var st in s)
            {
                Console.WriteLine(st);
            }
            Console.ReadKey();
        }
    }
    class Emp17
    /* WAP to create a List<Emp> and search for Emp object whose Empno=10 and delete all the records 
     whose dept is same as empno 10. Emp[Emp No, ename, Deptid]  Dept[did, dname] */
    {
        public int E_no;
        public string E_name;

        public Emp17(int E_no, string E_name)
        {
            this.E_no = E_no;
            this.E_name = E_name;
        }
    }
    class Dept17
    {
        public int D_id;
        public string D_name;
        public List<Emp> ed;

        public Dept17(int D_id, string D_name, List<Emp> ed)
        {
            this.D_id = D_id;
            this.D_name = D_name;
            this.ed = ed;
        }
    }
    class TaskCollectionCustomEmpList17
    {
        static void Main(string[] args)
        {
            int num = 10;
            List<Dept> li = new List<Dept>();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter Department ID :");
                int ID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Department Name :");
                string Name = Console.ReadLine();
                List<Emp> em = new List<Emp>();
                Console.WriteLine("Enter the Employee Details :");
                for (int j = 1; j < 4; j++)
                {
                    Console.WriteLine("Enter Employee ID :");
                    int E_no = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Employee Name :");
                    string E_name = Console.ReadLine();
                    em.Add(new Emp(E_no, E_name));
                }
                li.Add(new Dept(ID, Name, em));
            }
            Console.WriteLine("The Final Data is :");
            foreach (var d in li)
            {
                foreach (var e in d.ed)
                {
                    if (e.E_no == num)
                    {
                        Console.Write(d.D_id + "  " + d.D_name);
                        Console.Write("  " + e.E_no + "  " + e.E_name);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
