using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace myfirstproject.CollectionPrograms
{
    class HashtableDemo1
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable()
            {
                {1, "yash" },
                {2, "Pune" },
                {"1223", "Mumbai" }
            };
            foreach (DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key + "  " + kv.Value);
            }
            ht.Remove(1);
            Console.WriteLine(".....................");
            foreach (DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key + "  " + kv.Value);
            }
            Console.WriteLine("///////////////////////////////////");

            Dictionary<int, string> dm = new Dictionary<int, string>();
            dm.Add(5, "red");
            dm.Add(6, "green");
            dm.Add(1, "pink");
            foreach (KeyValuePair<int, string> kv in dm)
            {
                Console.WriteLine(kv.Key + "  " + kv.Value);
            }
            Hashtable t = new Hashtable(dm);
            Console.WriteLine("..............................");
            foreach (DictionaryEntry de in t)
            {
                Console.WriteLine(de.Key + "  " + de.Value);
            }
            Console.ReadKey();
        }
    }
}
