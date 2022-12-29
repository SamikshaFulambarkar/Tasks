using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.PropertyPrograms
{
    class StudentDetails
    {
        int s_id;
        string s_name;
        int s_age;
        public int S_ID
        {
            set
            {
                s_id = value;
            }
            get
            {
                return s_id;
            }
        }
        public string S_Name
        {
            set
            {
                s_name = value;
            }
            get
            {
                return s_name;
            }
        }
        public int S_Age
        {
            set
            {
                s_age = value;
            }
            get
            {
                return s_age;
            }
        }
        static void Main(string[] args)
        {
            StudentDetails sd = new StudentDetails();
            sd.S_ID = 26;
            sd.S_Name = "Neha Shah";
            sd.S_Age = 16;
            Console.WriteLine("Student ID =" + sd.S_ID);
            Console.WriteLine("Student Name =" + sd.S_Name);
            Console.WriteLine("Age =" + sd.S_Age);
            Console.ReadKey();
        }
    }
    class StudentComparison
    {
        int s_id_1;
        string s_name_1;
        double s_per_1;
        int s_id_2;
        string s_name_2;
        double s_per_2;
        public int S_ID_1
        {
            set
            {
                s_id_1 = value;
            }
            get
            {
                return s_id_1;
            }
        }
        public string S_Name_1
        {
            set
            {
                s_name_1 = value;
            }
            get
            {
                return s_name_1;
            }
        }
        public double S_Per_1
        {
            set
            {
                s_per_1 = value;
            }
            get
            {
                return s_per_1;
            }
        }
        public int S_ID_2
        {
            set
            {
                s_id_2 = value;
            }
            get
            {
                return s_id_2;
            }
        }
        public string S_Name_2
        {
            set
            {
                s_name_2 = value;
            }
            get
            {
                return s_name_2;
            }
        }
        public double S_Per_2
        {
            set
            {
                s_per_2 = value;
            }
            get
            {
                return s_per_2;
            }
        }
        static void Main(string[] args)
        {
            StudentComparison sc = new StudentComparison();
            sc.S_ID_1 = 12;
            sc.S_Name_1 = "Neha Sharma";
            sc.S_Per_1 = 89.20;
            sc.S_ID_2 = 15;
            sc.S_Name_2 = "Shreya Verma";
            sc.S_Per_2 = 78.40;
            if (sc.S_Per_1 > sc.S_Per_2)
            {
                Console.WriteLine("Student ID=" + sc.S_ID_1);
                Console.WriteLine("Student Name=" + sc.S_Name_1);
                Console.WriteLine("Percentage=" + sc.S_Per_1);
            }
            else
            {
                Console.WriteLine("Student ID=" + sc.S_ID_2);
                Console.WriteLine("Student Name=" + sc.S_Name_2);
                Console.WriteLine("Percentage=" + sc.S_Per_2);
            }
            Console.ReadKey();
        }
    }
    class EmployeeCompare
    {
        public int E_ID { get; set; }
        public string E_Name { get; set; }
        public int E_Salary { get; set; }
        public void Compare(EmployeeCompare ec)
        {
            if (E_Salary > ec.E_Salary)
                display();
            else
                ec.display();
        }
        public void display()
        {
            Console.WriteLine("Employee Id = " + E_ID);
            Console.WriteLine("Employee Name = " + E_Name);
            Console.WriteLine("Salary = " + E_Salary);
        }
        static void Main(string[] args)
        {
            EmployeeCompare ec1 = new EmployeeCompare();
            ec1.E_ID = 101;
            ec1.E_Name = "Shweta shah";
            ec1.E_Salary = 67000;

            EmployeeCompare ec2 = new EmployeeCompare();
            ec2.E_ID = 102;
            ec2.E_Name = "Priya Sharma";
            ec2.E_Salary = 57000;
            ec1.Compare(ec2);
            Console.ReadKey();
        }
    }
    class Time
    {
        public int Hr { get; set; }

        public int Min { get; set; }

        public Time add(Time t1, Time t2)
        {
            Time t = new Time();
            t.Hr = t1.Hr + t2.Hr;
            t.Min = t1.Min + t2.Min;
            if (t.Min >= 60)
            {
                t.Min = t.Min % 60;
                t.Hr++;
            }
            return t;
        }
        public void display()
        {
            Console.WriteLine("Hr=" + Hr);
            Console.WriteLine("Min=" + Min);
        }
        static void Main(string[] args)
        {
            Time t1 = new Time();
            t1.Hr = 6;
            t1.Min = 45;
            t1.display();


            Time t2 = new Time();
            t2.Hr = 2;
            t2.Min = 30;
            t2.display();

            Time t3 = new Time();
            t3 = t3.add(t1, t2);

            t3.display();
            Console.ReadKey();
        }
    }
    class Person
    {
        string name;
        int age;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        public void Compare(Person P)
        {
            if (Age > P.Age)
                display();
            else
                P.display();
        }
        public void display()
        {
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Age = " + Age);
        }
        static void Main(string[] args)
        {
            Person P1 = new Person();
            P1.Name = "Sneha";
            P1.Age = 26;
            Person P2 = new Person();
            P2.Name = "Neha";
            P2.Age = 24;
            P1.Compare(P2);
            Console.ReadKey();
        }
    }
    class Grade
    {
        int phy;
        int chem;
        int bio;
        int maths;
        int computer;
        int total_marks;
        double percentage;
        public int Total_Marks { get; set; }
        public void calculate()
        {
            total_marks = phy + chem + bio + maths + computer;
            percentage = (total_marks / 5);
            if (percentage >= 90)
            {
                Console.WriteLine("grade A");
            }
            else if (percentage >= 80)
            {
                Console.WriteLine("grade B");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("grade C");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("grade D");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("grade E");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            Console.WriteLine("Total Marks :" + total_marks);
            Console.WriteLine("Percentage :" + percentage + "%");
        }

        static void Main(string[] args)
        {
            Grade g = new Grade();
            Console.WriteLine("Enter the marks of five subject");
            g.phy = int.Parse(Console.ReadLine());
            g.chem = int.Parse(Console.ReadLine());
            g.bio = int.Parse(Console.ReadLine());
            g.maths = int.Parse(Console.ReadLine());
            g.computer = int.Parse(Console.ReadLine());
            g.calculate();
            Console.ReadKey();
        }
    }
    class ATM
    {
        public int cash { get; set; }
        public void Amount()
        {
            while (cash >= 0)
            {
                if (cash >= 2000)
                {
                    Console.WriteLine("2000:" + (cash / 2000));
                    cash = cash % 2000;
                }
                else if (cash >= 500)
                {
                    Console.WriteLine("500:" + (cash / 500));
                    cash = cash % 500;
                }
                else if (cash >= 200)
                {
                    Console.WriteLine("200:" + (cash / 200));
                    cash = cash % 200;
                }
                else if (cash >= 100)
                {
                    Console.WriteLine("100:" + (cash / 100));
                    cash = cash % 100;
                }
                else if (cash >= 50)
                {
                    Console.WriteLine("50:" + (cash / 50));
                    cash = cash % 50;
                }
                else if (cash >= 20)
                {
                    Console.WriteLine("20:" + (cash / 20));
                    cash = cash % 20;
                }
                else if (cash >= 10)
                {
                    Console.WriteLine("10:" + (cash / 10));
                    cash = cash % 10;
                }
                else if (cash >= 1)
                {
                    Console.WriteLine("1:" + (cash / 1));
                    cash = cash % 1;
                }
            }
        }
        static void Main(string[] args)
        {
            ATM A = new ATM();
            Console.WriteLine("Enter the amount in rupees:");
            A.cash = int.Parse(Console.ReadLine());
            A.Amount();
            Console.ReadKey();
        }
    }
    class ElectricityConsumption
    {
        public void calculateElectricityBill()
        {
            int units_Consumed;
            double bill = 0;

            Console.WriteLine("enter units consumed from customer");
            units_Consumed = int.Parse(Console.ReadLine());

            if (units_Consumed <= 50)
                bill = units_Consumed * 0.50;
            else
                if (units_Consumed <= 150)
                bill = (50 * 0.50) + (units_Consumed - 50) * 0.75;
            else
                if (units_Consumed <= 250)
                bill = (50 * 0.50) + ((units_Consumed - 50) * 0.75) + (units_Consumed - 150) * 1.20;
            else
                if (units_Consumed >= 250)
                bill = units_Consumed * 1.50;
            bill = bill + (bill * 0.2);
            Console.WriteLine(bill);
        }
        static void Main(string[] args)
        {
            ElectricityConsumption electricityCunsumption = new ElectricityConsumption();
            electricityCunsumption.calculateElectricityBill();
            Console.ReadKey();
        }
    }
    class Toggle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any character :");
            int ch;
            ch = int.Parse(Console.ReadLine());
            if (ch >= 65 && ch <= 90)
            {
                Console.WriteLine((char)ch + "is Uppercase Character");
            }
            else if (ch >= 97 && ch <= 122)
            {
                Console.WriteLine((char)ch + "is Lowercase Character");
            }
            else if (ch >= 48 && ch <= 57)
            {
                Console.WriteLine(ch + "is digit");
            }
            else
            {
                Console.WriteLine(ch + "is symbol");
            }
            Console.ReadKey();
        }
    }
    class Convert_D_M_Y
    {
        static void Main(string[] args)
        {
            int days, yr, m, d;
            Console.WriteLine("Enter days :=");
            days = int.Parse(Console.ReadLine());
            if (days >= 365)
            {
                yr = days / 365;
                Console.WriteLine("Year :=" + yr);
            }
            m = (days % 365) % 30;
            Console.WriteLine("Months:=" + m);
            d = (days % 365) % 30;
            Console.WriteLine("Days:=" + d);
            Console.ReadKey();
        }
    }
    class Even_Numbers
    {
        public int numbers { get; set; }
        public void Display()
        {
            for (int i = 121; i <= 229; i++)
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
        }
        static void Main(string[] args)
        {
            Even_Numbers EN = new Even_Numbers();
            Console.Write("Display even numbers:");
            EN.Display();
            Console.ReadKey();
        }
    }
    class Odd_Numbers
    {
        public int numbers { get; set; }
        public void Display()
        {
            for (int i = 521; i >= 229; i--)
                if (i % 2 != 0)
                {
                    Console.Write(i);
                }
        }
        static void Main(string[] args)
        {
            Odd_Numbers ON = new Odd_Numbers();
            Console.WriteLine("Display odd numbers:");
            ON.Display();
            Console.ReadKey();
        }
    }
    class Alphabets
    {
        public char alphabets { get; set; }
        public void Display()
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Alphabets A = new Alphabets();
            Console.WriteLine("Display alpabets:");
            A.Display();
            Console.ReadKey();
        }
    }
    class Even_Sum
    {
        int num;
        public int numbers { get; set; }
        public void Display()
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                    Console.WriteLine(sum);
                }
            }
        }
        static void Main(string[] args)
        {
            Even_Sum ES = new Even_Sum();
            Console.WriteLine("Enter the number :");
            ES.num = int.Parse(Console.ReadLine());
            ES.Display();
            Console.ReadKey();
        }
    }
    class Odd_Sum
    {
        int num;
        public int numbers { get; set; }
        public void Display()
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                    Console.WriteLine(sum);
                }
            }
        }
        static void Main(string[] args)
        {
            Odd_Sum OS = new Odd_Sum();
            Console.WriteLine("Enter the number :");
            OS.num = int.Parse(Console.ReadLine());
            OS.Display();
            Console.ReadKey();
        }
    }
    class Digit_Count
    {
        int num;
        int count;
        public int numbers { get; set; }
        public void Display()
        {
            while (num != 0)
            {
                num = num / 10;
                count++;
            }
            Console.WriteLine("Digit Count:" + count);
        }
        static void Main(string[] args)
        {
            Digit_Count DC = new Digit_Count();
            Console.WriteLine("Enter the number :");
            DC.num = int.Parse(Console.ReadLine());
            DC.Display();
            Console.ReadKey();
        }
    }
    class Calculator
    {
        int num1;
        int num2;
        int choice;
        public int numbers { get; set; }
        public void Display()
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition :" + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("Subtraction :" + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Multiplication :" + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("Division :" + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Calculator C = new Calculator();
            Console.WriteLine("Enter First number :");
            C.num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number :");
            C.num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("1.Addition\n 2.Subtraction\n 3.Multiplication\n 4.Division");
            Console.WriteLine("Enter the choice from above menu");
            C.choice = int.Parse(Console.ReadLine());
            C.Display();
            Console.ReadKey();
        }
    }
    class Days_in_Month
    {
        int month;
        public int calculate_days { get; set; }
        public void Display()
        {
            switch (month)
            {
                case 4:
                    Console.WriteLine("April : 30 Days");
                    break;
                case 6:
                    Console.WriteLine("June : 30 Days");
                    break;
                case 9:
                    Console.WriteLine("September : 30 Days");
                    break;
                case 11:
                    Console.WriteLine("Novemnber : 30 Days");
                    break;
                case 1:
                    Console.WriteLine("January : 31 Days");
                    break;
                case 3:
                    Console.WriteLine("March : 31 Days");
                    break;
                case 5:
                    Console.WriteLine("May : 31 Days");
                    break;
                case 7:
                    Console.WriteLine("July : 31 Days");
                    break;
                case 8:
                    Console.WriteLine("August : 31 Days");
                    break;
                case 10:
                    Console.WriteLine("October : 31 Days");
                    break;
                case 12:
                    Console.WriteLine("December : 31 Days");
                    break;
                case 2:
                    Console.WriteLine("February : 28 Days"); ;
                    break;
                default:
                    Console.WriteLine("Invalid Choice"); ;
                    break;
            }
        }
        static void Main(string[] args)
        {
            Days_in_Month DIM = new Days_in_Month();
            Console.WriteLine("Enter the month number :");
            DIM.month = int.Parse(Console.ReadLine());
            DIM.Display();
            Console.ReadKey();
        }
    }
    class Product_of_Digits
    {
        int num;
        public int numbers { get; set; }
        public void Display()
        {
            int product = 1;
            while (num > 0)
            {
                product = product * (num % 10);
                num = num / 10;
            }
            Console.WriteLine("Product of Digit:" + product);
        }
        static void Main(string[] args)
        {
            Product_of_Digits PD = new Product_of_Digits();
            Console.WriteLine("Enter any number:");
            PD.num = int.Parse(Console.ReadLine());
            PD.Display();
            Console.ReadKey();
        }
    }
    class Frequency_of_Digit
    {
        int num;
        public int number { get; set; }
        public void Display()
        {
            int count, digit, temp;
            for (int i = 0; i <= 9; i++)
            {
                count = 0;
                temp = num;
                while (temp > 0)
                {
                    digit = temp % 10;
                    if (digit == i)
                    {
                        count++;
                    }
                    temp = temp / 10;
                }
                if (count > 0)
                {
                    Console.WriteLine("Digit:" + i + "      " + "frequency:" + count);
                }
            }
        }
        static void Main(string[] args)
        {
            Frequency_of_Digit FD = new Frequency_of_Digit();
            Console.WriteLine("Enter any number:");
            FD.num = int.Parse(Console.ReadLine());
            FD.Display();
            Console.ReadKey();
        }
    }
    class Break
    {
        public int number { get; set; }
        public void Display()
        {
            for (int i = 1; i <= 9; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine(i);
            }
            Console.WriteLine(" ");
        }
        static void Main(string[] args)
        {
            Break B = new Break();
            B.Display();
            Console.ReadKey();
        }
    }
    class Prime_Number
    {
        public int number { get; set; }
        public void Display()
        {
            int count = 2;
            int prime = 1;
            for (int i = 400; i >= 300; i--)
            {
                while (count <= i / 2)
                {
                    if (i % count == 0)
                    {
                        prime = 0;
                        break;
                    }
                    count++;
                }
                if (prime == 1)
                {
                    Console.Write(i + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            Prime_Number PN = new Prime_Number();
            PN.Display();
            Console.ReadKey();
        }
    }
    class Power
    {
        int b;
        int i;
        public int power { get; set; }
        public void Display()
        {
            int power = 1;
            for (int j = i; j >= 1; j--)
            {
                power = power * b;
            }
            Console.WriteLine(b + "raised to" + i + "is:" + power);
        }

        static void Main(string[] args)
        {
            Power P = new Power();
            Console.WriteLine("Enter base number:");
            P.b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter index number:");
            P.i = int.Parse(Console.ReadLine());
            P.Display();
            Console.ReadKey();
        }
    }
    class Terms
    {
        public int numbers { get; set; }
        public void Display()
        {
            for (int i = 0; i < 10; i++)
            {
                int term = 1 + ((i * (i + 1)) / 2);
                Console.WriteLine(term + " ");
            }
        }
        static void Main(string[] args)
        {
            Terms T = new Terms();
            T.Display();
            Console.ReadKey();
        }
    }
    class Series
    {
        int num;
        public int numbers { get; set; }
        public void Display()
        {
            int n = 2;
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(-n + " ");
                }
                else
                {
                    Console.WriteLine(n + " ");
                }
                n += 2;
            }
        }
        static void Main(string[] args)
        {
            Series S = new Series();
            Console.WriteLine("Display the series:");
            S.num = int.Parse(Console.ReadLine());
            S.Display();
            Console.ReadKey();
        }
    }
}
