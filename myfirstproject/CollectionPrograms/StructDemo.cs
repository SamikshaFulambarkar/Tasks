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
}
