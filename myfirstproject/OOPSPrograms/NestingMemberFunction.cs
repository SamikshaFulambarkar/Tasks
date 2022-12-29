using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.OOPSPrograms
{
    class NestingMemberFunction
    {
        int a, b;
        public void GetInfo(int a, int b)
        {
            this.a = a;
            this.b = b;
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
            NestingMemberFunction N = new NestingMemberFunction();
            N.GetInfo(4, 6);
            N.PutInfo();
            Console.ReadKey();
        }
    }
}
