using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.All_Assignments
{
    class ListQ1
    // write a program to sort list by descending order without using sort method and without using converting into array
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            Console.WriteLine("Enter size of List :");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements in List :");
            for (int i = 0; i < s; i++)
            {
                int L = int.Parse(Console.ReadLine());
                li.Add(L);
            }
            for (int i = 0; i < s - 1; i++)
            {
                for (int j = i + 1; j < s; j++)
                {
                    if (li[i] < li[j])
                    {
                        int t = li[i];
                        li[i] = li[j];
                        li[j] = t;
                    }
                }
            }
            Console.WriteLine("Sorted List in Descending Order :");
            for (int i = 0; i < s; i++)
            {
                Console.Write(li[i] + "  ");
            }
            Console.ReadKey();
        }
    }
    class ListQ2
    // write a program to remove duplicate elements from list
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            Console.WriteLine("Enter size of List :");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements in List :");
            for (int i = 0; i < s; i++)
            {
                int L = int.Parse(Console.ReadLine());
                li.Add(L);
            }
            List<int> distinct = li.Distinct().ToList();
            Console.WriteLine("List after removing duplicate elements");
            foreach (int res in distinct)
            {
                Console.Write(res + "  ");
            }
            Console.ReadKey();
        }
    }
    class MovieList
    /* Consider a list of movie, movie has (int Movieid, string Moviename, List<string>actor) Find "Amitabh Bachchan
    has acted in how many movies */
    {
        public int Movie_id;
        public string Movie_name;
        public string Actor;

        public MovieList(int Movie_id, string Movie_name, string Actor)
        {
            this.Movie_id = Movie_id;
            this.Movie_name = Movie_name;
            this.Actor = Actor;
        }
    }
    class CustomMovieList
    {
        static void Main(string[] args)
        {
            int count = 0;
            string Actor_name = "Amitabh Bachchan";
            List<MovieList> li = new List<MovieList>();
            li.Add(new MovieList(101, "My name is Khan", "Shahrukh Khan"));
            li.Add(new MovieList(102, "Suryavansham", "Amitabh Bachchan"));
            li.Add(new MovieList(103, "Shahenshah", "Amitabh Bachchan"));
            li.Add(new MovieList(104, "Wanted", "Salman Khan"));
            li.Add(new MovieList(105, "Pink", "Amitabh Bachchan"));
            foreach (MovieList e in li)
            {
                if (e.Actor == Actor_name)
                {
                    count++;
                }
            }
            Console.WriteLine("Amitabh Bachchan has acted in " + count + " movies");
            Console.ReadKey();
        }
    }
    class Emp
    /* WAP to create a List<Emp> and search for Emp object whose Empno=10 and delete all the records whose dept is same as empno
     10. Emp[Emp No, ename, Deptid]  Dept[did, dname] */
    {
        public int E_no;
        public string E_name;

        public Emp(int E_no, string E_name)
        {
            this.E_no = E_no;
            this.E_name = E_name;
        }
    }
    class Dept
    {
        public int D_id;
        public string D_name;
        public List<Emp> ed;

        public Dept(int D_id, string D_name, List<Emp> ed)
        {
            this.D_id = D_id;
            this.D_name = D_name;
            this.ed = ed;
        }
    }
    class CustomEmpList
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
    class ArrQ5
    // WAP to find all pairs of elements in an integer array whose sum is equal to a given number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of Array :");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter Elements in an Array :");
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter any Number :");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Pair of elements whose sum is equal to " + num + " are :");
            for (int i = 0; i < s; i++)
            {
                for (int j = i + 1; j < s; j++)
                {
                    if ((arr[i] + arr[j]) == num)
                    {
                        Console.WriteLine(arr[i] + " + " + arr[j] + " = " + num);
                    }
                }
            }
            Console.ReadKey();
        }
    }
    /*class OutputQ6
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>();
            list1.Add("Me");
            list1.Add("You");
            list1.Add("He");
            list1.Add("She");
            list1.Add("It");
            List<string> list2 = new List<string>();
            list2.Add("You");
            list1.Insert(list2);
            foreach(string temp in list1)
            {
                Console.Write(temp+"  ");
            }
        } Ans :- Error is ArgumentOutOfRangeException
    }*/
    class Nib
    /* A pen contains variables refill, caplength and brand. Refill has variables inkColor, length and Nib(tip).
    Nib has variables materialType and width. Create a java class structure for above. Write a main method which sets
    values in all the variables using setter methods and prints all the variables using getter methods. */
    {
        string materialType;
        double width;
        public string MaterialType
        {
            get { return materialType; }
            set { materialType = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public void DisplayNib()
        {
            Console.WriteLine("Nib Details : \nMaterial Type = " + MaterialType + "\nWidth = " + Width);
        }
    }
    class Refil
    {
        string inkColor;
        double length;
        Nib nib;
        public string InkColor
        {
            get { return inkColor; }
            set { inkColor = value; }
        }
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public Nib Nib
        {
            get { return nib; }
            set { nib = value; }
        }
        public void DisplayRefil()
        {
            Console.WriteLine("Refill Details : \nInk Color = " + InkColor + "\nLength = " + Length);
            Nib.DisplayNib();
        }
    }
    class Pen1
    {
        Refil refil;
        double capLength;
        string brand;

        public Refil Refil
        {
            get { return refil; }
            set { refil = value; }
        }
        public double CapLength
        {
            get { return capLength; }
            set { capLength = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public void DisplayPen()
        {
            Console.WriteLine("Pen Details : \nCaplength = " + CapLength + "\nBrand = " + Brand);
            Refil.DisplayRefil();
        }
    }
    class Structure
    {
        static void Main(string[] args)
        {
            Pen1 p = new Pen1();
            p.CapLength = 4.5;
            p.Brand = "Cello";
            p.Refil = new Refil();
            p.Refil.InkColor = "Red";
            p.Refil.Length = 8.5;
            p.Refil.Nib = new Nib();
            p.Refil.Nib.MaterialType = "Plastic";
            p.Refil.Nib.Width = 0.8;
            p.DisplayPen();
            Console.ReadKey();
        }
    }
}
