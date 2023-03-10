using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace myfirstproject.FileHandeling
{
    class MyThreadDemo
    {
        static void DO()
        {
            for (int i = 0; i <= 5; i++)
            {
                // String s=Thread.CurrentThread.Name;
                Thread.Sleep(1000);
                // Console.WriteLine(s);
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(DO);
            t.Name = "t1";
            t.Start();
            //t.Start();
            Thread t2 = new Thread(DO);
            t2.Name = "t2";
            t2.Start();
            Console.ReadLine();
        }
    }
}
