using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.All_Assignments
{
    class TaskArr1
    // 1.WAP to search for a given number in an array and accordingly print the index if exists
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter elements");
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter element in an array");
            int ele = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < s; i++)
            {
                if (arr[i] == ele)
                {
                    Console.WriteLine($"{ele} is present at index {i}");
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"{ele} is not present in an array");
            }
            Console.ReadKey();
        }
    }
    class TaskArr3
    // 3.WAP to print all negative elements in an array and also count total number of negative elements in an array.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter elements");
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Negative element are : ");
            int count = 0;
            for (int i = 0; i < s; i++)
            {
                if (arr[i] < 0)
                {
                    Console.Write(arr[i] + " ");
                    count++;
                }
            }
            Console.WriteLine($"\nTotal negative elements present in array : {count}");
            Console.ReadKey();
        }
    }
    class TaskArr4
    // 4.WAP to put even and odd elements of array in two separate arrays.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] even = new int[s];
            int[] odd = new int[s];
            int e = 0, o = 0;
            for (int i = 0; i < s; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even[e++] = arr[i];
                }
                else
                {
                    odd[o++] = arr[i];
                }
            }
            Console.WriteLine("Even elements present in an array : ");
            for (int i = 0; i < e; i++)
            {
                Console.Write(even[i] + " ");
            }
            Console.WriteLine("\nOdd elements present in an array : ");
            for (int i = 0; i < o; i++)
            {
                Console.Write(odd[i] + " ");
            }
            Console.ReadKey();
        }
    }
    class TaskArr5
    // 5.WAP to find the maximum and minimum value in an array.
    {
        static void Main(string[] args)
        {
            int s, i, min, max;
            Console.WriteLine("Enter size of array");
            s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter elements");
            for (i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            min = max = arr[0];
            for (i = 0; i < s; i++)
            {
                if (min > arr[i])
                    min = arr[i];
                if (max < arr[i])
                    max = arr[i];
            }
            Console.WriteLine("Minimum number is:" + min);
            Console.WriteLine("Maximum number is:" + max);
            Console.ReadKey();
        }
    }
    class TaskArr6
    // 6.WAP to find and count total number of duplicate elements in an array.
    {
        static void Main(string[] args)
        {
            int s, i, j, dup_no = 1, count = 0;
            Console.WriteLine("Enter size of array");
            s = int.Parse(Console.ReadLine());
            int[] arr1 = new int[s];
            int[] arr2 = new int[s];
            int[] arr3 = new int[s];
            Console.WriteLine("Enter elements");
            for (i = 0; i < s; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < s; i++)
            {
                arr2[i] = arr1[i];
                arr3[i] = 0;
            }
            for (i = 0; i < s; i++)
            {
                for (j = 0; j < s; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr3[j] = dup_no;
                        dup_no++;
                    }
                }
                dup_no = 1;
            }
            for (i = 0; i < s; i++)
            {
                if (arr3[i] == 2) { count++; }
            }
            Console.Write("Total number of duplicate elements are: {0} \n", count);
            Console.ReadKey();
        }
    }
    class TaskArr7
    // 7.WAP to print all unique elements in the array.
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
    class TaskArr8
    // 8.WAP to find the second smallest element in an array.
    {
        static void Main(string[] args)
        {
            int s, i, j = 0, sml, sml2nd;
            Console.WriteLine("Enter size of array");
            s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter elements");
            for (i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            sml = 0;
            for (i = 0; i < s; i++)
            {
                if (sml > arr[i])
                {
                    sml = arr[i];
                    j = i;
                }
            }
            sml2nd = 99999;
            for (i = 0; i < s; i++)
            {
                if (i == j)
                {
                    i++;
                    i--;
                }
                else
                {
                    if (sml2nd > arr[i])
                    {
                        sml2nd = arr[i];
                    }
                }
            }
            Console.WriteLine("The Second smallest element in the array is :  {0} ", sml2nd);
            Console.ReadKey();
        }
    }
    class TaskArr9
    // 9.WAP to count frequency of each element in an array.
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
                Console.WriteLine(arr[i] + " is present " + cnt + " times in array");
            }
            Console.ReadKey();
        }
    }
    class TaskArr10
    // 10.WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value.
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
    class TaskArr11
    // 11. WAP sort array elements in ascending order.
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
    class TaskArr12
    // 12. WAP to reverse the array itself,
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
    class TaskArr13
    // 13. Write a  program to test the equality of two arrays. 
    {
        public static bool areEqual(int[] arr1, int[] arr2)
        {
            int s1 = arr1.Length;
            int s2 = arr2.Length;
            if (s1 != s2)
                return false;
            Array.Sort(arr1);
            Array.Sort(arr2);
            for (int i = 0; i < s1; i++)
                if (arr1[i] == arr2[i])
                    return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size for array:");
            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements in array:");
            int[] arr1 = new int[s1];
            for (int i = 0; i < s1; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter size for array:");
            int s2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements in array:");
            int[] arr2 = new int[s2];
            for (int i = 0; i < s2; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            if (areEqual(arr1, arr2))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            Console.ReadKey();
        }
    }
    class TaskArr14
    // 14. WAP to replace all negative value with its immediate left elements square. 
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
    class TaskArr15
    /* 15.WAP to arrange the elements of an given array of integers where
     all negative integers appear before all the positive integers. */
    {
        public static void move(int[] arr)
        {
            Array.Sort(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter size for array:");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements in array:");
            int[] arr = new int[s];
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            move(arr);
            foreach (int e in arr)
                Console.Write(e + " ");
            Console.ReadKey();
        }
    }
}
