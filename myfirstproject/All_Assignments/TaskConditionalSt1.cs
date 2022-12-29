using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.All_Assignments
{
    class TaskConditionalSt1
    // 1.Write a program to calculate area of an equilateral triangle.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of equilateral triangle = " + (1.73205081 / 4) * n * n);
            Console.ReadKey();
        }
    }
    class TaskConditionalSt2
    // 2.Write a program to enter marks of five subjects and calculate total, average and percentage
    {
        static void Main(string[] args)
        {
            int Total;
            double Avg;
            Console.WriteLine("Enter Marks of English Subject :");
            int E = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks of Maths Subject :");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks of Physics Subject :");
            int P = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks of Chemistry Subject :");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks of Biology Subject :");
            int B = int.Parse(Console.ReadLine());
            Total = E + M + P + C + B;
            Avg = Total / 5;
            Console.WriteLine("Average = " + Avg);
            Console.WriteLine("Percentage = " + Avg + " %");
            Console.ReadKey();
        }
    }
    class TaskConditionalSt3
    // 3.Write a  program to enter P, T, R and calculate Compound Interest.
    {
        static void Main(string[] args)
        {
            double Total = 0, interestRate, years, annualCompound, Amount;
            Console.Write("Enter the Initial Amount : ");
            Amount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Rate of Interest : ");
            interestRate = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.Write("Enter the Number of Years : ");
            years = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number of Times the Interest will be Compounded : ");
            annualCompound = Convert.ToDouble(Console.ReadLine());
            for (int t = 1; t < years + 1; t++)
            {
                Total = Amount * Math.Pow((1 + interestRate / annualCompound),
                                         (annualCompound * t));
                Console.Write("Your Total for Year {0} "
                            + "is {1:F0}. \n", t, Total);
            }
            Console.ReadKey();
        }
    }
    class TaskConditionalSt4
    // 4.Write a program to enter temperature in °Celsius and convert it into °Fahrenheit.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in celcius :");
            int C = int.Parse(Console.ReadLine());
            double F;
            F = (C * 1.8) + 32;
            Console.WriteLine("\nConvert Celcius to Fahrenheit=" + F + "F");
            Console.ReadKey();
        }
    }
    class TaskConditionalSt5
    // 5.Write a  program to enter temperature in Fahrenheit(°F) and convert it into Celsius(°C)
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in Fahrenheit :");
            int F = int.Parse(Console.ReadLine());
            double C;
            C = (F - 32) * 0.5556;
            Console.WriteLine("\nConvert Fahrenheit to celcius=" + C + "C");
            Console.ReadKey();
        }
    }
    class TaskConditionalSt6
    // 6.Write a program to check whether a year is leap year or not 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year");
            int y = int.Parse(Console.ReadLine());
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                Console.WriteLine(y + "is a leap year");
            }
            else
            {
                Console.WriteLine(y + "is not a leap year");
            }
            Console.ReadKey();
        }
    }
    class TaskConditionalSt7
    // 7.Write a Java program to check whether a number is divisible by 5 and 11 or not 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            if ((num % 5 == 0) && (num % 11 == 0))
            {
                Console.WriteLine("Divisible by 5 & 11 ");
            }
            else
            {
                Console.WriteLine("is neither divisible by 5 nor 11");
            }
            Console.ReadKey();
        }
    }
    class TaskConditionalSt8
    // 8.Write a Java program to find maximum between three numbers 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the three numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int max = 0;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    max = num1;
                }
                else
                {
                    max = num3;
                }
            }
            else if (num2 > num3)
            {
                max = num2;
            }
            else
            {
                max = num3;
            }
            Console.WriteLine("Greater number is =" + max);
            Console.ReadKey();
        }
    }
    class TaskConditionalSt9
    // 9.Write a Java program to input any alphabet and check whether it is vowel or consonant 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the character");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + " is an uppercase vowel");
            }
            else if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine(ch + "is lowercase vowel");
            }
            else
            {
                Console.WriteLine(ch + "is a consonant");
            }
            Console.ReadKey();
        }
    }
    class TaskConditionalSt10
    // 10.Write a Java program to create Simple Calculator  
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
            TaskConditionalSt10 C = new TaskConditionalSt10();
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
    class TaskConditionalSt11
    // 11.Write a Java program to check whether a number is negative, positive or zero 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine("Positive Number");
            }
            else if (n < 0)
            {
                Console.WriteLine("Negative Number");
            }
            else
            {
                Console.WriteLine("Zero");
            }
            Console.ReadKey();
        }
    }
    class TaskConditionalSt12
    // 12.Write a Java program to input any character and check whether it is alphabet, digit or special character 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any character");
            char c = Convert.ToChar(Console.ReadLine());
            if (c >= 65 || c <= 90 || c >= 97 || c <= 122)
            {
                Console.WriteLine("It is Alphabet");
            }
            else if (c >= 48 || c <= 57)
            {
                Console.WriteLine("It is Digit");
            }
            else
            {
                Console.WriteLine("It is Special Character");
            }
            Console.ReadKey();
        }
    }
    class TaskConditionalSt13
    // 13.Write a Java program to check whether a number is even or odd 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
            Console.ReadKey();
        }
    }
    class TaskConditionalSt14
    // 14.Write a Java program print total number of days in a month 
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
            TaskConditionalSt14 DIM = new TaskConditionalSt14();
            Console.WriteLine("Enter the month number :");
            DIM.month = int.Parse(Console.ReadLine());
            DIM.Display();
            Console.ReadKey();
        }
    }
    class TaskConditionalSt15
    /* 15.Write a Java program to input basic salary of an employee and calculate its
    / Gross salary according to following: Basic Salary <= 10000 : HRA = 20%, DA = 80%
      Basic Salary <= 20000 : HRA = 25%, DA = 90% Basic Salary >20000 : HRA = 30%, DA = 95% */
    {
        static void Main(string[] args)
        {
            double basic_salary, HRA, DA, gross_salary;
            Console.WriteLine("Enter basic salry :");
            basic_salary = double.Parse(Console.ReadLine());
            if (basic_salary <= 10000)
            {
                DA = basic_salary * 0.8;
                HRA = basic_salary * 0.2;
            }
            else if (basic_salary <= 20000)
            {
                DA = basic_salary * 0.9;
                HRA = basic_salary * 0.25;
            }
            else
            {
                DA = basic_salary * 0.95;
                HRA = basic_salary * 0.3;
            }
            gross_salary = basic_salary + DA + HRA;
            Console.WriteLine("The Gross Salary is : " + gross_salary);
            Console.ReadKey();
        }
    }
    class TaskConditionalSt16
    /* 16.Write a Java program to input electricity consumption unit and calculate totalelectricity
     billaccording to the given condition: For first 50 units Rs. 0.50/unit For next 100 units Rs. 0.75/unit
     For next 100 units Rs. 1.20/unit For unit above 250 Rs. 1.50/unit An additional surcharge of 20% is added to the bill */
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
            TaskConditionalSt16 electricityCunsumption = new TaskConditionalSt16();
            electricityCunsumption.calculateElectricityBill();
            Console.ReadKey();
        }
    }
}
