using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.OOPSPrograms
{
    /*class AbstractInterface
    {
        interface IInput
        {
            public int Sum(int x);
        }
        class Display : IInput
        {
            int sum;
            public int Sum(int y)
            {
                for (int i = 1; i <= y; i++)
                {
                    if (y % i == 0)
                    {
                        sum += i;
                    }
                }
                return sum;
            }
        }
        class FactUsingInterface
        {
            static void Main(string[] args)
            {
                Display d = new Display();
                Console.WriteLine("Enter the number: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Sum of factor is: " + d.Sum(num));
                Console.ReadKey();
            }
        }
    }
    abstract class Input
    {
        public int x = 10;
        public abstract void Show();
    }
    interface IProgram
    {
        static int y = 20;
        void Add();
    }
    class Calculate : Input, IProgram
    {
        int sum;
        public void Add()
        {
            sum = x + IProgram.y;
        }
        public override void Show()
        {
            Console.WriteLine("Addition " + sum);
        }
    }

    class Addition
    {
        static void Main(string[] args)
        {
            Calculate c = new Calculate();
            c.Add();
            c.Show();
            Console.ReadKey();
        }
    }
    interface IMovable
    {
        void Move();
    }
    interface IRunnable : IMovable
    {
        void Run();
    }
    class Car : IRunnable
    {
        public void Move()
        {
            Console.WriteLine("car is moving");
        }
        public void Run()
        {
            Console.WriteLine("car is running");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            IRunnable r = new Car();
            r.Move();
            r.Run();
            Console.ReadKey();
        }
    }*/
}
