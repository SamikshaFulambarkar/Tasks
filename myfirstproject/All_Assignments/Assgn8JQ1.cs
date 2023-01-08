using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.All_Assignments
{
    // 1.	WAP to sort the elements of List that contains String objects. Print List.
    class Assgn8JQ1
    {
        static void Main(string[] args)
        {
            int i, j;
            string t;
            List<string> li = new List<string>();
            Console.WriteLine("Enter the size of List :");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Elements in list :");
            for (i = 1; i <= s; i++)
            {
                string L = Console.ReadLine();
                li.Add(L);
            }
            Console.WriteLine();
            for (i = 0; i < s; i++)
            {
                for (j = 0; j < s - 1; j++)
                {
                    if (li[j].CompareTo(li[j + 1]) > 0)
                    {
                        t = li[j];
                        li[j] = li[j + 1];
                        li[j + 1] = t;
                    }
                }
            }
            Console.WriteLine("Sorted string array is:");
            for (i = 0; i < s; i++)
            {
                Console.Write(li[i] + " ");
            }
            Console.ReadKey();
        }
    }

    // 2.	WAP to create a class Employee with (name, designation ,salary).Now create and add Employee objects elements to List. Print List.
    class Assgn8JQ2
    {
        class Employee_List
        {
            public string name;
            public string designation;
            public int salary;

            public Employee_List(string name, string designation, int salary)
            {
                this.name = name;
                this.designation = designation;
                this.salary = salary;
            }
        }
        static void Main(string[] args)
        {
            List<Employee_List> li = new List<Employee_List>();
            li.Add(new Employee_List("Shreya", "Sales", 35000));
            li.Add(new Employee_List("Neha", "HR", 18000));
            li.Add(new Employee_List("Snehal", "Accountant", 20000));
            li.Add(new Employee_List("Samiksha", "Software Developer", 48000));
            li.Add(new Employee_List("Shweta", "RND", 30000));
            foreach (Employee_List e in li)
            {
                Console.WriteLine(e.name + "  " + e.designation + "  " + e.salary);
            }
            Console.ReadKey();
        }
    }

    // 3.	WAP to create a Queue with some colors(String) using generics.
    class Assgn8JQ3
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("Yellow");
            q.Enqueue("Orange");
            q.Enqueue("Green");
            q.Enqueue("Red");
            q.Enqueue("Blue");
            q.Enqueue("Indigo");
            q.Enqueue("Violet");
            foreach (var x in q)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }

    /* 4.	WAP to add user defined objects of type Employee in a HashSet employee object.
         Make sure if I create 2 different objects with same data the other one should not be added as hashset stores unique objects */

    class Assgn8JQ4
    {
        class Employee
        {
            public int id;
            public string name;
            public int salary;
            public Employee(int id, string name, int salary)
            {
                this.id = id;
                this.name = name;
                this.salary = salary;
            }
            public void DisplayEmp()
            {
                Console.WriteLine(id + "  " + name + "  " + salary);
            }
        }
        static void Main(string[] args)
        {
            HashSet<Employee> hs = new HashSet<Employee>();
            Console.WriteLine("Enter number of employee");
            int empcnt = int.Parse(Console.ReadLine());
            for (int i = 0; i < empcnt; i++)
            {
                Console.WriteLine("Enter id");
                int id = int.Parse(Console.ReadLine());
                bool Ispresent = false;
                foreach (Employee e in hs)
                {
                    if (e.id.Equals(id))
                    {
                        Console.WriteLine("Already Present");
                        Ispresent = true;
                        empcnt++;
                        break;
                    }
                }
                if (!Ispresent)
                {
                    Console.WriteLine("Enter name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter salary");
                    int salary = int.Parse(Console.ReadLine());
                    Employee emp = new Employee(id, name, salary);
                    hs.Add(emp);
                }
            }
            foreach (Employee emp in hs)
            {
                emp.DisplayEmp();
            }
            Console.ReadKey();
        }
    }


    // 5.	WAP to create SortedList where key is of Integer type and value string and print all key-value pairs.
    class Assgn8JQ5
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(1, "Pune");
            sl.Add(2, "Mumbai");
            sl.Add(3, "Nagpur");
            sl.Add(4, "Banglore");
            sl.Add(5, "Chennai");
            sl.Add(6, "Hyderabad");
            sl.Add(7, "Nashik");
            sl.Add(8, "Aurangabad");
            sl.Add(9, "Goa");
            sl.Add(10, "Ahmedabad");
            foreach (var myentry in sl)
            {
                Console.WriteLine(myentry.Key + "  " + myentry.Value);
            }
            Console.ReadKey();
        }
    }

    // 6.	WAP to create Dictionary where key is of string type and value of float type and print all key-value pairs.
    class Assgn8JQ6
    {
        static void Main(string[] args)
        {
            Dictionary<string, float> mycities = new Dictionary<string, float>();
            mycities.Add("Pune", 1.1f);
            mycities.Add("Mumbai", 2.1f);
            mycities.Add("Goa", 3.1f);
            mycities.Add("Chennai", 4.1f);
            mycities.Add("Nashik", 5.1f);
            mycities.Add("Banglore", 6.1f);
            mycities.Add("Ahmedabad", 7.1f);
            foreach (KeyValuePair<string, float> m in mycities)
            {
                Console.WriteLine(m.Key + "    " + m.Value);
            }
            Console.ReadKey();
        }
    }


    /* 7.	Make use of such collection that stores moviename such that last entered movie is first
        deleted and accordingly previous one. */
    class Assgn8JQ7
    {
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();
            st.Push("Dear Zindagi");
            st.Push("Sarfarosh");
            st.Push("God Tussi Great Ho ");
            st.Push("Pink");
            st.Push("Dilwale");
            st.Push("Arjun Reddy");
            st.Push("Kabir Singh");
            st.Push("Aashiqui 2");
            st.Push("Koi Mil Gaya");
            st.Push("Kal Ho Na Ho");
            st.Pop();
            foreach (var movie in st)
            {
                Console.WriteLine(movie);
            }
            Console.ReadKey();
        }
    }


    /* 8.	WAP to create SortedList<Employee,string> where key is of Employee type and value is departmentname(string) he works in.
         SortedList should maintain data in descending order of salary.   */
    class Assgn8JQ8
    {
        class List_Employee : IComparable<List_Employee>
        {
            public int ID;
            public string Name;
            public int Salary;

            public List_Employee(int ID, string Name, int Salary)
            {
                this.ID = ID;
                this.Name = Name;
                this.Salary = Salary;
            }
            public void DisplayEmp()
            {
                Console.Write(ID + "  " + Name + "  " + Salary + "  ");
            }
            int IComparable<List_Employee>.CompareTo(List_Employee other)
            {
                return other.Salary - this.Salary;
            }
        }
        static void Main(string[] args)
        {
            SortedList<List_Employee, string> sl = new SortedList<List_Employee, string>();
            sl.Add(new List_Employee(12, "Neha", 78000), "RND");
            sl.Add(new List_Employee(11, "Shreya", 88000), "Sales");
            sl.Add(new List_Employee(15, "Monali", 48000), "Accountant");
            sl.Add(new List_Employee(14, "Yuga", 20000), "HR");
            sl.Add(new List_Employee(13, "Nikita", 38000), "RND");
            foreach (KeyValuePair<List_Employee, string> kv in sl)
            {
                List_Employee e = kv.Key;
                e.DisplayEmp();
                Console.WriteLine(kv.Value);
            }
            Console.ReadKey();
        }
    }


    /* 9.	 Create a class Flat (flatno,WingName,List<Member> memberlist)
        Member(memberid, membername, profession, age)
        Create of 2 flat objects    */
    class Assgn8JQ9
    {
        class Member
        {
            public int M_id;
            public string M_Name;
            public string M_Profession;
            public int M_Age;


            public Member(int M_id, string M_Name, string M_Profession, int M_Age)
            {
                this.M_id = M_id;
                this.M_Name = M_Name;
                this.M_Profession = M_Profession;
                this.M_Age = M_Age;
            }
        }
        class Flat
        {
            public int Flat_no;
            public string Wing_name;
            public List<Member> m;

            public Flat(int Flat_no, string Wing_name, List<Member> m)
            {
                this.Flat_no = Flat_no;
                this.Wing_name = Wing_name;
                this.m = m;
            }
        }
        static void Main(string[] args)
        {
            List<Flat> li = new List<Flat>();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter the Flat No. :");
                int No = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Wing Name :");
                string Wing_Name = Console.ReadLine();
                List<Member> f = new List<Member>();
                Console.WriteLine("Enter the Member details ");
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("Enter the Member ID :");
                    int M_id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Member Name :");
                    string M_Name = Console.ReadLine();
                    Console.WriteLine("Enter the Member Profession :");
                    string M_Profession = Console.ReadLine();
                    Console.WriteLine("Enter the Member Age :");
                    int M_Age = int.Parse(Console.ReadLine());
                    f.Add(new Member(M_id, M_Name, M_Profession, M_Age));
                }
                li.Add(new Flat(No, Wing_Name, f));
            }
            Console.WriteLine("..............");
            foreach (var d in li)
            {
                Console.Write(d.Flat_no + "  " + d.Wing_name + "  ");
                foreach (var e in d.m)
                {
                    Console.Write("  " + e.M_id + "  " + e.M_Name + "  " + e.M_Profession + "  " + e.M_Age);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
