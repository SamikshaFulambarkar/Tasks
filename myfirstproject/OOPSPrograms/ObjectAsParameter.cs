using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.OOPSPrograms
{
    class ObjectAsParameter
    {
        int no, sum;
        public ObjectAsParameter(int no)
        {
            this.no = no;
        }
        public void Add(ObjectAsParameter OP)
        {
            sum = this.no + OP.no;
        }
        public bool Compare(ObjectAsParameter OP)
        {
            if (no > OP.no)
                return true;
            else
                return false;
        }
        public void PutInfo()
        {
            Console.WriteLine("Addition of two objects is" + sum);
        }
        static void Main(string[] args)
        {
            ObjectAsParameter OP1 = new ObjectAsParameter(30);
            ObjectAsParameter OP2 = new ObjectAsParameter(20);
            OP1.Add(OP2);
            OP2.Add(OP1);
            OP1.PutInfo();
            OP2.PutInfo();
            if (OP1.Compare(OP2))
                Console.WriteLine("First Object is greatest");
            else
                Console.WriteLine("Second Object is greatest");
            Console.ReadKey();
        }
    }
    class ObjectReturning
    {
        int no;
        public ObjectReturning()
        {
            this.no = 0;
        }
        public ObjectReturning(int no)
        {
            this.no = no;
        }
        public void Display()
        {
            Console.WriteLine("Number is " + no);
        }
        public ObjectReturning add(ObjectReturning OR)
        {
            ObjectReturning temp = new ObjectReturning();
            temp.no = this.no + OR.no;
            return temp;
        }
        public ObjectReturning Compare(ObjectReturning OR)
        {
            ObjectReturning temp = new ObjectReturning();
            if (this.no > OR.no)
                temp = this;
            else
                temp = OR;
            return temp;
        }
        static void Main(string[] args)
        {
            ObjectReturning OR1 = new ObjectReturning(9);
            ObjectReturning OR2 = new ObjectReturning(5);
            ObjectReturning OR3 = OR1.add(OR2);
            OR1.Display();
            OR2.Display();
            OR3.Display();
            Console.WriteLine("After Comparison");
            OR3 = OR1.Compare(OR2);
            OR1.Display();
            OR2.Display();
            OR3.Display();
            Console.ReadKey();
        }
    }
    class Time
    {
        int hr, min;
        public Time()
        {
            hr = 0;
            min = 0;
        }
        public Time(int hr, int min)
        {
            this.hr = hr;
            this.min = min;
        }
        public void ShowTime()
        {
            Console.WriteLine("Time is " + hr + " : " + min);
        }
        public Time AddTime(Time T)
        {
            Time temp = new Time();
            temp.hr = this.hr + T.hr;
            temp.min = this.min + T.min;
            if (temp.min >= 60)
            {
                temp.min = temp.min % 60;
                temp.hr++;
            }
            return temp;
        }
        static void Main(string[] args)
        {
            Time T1 = new Time(3, 40);
            Time T2 = new Time(4, 55);
            T1.ShowTime();
            T2.ShowTime();
            Time T3 = new Time();
            T3 = T1.AddTime(T2);
            T3.ShowTime();
            Console.ReadKey();
        }
    }
}
