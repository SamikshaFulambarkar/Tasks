using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.StringPrograms
{
    class MutableString
    // write code to check string is palindrome or not using the stringbuilder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder(str);
            string rev;
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool check = str.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (check == true)
            {
                Console.WriteLine(" " + sb + " is a palindrome");
            }
            else
            {
                Console.WriteLine(" " + sb + " is not a palindrome");
            }
            Console.ReadKey();
        }
    }
}
