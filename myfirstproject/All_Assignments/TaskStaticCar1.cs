using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.All_Assignments
{
    class TaskStaticCar1
    // 1.Create a class Car with String model and int totalCarSold as static variable in main() method.
    {
        static string model = "we33";
        static int totalcarsold = 23;
        static void Main(string[] args)
        {
            Console.WriteLine("model is " + TaskStaticCar1.model);
            Console.WriteLine("totalcarsold " + TaskStaticCar1.totalcarsold);
            TaskStaticCar1.model = "qw234";
            Console.WriteLine("model is " + TaskStaticCar1.model);
            TaskStaticCar1 car1 = new TaskStaticCar1();
            // car1. model = "qwrty456"; cannot aceess with instance of car
            TaskStaticCar1 car2 = new TaskStaticCar1();
            Console.ReadKey();
        }
    }
    class TaskStaticStudent2
    // 2.Change the value of variable by class name then Print it.
    {
        public string studentName;
        static string schoolName = "Genius School";
        static void Main(string[] args)
        {
            TaskStaticStudent2 s1 = new TaskStaticStudent2();
            s1.studentName = "Sapna";
            Console.WriteLine("Name =" + s1.studentName);//call instance variable
            Console.WriteLine("School Name=" + TaskStaticStudent2.schoolName);//call static variable
            Console.ReadKey();
        }
    }
    class TaskStaticSum3
    /* 5.See if you can overload static method, by using static keyword for 2nd overloaded method
    / and without using static keyword.    */
    {
        public static void Sum(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("The sum is: " + c);
        }
        public void Sum(float a, float b)
        {
            float c = a + b;
            Console.WriteLine("The sum is: " + c);
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.Sum(12.3f, 2.3f);
            Console.ReadKey();
        }
    }
    public class Parent
    // See if you can override static method.
    {
        string name = "Sapna";
        public virtual void showdata()
        {
            Console.WriteLine(" Name=: " + name);
        }
    }
    class Child : Parent
    {
        string s = " Software Engineer";
        public override void showdata()
        {
            base.showdata();

            Console.WriteLine("Position=" + s);
        }
    }
    class TaskStatic4
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.showdata();
            Console.ReadKey();
        }
    }
    class A
    // 7.WAP to check whether you can inherit static variable of Parent class in Child class
    {
        public static int num = 20;
        public static void Display()
        {
            Console.WriteLine("Static Method");
        }
    }
    class B : A
    {
        public void Display1()
        {

        }
    }
    class TaskStatic5
    {
        public static void Main(string[] args)
        {
            B.Display();
            Console.WriteLine(B.num);
            Console.ReadKey();
        }
    }
    class TaskStatic6
    // 1.Write a method to accept variable no of integers. Method should find sum of all the integers and display the result.
    {
        public static int Sumval(params int[] num)
        {
            int res = 0;
            foreach (int j in num)
            {
                res += j;
            }
            return res;
        }
        static void Main(string[] args)
        {
            int x = Sumval(21, 26, 16, 5);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
    class Class1
    // Write a  program to show the use of method overriding.
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent Class Show Method");
        }
    }
    class Class2 : Class1
    {
        public override void Show()
        {
            Console.WriteLine("Child Class Show Method");
        }
    }
    class TaskStatic7
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class2();
            obj1.Show();
            Class2 obj2 = new Class2();
            obj2.Show();
            Console.ReadKey();
        }
    }
    class TaskStaticThisKeyword
    // WAP to show all the use of ‘this’ keyword.
    {
        int a, b, sum;
        public TaskStaticThisKeyword()
        {
            a = 0;
            b = 0;
            sum = a + b;
        }
        public TaskStaticThisKeyword(int a)
        {
            Console.WriteLine("Single parameterized constructor called");
            this.a = a;
            this.b = a;
            sum = a + b;
        }
        public TaskStaticThisKeyword(int a, int b) : this(a)
        {
            this.a = a;
            this.b = b;
        }
        public void putinfo()
        {
            Console.WriteLine("Addition is" + sum);
        }
        static void Main(string[] args)
        {
            TaskStaticThisKeyword obj = new TaskStaticThisKeyword();
            obj.putinfo();
            obj = new TaskStaticThisKeyword(3);
            obj.putinfo();
            obj = new TaskStaticThisKeyword(10);
            obj.putinfo();
            Console.ReadKey();
        }
    }
    class Program45
    {
        void Display(int a)
        {
            Console.WriteLine("Number: " + a);
        }
        void Display(int a, int b)
        {
            Console.WriteLine("Number is: " + a + " and " + b);
        }
        static void Main(string[] args)
        {
            Program45 p1 = new Program45();
            p1.Display(100);
            p1.Display(100, 200);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
