using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.Linq_Programs
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Dept_Name { get; set; }
        public override string ToString()
        {
            return $"ID->{ID}, Name->{Name}, Salary->{Salary}, Dept_Name->{Dept_Name}";
        }
    }
    class LinqDemoProgram
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee { ID = 101, Name = "Shreya Shahu", Salary = 56000, Dept_Name = "HR" },
                new Employee { ID = 102, Name = "Neha Sharma", Salary = 48000, Dept_Name = "RND" },
                new Employee { ID = 103, Name = "Nikita Mane", Salary = 55000, Dept_Name = "SD" },
                new Employee { ID = 104, Name = "Ankita Shah", Salary = 32000, Dept_Name = "Finance" },
                new Employee { ID = 105, Name = "Priya Verma", Salary = 40000, Dept_Name = "Sales" },
                new Employee { ID = 106, Name = "Snehal Chaudhari", Salary = 50000, Dept_Name = "RND" },
                new Employee { ID = 107, Name = "Ashwini Pode", Salary = 35000, Dept_Name = "HR" },
                new Employee { ID = 108, Name = "Sonal Mishra", Salary = 38000, Dept_Name = "SD" },
                new Employee { ID = 109, Name = "Avantika Netke", Salary = 41000, Dept_Name = "Finance" },
                new Employee { ID = 110, Name = "Swara Sahare", Salary = 45000, Dept_Name = "Sales" },
            };
            // Display all Employees
            var result1 = from e in emp select e;
            foreach (Employee e in result1)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("....................");
            // Display Employee from HR dept
            var result2 = from e in emp where e.Dept_Name.Contains("HR") select e;
            foreach (Employee e in result2)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine(".....................");
            // Display Employee salary in desc order
            var result3 = from e in emp where e.Salary<=50000 orderby e.Name descending select e;
            foreach (Employee e in result3)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine(".....................");
            // Display employee whose name start with p
            var result4 = from e in emp where e.Name.StartsWith("P") orderby e.Name ascending select e;
            foreach (Employee e in result4)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine(".....................");
            // display emp whose dept is development & sort the list by name asc
            var result5 = from e in emp where e.Dept_Name.Contains("SD") orderby e.Name ascending select e;
            foreach (Employee e in result5)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine(".....................");
            // display emp whose salary is in between 35000 to 55000
            var result6 = from e in emp where e.Salary >= 35000 && e.Salary <= 55000 select e;
            foreach (Employee e in result6)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
