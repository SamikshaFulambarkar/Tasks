using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.All_Assignments
{
    abstract class Teacher
    /* 1.Create class Teacher with following
        Tid,Tname,MobileNo
        Parameterized constructor
        abstract void salary()
         Create class Hourlybased which is derived class from teacher with fields
        rate_per_hr,
        int hrs;
        Parameterized constructor
        void salary()
        Create class SalaryBased which is derived class from teacher
        with fields
        int salary;
        Parameterized constructor
        void salary()
        Write main to create objects of HourlyBased teacher and SalaryBased teacher and 
        also call respective salary method and also show runtime polymorphism  */
    {
        public int Tid;
        public string Tname;
        public long MobileNo;

        public Teacher(int id, string name, long mobNo)
        {
            this.Tid = id;
            this.Tname = name;
            this.MobileNo = mobNo;
        }
        public abstract void Salary();
    }
    class Hourlybased : Teacher
    {
        public int rate_per_hr;
        public int hrs;
        public Hourlybased(int RPHr, int Hrs) : base(101, "Rajeshwar", 976352484)
        {
            this.rate_per_hr = RPHr;
            this.hrs = Hrs;
        }
        public override void Salary()
        {
            Console.WriteLine("Rate/Hr : " + rate_per_hr + "\nHours : " + hrs);
        }
    }
    class SalaryBased : Teacher
    {
        int salary;
        public SalaryBased(int sal) : base(102, "Rajesh", 9623514785)
        {
            this.salary = sal;
        }
        public sealed override void Salary()
        {
            Console.WriteLine("Rate/Hr : " + salary);
        }
    }

    class TaskInheritance1
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Hourlybased(750, 2);
            t1.Salary();
            Teacher t2 = new SalaryBased(50000);
            t2.Salary();
            Console.ReadKey();
        }
    }
    class Nib1
    /* 2.A Pen contains variables Refill r, int capLength and  String brand. 
        Refill has variables inkColor, length and Nib (tip).
        Nib has variables materialType and width. 
        Create a Java class structure for above . 
        Write a main method which sets values in all the variables
        using setter methods and prints all the variables using getter methods. */
    {
        string materialType;
        double width;
        public string MaterialType
        {
            get { return materialType; }
            set { materialType = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public void DisplayNib()
        {
            Console.WriteLine("Nib Details : \nMaterial Type = " + MaterialType + "\nWidth = " + Width);
        }
    }
    class Refil1
    {
        string inkColor;
        double length;
        Nib1 nib;
        public string InkColor
        {
            get { return inkColor; }
            set { inkColor = value; }
        }
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public Nib1 Nib
        {
            get { return nib; }
            set { nib = value; }
        }
        public void DisplayRefil()
        {
            Console.WriteLine("Refill Details : \nInk Color = " + InkColor + "\nLength = " + Length);
            Nib.DisplayNib();
        }
    }
    class Pen2
    {
        Refil1 refil;
        double capLength;
        string brand;

        public Refil1 Refil
        {
            get { return refil; }
            set { refil = value; }
        }
        public double CapLength
        {
            get { return capLength; }
            set { capLength = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public void DisplayPen()
        {
            Console.WriteLine("Pen Details : \nCaplength = " + CapLength + "\nBrand = " + Brand);
            Refil.DisplayRefil();
        }
    }
    class TaskInheritance2
    {
        static void Main(string[] args)
        {
            Pen1 p = new Pen1();
            p.CapLength = 4.5;
            p.Brand = "Cello";
            p.Refil = new Refil();
            p.Refil.InkColor = "Red";
            p.Refil.Length = 8.5;
            p.Refil.Nib = new Nib();
            p.Refil.Nib.MaterialType = "Plastic";
            p.Refil.Nib.Width = 0.8;

            p.DisplayPen();
            Console.ReadKey();
        }
    }
    class Vehicle
    /* 3.Write a program to create 2 person objects .Take input or hardcode  for all  two person from console. 
      Person class is as follows 
        Person (int id, String name, Vehicle v )
        Vehicle (int vid, String vname) */
    {
        int vid;
        string vname;
        public Vehicle(int V_Id, string vName)
        {
            this.vid = V_Id;
            this.vname = vName;
        }
        public void ShowVehicle()
        {
            Console.WriteLine("Vehicle Id : " + vid + "\nVehicle Name : " + vname);
        }
    }
    class Person
    {
        int id;
        string name;
        Vehicle v;
        public Person(int Id, string Name, Vehicle veh)
        {
            this.id = Id;
            this.name = Name;
            this.v = veh;
        }
        public void ShowPerson()
        {
            Console.WriteLine("ID : " + id + "\nName : " + name);
            v.ShowVehicle();
        }
        static void Main(string[] args)
        {
            Person p1 = new Person(101, "Pavan", new Vehicle(123, "Audi"));
            p1.ShowPerson();
            Person p2 = new Person(102, "Rahul", new Vehicle(153, "Mercedes"));
            p2.ShowPerson();
            Console.ReadKey();
        }
    }
    interface ICake
    /* 4.Create interface Cake with a method declared as bake. Create 2 classes 
        Strawberry, BlackForest both implementing Cake interface. */
    {
        void Bake();
    }

    class StrawBerry : ICake
    {
        public void Bake()
        {
            Console.WriteLine("StrawBerry Cake is Baking");
        }
    }
    class BlackForest : ICake
    {
        public void Bake()
        {
            Console.WriteLine("BlackForest Cake is Baking");
        }
    }
    class TaskInheritance4
    {
        static void Main(string[] args)
        {
            ICake myCake = new StrawBerry();
            myCake.Bake();
            ICake myCake2 = new BlackForest();
            myCake2.Bake();
            Console.ReadKey();
        }
    }
    interface IIceCream
    /*  5.Create interface IceCream with method eat and Juice with method drink, 
        Create class Mastani which implements both interfaces. */
    {
        void Eat();
    }
    interface IJuice
    {
        void Drink();
    }
    class Mastani : IIceCream, IJuice
    {
        public void Eat()
        {
            Console.WriteLine("Mastani is Eating Icecream");
        }
        public void Drink()
        {
            Console.WriteLine("Mastani is Drinking Juice");
        }
    }
    class TaskInheritance5
    {
        static void Main(string[] args)
        {
            /* Mastani m1 = new Mastani();
           m1.Eat();
           m1.Drink();*/

            IIceCream m2 = new Mastani();
            m2.Eat();
            IJuice m3 = new Mastani();
            m3.Drink();
            Console.ReadKey();
        }
    }
    class CalVolume
    /*  6.Design a class to overload a function volume() as follows:  [2M]
        (i) double volume(double r) – with radius ‘r’ as an argument, returns the volume of sphere using the formula:
        v = 4 / 3 × 22 / 7 × r3
        (ii)double volume(double h, double r) – with height ‘h’ and radius ‘r’ as the arguments, returns the 
        volume of a cylinder using the formula: v = 22 / 7 × r2 × h
        (iii) double volume(double l, double b, double h) – with length ‘l’, breadth ‘b’ and height ‘h’ as the arguments, 
        returns the volume of a cuboid using the formula: v = l × b × h   */
    {
        public double Volume(double rad)
        {
            double v = (4 / 3) * (22 / 7) * (rad * 3);
            return v;
        }
        public double Volume(double height, double rad)
        {
            double v = (22 / 7) * (rad * 2) * height;
            return v;
        }
        public double Volume(double length, double bredth, double height)
        {
            double v = length * bredth * height;
            return v;
        }
    }
    class TaskInheritance6
    {
        static void Main(string[] args)
        {
            CalVolume obj = new CalVolume();
            Console.WriteLine("Sphere Volume : " + obj.Volume(5.8));
            Console.WriteLine("Cylinder Volume : " + obj.Volume(8, 1.2));
            Console.WriteLine("Cuboid Volume : " + obj.Volume(7, 3, 2.5));
            Console.ReadKey();
        }
    }
    class Item
    /*  7.Design class Order (int ordered,String Orderdate,Customer cust,Item item)
        Customer (int custid,String custname,Address address)
        Address( String addr1,city,int pincode)
        Item (int itemid,String itemname,int price)
        Write constructors,properties in respective classes.    */
    {
        int itemId;
        string itemName;
        int price;
        public Item(int id, string itemname, int Price)
        {
            this.itemId = id;
            this.itemName = itemname;
            this.price = Price;
        }
        public void ShowItem()
        {
            Console.WriteLine($"Item Details :=\nItem id : {itemId} \nItem Name : " +
                $"{itemName} \nPrice : {price}");
        }
    }
    class Address
    {
        string Adr1;
        string city;
        int pinCode;
        public Address(string addr1, string city, int PinCode)
        {
            this.Adr1 = addr1;
            this.city = city;
            this.pinCode = PinCode;
        }
        public void ShowAddress()
        {
            Console.WriteLine($"Address Details :=\nAddress : {Adr1}" +
                $"\nCity : {city}\nPinCode : {pinCode} ");
        }
    }
    class Customer
    {
        int custid;
        string custname;
        Address address;
        public Customer(int Cust_Id, string custName, Address addr)
        {
            this.custid = Cust_Id;
            this.custname = custName;
            this.address = addr;
        }
        public void ShowCustomer()
        {
            Console.WriteLine($"Customer Details :=\nCustomer id : {custid}\n" +
                $"Customer Name : {custname}");
            address.ShowAddress();
        }
    }
    class Order2
    {
        int ordered;
        string Orderdate;
        Customer cust;
        Item item;
        public Order2(int ordered, string OrdDate, Customer Customer, Item item)
        {
            this.ordered = ordered;
            this.Orderdate = OrdDate;
            this.cust = Customer;
            this.item = item;
        }
        public void ShowOrder()
        {
            Console.WriteLine($"Order Details :=\nOrdered : {ordered} \nOrder Date : " +
                $"{Orderdate}");
            cust.ShowCustomer();
            item.ShowItem();
        }
    }
    class TaskInheritance7
    {
        static void Main(string[] args)
        {
            Order2 newOrder = new Order2(201, "13/Dec/2022", new Customer(1234, "Pavan",
           new Address("Narmada Colony", "Nandurbar", 425412)), new Item(511, "Shoes", 600));

            newOrder.ShowOrder();
            Console.ReadKey();
        }
    }
}
