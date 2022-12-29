using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.All_Assignments
{
    class AssgnStringQ1
    // 1.Write a  program to find the duplicate words and their number of occurrences in a string
    {
        public static void FindOccuranceChar(char[] ch)
        {

            for (int i = 0; i < ch.Length; i++)
            {
                int count = 1;
                bool flag = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (ch[i] == ch[k])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    for (int j = i + 1; j < ch.Length; j++)
                    {
                        if (ch[i] == ch[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(ch[i] + " " + count);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            int count = 0;
            foreach (char c in ch)
            {
                Console.Write(c + " ");
                count++;
            }
            Console.WriteLine();
            Console.WriteLine(count);
            AssgnStringQ1.FindOccuranceChar(ch);
            Console.ReadKey();
        }
    }
    class AssgnStringQ2
    // 2.Write a program to count the number of words in a string
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();
            int i = 0, count = 1;
            while (i <= str.Length - 1)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
                i++;
            }
            Console.WriteLine("Number of words in the string : " + count);
        }
    }
    class AssgnStringQ3
    // 3.Write a  program to check whether two strings are anagram or not?
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string :");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string :");
            string str2 = Console.ReadLine();
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);
            if (val1 == val2)
            {
                Console.WriteLine("Both the strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagrams");
            }
            Console.ReadKey();
        }
    }
    class AssgnStringQ4
    // 4.Create an array of 10 names sort in descending order
    {
        static void Main(string[] args)
        {
            string[] arr = { "mango", "cherry", "apple", "lemon", "banana", "kiwi", "grapes", "pineapple", "watermelon", "dragonfruit" };
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}]: {1}", i, arr[i]);
            }
            Console.ReadKey();
        }
    }
    class AssgnStringQ5
    // 5.Write a program to find total number of alphabets, digits or special character in a string.
    {
        static void Main(string[] args)
        {
            string str;
            int alp, digit, splch, i, l;
            alp = digit = splch = i = 0;
            Console.WriteLine("Count total number of alphabets, digits and special characters :");
            Console.WriteLine("Input the string : ");
            str = Console.ReadLine();
            l = str.Length;
            while (i < l)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alp++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    splch++;
                }

                i++;
            }
            Console.Write("Number of Alphabets in the string is : {0}\n", alp);
            Console.Write("Number of Digits in the string is : {0}\n", digit);
            Console.Write("Number of Special characters in the string is : {0}\n\n", splch);
            Console.ReadKey();
        }
    }
    class AssgnStringQ6
    // 6.Write a  program to convert uppercase string to lowercase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String :");
            string str = Console.ReadLine();
            Console.WriteLine("Converted string are:");
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                    Console.Write(Char.ToLower(str[i]));
                else
                    Console.Write(Char.ToUpper(str[i]));
            }
            Console.ReadKey();
        }
    }
    class AssgnArrQ7
    // 7. WAP to reverse the array itself,
    {
        static void Main(string[] args)
        {
            int i, j, t;
            Console.WriteLine("Enter size for  array:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements in array:");
            int[] arr = new int[size];
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (i = t = 0, j = size - 1; i < size / 2; i++, j--)
            {
                t = arr[i];
                arr[i] = arr[j];
                arr[j] = t;
            }
            Console.WriteLine("In place reverse array is := ");
            for (i = 0; i < size; i++)
                Console.Write(arr[i] + " ");
            Console.ReadKey();
        }
    }
    class AssgnArrQ8
    // 8.WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter size for both arrays:");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements in first array:");
            int[] arr1 = new int[s];
            for (i = 0; i < s; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter elements in second array:");
            int[] arr2 = new int[s];
            for (i = 0; i < s; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            int[] arr3 = new int[arr1.Length + arr2.Length];
            int k = 0, count;
            for (i = 0; i < arr1.Length; i++)
            {
                count = 0;
                for (j = k - 1; j >= 0; j--)
                {
                    if (arr3[j] == arr1[i])
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
            for (i = 0; i < arr2.Length; i++)
            {
                count = 0;
                for (j = k - 1; j >= 0; j--)
                {
                    if (arr3[j] == arr2[i])
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    arr3[k] = arr2[i];
                    k++;
                }
            }
            Console.WriteLine("Concatenated Array :");
            for (i = 0; i < k; i++)
            {
                Console.Write(arr3[i] + " ");
            }
            Console.ReadKey();
        }
    }
    class AssgnArrQ9
    // 9.WAP sort array elements in ascending order
    {
        static void Main(string[] args)
        {
            int i, j, t;
            Console.WriteLine("Enter size for array:");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements in array:");
            int[] arr = new int[s];
            for (i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < s - 1; i++)
            {
                for (j = i + 1; j < s; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            Console.WriteLine("Sorted array is:");
            for (i = 0; i < s; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
    class AssgnArrQ10
    // 10. WAP to replace all the 0’s with 1’s in your array. 
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter size:");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements:");
            int[] arr = new int[s];
            for (i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < s; i++)
                if (arr[i] == 0)
                    arr[i] = 1;
            Console.WriteLine("Modified Array is:");
            for (i = 0; i < s; i++)
                Console.Write(arr[i] + " ");
            Console.ReadKey();
        }
    }
    class AssgnArr11
    // 11. WAP to replace all negative value with its immediate left elements square.
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter size for array:");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements in array:");
            int[] arr = new int[s];
            for (i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < s; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr[i - 1] * arr[i - 1];
                }
            }
            Console.WriteLine("Array is:");
            for (i = 0; i < s; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
    class AssgnCharArrQ12
    // 12. WAP to find min character in character array. 
    {
        static void Main(string[] args)
        {
            int size, i;
            char min;
            Console.WriteLine("Enter size");
            size = int.Parse(Console.ReadLine());
            char[] arr = new char[size];
            Console.WriteLine("Enter character");
            for (i = 0; i < size; i++)
            {
                arr[i] = Convert.ToChar(Console.ReadLine());
            }
            min = arr[0];
            for (i = 0; i < size; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Minimum character is : " + min);
            Console.ReadKey();
        }
    }
    class AssgnArr13
    // 13.WAP to print all unique elements in the array
    {
        static void Main(string[] args)
        {
            int s, i;
            Console.WriteLine("Enter size of array");
            s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter elements");
            for (i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Unique array elements: ");
            for (i = 0; i < s; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    Console.Write(arr[i] + " ");

                }
            }
            Console.ReadKey();
        }
    }
    class AssgnSumQ14
    // 14. Write a  program to enter two numbers and find their sum.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number :");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum = " + (n1 + n2));
            Console.ReadKey();
        }
    }
    class AssgnAllArithmeticOperationsQ15
    // 15. Write a  program to enter two numbers and perform all arithmetic operations Different Program for each .
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number :");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Addition = " + (n1 + n2));
            Console.WriteLine("Subtraction = " + (n1 - n2));
            Console.WriteLine("Multiplication = " + (n1 * n2));
            Console.WriteLine("Division = " + (n1 / n2));
            Console.ReadKey();
        }
    }
    class AssgnRectangleAreaQ16
    // 16. Write a  program to enter length and breadth of a rectangle and find its Area
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length for rectangle :");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth for rectangle :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of Rectangle = " + (l * b));
            Console.ReadKey();
        }
    }
    class AssgnTriangleAreaQ17
    // 17. Write a  program to enter base and height of a triangle and find its area..
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base for triangle :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter height for triangle :");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of Triangle = " + (0.5 * b * h));
            Console.ReadKey();
        }
    }
    class AssgnSquareQ18
    // 18. Write a Program to calculate Square of given number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Square of given number = " + (n * n));
            Console.ReadKey();
        }
    }
    class AssgnCubeQ19
    // 19. Write a Program to calculate cube of given number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Cube of given number = " + (n * n * n));
            Console.ReadKey();
        }
    }
    class AssgnConversionL_M_KQ20
    // 20. Write a program to enter length in centimeter and convert it into meter and kilometer.
    {
        static void Main(string[] args)
        {
            double m, km;
            Console.WriteLine("Enter Length in centimeter :");
            int cm = int.Parse(Console.ReadLine());
            m = cm / 100;
            km = cm / 100000;
            Console.WriteLine("\n Convert cm to m=" + m + "m");
            Console.WriteLine("\n Convert cm to km=" + km + "km");
            Console.ReadKey();
        }
    }
    class AssgnM_A_PQ21
    // 21. Write a Java program to enter marks of five subjects and calculate total, average and percentage.
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
    class AssgnSIQ22
    // 22. Write a Java program to enter P, T, R and calculate Simple Interest.
    {
        static void Main(string[] args)
        {
            double SI;
            Console.WriteLine("Enter Principal Amount :");
            int P = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Time :");
            int T = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Rate :");
            int R = int.Parse(Console.ReadLine());
            SI = (P * R * T) / 100;
            Console.WriteLine("Simple Interest = " + SI);
            Console.ReadKey();
        }
    }
    class AssgnRectanglePerimeterQ23
    // 23. Write a Java program to enter length and breadth of a rectangle and find its perimeter.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length for rectangle :");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth for rectangle :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter of Rectangle = " + (2 * (l + b)));
            Console.ReadKey();
        }
    }
}
