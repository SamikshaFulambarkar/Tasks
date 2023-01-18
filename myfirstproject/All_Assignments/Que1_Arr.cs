using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.All_Assignments
{
    class Que1_Arr
    //1.Merging elements of two different arrays alternatively in third array.
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
            for (i = j = 0; i < s; i++)
            {
                arr3[j++] = arr1[i];
                arr3[j++] = arr2[i];
            }
            Console.WriteLine("Alternate elements of both array are:");
            for (i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
            Console.ReadKey();
        }
    }
    class Que2_Arr
    //WAP to create a array of 10 elements and swap first two elements with last two elements.
    {
        static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            Console.Write("After swapping elements: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.ReadKey();
        }
        static int[] test(int[] numbers)
        {
            int first = numbers[0];
            numbers[0] = numbers[numbers.Length - 1];
            numbers[numbers.Length - 1] = first;
            int second = numbers[1];
            numbers[1] = numbers[numbers.Length - 2];
            numbers[numbers.Length - 2] = second;
            return numbers;
        }
    }
    class Que3_Arr
    //WAP to find frequency/count of each element in 1D array.
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
                arr[i] = int.Parse(Console.
                    ReadLine());
            }
            bool[] found = new bool[s];
            for (i = 0; i < s; i++)
                found[i] = false;
            for (i = 0; i < s; i++)
            {
                if (found[i] == true)
                    continue;
                int cnt = 1;
                for (int j = i + 1; j < s; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        found[j] = true;
                        cnt++;
                    }
                }
                Console.WriteLine(arr[i] + " " + "is present" + " " + cnt + " " + "times in array");
            }
            Console.ReadKey();
        }
    }
    class Que4_Arr
    //How to rearrange array in alternating positive and negative number.
    {
        static void rightrotate(int[] arr, int n,
                            int outofplace, int cur)
        {
            int tmp = arr[cur];
            for (int i = cur; i > outofplace; i--)
                arr[i] = arr[i - 1];
            arr[outofplace] = tmp;
        }
        static void rearrange(int[] arr, int n)
        {
            int outofplace = -1;

            for (int index = 0; index < n; index++)
            {
                if (outofplace >= 0)
                {
                    if (((arr[index] >= 0)
                     && (arr[outofplace] < 0))
                    || ((arr[index] < 0)
                        && (arr[outofplace] >= 0)))
                    {
                        rightrotate(arr, n, outofplace, index);
                        if (index - outofplace > 2)
                            outofplace = outofplace + 2;
                        else
                            outofplace = -1;
                    }
                }
                if (outofplace == -1)
                {
                    if (((arr[index] >= 0)
                     && ((index & 0x01) == 0))
                    || ((arr[index] < 0)
                        && (index & 0x01) == 1))
                        outofplace = index;
                }
            }
        }
        static void printArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine("");
        }
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, -4, -1, 4 };
            int n = arr.Length;
            Console.WriteLine("Given array is ");
            printArray(arr, n);
            rearrange(arr, n);
            Console.WriteLine("Rearranged array is ");
            printArray(arr, n);
            Console.ReadKey();
        }
    }
    class Que5_Arr
    //Write a java program to separate zeros from non-zeros in an integer array?
    {
        static void pushZerosToEnd(int[] arr, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
                if (arr[i] != 0)
                    arr[count++] = arr[i];
            while (count < n)
                arr[count++] = 0;
        }
        static void Main(string[] args)
        {
            int[] arr = { 12, 0, 7, 0, 8, 0, 3 };
            int n = arr.Length;
            Console.WriteLine("Array Data:");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            pushZerosToEnd(arr, n);
            Console.WriteLine("\nArray after pushing all zeros to the back: ");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.ReadKey();
        }
    }
}
