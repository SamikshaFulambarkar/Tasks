using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.All_Assignments
{
    class TaskLoops1
    // 1.WAP to print even numbers from 121 to 229 using do-while loop. 
    {
        static void Main(string[] args)
        {
            int i = 121;
            do
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
                i++;
            }
            while (i <= 229);
            Console.ReadKey();
        }
    }
    class TaskLoops2
    // 2.WAP to show the use of break statement ( in for loop)
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
    class TaskLoops3
    // 3.Write a program to print all alphabets from a to z. - using  for loop
    {
        static void Main(string[] args)
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.WriteLine("Character :");
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
    class TaskLoops4
    // 4. Write a  program to find sum of all even numbers between 1 to n. 
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter number of limt");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                    sum = sum + i;
                }
            }
            Console.WriteLine("\nSum of even numbers : " + sum);
            Console.ReadKey();
        }
    }
    class TaskLoops5
    // 5. Write a program to find sum of all odd numbers between 1 to n.
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter number of limt");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                    sum = sum + i;
                }
            }
            Console.WriteLine("\nSum of odd numbers : " + sum);
            Console.ReadKey();
        }
    }
    class TaskLoops6
    // 6.Write a  program to count number of digits in any number
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter any number");
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                n = n / 10;
                count++;
            }
            Console.WriteLine("Number of Digits : " + count);
            Console.ReadKey();
        }
    }
    class TaskLoops7
    // 7.Write a  program to calculate product of digits of any number.
    {
        static void Main(string[] args)
        {
            int product = 1;
            Console.WriteLine("Enter any number");
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                product = product * (n % 10);
                n = n / 10;
            }
            Console.WriteLine("Product of digits = " + product);
            Console.ReadKey();
        }
    }
    class TaskLoops8
    // 8.Write a program to find frequency of each digit in a given integer.
    {
        static void Main(string[] args)
        {
            int digit, count, temp;
            Console.WriteLine("Enter any number :");
            int num = int.Parse(Console.ReadLine());
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
                    Console.WriteLine("Digit : " + i + " frequency : " + count);
                }
            }
            Console.ReadKey();
        }
    }
    class TaskLoops9
    // 9.Find all prime number between 400 to 300
    {
        static void Main(string[] args)
        {
            int i, count;
            Console.WriteLine("Prime numbers are :");
            for (i = 400; i >= 300; i--)
            {
                count = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0 && i != 1)
                    Console.Write("{0} ", i);
            }
            Console.Write("\n");
            Console.ReadKey();
        }
    }
    class TaskLoops10
    // 10.WAP to print table of given no
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number :");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num * i);
            }
            Console.ReadKey();
        }
    }
    class TaskLoops11
    // 11.WAP to accept base and index from user and calculates power
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base number :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter index number :");
            int i = int.Parse(Console.ReadLine());
            int power = 1;
            for (int j = i; j >= 1; j--)
            {
                power = power * b;
            }
            Console.WriteLine(b + " raised to " + i + " is : " + power);
            Console.ReadKey();
        }
    }
    class TaskLoops12
    // 12.s=1!+2!+3!.........+n! find s
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int factorial = 1, sum = 0;
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
                sum += factorial;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
    class TaskLoops13
    // 13.check no is krishnamurthi or not
    {
        static void Main(string[] args)
        {
            int r, temp, s, count = 0;
            Console.WriteLine("Enter any number :");
            int num = int.Parse(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                r = num % 10;
                s = 1;
                for (int i = r; i >= 1; i--)
                    s = s * i;
                count = count + s;
                num = num / 10;
            }
            if (count == temp)
                Console.WriteLine("Krishnamurthy Number");
            else
                Console.WriteLine("Not Krishnamurthy Number");
            Console.ReadKey();
        }
    }
    class TaskLoops14
    // 14. check no is Disarium or not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number :");
            int num = int.Parse(Console.ReadLine());
            string numStr = num.ToString();
            int length = numStr.Length;
            int divide = 0, sum = 0, temp = num;
            while (temp > 0)
            {
                divide = temp % 10;
                sum = sum + (int)Math.Pow(divide, length);
                length--;
                temp = temp / 10;
            }
            if (sum == num)
                Console.WriteLine("Disarium Number.");
            else
                Console.WriteLine("Not a Disarium Number.");
            Console.ReadKey();
        }
    }
    class TaskLoops15
    // 15.check no is palimdrom or not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number :");
            int num = int.Parse(Console.ReadLine());
            int sum = 0, temp, r;
            temp = num;
            while (num > 0)
            {
                r = num % 10;
                sum = (sum * 10) + r;
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("palindrome number");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
            Console.ReadKey();
        }
    }
    class TaskLoops16
    // 16. check no is automorphic or not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number :");
            int num = int.Parse(Console.ReadLine());
            if (CheckAutomorphicNumber(num))
            {
                Console.WriteLine("Automorphic Number");
            }
            else
            {
                Console.WriteLine("Not Automorphic Number");
            }
            Console.ReadKey();
        }
        public static bool CheckAutomorphicNumber(int no)
        {
            int square = no * no;
            while (no > 0)
            {
                if (no % 10 != square % 10)
                {
                    return false;
                }
                no = no / 10;
                square = square / 10;
            }
            return true;
        }
    }
    class TaskLoops17
    /* 1.Write a program in  to display the first 10 terms of the following series:
        10, 20, 30, 40, ……..*/
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <= 100; i = i + 10)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
    class TaskLoops18
    /* 2.Write the program  to display the first ten terms of the following series:
        1, 4, 9, 16,....*/
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write((i * i) + " ");
            }
            Console.ReadKey();
        }
    }
    class TaskLoops19
    /* 3.Write the program  to display the first ten terms of the following series:
        1, 2, 4, 7, 11,.....*/
    {
        static void Main(string[] args)
        {
            int sum = 1;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + i;
                Console.Write(sum + " ");
            }
            Console.ReadKey();
        }
    }
    class TaskLoops20
    // 4.Print Series 2 -4 6 -8………n terms
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of limit");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    if (i % 4 == 0)
                    {
                        Console.Write(-i + " ");
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            Console.ReadKey();
        }
    }
    class TaskLoops21
    // 5.Print Series 1  11  111  111……..n terms
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter number of limit");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                sum = (sum * 10) + 1;
                Console.Write(sum + " ");
            }
            Console.ReadKey();
        }
    }
    class TaskLoops22
    /*   *
         * *
         * * *
         * * * * 
         * * * * *    */
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    class TaskLoops23
    /*                *
                    * *
                  * * *
                * * * *
              * * * * *
            * * * * * *       */
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 6 - i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
    class TaskLoops24
    /*          *
               * *
              * * *
             * * * *
            * * * * *
           * * * * * *      */
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int k = 6; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    class TaskLoops25
    /*     * * * * * * *
           * * * * * *
           * * * * *
           * * * *
           * * *
           * *
           *            */
    {
        static void Main(string[] args)
        {
            for (int i = 7 - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    class TaskLoops26
    /*                     *
                          **
                         ***
                        ****
                       *****
                      ******
                     *******
                    ********          */
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 8 - i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    class TaskLoops27
    /*      * * * * * * * *
             * * * * * * *
              * * * * * *
               * * * * *
                * * * *
                 * * *
                  * *
                   *         */
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 8; i++)
            {
                for (int k = 1; k < i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 8; j >= i; j--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
    class TaskLoops28
    /*          *******
                 ******
                  *****
                   ****
                    ***
                     **
                      *             */
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (7 - i); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    class TaskLoops29
    /*  1 
        2 3
        5 5 6
        7 8 9 10
        11 12 13 14 15
        16 17 18 19 20 21
        22 23 24 25 26 27 28    */
    {
        static void Main(string[] args)
        {
            int k = 1;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("{0} ", k++);
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
    class TaskLoops30
    /*      101010101
            010101010   
            101010101   
            010101010
            101010101
            010101010
            101010101
            010101010
            101010101       */
    {
        static void Main(string[] args)
        {
            int i, j, c = 0;

            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    c++;
                    if (c % 2 == 0)
                        Console.Write(0);
                    else
                        Console.Write(1);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    class TaskLoops31
    /*      A
            A B
            A B C
            A B C D
            A B C D E
            A B C D E F
            A B C D E F G
            A B C D E F G H
            A B C D E F G H G       */

    {
        static void Main(string[] args)
        {
            char i, j;
            for (i = 'A'; i <= 'I'; i++)
            {
                for (j = 'A'; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
    class TaskLoops32
    /*      A
            B B
            C C C
            D D D D
            E E E E E
            F F F F F F
            G G G G G G G
            H H H H H H H H
            I I I I I I I I I
            J J J J J J J J J J     */
    {
        static void Main(string[] args)
        {
            char i, j;
            for (i = 'A'; i <= 'J'; i++)
            {
                for (j = 'A'; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
    class TaskLoops33
    /*                  A
                       A B
                      A B C
                     A B C D
                    A B C D E
                   A B C D E F
                  A B C D E F G
                 A B C D E F G H
                A B C D E F G H H       */
    {
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'I'; i++)
            {
                for (char k = 'I'; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    class TaskLoops34
    //  34.Write a program to print even numbers from 121 to 229 using for loop. 
    {
        static void Main(string[] args)
        {
            for (int i = 121; i <= 229; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();
        }
    }
    class TaskLoops35
    //  35.Write a program to print odd numbers from 521 to 229 using while loop. 
    {
        static void Main(string[] args)
        {
            int i = 521;
            while (i >= 229)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
                i--;
            }
            Console.ReadKey();
        }
    }
    class TaskLoops36
    // 36.Write a program to find GCD and LCM of given number
    {
        static void Main(string[] args)
        {
            long num1, num2, hcf, lcm;
            Console.WriteLine("Find the LCM and GCD of two numbers :");
            Console.WriteLine(" Enter the first number : ");
            num1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(" Enter the second number : ");
            num2 = Convert.ToInt64(Console.ReadLine());
            hcf = gcd(num1, num2);
            lcm = (num1 * num2) / hcf;
            Console.WriteLine("The GCD of {0} and {1} = {2} ", num1, num2, hcf);
            Console.WriteLine("The LCM of {0} and {1} = {2}\n", num1, num2, lcm);
            Console.ReadKey();
        }
        static long gcd(long n1, long n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return gcd(n2, n1 % n2);
            }
        }
    }
    class TaskLoops37
    // 37.WAP to print squares from 1 to20
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Squares are :");
            for (int i = 1; i <= 20; i++)
            {
                Console.Write(i * i + "  ");
            }
            Console.ReadKey();
        }
    }
    class TaskLoops38
    // 38.WAP to find given number is Harshad/Niven number or not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number : ");
            int n = int.Parse(Console.ReadLine());
            checkForHarshad(n);
        }
        private static void checkForHarshad(int n)
        {
            int copyOfInputNumber = n;
            int sum = 0;
            int lastDigit = 0;
            while (n != 0)
            {
                lastDigit = n % 10;
                sum = sum + lastDigit;
                n = n / 10;
            }
            if ((copyOfInputNumber % sum) == 0)
            {
                Console.WriteLine(copyOfInputNumber + " is a Harshad number");
            }
            else
            {
                Console.WriteLine(copyOfInputNumber + " is not a Harshad number");
            }
            Console.ReadKey();
        }
    }
    class TaskLoops39
    // 39.Print all palindrome numbers from 100 to 500
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome Numbers :");
            for (int k = 100; k <= 500; k++)
            {
                string data = k.ToString();
                bool isPalindrome = true;
                for (int i = 0; i < data.Length / 2; i++)
                {
                    if (data[i] != data[(data.Length - 1) - i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                if (isPalindrome)
                {
                    Console.Write(k + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
