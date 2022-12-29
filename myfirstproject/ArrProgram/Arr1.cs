using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.ArrProgram
{
    class Arr1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
            for (int i = 0; i < 5; i++)
                Console.Write(arr[i] + " ");
            Console.ReadKey();
        }
    }
    class Arr2
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 elements");
            for (int i = 0; i < 5; i++)
                arr[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Array data is:");
            for (int i = 0; i < 5; i++)
                Console.Write(arr[i] + " ");
            Console.ReadKey();
        }
    }
    class Arr3
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 14, 15, 17, 20 };
            Console.WriteLine("Array data is:");
            for (int i = 0; i < 5; i++)
                Console.Write(arr[i] + " ");
            Console.ReadKey();
        }
    }
    class Arr4
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 14, 15, 17, 20 };
            Console.WriteLine("Array reverse data is:");
            for (int i = 4; i >= 0; i--)
                Console.Write(arr[i] + " ");
            Console.ReadKey();
        }
    }
    class Arr5
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter size of array:");
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter" + size + "elements to array");
            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Array data is:");
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");
            Console.ReadKey();
        }
    }
    class Add_Elements
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
            Console.WriteLine("Array is ");
            int sum = 0;
            for (int i = 0; i < s; i++)
            {
                Console.Write(ar[i] + " ");
                sum = sum + ar[i];
            }
            Console.WriteLine($"\naddition is : {sum}");
            Console.ReadKey();
        }
    }
    class Add_Even_Elements
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
            Console.WriteLine("Array is ");
            int sum = 0;
            for (int i = 0; i < s; i++)
            {
                Console.Write(ar[i] + " ");
                if (ar[i] % 2 == 0)
                {
                    sum = sum + ar[i];
                }
            }
            Console.WriteLine($"\n even element addition is : {sum}");
            Console.ReadKey();
        }
    }
    class Copied_Elements
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            Console.WriteLine("Enter 5 elements");
            for (int i = 0; i < 5; i++)
                arr1[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 4; i++)
                arr2[i] = arr1[i];
            Console.WriteLine("Copied array is:");
            for (int i = 0; i < 5; i++)
                Console.Write(arr2[i] + " ");
            Console.ReadKey();
        }
    }
    class Copied_Reverse
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            Console.WriteLine("Enter 5 elements");
            for (int i = 0; i < 5; i++)
                arr1[i] = int.Parse(Console.ReadLine());
            for (int i = 0, j = 4; i <= 4; i++, j--)
                arr2[i] = arr1[j];
            Console.WriteLine("Copied array is:");
            for (int i = 0; i < 5; i++)
                Console.Write(arr2[i] + " ");
            Console.ReadKey();
        }
    }
    class Present_number
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 elements");
            for (int i = 0; i < 5; i++)
                arr[i] = int.Parse(Console.ReadLine());
            int no, count = 0;
            Console.WriteLine("Enter any number");
            no = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 4; i++)
                if (arr[i] == no)
                    count++;
            if (count == 0)
                Console.WriteLine(no + "Not present in Array");
            else
                Console.WriteLine(no + "Present in Array" + count + "times");
            Console.ReadKey();
        }
    }
    class Modified
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 elements");
            for (int i = 0; i < 5; i++)
                arr[i] = int.Parse(Console.ReadLine());
            int no;
            Console.WriteLine("Enter any number to find");
            no = int.Parse(Console.ReadLine());
            int no1;
            Console.WriteLine("Enter any number to replace");
            no1 = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 4; i++)
                if (arr[i] == no)
                    arr[i] = no1;
            Console.WriteLine("Modified Array is:");
            for (int i = 0; i < 5; i++)
                Console.Write(arr[i] + " ");
            Console.ReadKey();
        }
    }
    class Delete_Element
    {
        static void Main(string[] args)
        {
            int i;
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 elements");
            for (i = 0; i < 5; i++)
                arr[i] = int.Parse(Console.ReadLine());
            int no;
            Console.WriteLine("Enter any number to find");
            no = int.Parse(Console.ReadLine());
            if (arr[i] == no)
                arr[i] = 0;
            Console.WriteLine("Modified Array is:");
            for (i = 0; i < 5; i++)
                Console.Write(arr[i] + " ");
            Console.ReadKey();
        }
    }
    class Average_Elements
    {
        static void Main(string[] args)
        {
            int i;
            double average;
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 elements");
            for (i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array is:");
            int sum = 0;
            for (i = 0; i < 5; i++)
            {
                sum = sum + arr[i];
                average = sum / 5;
                Console.WriteLine("Average value of the array is:" + average);
                Console.ReadKey();
            }
        }
    }
    class Negative_Elements
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
            Console.WriteLine("Negative element are : ");
            int count = 0;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] < 0)
                {
                    Console.Write(ar[i] + " ");
                    count++;
                }
            }

            Console.WriteLine($"\nTotal negative numbers are : {count}");
            Console.ReadKey();
        }
    }
    class Even_Odd_Elements
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
    class Alternate_Elements
    {
        static void Main(string[] args)
        {
            int s, i, j;
            Console.WriteLine("Enter size of array");
            s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter elements");
            for (i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Alternate elements of array :");
            int sum = 0;
            for (j = 0; j < s; j += 2)
            {
                Console.WriteLine(arr[j]);
                sum = sum + arr[j];
            }
            Console.WriteLine("Sum of alternate elements :" + sum);
            Console.ReadKey();
        }
    }
    class Insert_Specific_Position_Elements
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
            int pos, element;
            Console.WriteLine("Enter position where element is to be inserted :");
            pos = int.Parse(Console.ReadLine());
            if (pos <= s && pos != 0)
            {
                Console.WriteLine("Enter element to be inserted at position :" + pos);
                element = int.Parse(Console.ReadLine());
                arr[pos - 1] = element;
                Console.Write("Revised array is :");
                for (i = 0; i < s; i++)
                    Console.Write(arr[i] + " ");
            }
            else
            {
                Console.WriteLine("Invalid position array index out of range");
            }
            Console.ReadKey();
        }
    }
    class Presence_Element
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
            int old_element, new_element;
            Console.WriteLine("Enter element to be found");
            old_element = int.Parse(Console.ReadLine());
            for (i = 0; i < s; i++)
            {
                if (arr[i] == old_element)
                {
                    Console.WriteLine("Enter element to be replaced:");
                    new_element = int.Parse(Console.ReadLine());
                    arr[i] = new_element;
                }
            }
            Console.WriteLine("Revised array is:");
            for (i = 0; i < s; i++)
                Console.Write(arr[i] + " ");
            Console.ReadKey();
        }
    }
    class Occurence_Element
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
            int no, count = 0;
            Console.WriteLine("Enter any number");
            no = int.Parse(Console.ReadLine());
            for (i = 0; i < s; i++)
                if (arr[i] == no)
                    count++;
            if (count == 0)
                Console.WriteLine(no + "Not present in Array");
            else
                Console.WriteLine(no + "Present in Array" + count + "times");
            Console.ReadKey();
        }
    }
    class Elements_frequency
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
                Console.WriteLine(arr[i] + "is present" + cnt + "times in array");
                Console.ReadKey();
            }
        }
    }
    class Elements_Negative
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
            int cnt = 0;
            for (i = 0; i < s; i++)
            {
                if (arr[i] < 0)
                    cnt++;
            }
            Console.WriteLine("Count of negative numbers in an array :" + cnt);
            Console.ReadKey();
        }
    }
    class Index
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("Enter elements");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter element of an array");
            int ele = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] == ele)
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
    class Max_Min_elements
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
                if (min < arr[i])
                    min = arr[i];
                if (max > arr[i])
                    max = arr[i];
            }
            Console.WriteLine("Minimum number is:" + min);
            Console.WriteLine("Maximum number is:" + max);
            Console.ReadKey();
        }
    }
    class Prime_Numbers
    {
        static void Main(string[] args)
        {
            int s, i, counter;
            Console.WriteLine("Enter size of array");
            s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter elements");
            for (i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Prime numbers in array :");
            for (i = 0; i < s; i++)
            {
                counter = 1;
                for (int j = 2; j <= arr[i] / 2; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        counter = 0;
                        break;
                    }
                }
                if (counter == 1)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
    class Positive_Neagative_Elements
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
            int[] positive = new int[s];
            int[] negative = new int[s];
            int p = 0, n = 0;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] > 0)
                {
                    positive[p++] = ar[i];
                }
                else
                {
                    negative[n++] = ar[i];
                }
            }
            Console.WriteLine("Positive elements in array : ");
            for (int i = 0; i < p; i++)
            {
                Console.Write(positive[i] + " ");
            }
            Console.WriteLine("\n Negative elements in array : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(negative[i] + " ");
            }
            Console.ReadKey();
        }
    }
    class Compare_Elements
    {
        static void Main(string[] args)
        {
            bool is_array_equal = true;
            int s, i;
            Console.WriteLine("Enter size for both arrays");
            s = int.Parse(Console.ReadLine());
            int[] arr1 = new int[s];
            Console.WriteLine("Enter elements in first array:");
            for (i = 0; i < s; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            int[] arr2 = new int[s];
            Console.WriteLine("Enter elements in second array:");
            for (i = 0; i < s; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            if (arr1.Length == arr2.Length)
            {
                for (i = 0; i < arr2.Length; i++)
                {
                    if (arr2[i] != arr1[i])
                    {
                        is_array_equal = false;
                        break;
                    }
                }
            }
            else
            {
                is_array_equal = false;
            }
            if (is_array_equal)
            {
                Console.WriteLine("Both Arrays are Equal");
            }
            else
            {
                Console.WriteLine("Both Arrays are not Equal");
            }
            Console.ReadKey();
        }
    }
    class Concatenate_Elements
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter size for first array:");
            int size1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements in first array:");
            int[] arr1 = new int[size1];
            for (i = 0; i < size1; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter size for second array:");
            int size2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements in second array:");
            int[] arr2 = new int[size2];
            for (i = 0; i < size2; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            int[] arr3 = new int[size1 + size2];
            for (i = 0, j = 0; i < size1; i++)
            {
                arr3[j++] = arr1[i];
            }
            for (i = 0; i < size2; i++)
            {
                arr3[j++] = arr2[i];
            }
            Console.WriteLine("Elements of third array are:");
            for (i = 0; i < size1 + size2; i++)
            {
                Console.Write(arr3[i] + " ");
            }
            Console.ReadKey();
        }
    }
    class Merge_Elements_Store_first
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter size for first array:");
            int size1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements in first array:");
            int[] arr1 = new int[size1];
            for (i = 0; i < size1; i++)
                arr1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter size for second array:");
            int size2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements in second array:");
            int[] arr2 = new int[size2];
            for (i = 0; i < size2; i++)
                arr2[i] = int.Parse(Console.ReadLine());
            int size3 = 0;
            {
                for (i = size1, j = 0; j < size2; i++, j++)
                {
                    arr1[i] = arr2[j];
                    size3 = i;
                }
                Console.WriteLine("Concatenated Array is:");
                for (i = 0; i <= size3; i++)
                {
                    Console.Write(arr1[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
    class Reverse_Elements
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
                Console.WriteLine($"{arr[i]}  ");
            Console.ReadKey();
        }
    }
    class Merging_Alternate_Elements
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
    class Concatenate_Without_Duplicate_Elements
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
    class Sorted_elements_Ascending
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
    class Sorted_elements_Descending
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
                    if (arr[i] < arr[j])
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
    class Replace_negative_square_elements
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
    class ArrReverseDemo
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(" ", a));
            int j = a.Length - 1;
            for (int i = 0; i < a.Length / 2; i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            Console.WriteLine(string.Join(" ", a));
            Console.ReadKey();
        }
    }
    class ArrWithoutDuplicate
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 4, 3, 6, 8 };
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(a[i] + "   " + count);
                }
            }
            Console.ReadKey();
        }
    }
    class ArrMergeTwo
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 3, 4 };
            int[] b = { 2, 6, 4, 5 };
            int[] c = new int[a.Length + b.Length];
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                bool isvisted = false;
                for (int p = k; p >= 0; p--)
                {
                    if (a[i] == c[p])
                    {
                        isvisted = true;
                        break;
                    }
                }
                if (isvisted == false)
                {
                    c[k] = a[i];
                    k++;
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                bool isvisted = false;
                for (int p = k; p >= 0; p--)
                {
                    if (b[i] == c[p])
                    {
                        isvisted = true;
                        break;
                    }
                }
                if (isvisted == false)
                {
                    c[k] = b[i];
                    k++;
                }
            }
            Console.WriteLine("Merge Array is:");
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
