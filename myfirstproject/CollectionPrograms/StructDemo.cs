using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.CollectionDemo
{
    struct Mystruct
    {
        public int x;
        public int y;
    }
    class StructDemo
    {
        static void Main(string[] args)
        {
            Mystruct s = new Mystruct();
            s.x = 90;
            s.y = 45;
            Console.WriteLine(s.x);
            Console.WriteLine(s.y);
            Console.ReadKey();
        }
    }
    struct Mystruct2
    {
        public int x;
        public int y;

        public Mystruct2(int x, int y )
        {
            this.x = x;
            this.y = y;
        }
    }
    class StructDemo2
    {
        static void Main(string[] args)
        {
            Mystruct2 s = new Mystruct2(100, 200);
            Console.WriteLine(s.x);
            Console.WriteLine(s.y);
        }
    }
    struct Mystruct3
    {
        int x;
        int y;

        public int X
        {
            set;
            get;
        }
        public int Y
        {
            set;
            get;
        }
    }
    class StructDemo3
    {
        static void Main(string[] args)
        {
            Mystruct3 s = new Mystruct3();
            s.X = 90;
            s.Y = 83;
            Console.WriteLine(s.X);
            Console.WriteLine(s.Y);
        }
    }
    struct Mystruct4
    {
        int x;
        int y;

        public void MyData()
        {
            Console.WriteLine("This is My Method....................");
        }
    }
    class StructDemo4
    {
        static void Main(string[] args)
        {
            Mystruct4 s = new Mystruct4();
            s.MyData();
        }
    }
}
