using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.ArrProgram
{
    class Assgn3decQ1
    // create a Array of integer and count the number of even  and odd elements from array.
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            int[] even = new int[s];
            int[] odd = new int[s];
            int e = 0, o = 0;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] % 2 == 0)
                {
                    even[e++] = ar[i];
                }
                else
                {
                    odd[o++] = ar[i];
                }
            }
            Console.WriteLine("Even array : ");
            for (int i = 0; i < e; i++)
            {
                Console.Write(even[i] + " ");
            }
            Console.WriteLine("\nOdd array : ");
            for (int i = 0; i < o; i++)
            {
                Console.Write(odd[i] + " ");
            }
            Console.ReadKey();
        }
    }
    class AssgnQ2
    // Predict the output: 
    {
        static int mcCartyCounter = 100;
        public static int mcCarthy(int n)
        {
            mcCartyCounter++;
            if (n > 100)
                return n - 10;
            else
                return mcCarthy(n + 11);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(mcCarthy(100) + "  " + mcCartyCounter);
            Console.ReadKey();
        }
    }
    class AssgnQ3
    // Write a program to find Minimum frequency char from an Array
    {
        static void Main(string[] args)
        {
            int size, i;
            Console.WriteLine("Enter size");
            size = int.Parse(Console.ReadLine());
            char[] arr = new char[size];
            Console.WriteLine("Enter character");
            for (i = 0; i < size; i++)
            {
                arr[i] = Convert.ToChar(Console.ReadLine());
            }
            char minChar = arr[0];
            int[] freq = new int[arr.Length];
            int j, min;
            for (i = 0; i < arr.Length; i++)
            {
                freq[i] = 1;
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && arr[i] != ' ' && arr[i] != '0')
                    {
                        freq[i]++;


                        arr[j] = '0';
                    }
                }
            }
            min = freq[0];
            for (i = 0; i < freq.Length; i++)
            {

                if (min > freq[i] && freq[i] != '0')
                {
                    min = freq[i];
                    minChar = arr[i];
                }
            }
            Console.WriteLine(minChar);
            Console.ReadKey();
        }
    }
    class AssgnQ4
    // Write a  program to separate zeros from non-zeros in an integer array?
    {
        static void pushZerosToEnd(int[] arr, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
                if (arr[i] != 0)
                    arr[count++] = arr[i];
            while (count < n)
                arr[count++] = 0;
            Console.ReadKey();
        }
        public static void Main()
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array Data:");
            for (int i = 0; i < s; i++)
                Console.Write(arr[i] + " ");
            pushZerosToEnd(arr, s);
            Console.WriteLine("\nArray after pushing all zeros to the back: ");
            for (int i = 0; i < s; i++)
                Console.Write(arr[i] + " ");
            Console.ReadKey();
        }
    }
    class AssgnQ5
    // Write a  program to remove duplicate elements from an array?
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter size:");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements:");
            int[] arr = new int[s];
            for (i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] arr2 = new int[arr.Length];
            int k = 0, count;
            for (i = 0; i < arr.Length; i++)
            {
                count = 0;
                for (j = k - 1; j >= 0; j--)
                {
                    if (arr2[j] == arr[i])
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    arr2[k] = arr[i];
                    k++;
                }
            }
            Console.WriteLine(" Array without duplicate elements :");
            for (i = 0; i < k; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.ReadKey();
        }
    }
    /*class Numbers
    // What will be output of following program. 
    {
        static void main(String []args)
        {
            int[] var = new int[10];
            for (int i = 0; i < 10; ++i)
            {
                var[i] = i;
                Console.WriteLine(var[i] +" ");
                i++;
            }
        }
    }*/
    /*public class ArrayOuput
    {
        public static void main(String[] args)
        {
            int a1[], a2;
            a1 ={ 1,2,3};
            a2 = new String[a1.length];
            for (int i = 0; i < a1.length; i++)
            {
                a2[i] = a1[i];
            }
            for (int i = 0; i < a2.length(); i++)
            {
                Console.WriteLine(a2[i]);
            }
        }
    }*/
    class AssgnQ6
    /* Write a  program that prints the numbers
    from 1 to 50. But for multiples of three print “buzz” instead of the
    number and for the multiples of five print “fizz”. For numbers which
    are multiples of both three and five print “ buzzfizz “. After program
    looping is completed print how many times buzz was printed, fizz
    was printed and buzzfizz was printed. */
    {
        static void Main(string[] args)
        {
            int count1 = 0, count2 = 0, count3 = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Buzzfizz");
                    count1++;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Buzz");
                    count2++;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Fizz");
                    count3++;
                }
            }
            Console.WriteLine("Count of BuzzFizz : " + count1);
            Console.WriteLine("Count of Buzz : " + count2);
            Console.WriteLine("Count of Fizz : " + count3);
            Console.ReadKey();
        }
    }
    class AssgnQ7
    // WAP to replace all the 0’s with 1’s in your array.
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
    class AssgnQ8
    //  WAP to display all perfect square number in array.
    {
        static void Main(string[] args)
        {
            int i, count = 0;
            Console.WriteLine("Enter size for array:");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements in array:");
            int[] arr = new int[s];
            for (i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] square = new int[arr.Length];
            for (i = 0; i < s; i++)
            {
                square[i] = arr[i] * arr[i];
                count++;
            }
            Console.WriteLine("Modified Array is:");
            for (i = 0; i < s; i++)
                Console.Write(arr[i] + " ");
            Console.ReadKey();
        }
    }
}
