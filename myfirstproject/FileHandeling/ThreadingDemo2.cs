using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace myfirstproject.FileHandeling
{
    /*class ThreadingDemo2
    {
        static Object mylock = new object();
        static Object newlock=new object();
        public static void Print()
        {
            lock (mylock)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
                for (int i = 1; i <= 5; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(i);
                }
            }
        }
        public static void Print2()
        {
            lock (newlock)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
                for (int i = 1; i <= 3; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Print);
            t1.Name = "Thread-1";
            Thread t2 = new Thread(Print2);
            t2.Name = "Thread-2";
            t1.Start();
            t1.Join();
            t2.Start();
            Console.ReadKey();
        }
    }*/
    class ThreadingDemo2
    {
        static Object mylock = new object();
        public static void Print(int num)
        {
            lock (mylock)
            {
                //int x = 5;
                //int n = 3;
                for(int i=1; i<=10; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(num*i);
                }       
            }  
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(() => Print(5));
            t1.Name = "Thread-1";

            Thread t2 = new Thread(() => Print(3));
            t2.Name = "Thread-2";

            t1.Start();
            t1.Join();
            t2.Start();
            Console.ReadKey();
        }
    }
    class PrintTable
    {
        public void Table(int num)
        {
            for(int i=1; i<=10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(num*i);
            }
        }
        static void Main(string[] args)
        {
            PrintTable t1 = new PrintTable();
            Console.WriteLine("Thread-1");
            t1.Table(5);
            PrintTable t2 = new PrintTable();
            Console.WriteLine("Thread-2");
            t2.Table(3);
            Console.ReadKey();
        }
    }
}
