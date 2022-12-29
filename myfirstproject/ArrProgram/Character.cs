using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.ArrProgram
{
    class Character
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
            Console.WriteLine("Character Array");
            for (i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
    class ASCII_Characters
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
            Console.WriteLine("Character Array");
            for (i = 0; i < size; i++)
            {
                if (arr[i] >= 65 && arr[i] <= 90)
                {
                    Console.WriteLine("Uppercase Character :" + arr[i]);
                }
                else if (arr[i] >= 97 && arr[i] <= 122)
                {
                    Console.WriteLine("Lowercase Character :" + arr[i]);
                }
            }
            Console.ReadKey();
        }
    }
    class Character_Conversion
    {
        static void Main(string[] args)
        {
            int size, i;
            Console.WriteLine("Enter size");
            size = int.Parse(Console.ReadLine());
            char[] str = new char[size];
            Console.WriteLine("Enter character");
            for (i = 0; i < size; i++)
            {
                str[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Character Array");
            for (i = 0; i < size; i++)
            {
                Console.Write(str[i] + " ");
            }
            for (i = 0; i < str.Length; i++)
            {
                if (str[i] >= 65 && str[i] <= 90)
                {
                    str[i] = (char)(str[i] + 32);
                }
                else
                {
                    str[i] = (char)(str[i] - 32);
                }
            }
            Console.WriteLine("Converted character is:");
            for (i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
            }
            Console.ReadKey();
        }
    }
    class Present_Character
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());

            char[] ar = new char[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Enter character to check");
            char ch = Convert.ToChar(Console.ReadLine());
            bool check = true;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] == ch)
                {
                    check = false;
                    break;
                }
            }
            if (check == false)
            {
                Console.WriteLine($"{ch} is present in array");
            }
            else
            {
                Console.WriteLine($"{ch} is not present in array");
            }
            Console.ReadKey();
        }
    }
    class Occurence_Character
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int s = int.Parse(Console.ReadLine());

            char[] ar = new char[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Enter character to check");
            char ch = Convert.ToChar(Console.ReadLine());
            int cnt = 0;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] == ch)
                {
                    cnt++;
                }
            }
            if (cnt == 0)
            {
                Console.WriteLine($"{ch} is not present in array");
            }
            else
            {
                Console.WriteLine($"{ch} is present in array" + cnt + "times");
            }
            Console.ReadKey();
        }
    }
    class Ascending_Character
    {
        static void Main(string[] args)
        {
            int size, i, j;
            char t;
            Console.WriteLine("Enter size");
            size = int.Parse(Console.ReadLine());
            char[] str = new char[size];
            Console.WriteLine("Enter character");
            for (i = 0; i < size; i++)
            {
                str[i] = Convert.ToChar(Console.ReadLine());
            }
            for (i = 0; i < size - 1; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (str[i] > str[j])
                    {
                        t = str[i];
                        str[i] = str[j];
                        str[j] = t;
                    }
                }
            }
            Console.WriteLine("Sorted array is:");
            for (i = 0; i < size; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.ReadKey();
        }
    }
    class Descending_Character
    {
        static void Main(string[] args)
        {
            int size, i, j;
            char t;
            Console.WriteLine("Enter size");
            size = int.Parse(Console.ReadLine());
            char[] str = new char[size];
            Console.WriteLine("Enter character");
            for (i = 0; i < size; i++)
            {
                str[i] = Convert.ToChar(Console.ReadLine());
            }
            for (i = 0; i < size - 1; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (str[i] < str[j])
                    {
                        t = str[i];
                        str[i] = str[j];
                        str[j] = t;
                    }
                }
            }
            Console.WriteLine("Sorted array is:");
            for (i = 0; i < size; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.ReadKey();
        }
    }
    class Concatenate_Without_Duplicate_Character
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter size for first array:");
            int size1 = int.Parse(Console.ReadLine());
            char[] str1 = new char[size1];
            Console.WriteLine("Enter character in first array");
            for (i = 0; i < size1; i++)
            {
                str1[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Enter size for second array:");
            int size2 = int.Parse(Console.ReadLine());
            char[] str2 = new char[size2];
            Console.WriteLine("Enter character in second array");
            for (i = 0; i < size2; i++)
            {
                str2[i] = Convert.ToChar(Console.ReadLine());
            }
            char[] str3 = new char[str1.Length + str2.Length];
            int k = 0, count;
            for (i = 0; i < str1.Length; i++)
            {
                count = 0;
                for (j = k - 1; j >= 0; j--)
                {
                    if (str3[j] == str1[i])
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    str3[k] = str1[i];
                    k++;
                }
            }
            for (i = 0; i < str2.Length; i++)
            {
                count = 0;
                for (j = k - 1; j >= 0; j--)
                {
                    if (str3[j] == str2[i])
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    str3[k] = str2[i];
                    k++;
                }
            }
            Console.WriteLine("Concatenated character Array :");
            for (i = 0; i < k; i++)
            {
                Console.Write(str3[i] + " ");
            }
            Console.ReadKey();
        }
    }
    class Merging_Alternate_Character
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter size for both arrays:");
            int size = int.Parse(Console.ReadLine());
            char[] str1 = new char[size];
            Console.WriteLine("Enter character in first array");
            for (i = 0; i < size; i++)
            {
                str1[i] = Convert.ToChar(Console.ReadLine());
            }
            char[] str2 = new char[size];
            Console.WriteLine("Enter character in second array");
            for (i = 0; i < size; i++)
            {
                str2[i] = Convert.ToChar(Console.ReadLine());
            }
            char[] str3 = new char[str1.Length + str2.Length];
            for (i = j = 0; i < size; i++)
            {
                str3[j++] = str1[i];
                str3[j++] = str2[i];
            }
            Console.WriteLine("Alternate characters of both array are:");
            for (i = 0; i < str3.Length; i++)
            {
                Console.Write(str3[i] + " ");
            }
            Console.ReadKey();
        }
    }
    class Reverse_Character
    {
        static void Main(string[] args)
        {
            int i, j;
            char t;
            Console.WriteLine("Enter size for array:");
            int size = int.Parse(Console.ReadLine());
            char[] str = new char[size];
            Console.WriteLine("Enter character in first array");
            for (i = 0; i < size; i++)
            {
                str[i] = Convert.ToChar(Console.ReadLine());
            }
            for (i = 0, j = size - 1; i < size / 2; i++, j--)
            {
                t = str[i];
                str[i] = str[j];
                str[j] = t;
            }
            Console.WriteLine("In place reverse character array is := ");
            for (i = 0; i < size; i++)
                Console.Write($"{str[i]}  ");
            Console.ReadKey();
        }
    }
    class Concatenate_Character
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter size for first array:");
            int size1 = int.Parse(Console.ReadLine());
            char[] str1 = new char[size1];
            Console.WriteLine("Enter character in first array");
            for (i = 0; i < size1; i++)
            {
                str1[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Enter size for second array:");
            int size2 = int.Parse(Console.ReadLine());
            char[] str2 = new char[size2];
            Console.WriteLine("Enter character in second array");
            for (i = 0; i < size2; i++)
            {
                str2[i] = Convert.ToChar(Console.ReadLine());
            }
            char[] str3 = new char[size1 + size2];
            for (i = 0, j = 0; i < size1; i++)
            {
                str3[j++] = str1[i];
            }
            for (i = 0; i < size2; i++)
            {
                str3[j++] = str2[i];
            }
            Console.WriteLine("Elements of third array are:");
            for (i = 0; i < size1 + size2; i++)
            {
                Console.Write(str3[i] + " ");
            }
            Console.ReadKey();
        }
    }
    class Merge_Characters_Store_First
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter size for first array:");
            int size1 = int.Parse(Console.ReadLine());
            char[] str1 = new char[size1];
            Console.WriteLine("Enter character in first array");
            for (i = 0; i < size1; i++)
            {
                str1[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Enter size for second array:");
            int size2 = int.Parse(Console.ReadLine());
            char[] str2 = new char[size2];
            Console.WriteLine("Enter character in second array");
            for (i = 0; i < size2; i++)
            {
                str2[i] = Convert.ToChar(Console.ReadLine());
            }
            int size3 = 0;
            {
                for (i = size1, j = 0; j < size2; i++, j++)
                {
                    str1[i] = str2[j];
                    size3 = i;
                }
                Console.WriteLine("Concatenated character Array is:");
                for (i = 0; i <= size3; i++)
                {
                    Console.Write(str1[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
