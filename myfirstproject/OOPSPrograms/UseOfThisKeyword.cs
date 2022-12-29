using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.OOPSPrograms
{
    class UseOfThisKeyword
    {
        int a, b, sum = 0;
        public UseOfThisKeyword()
        {
            a = 0;
            b = 0;
            sum = a + b;
        }
        public UseOfThisKeyword(int a)
        {
            Console.WriteLine("Single parametrized constructor called");
            this.a = a;
            this.b = a;
            sum = a + b;
        }
        public UseOfThisKeyword(int a, int b) : this(a)
        {
            this.a = a;
            this.b = b;
        }
        public void PutInfo()
        {
            Console.WriteLine("Addition is" + sum);
        }
        static void Main(string[] args)
        {
            UseOfThisKeyword UTK = new UseOfThisKeyword();
            UTK.PutInfo();
            UTK = new UseOfThisKeyword(3);
            UTK.PutInfo();
            UTK = new UseOfThisKeyword(10, 3);
            UTK.PutInfo();
            Console.ReadKey();
        }
    }
    class UseOfThisKeyword_1
    {
        int a, b, sum = 0;
        public UseOfThisKeyword_1()
        {
            Console.WriteLine("No parametrized constructor");
        }
        public UseOfThisKeyword_1(int a) : this()
        {
            this.a = a;
            Console.WriteLine(a);
        }
        public UseOfThisKeyword_1(int a, int b) : this(a)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine(a + " " + b);
        }
        static void Main(string[] args)
        {
            UseOfThisKeyword_1 UTK1 = new UseOfThisKeyword_1(2, 5);
            Console.ReadKey();
        }
    }
    class UseOfThisKeyword_2
    {
        int a, b, sum = 0;
        public UseOfThisKeyword_2()
        {
            Console.WriteLine("No parametrized constructor");
        }
        public UseOfThisKeyword_2(int a) : this()
        {
            this.a = a;
            Console.WriteLine(a);
        }
        public UseOfThisKeyword_2(int a, int b) : this(a)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine(a + " " + b);
        }
        public int Greatest(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public void Display()
        {
            int g = this.Greatest(this.a, this.b);
            Console.WriteLine("Greatest is" + g);
        }
        static void Main(string[] args)
        {
            UseOfThisKeyword_2 UTK2 = new UseOfThisKeyword_2(2, 5);
            Console.ReadKey();
        }
    }
}
