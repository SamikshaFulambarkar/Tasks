using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.All_Assignments
{
    class Assgn17DQ1
    // 5.WAP to check if two Strings are anagrams of each other?
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string :");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string :");
            string str2 = Console.ReadLine();
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);
            if (val1 == val2)
            {
                Console.WriteLine("Both the strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagrams");
            }
            Console.ReadKey();
        }
    }
    class Assgn17DQ2
    // 6.Accept a sentence from user and write a logic to do sum of numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String :");
            string str = Console.ReadLine();
            int sum = 0;
            foreach (char ch in str)
            {
                if (ch >= 48 && ch <= 57)
                    sum = sum + int.Parse(ch.ToString());
            }
            Console.WriteLine("Sum of digits presen in string = " + sum);
            Console.ReadKey();
        }
    }
    class Assgn17DQ3
    // 7.Accept a string print following pattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string :");
            string str = Console.ReadLine();
            Console.WriteLine();
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write(str[j]);
                Console.WriteLine();
            }
            for (int i = str.Length - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write(str[j]);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    /*class Test
    // 8.Predict the output of the following program.
    {
        int count = 0;
        void A()
        {
            try
            {
                count++;
                try
                {
                    count++;
                    try
                    {
                        count++;
                        throw new Exception();
                    }
                    catch (Exception ex)
                    {
                        count++;
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    count++;
                }
            }
            catch (Exception ex)
            {
                count++;
            }
        }
        void display()
        {
            Console.WriteLine(count);
        }
        static void main(String[] args)
        {
            Test obj = new Test();
            obj.A();
            obj.display();
        }
    } */
    class Assgn17DQ4
    // 3.WAP to generate NullPointerException ? 
    {
        static string s = null;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(s);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Variable is Null");
            }
            Console.ReadKey();
        }
    }
    class Assgn17DQ5
    /* Write a  program or function which takes two strings as input
     and print common characters between them in alphabetical order. */
    {
        static int MAX_CHAR = 26;
        static void printCommon(string s1, string s2)
        {
            int[] a1 = new int[MAX_CHAR];
            int[] a2 = new int[MAX_CHAR];
            int length1 = s1.Length;
            int length2 = s2.Length;
            for (int i = 0; i < length1; i++)
                a1[s1[i] - 'a'] += 1;
            for (int i = 0; i < length2; i++)
                a2[s2[i] - 'a'] += 1;
            for (int i = 0; i < MAX_CHAR; i++)
            {
                if (a1[i] != 0 && a2[i] != 0)
                {
                    for (int j = 0; j < Math.Min(a1[i], a2[i]); j++)
                        Console.Write(((char)(i + 'a')) + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string 1 :");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter string 2 :");
            string s2 = Console.ReadLine();
            printCommon(s1, s2);
            Console.ReadKey();
        }
    }
}
