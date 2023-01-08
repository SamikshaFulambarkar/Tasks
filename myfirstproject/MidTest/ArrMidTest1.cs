using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.MidTest
{
    class ArrMidTest1
        // arrange negative first and then positive

    {
        static int[] ArrangeArray(int[] arr, int l, int r)
        {
            int temp = arr[r];
            for(int j=r; j>l-1; j--)
            {
                arr[j] = arr[j - 1];
            }
            arr[l] = temp;
            return arr;
        }
        static int[] moveNegative(int[] arr)
        {
            int last_negative_index = -1;
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i]<0)
                {
                    last_negative_index += 1;
                    int temp = arr[i];
                    arr[i] = arr[last_negative_index];
                    arr[last_negative_index] = temp;
                    if (i - last_negative_index >= 2)
                        ArrangeArray(arr, last_negative_index + 1, i);
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 6, -3, -4, -8, 0, -7, 3, -9, 10, -2 };
            arr = moveNegative(arr);
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }
            Console.ReadKey();
        }
    }
    class MidTest2
        // Vowels replace with $ in given string
    {
        static void Main(string[] args)
        {
            string s = "My name is Samiksha";
            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i', 'A', 'E', 'O', 'U', 'I' };
            char[] newstring = new char[s.Length];
            bool k = false;
            for(int i=0; i<s.Length; i++)
            {
                for(int j=0; j<vowels.Length; j++)
                {
                    if(s[i]==vowels[j])
                    {
                        k = true;
                        break;
                    }
                }
                if(k)
                {
                    newstring[i] = '$';
                    k = false;
                }
                else
                {
                    newstring[i] = s[i];
                }
            }
            foreach(char ch in newstring)
            {
                Console.Write(ch);
            }
            Console.ReadKey();
        }
    }
    class Employee10
    {
        public int id;
        public string name;
        public string department_name;

        public Employee10(int id, string name, string department_name)
        {
            this.id = id;
            this.name = name;
            this.department_name = department_name;
        }
        public void Display()
        {
            Console.WriteLine("Employee Id" + id);
            Console.WriteLine("Employee Name" + name);
            Console.WriteLine("Department_Name" + department_name);
        }
    }
    class EmployeeDetails10
    {
        static void Main(string[] args)
        {
            Employee10 ed = new Employee10(101, "Samiksha", "RND");
            ed.Display();
            Console.ReadKey();
        }
    }
}
