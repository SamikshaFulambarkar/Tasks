using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.OOPSPrograms
{
    public class Demo
    {
        const int no = 80;
        public void show()
        {
            Console.WriteLine("No is " + no);
        }
    }
    class UseConstantKeyword
    {
        static void Main(string[] args)
        {
            const double PI = 3.14;
            double r = 2.3, area;
            area = PI * r * r;
            Console.WriteLine("Area " + area);
            Console.ReadKey();
        }
    }
    class UseReadonly
    {
        public class Student
        {
            public readonly int rollno;
            public string name;
            public Student(int rollno, string name)
            {
                this.rollno = rollno;
                this.name = name;
            }
            public void Display()
            {
                Console.WriteLine("Roll no " + rollno);
                Console.WriteLine("Name " + name);
            }
        }
        static void Main(string[] args)
        {
            Student st1 = new Student(1, "Shreya");
            Student st2 = new Student(2, "Neha");
            Student st3 = new Student(3, "Sneha");
            st1.Display();
            st2.Display();
            st3.Display();
            Console.ReadKey();
        }
    }
}
