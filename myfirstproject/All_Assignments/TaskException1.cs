using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.All_Assignments
{
    class TaskException1
    /* 4.WAP which throws IndexOutOfRangeException. In the console, observe the stack trace and the line number
     from where the Exception is thrown */
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 2, 3, 4, 5 };
            for (int i = 0; i <= ar.Length; i++)
                Console.WriteLine(ar[i]);
            Console.ReadKey();
        }
    }
    class TaskException2
    // 5.WAP to use catch / handle the IndexOutOfRangeException exception. 
    {
        public void calculatedifference()
        {
            int difference = 0;
            int[] number = new int[5] { 1, 2, 3, 4, 5 };
            try
            {
                for (int init = 1; init <= 5; init++)
                {
                    difference = difference - number[init];
                }
                Console.WriteLine("The difference of the array is:" + difference);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    class classmain
    {
        static void Main(string[] args)
        {
            TaskException2 obj = new TaskException2();
            obj.calculatedifference();
            Console.ReadLine();
            Console.ReadKey();
        }
    }
    class TaskException3
    // 6.WAP to catch multiple exceptions. i.e IndexOutOfRangeException, NullReferenceException and DivideByZeroException.
    {
        static void Main(string[] args)
        {
            try
            {
                throw new DivideByZeroException();
            }
            catch (Exception e)
            {
                switch (e.GetType().ToString())
                {
                    case "System.NullReferenceException":
                        Console.WriteLine("NullReferenceException occured");
                        break;
                    case "System.DivideByZeroException":
                        Console.WriteLine("DivideByZeroException occured");
                        break;
                    case "System.IndexOutOfRangeException":
                        Console.WriteLine("IndexOutOfRangeException occured");
                        break;
                    default:
                        Console.WriteLine("Exception occured");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
    class TaskException4
    // 7.WAP to show checked exception and use multiple catch block with universal Exception handler.
    {
        static void Main(string[] args)
        {
            int Number1, Number2, Result;
            try
            {
                Console.WriteLine("Enter First Number");
                Number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                Number2 = int.Parse(Console.ReadLine());
                Result = Number1 / Number2;
                Console.WriteLine($"Result: {Result}");
            }
            catch (DivideByZeroException DBZE)
            {
                Console.WriteLine("Second Number Should Not Be Zero");
            }
            catch (FormatException FE)
            {
                Console.WriteLine("Enter Only Integer Numbers");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Catch Block...");
            }
            Console.ReadKey();
        }
    }
    class ExceptionClass5
    /* WAP to check Exception handling with method overriding. Means, If super class method don’t 
        declare exception then subclass overridden method can declare exception or not. */
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent Class Show Method");
        }
    }
    class ExceptionClass6 : ExceptionClass5
    {
        public override void Show()
        {
            Console.WriteLine("Child Class Show Method");
        }
    }
    class TaskException5
    {
        static void Main(string[] args)
        {
            ExceptionClass5 obj1 = new ExceptionClass6();
            obj1.Show();
            ExceptionClass6 obj2 = new ExceptionClass6();
            obj2.Show();
            Console.ReadKey();
        }
    }
    class StudentException6
    // 9.WAP to create custom Exception and show use of throw keyword
    {
        private readonly bool StudentName;

        static void Main(string[] args)
        {
            StudentException6 std = null;

            try
            {
                PrintStudentName(std);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
        private static void PrintStudentName(StudentException6 std)
        {
            if (std == null)
                throw new NullReferenceException("Student object is null.");

            Console.WriteLine(std.StudentName);
        }
    }
    class TestFitness
    // 10.WAP to create user defined Exception raise and catch the exception.
    {
        static void Main(string[] args)
        {
            TestFitness f = new TestFitness();
            try
            {
                f.showResult();
            }
            catch (FitnessTestFailedException e)
            {
                Console.WriteLine("User defined exception: {0}", e.Message);
            }
            Console.ReadKey();
        }

        private void showResult()
        {
            throw new NotImplementedException();
        }
    }
    public class FitnessTestFailedException : Exception
    {
        public FitnessTestFailedException(string message) : base(message)
        {

        }
        public class Fitness
        {
            int points = 0;
            public void showResult()
            {
                if (points < 110)
                {
                    throw (new FitnessTestFailedException("Player failed the fitness test!"));
                }
                else
                {
                    Console.WriteLine("Player passed the fitness test!");
                }
            }
        }
    }
}
