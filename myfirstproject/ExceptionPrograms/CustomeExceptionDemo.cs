using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.ExceptionPrograms
{
    class NotBinaryNumberException : SystemException
    /* write code to create custom exception where to check the given no. is binary or not
    if it is not binary then throw custom exception invalid custom system */
    {
        public NotBinaryNumberException()
        {
            Console.WriteLine("NotBinaryNumberException");
        }
        public NotBinaryNumberException(string s) : base(s)
        {

        }
    }
    class CustomeExceptionDemo
    {
        public static void check(string s)
        {
            bool ispresent = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '0' && s[i] != '1')
                {
                    ispresent = true;
                    break;

                }
            }
            if (ispresent == true)
            {
                throw new NotBinaryNumberException();
            }
            Console.WriteLine("valid Number");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string.");
            string s = Console.ReadLine();
            try
            {
                check(s);
            }
            catch
            {
                Console.WriteLine("handle");
            }
            Console.ReadKey();
        }
    }
    class NegativeNumberException : SystemException
    {
        public NegativeNumberException()
        {
            Console.WriteLine("Negative number Exception");
        }
        public NegativeNumberException(string s) : base(s)
        {

        }
    }
    class CustomExceptionDemo2
    {
        public static void Valid(int n)
        {
            if (n < 0)
            {
                throw new NegativeNumberException("Invalid negative number");
            }
            else
            {
                Console.WriteLine("Valid number");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Valid(-2);
            }
            catch (Exception e)
            {
                Console.WriteLine("Handle.............." + e.Message);
            }
            Console.ReadKey();
        }
    }
    class NumberNotAllowedException : SystemException
    {
        public NumberNotAllowedException()
        {
            Console.WriteLine("Digit Not allowed in Text");
        }
    }
    class CustomeExceptionDemo3
    {
        public static void Check(string s)
        {
            bool ispresent = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    ispresent = true;
                    break;
                }
                if (ispresent == true)
                {
                    throw new NumberNotAllowedException();
                }
                Console.WriteLine("Valid string");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string s = Console.ReadLine();
            try
            {
                Check(s);
            }
            catch
            {
                Console.WriteLine("Handle..........");
            }
            Console.ReadKey();
        }
    }
    class NoDigitNumber : SystemException
    /* take a one string from user & check only digit if it is contain any alphabet then throw custom exception
   if it is contain digits then find out it contain only 10 digit if no.< or > 10 then throw custom exception */
    {
        public NoDigitNumber()
        {
            Console.WriteLine("Alphabet not acceptable");
        }
    }
    class InvalidNumber : SystemException
    {
        public InvalidNumber()
        {
            Console.WriteLine("Invalid Number");
        }
    }
    class CustomStringTask
    {
        public static void onlyDigits(string str)
        {
            char[] ch = str.ToCharArray();
            int cnt = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (Char.IsDigit(ch[i]))
                {
                    cnt++;
                }
                else
                {
                    throw new NoDigitNumber();
                }
            }
            if (cnt == 10)
            {
                Console.WriteLine("Valid Number");
            }
            else
            {
                throw new InvalidNumber();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string str = Console.ReadLine();
            try
            {
                onlyDigits(str);
            }
            catch
            {
                Console.WriteLine("Handle.......");
            }
            Console.ReadKey();
        }
    }
}
