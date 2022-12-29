using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.CollectionPrograms
{
    class DictionaryList
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            Console.WriteLine("Enter the size of List :");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Elements in list :");
            for (int i = 1; i <= s; i++)
            {
                int L = int.Parse(Console.ReadLine());
                li.Add(L);
            }
            bool[] found = new bool[li.Count];
            for (int i = 0; i < li.Count; i++)
                found[i] = false;
            for (int i = 0; i < li.Count; i++)
            {
                if (found[i] == true)
                    continue;
                int cnt = 1;
                for (int j = i + 1; j < li.Count; j++)
                {
                    if (li[i] == li[j])
                    {
                        found[j] = true;
                        cnt++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine(li[i] + " is present " + cnt + " times in Linklist ");
            }
            Console.ReadKey();
        }
    }
    class DictionaryList2
    // Frequency of list
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            Console.WriteLine("Enter the size of List :");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Elements in list :");
            for (int i = 1; i <= s; i++)
            {
                string L = Console.ReadLine();
                li.Add(L);
            }
            Console.WriteLine();
            bool[] found = new bool[li.Count];
            for (int i = 0; i < li.Count; i++)
                found[i] = false;
            for (int i = 0; i < li.Count; i++)
            {
                if (found[i] == true)
                    continue;
                int cnt = 1;
                for (int j = i + 1; j < li.Count; j++)
                {
                    if (li[i] == li[j])
                    {
                        found[j] = true;
                        cnt++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine(li[i] + " is present " + cnt + " times");
            }
            Console.ReadKey();
        }
    }
    class List
    // create a list of string and sort the list on the basis of length in ascending order.
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            Console.WriteLine("Enter the size of List :");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Elements in list :");
            for (int i = 1; i <= s; i++)
            {
                string L = Console.ReadLine();
                li.Add(L);
            }
            Console.WriteLine("Display the list according to the length in ascending order");
            for (int i = 0; i < li.Count; i++)
            {
                for (int j = i + 1; j < li.Count; j++)
                {
                    if (li[i].Length > li[j].Length)
                    {
                        string temp = li[i];
                        li[i] = li[j];
                        li[j] = temp;
                    }
                    else if (li[i].Length == li[j].Length)
                    {
                        if (li[i].CompareTo(li[j]) < 1)
                        {
                            string temp = li[i];
                            li[i] = li[j];
                            li[j] = temp;
                        }
                    }
                }
            }
            Console.WriteLine();
            foreach (string city in li)
            {
                Console.Write(city + "   ");
            }
            Console.ReadKey();
        }
    }
    class DictionaryList3
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> mycities = new Dictionary<int, string>();
            mycities.Add(5, "Pune");
            mycities.Add(7, "Mumbai");
            mycities.Add(4, "Goa");
            mycities.Add(1, "Pune");
            mycities.Add(6, "Nashik");
            mycities.Add(2, "Banglore");
            foreach (var data in mycities)
            {
                Console.WriteLine(data.Key + "  " + data.Value);
            }
            Console.WriteLine(".............");
            foreach (KeyValuePair<int, string> m in mycities)
            {
                Console.WriteLine(m.Key + "....." + m.Value);
            }
            Console.WriteLine("...................." + mycities.Count);
            for (int i = 0; i < mycities.Count; i++)
            {
                Console.WriteLine(mycities.ElementAt(i).Key + "  " + mycities.ElementAt(i).Value);
            }
            Console.WriteLine(".................");
            Console.WriteLine(mycities.ContainsKey(5));
            List<int> l = new List<int>(mycities.Keys);
            foreach (var x in l)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
    class DictionaryList4
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            Console.WriteLine("Enter the size of List :");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Elements in list :");
            for (int i = 1; i <= s; i++)
            {
                string L = Console.ReadLine();
                li.Add(L);
            }
            Console.WriteLine();
            for (int i = 0; i < li.Count; i++)
            {
                int count = 1;
                for (int j = i + 1; j < li.Count; j++)
                {
                    if (li[i] == li[j])
                    {
                        count++;
                        li.RemoveAt(j);
                        j--;
                    }
                }
                Console.WriteLine(li[i] + "  " + count);
            }
            Dictionary<string, int> dm = new Dictionary<string, int>();
            for (int i = 0; i < li.Count; i++)
            {
                int count = 1;
                for (int j = i + 1; j < li.Count; j++)
                {
                    if (li[i] == li[j])
                    {
                        count++;
                        li.RemoveAt(j);
                        j--;
                    }
                }
                dm.Add(li[i], count);
            }
            Console.WriteLine("..............");
            foreach (KeyValuePair<string, int> kv in dm)
            {
                Console.WriteLine(kv.Key + "  " + kv.Value);
            }
            Console.ReadKey();
        }
    }
    class Student6
    {
        public int id;
        public string name;

        public Student6(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    class CustomList6
    {
        static void Main(string[] args)
        {
            List<Student6> li = new List<Student6>();
            li.Add(new Student6(101, "Neha"));
            li.Add(new Student6(102, "Shreya"));
            li.Add(new Student6(103, "Pooja"));
            foreach (Student6 s in li)
            {
                Console.WriteLine(s.id + "  " + s.name);
            }
            Console.ReadKey();
        }
    }
    class Student7
    /* we want to create a dictionary from the list of student where marks is a key and list of student name
      who got the same marks as a value  */
    {
        public int id;
        public string name;
        public int marks;

        public Student7(int id, string name, int marks)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;
        }
    }
    class CustomListDictionary
    {
        static void Main(string[] args)
        {
            List<Student7> li = new List<Student7>();
            li.Add(new Student7(101, "Neha", 86));
            li.Add(new Student7(102, "Shreya", 80));
            li.Add(new Student7(103, "Pooja", 83));
            li.Add(new Student7(103, "Snehal", 89));
            foreach (Student7 s in li)
            {
                Console.WriteLine(s.id + "  " + s.name + "  " + s.marks);
            }
            Console.WriteLine("...............");
            Dictionary<int, List<string>> dm = new Dictionary<int, List<string>>();
            for (int i = 0; i < li.Count; i++)
            {
                List<string> snamelist = new List<string>();
                for (int j = 0; j < li.Count; j++)
                {
                    if (li[i].marks == li[j].marks)
                    {
                        snamelist.Add(li[j].name);
                    }
                }
                if (!dm.ContainsKey(li[i].marks))
                {
                    dm.Add(li[i].marks, snamelist);
                }
            }
            foreach (KeyValuePair<int, List<string>> kv in dm)
            {
                Console.Write(kv.Key + "  ");
                /*foreach(var x in kv.Value)
                {
                    Console.Write(x+"  ");
                }*/
                List<string> name = new List<string>(kv.Value);
                foreach (var n in name)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    class EmployeeInformation
    /* create a dictionary which contain employee as a key and employee-department name as a value
      employee has id, name, salary if 2 employee has same id and name then avoid to add thet entry in a dictionary  */
    {
        public int id;
        public string name;
        public int salary;

        public EmployeeInformation(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
    }
    class EqualCheck : IEqualityComparer<EmployeeInformation>
    {
        bool IEqualityComparer<EmployeeInformation>.Equals(EmployeeInformation x, EmployeeInformation y)
        {
            return x.id == y.id && x.name == y.name;
        }
        int IEqualityComparer<EmployeeInformation>.GetHashCode(EmployeeInformation obj)
        {
            return obj.id;
        }
    }
    class CustomDictionaryList1
    {
        static void Main(string[] args)
        {
            Dictionary<EmployeeInformation, string> dm = new Dictionary<EmployeeInformation, string>(new EqualCheck());
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter Employee ID :");
                int E_id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name :");
                string E_name = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary :");
                int E_salary = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Department Name :");
                string d_name = Console.ReadLine();

                EmployeeInformation e = new EmployeeInformation(E_id, E_name, E_salary);
                if (dm.ContainsKey(e))
                {
                    Console.WriteLine("Already Present in the above data");
                }
                else
                {
                    dm.Add(e, d_name);
                }
            }
            foreach (KeyValuePair<EmployeeInformation, string> kv in dm)
            {
                EmployeeInformation e = kv.Key;
                Console.WriteLine(e.id + "  " + e.name + "  " + e.salary + "  " + kv.Value);
            }
            Console.ReadKey();
        }
    }
    class CarInformation
    {
        public int model_no;
        public string name;

        public CarInformation(int model_no, string name)
        {
            this.model_no = model_no;
            this.name = name;
        }
    }
    class EqualCheck1 : IEqualityComparer<CarInformation>
    {
        bool IEqualityComparer<CarInformation>.Equals(CarInformation x, CarInformation y)
        {
            return x.model_no == y.model_no;
        }
        int IEqualityComparer<CarInformation>.GetHashCode(CarInformation obj)
        {
            return obj.model_no;
        }
    }
    class CustomDictionaryList2
    {
        static void Main(string[] args)
        {
            Dictionary<CarInformation, int> dm = new Dictionary<CarInformation, int>(new EqualCheck1());
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter the Car No. :");
                int M_No = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Car Name :");
                string C_name = Console.ReadLine();

                Console.WriteLine("Enter the Price :");
                int C_price = int.Parse(Console.ReadLine());

                CarInformation c = new CarInformation(M_No, C_name);
                if (dm.ContainsKey(c))
                {
                    Console.WriteLine("Already Present in the above data");
                }
                else
                {
                    dm.Add(c, C_price);
                }
            }
            foreach (KeyValuePair<CarInformation, int> kv in dm)
            {
                CarInformation c = kv.Key;
                Console.WriteLine(c.model_no + "  " + c.name + "  " + kv.Value);
            }
            Console.ReadKey();
        }
    }
}
