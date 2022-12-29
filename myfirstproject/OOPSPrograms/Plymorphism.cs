using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.OOPSPrograms
{
    class Polymorphism
    //Method Overloading//
    {
        int a, b;
        public void GetInfo(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void GetInfo()
        {
            this.a = 1;
            this.b = 8;
        }
        public void GetInfo(int n)
        {
            a = b = n;
        }
        public int Greatest()
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public void PutInfo()
        {
            Console.WriteLine("Greatest is:=" + Greatest());
        }
        static void Main(string[] args)
        {
            Polymorphism P = new Polymorphism();
            P.GetInfo();
            P.PutInfo();
            Console.ReadKey();
        }
    }
}
