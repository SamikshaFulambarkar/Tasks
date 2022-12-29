using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.StringPrograms
{
    class StringBehavior
    {
        static void Main(string[] args)
        {
            string str = "Samiksha";
            string str1 = "Samiksha";
            Console.WriteLine("Reference for string: " + str.GetHashCode());
            Console.WriteLine("Reference for string1: " + str1.GetHashCode());
            str = str + "Agarkar";
            Console.WriteLine("Reference for string: " + str.GetHashCode());
            Console.WriteLine("Reference for string1: " + str1.GetHashCode());
            str = str + "Agarkar";
            str = str + "Electronic Engineer";
            str = str + "Lives in Pune";
            str = str + "Is a sweet girl";
            Console.WriteLine("Reference for string: " + str.GetHashCode());
            StringBuilder sb = new StringBuilder();
            sb.Append(" Hello World ");
            Console.WriteLine("Reference for sb: " + str.GetHashCode());
            sb.Append(" C# ");
            sb.Append(" Programming ");
            Console.WriteLine("String is " + sb.ToString());
            Console.WriteLine("Reference for sb: " + str.GetHashCode());
            Console.ReadKey();
        }
    }
    class StringProgram1
    // find out length of string
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            Console.WriteLine("String is: " + str);
            int len = 0;
            foreach (char ch in str)
            {
                Console.Write("Characters: " + ch + " ");
                len++;
            }
            Console.WriteLine();
            Console.WriteLine("Length of string is: " + len);
            Console.ReadKey();
        }
    }
    class StringProgram2
    // find out string length as a property
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            Console.WriteLine("String is: " + str);
            Console.WriteLine("Length of string is: " + str.Length);
            for (int i = 0; i < str.Length; i++)
                Console.Write(str[i] + " ");
            Console.ReadKey();
        }
    }
    class StringProgram3
    // display the alternate characters of string
    {
        static void Main(string[] args)
        {
            string str = "Samiksha";
            Console.WriteLine("String is: " + str);
            Console.WriteLine("Length of string is: " + str.Length);
            for (int i = 0; i < str.Length; i++)
                Console.Write(str[i] + " ");
            Console.ReadKey();
        }
    }
    class StringProgram4
    // display character is present or not in string
    {
        static void Main(string[] args)
        {
            string str = "Samiksha";
            Console.WriteLine("String is: " + str);
            Console.WriteLine("Length of string is: " + str.Length);
            for (int i = 0; i < str.Length; i++)
                Console.Write(str[i] + " ");
            Console.WriteLine("\nEnter any character");
            char ch = Convert.ToChar(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (ch == str[i])
                    count++;
            }
            if (count == 0)
                Console.WriteLine("character is not present in string");
            else
                Console.WriteLine("Character is present {0} times ", count);
            Console.ReadKey();
        }
    }
    class StringProgram5
    // Conversion Uppercase to lowercase and vice versa
    {
        static void Main(string[] args)
        {
            string str = "SaMiKsHa";
            Console.WriteLine("String is: " + str);
            Console.WriteLine("Converted characters are:");
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                    Console.Write(Char.ToLower(str[i]) + " ");
                else
                    Console.Write(Char.ToUpper(str[i]) + " ");
                Console.ReadKey();
            }
        }
    }
    class StringProgram6
    // reverse string
    {
        static void Main(string[] args)
        {
            string str = "Samiksha";
            Console.WriteLine("String is: " + str);
            string strRev = " ";
            for (int i = str.Length - 1; i >= 0; i--)
                strRev = strRev + str[i];
            Console.WriteLine("String in reverse order is: " + strRev);
            Console.ReadKey();
        }
    }
    class StringProgram7
    // count vowels from string
    {
        static void Main(string[] args)
        {
            string myStr;
            int i, len, count_vowel, count_cons;
            myStr = "Samiksha";
            count_vowel = 0;
            count_cons = 0;
            len = myStr.Length;
            for (i = 0; i < len; i++)
            {
                if (myStr[i] == 'a' || myStr[i] == 'e' || myStr[i] == 'i' || myStr[i] == 'o' || myStr[i] == 'u' || myStr[i] == 'A' || myStr[i] == 'E' || myStr[i] == 'I' || myStr[i] == 'O' || myStr[i] == 'U')
                {
                    count_vowel++;
                }
                else
                {
                    count_cons++;
                }
            }
            Console.WriteLine("Vowels in the string:{0}", count_vowel);
            Console.ReadKey();
        }
    }
    class StringProgram8
    // count word in string
    {
        static void Main(string[] args)
        {
            string str = "Samiksha Agarkar";
            Console.WriteLine("String is: " + str);
            int i = 0, myWord = 1;
            while (i <= str.Length - 1)
            {
                if (str[i] == ' ')
                {
                    myWord++;
                }
                i++;
            }
            Console.WriteLine("Number of words in the string = {0}", myWord);
            Console.ReadKey();
        }
    }
    class StringProgram9
    // split method
    {
        static void Main(string[] args)
        {
            string str = "Samiksha Agarkar";
            Console.WriteLine("String is: " + str);
            string[] strArr = str.Split(' ');
            Console.WriteLine("No of string present in {0} is {1}", str, strArr.Length);
            foreach (string str2 in strArr)
                Console.WriteLine(str2);
            Console.ReadKey();
        }
    }
    class StringProgram10
    // count int from string and add them
    {
        static void Main(string[] args)
        {
            string str = "Sami8ksha23 Agar7kar5";
            Console.WriteLine("String is: " + str);
            int sum = 0;
            foreach (char ch in str)
            {
                if (ch >= 48 && ch <= 57)
                    sum = sum + int.Parse(ch.ToString());
            }
            Console.WriteLine("Sum of digits presen in string = " + sum);
                 Console.ReadKey();
        }
    }
    class StringProgram11
    // find out the index of character in given string
    {
        static void Main(string[] args)
        {
            string str = "Samiksha";
            Console.WriteLine("String is: " + str);
            Console.WriteLine("Enter any character");
            char ch = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < str.Length; i++)
            {
                if (ch == str[i])
                {
                    Console.WriteLine("Zero based index position is: " + i);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
    class StringProgram12
    // word is present or not in string (by using contains method)
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            Console.WriteLine("Enter string to be found in present string:");
            string strToFound = Console.ReadLine();
            int count = 0;
            bool isPresent = str.Contains(strToFound);
            if (isPresent)
            {
                Console.WriteLine(strToFound + " is present in string");
                count++;
            }
            else
            {
                Console.WriteLine(strToFound + " is not present in string");
            }
            Console.ReadKey();
        }
    }
    class StringProgram13
    // To combine two strings
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            string str2 = Console.ReadLine();
            string str3 = " ";
            foreach (char ch in str1)
                str3 = str3 + ch;
            foreach (char ch in str2)
                str3 = str3 + ch;
            Console.WriteLine("Concatenated string is : " + str3);
            Console.ReadKey();
        }
    }
    class StringProgram14
    // concatenated string in same string
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            string str2 = Console.ReadLine();
            foreach (char ch in str2)
                str1 = str1 + ch;
            Console.WriteLine("Concatenated string is : " + str1);
            Console.ReadKey();
        }
    }
    class StringProgram15
    // concat by method
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            string str2 = Console.ReadLine();
            string str = string.Concat(str1, str2);
            Console.WriteLine("Concatenated string is : " + str);
            Console.ReadKey();
        }
    }
    class StringProgram16
    // index of string
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter string to be found");
            string str2 = Console.ReadLine();
            int position = str1.IndexOf(str2);
            Console.WriteLine("String {0} is present at {1} location", str2, position);
            Console.ReadKey();
        }
    }
    class StringProgram17
    // Compare two string by using compare method
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter string to be found");
            string str2 = Console.ReadLine();
            int comparison = string.Compare(str1, str2);
            /* compare return less than 0 if the first string precedes the second string in sort order
                return 0 if both strings are equal
                return positive or greater than 0 if the first string follows the second string in sort order */
            if (comparison == 0)
            {
                Console.WriteLine("Both the strings are equal");
            }
            else if (comparison < 0)
            {
                Console.WriteLine("less than 0 first string precedes the second string in sort order");
            }
            else
            {
                Console.WriteLine("greater than 0 first string follows the second string in sort order");
            }
            Console.ReadKey();
        }
    }
    class StringProgram18
    // Copy method one string to another string
    {
        static void Main(string[] args)
        {
            // copy method
            Console.WriteLine("Enter string");
            string str1 = Console.ReadLine();
            string str2 = " ";
            str2 = string.Copy(str1);
            Console.WriteLine("Copied string is : " + str2);
            Console.ReadKey();
        }
    }
    class StringProgram18_1
    // using copy-to method
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str1 = Console.ReadLine();
            char[] str2 = new char[20];
            str1.CopyTo(1, str2, 2, str1.Length - 1);
            Console.WriteLine("Copied string is : " + str2);
            Console.ReadKey();
        }
    }
    class StringProgram19
    // write code to find out no. of characters from the string
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();
            int count = 0;
            foreach (char ch in str)
            {
                count++;
            }
            Console.WriteLine("No of characters present in the string : " + count);
            Console.ReadKey();
        }
    }
    class StringProgram20
    // write code to find out the no. of words from the string
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
            Console.ReadKey();
        }
    }
    class StringProgram21
    // write code to reverse string words except first word and last word
    {
        public string ReverseWords(string s)
        {
            string[] str = s.Split();
            string mywords = "";
            for (int i = 0; i < str.Length; i++)
            {
                string wordvalue = str[i];
                string revword = "";
                if (i != 0 && i != str.Length - 1)
                {
                    for (int j = 0; j < wordvalue.Length; j++)
                    {
                        revword = wordvalue[j] + revword;
                    }
                }
                else
                {
                    revword = wordvalue;
                }
                mywords = mywords + "  " + revword;
            }
            return mywords;
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the String");
            String str = Console.ReadLine();

            StringProgram21 r = new StringProgram21();
            Console.WriteLine(r.ReverseWords(str));
            Console.ReadKey();
        }
    }

    class StringProgram22
    // arrange a string in pattern format
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();
            string s = " ";
            string[] strArr = str.Split(' ');
            foreach (string str2 in strArr)
            {
                s = s + str2;
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
    class StringProgram23
    // write code to check given string is palindrome or not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string :");
            string str = Console.ReadLine();
            string rev;
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool check = str.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (check == true)
            {
                Console.WriteLine(" " + str + " is a palindrome");
            }
            else
            {
                Console.WriteLine(" " + str + " is not a palindrome");
            }
            Console.ReadKey();
        }
    }
    class StringProgram24
    // write code to calculate the average of digit from the string
    {
        static void Main(string[] args)
        {
            double average;
            Console.WriteLine("Enter string :");
            string str = Console.ReadLine();
            int count = 0, total = 0;
            foreach (char ch in str)
            {
                if (ch >= 48 && ch <= 57)
                    total = total + int.Parse(ch.ToString());
                count++;
            }
            Console.WriteLine("Average of digits present in string : " + total);
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
    class StringProgram25
    // write code to take full name of person from users convert it like in abbreviated form
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string :");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length - 1; i++)
            {
                words[i] = words[i].Substring(0, 1);
            }
            string s1 = string.Join(".", words);
            Console.WriteLine("Name of person in Abbreviated form : " + s1);
            Console.ReadKey();
        }
    }
    class StringProgram26
    // write code to find out the longest word from the string
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string :");
            string str = Console.ReadLine();
            string[] words = str.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int count = 0;
            foreach (String s in words)
            {
                if (s.Length > count)
                {
                    word = s;
                    count = s.Length;
                }
            }
            Console.WriteLine("Longest word from string : " + word);
            Console.ReadKey();
        }
    }
    class StringProgram27
    // write code to find out the no. of vowels from the string
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string :");
            string str = Console.ReadLine();
            int i, len, count_vowel, count_cons;
            count_vowel = 0;
            count_cons = 0;
            len = str.Length;
            for (i = 0; i < len; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    count_vowel++;
                }
                else
                {
                    count_cons++;
                }
            }
            Console.WriteLine("No of vowels from the string : " + count_vowel);
            Console.ReadKey();
        }
    }
    class StringProgram28
    // write code to find out the occurences of each character from the string
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
            StringProgram28.FindOccuranceChar(ch);
            Console.ReadKey();
        }
    }
}
