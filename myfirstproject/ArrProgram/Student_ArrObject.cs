using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.ArrProgram
{
    class Student_ArrObject
    {
        int id;
        string name;
        int marks;
        public int ID { get; set; }
        public string NAME { get; set; }
        public int MARKS { get; set; }

        static void Main(string[] args)
        {
            Student_ArrObject[] stud = new Student_ArrObject[3];
            for (int i = 0; i < stud.Length; i++)
            {
                stud[i] = new Student_ArrObject();
                Console.WriteLine("Enter ID:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter NAME:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Marks:");
                int marks = int.Parse(Console.ReadLine());
                stud[i].ID = id;
                stud[i].NAME = name;
                stud[i].MARKS = marks;
            }
            Console.WriteLine("ID \tNAME\tMARKS");
            foreach (Student_ArrObject s in stud)
            {
                Console.WriteLine(s.ID + "\t" + s.NAME + "\t" + s.MARKS);
            }
            Console.ReadKey();
        }
    }
    class Employee_ArrObject
    {
        int id;
        string name;
        int salary;
        public int ID { get; set; }
        public string NAME { get; set; }
        public int SALARY { get; set; }

        static void Main(string[] args)
        {
            Employee_ArrObject[] emp = new Employee_ArrObject[3];
            for (int i = 0; i < emp.Length; i++)
            {
                emp[i] = new Employee_ArrObject();
                Console.WriteLine("Enter ID:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter NAME:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Salary:");
                int salary = int.Parse(Console.ReadLine());
                emp[i].ID = id;
                emp[i].NAME = name;
                emp[i].SALARY = salary;
            }
            Console.WriteLine("ID \tNAME\tSALARY");
            foreach (Employee_ArrObject em in emp)
            {
                Console.WriteLine(em.ID + "\t" + em.NAME + "\t" + em.SALARY);
            }
            Console.ReadKey();
        }
    }
    class Student1
    {
        int id;
        string name;
        int marks;
        public Student1()
        {
            id = 0;
            name = "";
            marks = 0;
            Console.WriteLine("Default constructor");
        }
        public Student1(int id, string name, int marks) : this()
        {
            this.id = id;
            this.name = name;
            this.marks = marks;
        }
        public void display()
        {
            Console.WriteLine(id + "\t" + name + "\t" + marks);
        }
        static void Main(string[] args)
        {
            Student1[] stud = new Student1[3];
            for (int i = 0; i < stud.Length; i++)
            {
                Console.WriteLine("Enter ID:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter NAME:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Marks:");
                int marks = int.Parse(Console.ReadLine());
                stud[i] = new Student1(id, name, marks);
            }
            Console.WriteLine("ID \tNAME\tMARKS");
            foreach (Student1 s in stud)
            {
                s.display();
            }
            Console.ReadKey();
        }
    }
    class Employee1
    {
        int id;
        string name;
        int salary;
        public Employee1()
        {
            id = 0;
            name = "";
            salary = 0;
        }
        public Employee1(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine(id + "\t" + name + "\t" + salary);
        }
        static void Main(string[] args)
        {
            Employee1[] emp = new Employee1[3];
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine("Enter ID:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter NAME:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Salary:");
                int salary = int.Parse(Console.ReadLine());
                emp[i] = new Employee1(id, name, salary);
            }
            Console.WriteLine("ID \tNAME\tMARKS");
            foreach (Employee1 e in emp)
            {
                e.display();
            }
            Console.ReadKey();
        }
    }
}
