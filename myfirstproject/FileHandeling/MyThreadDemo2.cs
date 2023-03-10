using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace myfirstproject.FileHandeling
{
    class MyThreadDemo2
    {
        static object mylock = new object();
        public static void Print()
        {
            lock(mylock)
            {
                Console.WriteLine(Thread.CurrentThread.Name+"  "+((int)Thread.CurrentThread.Priority));
                Console.WriteLine(Thread.CurrentThread.Name+"  "+Thread.CurrentThread.Priority);
                for(int i=1; i<=5; i++)
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
            t1.Priority = (ThreadPriority)4;
            Thread t2 = new Thread(Print);
            t2.Name = "Thread-2";
            t2.Priority = 0;
            Thread t3 = new Thread(Print);
            t3.Name = "Thread-3";
            t3.Priority = (ThreadPriority)1;
            Thread t4 = new Thread(Print);
            t4.Name = "Thread-4";
            t4.Priority = (ThreadPriority)2;
            Thread t5 = new Thread(Print);
            t5.Name = "Thread-5";
            t5.Priority = (ThreadPriority)3;
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            Console.ReadKey();
        }
    }
}
