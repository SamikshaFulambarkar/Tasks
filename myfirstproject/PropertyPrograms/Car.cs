using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.PropertyPrograms
{
    class Car
    {
        public int cmodel;
        public string cname;
        public int cprice;
        public string ccolor;
        static void Main(string[] args)
        {
            Car C1 = new Car();
            C1.cmodel = 2219;
            C1.cname = "Audi";
            C1.cprice = 2500000;
            C1.ccolor = "Black";
            Console.WriteLine(C1.cmodel + " " + C1.cname + " " + C1.cprice + " " + C1.ccolor);

            Car C2 = new Car();
            C2.cmodel = 2218;
            C2.cname = "BMW";
            C2.cprice = 3500000;
            C2.ccolor = "White";
            Console.WriteLine(C2.cmodel + " " + C2.cname + " " + C2.cprice + " " + C2.ccolor);

            Car C3 = new Car();
            C3.cmodel = 2217;
            C3.cname = "Mercedes";
            C3.cprice = 4500000;
            C3.ccolor = "Red";
            Console.WriteLine(C3.cmodel + " " + C3.cname + " " + C3.cprice + " " + C3.ccolor);
            Console.ReadKey();
        }
    }
    class Student
    {
        public int SId;
        public string SName;
        public int Phy;
        public int Chem;
        public int Math;
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.SId = 26;
            S1.SName = "Shreya";
            S1.Phy = 75;
            S1.Chem = 82;
            S1.Math = 89;
            Console.WriteLine(S1.SId + " " + S1.SName + " " + S1.Phy + " " + S1.Chem + " " + S1.Math);
            int total = 75 + 82 + 89;
            Console.WriteLine(total);
            float percentage = (total / 3);
            Console.WriteLine(percentage + "%");
            Console.ReadKey();
        }
    }
    class Box
    {
        public int l;
        public int w;
        public int h;
        static void Main(string[] args)
        {
            Box B1 = new Box();
            B1.l = 5;
            B1.w = 2;
            B1.h = 4;
            Console.WriteLine(B1.l + " " + B1.w + " " + B1.h);
            int area = 2 * (5 * 2 + 5 * 4 + 2 * 4);
            Console.WriteLine(area);
            Console.ReadKey();
        }
    }

}
