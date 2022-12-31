using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace myfirstproject.CollectionPrograms
{
    class TupleDemo
    {
        static void Main(string[] args)
        {
            var mytuple = Tuple.Create(2, "One", 9, "Four");
            Console.WriteLine(mytuple.Item1);
            Console.WriteLine(mytuple.Item3);

            var nesttuple = Tuple.Create(1, 2, Tuple.Create(100, 200));
            Console.WriteLine(nesttuple.Item1);
            
        }
    }
}
