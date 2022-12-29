using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.OOPSPrograms
{
    class Student_Info
    {
        int id;
        string name;
        int age;
        public void GetInfo()
        {
            id = 1;
            name = "Neha";
            age = 12;
        }
        public void GetInfo(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public void PutInfo()
        {
            Console.WriteLine("Id :-" + id);
            Console.WriteLine("Name :-" + name);
            Console.WriteLine("Age :-" + age);
        }
        static void Main(string[] args)
        {
            Student_Info S = new Student_Info();
            S.GetInfo();
            S.PutInfo();
            Student_Info St = new Student_Info();
            St.GetInfo(2, "Shreya", 13);
            St.PutInfo();
            Console.ReadKey();
        }
    }
    class Bank
    {
        int bal;
        public int GetBalance()
        {
            return bal;
        }
        public void Withdraw(int amt)
        {
            bal = bal - amt;
        }
        public void Deposit(int amt)
        {
            bal = bal + amt;
        }
        static void Main(string[] args)
        {
            Bank B = new Bank();
            B.Deposit(3000);
            Console.WriteLine("Current balance after 3000 deposit is:=" + B.GetBalance());
            B.Deposit(2000);
            Console.WriteLine("Current balance after 2000 deposit is:=" + B.GetBalance());
            B.Withdraw(4000);
            Console.WriteLine("Current balance after 4000 withdraw is:=" + B.GetBalance());
            Console.ReadKey();
        }
    }
    class Student_Per
    {
        public int id;
        public string name;
        public int phy;
        public int chem;
        public int maths;
        public void GetInfo()
        {
            id = 1;
            name = "Neha";
            phy = 75;
            chem = 82;
            maths = 89;
        }
        public void PutInfo()
        {
            Console.WriteLine("Id :-" + id);
            Console.WriteLine("Name :-" + name);
            Console.WriteLine("Physics :-" + phy);
            Console.WriteLine("Chemistry :-" + chem);
            Console.WriteLine("Maths :-" + maths);
        }
        public void GetInfo(int id, string name, int phy, int chem, int maths)
        {
            this.id = id;
            this.name = name;
            this.phy = phy;
            this.chem = chem;
            this.maths = maths;
        }
        public double Calper()
        {
            double total = phy + chem + maths;
            double percent = total / 3;

            return percent;
        }
        public char Grade()
        {
            if (Calper() >= 75)
            {
                return 'A';
            }
            else if (Calper() >= 60 && Calper() <= 75)
            {
                return 'B';
            }
            else if (Calper() < 60 && Calper() >= 35)
            {
                return 'C';
            }
            else
            {
                return 'F';
            }
        }
        static void Main(string[] args)
        {
            Student_Per SP = new Student_Per();
            SP.GetInfo();
            SP.PutInfo();
            Console.WriteLine("Percentage :-" + SP.Calper() + "%");
            Console.WriteLine("Grade :-" + SP.Grade());
            Console.ReadKey();
        }
    }
    class StudentCompare
    {
        public int id;
        public string name;
        public double phy;
        public double chem;
        public double maths;
        public double per;
        public void Accept()
        {
            Console.WriteLine("Enter Id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter marks for Physics");
            phy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter marks for Chemistry");
            chem = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter marks for Mathematics");
            maths = Convert.ToDouble(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Id := " + id);
            Console.WriteLine("Name := " + name);
            Console.WriteLine("Percentage := " + per);
        }
        public void GetInfo(int id, string name, int age, int phy, int chem, int maths)
        {
            this.id = id;
            this.name = name;
            this.phy = phy;
            this.chem = chem;
            this.maths = maths;
        }
        public double CalPer()
        {
            double total = phy + chem + maths;
            per = (total / 3);

            return per;
        }
        public char Grade()
        {
            if (per >= 75)
            {
                return 'A';
            }
            else if (per < 75 && per >= 60)
            {
                return 'B';
            }
            else if (per < 60 && per >= 35)
            {
                return 'C';
            }
            else
            {
                return 'F';
            }
        }
        public static void Main(string[] args)
        {
            StudentCompare s1 = new StudentCompare();
            s1.Accept();
            StudentCompare s2 = new StudentCompare();
            s2.Accept();
            if (s1.CalPer() > s2.CalPer())
            {
                s1.Display();
            }
            else
            {
                s2.Display();
            }
            Console.ReadKey();
        }
    }
    public class Student
    {
        int id;
        string name;
        int age;

        public Student()
        {
            id = 0;
            name = "";
            age = 0;
            Console.WriteLine("Default Constructor");
        }
        public Student(int id, string name, int age) : this(id, name)
        {

            this.id = id;
            this.name = name;
            this.age = age;
        }
        public Student(int id, string name)
        {

            this.id = id;
            this.name = name;
            Console.WriteLine("Constructor with 2 parameters called");
        }
        public Student(Student s)
        {
            this.id = s.id;
            this.name = s.name;
            this.age = s.age;
        }
        public void GetInfo(int id, string name = " ", int age = 16)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public void Display()
        {
            Console.WriteLine("Id := " + id + " Name := " + name + " Age := " + age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();//Default constructor calling
            //student.GetInfo(10, "abc");
            //student.Display();
            Student student1 = new Student(1, "AAA", 89);//parameterised constructor
            student1.Display();
            Student student2 = student1;//copy constructor
            student2.Display();
            Console.ReadKey();
        }
    }
}
