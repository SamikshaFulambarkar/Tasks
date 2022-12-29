using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.PropertyPrograms
{
    class Student_1
    {
        int s_id;
        string s_name;
        int s_marks;
        bool isresult;
        public int S_ID
        {
            set
            {
                s_id = value;
            }
            get
            {
                return s_id;
            }
        }
        public string S_Name
        {
            set
            {
                s_name = value;
            }
            get
            {
                return s_name;
            }
        }
        public int S_Marks
        {
            set
            {
                s_marks = value;
            }
            get
            {
                return s_marks;
            }
        }
        public bool Result
        {
            set
            {
                isresult = value;
            }
            get
            {
                return isresult;
            }
        }
    }
    class StudentInfo
    {
        static void Main(string[] args)
        {
            Student_1 s = new Student_1();
            s.S_ID = 26;
            s.S_Name = "Neha Shah";
            s.S_Marks = 78;
            s.Result = true;
            Console.WriteLine("Student ID =" + s.S_ID);
            Console.WriteLine("Student Name =" + s.S_Name);
            Console.WriteLine("Marks =" + s.S_Marks);
            if (s.Result == true)
            {
                Console.WriteLine("Result is Pass");
            }
            else
            {
                Console.WriteLine("Result is Fail");
            }
            Console.ReadKey();
        }
    }
    public class Course
    {
        private int id;
        private string name;
        private double fees;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Fees
        {
            get { return fees; }
            set { fees = value; }
        }
        static void Main(string[] args)
        {
            Course c1 = new Course();
            c1.Id = 1;
            c1.Name = "C#";
            c1.Fees = 20000;
            Console.WriteLine($"Id {c1.Id} {c1.Name} {c1.Fees}");
            Course c2 = new Course { Id = 2, Name = "Java", Fees = 20000 };
            Console.WriteLine($"Id {c2.Id} {c2.Name} {c2.Fees}");
            Console.ReadKey();
        }
    }
    public class Employee5
    {
        private int Emp_id;
        private string Emp_name;
        private double salary;
        public int Id
        {
            get { return Emp_id; }
            set { Emp_id = value; }
        }
        public string Name
        {
            get { return Emp_name; }
            set { Emp_name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        static void Main(string[] args)
        {
            Employee5 e1 = new Employee5();
            e1.Id = 1;
            e1.Name = "Neha";
            e1.Salary = 80000;
            Console.WriteLine($"Id:{e1.Id}  Name:{e1.Name}  Salary:{e1.Salary}");
            Employee5 e2 = new Employee5 { Id = 2, Name = "Shreya", Salary = 60000 };
            Console.WriteLine($"Id:{e2.Id}  Name:{e2.Name}  Salary:{e2.Salary}");
            Console.ReadKey();
        }
    }
}
