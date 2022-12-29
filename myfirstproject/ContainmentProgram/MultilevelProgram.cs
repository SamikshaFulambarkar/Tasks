using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.ContainmentProgram
{
    class Human
    // write code to show single inheritence using a real time example.
    {
        public int legs = 2;
        public int hands = 2;
    }
    class Male_Female : Human
    {
        void Show()
        {
            Console.WriteLine("Male & female has " + legs + " legs and " + hands + " hands");
        }
        static void Main(string[] args)
        {
            Male_Female mf = new Male_Female();
            mf.Show();
            Console.ReadKey();
        }
    }
    class Vehicle
    // write code to show multilevel inheritence using a real time example.
    {
        public int wheels = 4;
        public void ShowVehicleData()
        {
            Console.WriteLine("Wheels of vehicle : " + wheels);
        }
    }
    class Truck : Vehicle
    {
        public void Show()
        {
            Console.WriteLine(wheels);
        }
    }
    class Tank_Truck : Truck
    {
        public void NoOfWheels()
        {
            wheels = 6;
        }
        public void DisplayData()
        {
            Console.WriteLine("Tank-Truck wheels : " + wheels);
        }
    }
    class MultilevelProgram
    {
        static void Main(string[] args)
        {
            Tank_Truck T = new Tank_Truck();
            T.Show();
            T.ShowVehicleData();
            T.NoOfWheels();
            T.DisplayData();
            Console.ReadKey();
        }
    }
    class Fruit
    // write code to show hierarchical inheritence using a real time example.
    {
        public string seeds;
        public void NoOfSeeds()
        {
            Console.WriteLine("Fruits having seeds");
        }
    }
    class Mango : Fruit
    {
        public void ShowMango()
        {
            seeds = "Only one";
            Console.WriteLine("Mango having " + seeds + " seed");
        }
    }
    class Watermelon : Fruit
    {
        public void ShowWatermelon()
        {
            seeds = "Multi";
            Console.WriteLine("Watermelon having " + seeds + " seeds");
        }
    }
    class HierarchicalProgram
    {
        static void Main(string[] args)
        {
            Mango M = new Mango();
            M.NoOfSeeds();
            M.ShowMango();
            Watermelon W = new Watermelon();
            W.NoOfSeeds();
            W.ShowWatermelon();
            Console.ReadKey();
        }
    }
    class Classroom
    // create a one class and show all the uses of base-keywords
    {
        public string Student_name = "XYZ";
    }
    class Boys_Girls : Classroom
    {
        public string Student_name = "ABC";
        public void Show()
        {
            Console.WriteLine(Student_name + "  " + base.Student_name);
        }
    }
    class BaseProgram
    {
        static void Main(string[] args)
        {
            Boys_Girls st = new Boys_Girls();
            st.Show();
        }
    }
    class Classroom1
    {
        public string Student_name = "XYZ";
        public void Show()
        {
            Console.WriteLine("Classroom");
        }
    }
    class Boys_Girls1 : Classroom1
    {
        public string Student_name = "ABC";
        public void Show()
        {
            Console.WriteLine(Student_name + "  " + base.Student_name);
            base.Show();
        }
    }
    class BaseProgram1
    {
        static void Main(string[] args)
        {
            Boys_Girls1 st = new Boys_Girls1();
            st.Show();
            Console.ReadKey();
        }
    }
}
