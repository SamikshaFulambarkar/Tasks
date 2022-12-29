using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.OOPSPrograms
{
    /* public class Demo1
     {
         static int no;
         int x;
         public void Getno()
         {
             Console.WriteLine("Static value is "+no);
         }
         public void PutData(int n)
         {
             x = n;
             no++;
         }
         public void GetData()
         {
             Console.WriteLine("Instance  variable x: "+x);
         }
     }
     class ObjectOrientedEx
     {
         static int x, y;
         int no = 4;
         public void Add()
         {
             int sum=x + y;
             Console.WriteLine("Addition "+sum);
             Console.WriteLine("Member variable is "+no);
         }
         static void Main(string[] args)
         {
             Demo1 d1 = new Demo1();
             Demo1 d2 = new Demo1();
             Demo1 d3 = new Demo1();
             d1.Getno();
             d2.Getno();
             d3.Getno();
             d1.PutData(100);
             d2.PutData(200);
             d3.PutData(300);
             d1.Getno();
             d2.Getno();
             d3.Getno();
             d1.GetData();
             d2.GetData();
             d3.GetData();
     Console.ReadKey();
         }
     }*/
    /*public class Demo2
    {
        static int no;
        int x;
        public void Getno()
        {
            Console.WriteLine("Static value is " + no);
        }
        public void PutData(int n)
        {
            x = n;
            no++;
        }
        public static void ShowNo()
        {
            Console.WriteLine("No of objects are created " + no);
        }
        public void GetData()
        {
            Console.WriteLine("Instance  variable x: " + x);
        }
    }
    class StaticExample
    {
        static void Main(string[] args)
        {
            Demo2 d1 = new Demo2();
            Demo2 d2 = new Demo2();
            d1.PutData(100);
            d2.PutData(200);
            Demo2.ShowNo();
            Demo2 d3 = new Demo2();
            d3.PutData(300);
            Demo2.ShowNo();
            Demo2 d4 = new Demo2();
            d4.PutData(400);
            Demo2.ShowNo();
     Console.ReadKey();
        }
    }
    public class Cube2
    {
        int side;
        static int objectCount = 0;
        Cube2()
        {
            objectCount++;
        }
        Cube2(int x)
        {
            side = x;
            objectCount++;
        }
        public static void main(String[] args)
        {
            // TODO code application logic here
            Cube2 c1 = new Cube2(5);
            Cube2 c2 = new Cube2(8);
            Cube2 c3 = new Cube2(10);
            Console.WriteLine("Number of Cube Objects: " + objectCount);
     Console.ReadKey();
        }
    }*/
    public class Circle1
    {
        static double PI = 3.14;
        double r;
        static int c;
        public Circle1()
        {
            c++;
        }
        public Circle1(double pI, double r)
        {
            PI = pI;
            this.r = r;
            c++;
        }
        public static int ReturnObjectCount()
        {
            return c;
        }
        public double Area()
        {
            double a = PI * r * r;
            return a;
        }
    }
    internal class StaticVariable1
    {
        static void Main(string[] args)
        {
            Circle1 c = new Circle1();
            Console.WriteLine("Objects created are " + Circle1.ReturnObjectCount());
            Circle1 c1 = new Circle1(3.14, 3.4);
            Console.WriteLine("Objects created are " + Circle1.ReturnObjectCount());
            Console.WriteLine("Area is " + c1.Area());
            Circle1 c2 = new Circle1(3.14, 5.4);
            Console.WriteLine("Area is " + c2.Area());
            Console.WriteLine("Objects created are " + Circle1.ReturnObjectCount());
            Circle1 c4 = new Circle1();
            Console.WriteLine("Objects created are " + Circle1.ReturnObjectCount());
            Console.ReadKey();
        }
    }
}
