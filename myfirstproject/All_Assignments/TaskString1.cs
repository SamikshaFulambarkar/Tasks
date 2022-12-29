using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace myfirstproject.All_Assignments
{
    class TaskString1
    // 1.WAP to split string into 2 tokens where string is “HELLO$WORLD”
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String :");
            string str = Console.ReadLine();
            string[] strArr = str.Split(' ', '!', '@', '#', '%', '$', '&', '*');
            foreach (string str2 in strArr)
                Console.WriteLine(str2);
            Console.ReadKey();
        }
    }
    class TaskString2
    // 2.Write a Java program to find first occurrence of a character in a given string.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String :");
            string str = Console.ReadLine();
            foreach (char ch in str)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (ch == str[i])
                    {
                        Console.WriteLine("Zero based index position is: " + i);
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
    class TaskString3
    // 3.Write a Java program to count occurrences of a character in given string.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String :");
            string str = Console.ReadLine();
            Console.WriteLine("Occurences of character from string");
            str = str.Replace(" ", string.Empty);
            while (str.Length > 0)
            {
                Console.Write(str[0] + " : ");
                int count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
            Console.ReadKey();
        }
    }
    class TaskString4
    // 4.Write a Java program to trim leading white space characters in a string.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String :");
            string str = Console.ReadLine();
            char[] charsToTrim1 = { '*', '0' };
            Console.WriteLine("After:");
            Console.WriteLine(str.TrimStart(charsToTrim1));
            Console.ReadKey();
        }
    }
    class TaskString5
    // 5.Write a Java program to count total number of words in a string. 
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
    class TaskString6
    // 6.Write a Java program to remove all occurrences of a character from string.
    {
        static void removeChar(string s, char c)
        {
            int j, count = 0, n = s.Length;
            char[] t = s.ToCharArray();
            for (int i = j = 0; i < n; i++)
            {
                if (s[i] != c)
                    t[j++] = s[i];
                else
                    count++;
            }

            while (count > 0)
            {
                t[j++] = '\0';
                count--;
            }

            Console.Write(t);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string :");
            string s = Console.ReadLine();
            Console.WriteLine("Enter character for remove all occurences :");
            char c = Convert.ToChar(Console.ReadLine());
            removeChar(s, c);
            Console.ReadKey();
        }
    }
    class TaskString7
    // 7.Write a Java program to trim trailing white space characters in a string.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String :");
            string s = Console.ReadLine();
            char[] charsToTrim1 = { '*', '0' };
            Console.WriteLine("After:");
            Console.WriteLine(s.TrimEnd(charsToTrim1));
            Console.ReadKey();
        }
    }
    class TaskString8
    // 8.Write a Java program to toggle case of each character of a string.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string :");
            string str = Console.ReadLine();
            Console.WriteLine("Converted characters are:");
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                    Console.Write(Char.ToLower(str[i]) + " ");
                else
                    Console.Write(Char.ToUpper(str[i]) + " ");
            }
            Console.ReadKey();
        }
    }
    class TaskString9
    // 9.Write a Java program to count total number of vowels and consonants in a string.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string :");
            string s = Console.ReadLine();
            int i, len, count_vowel, count_cons;
            count_vowel = 0;
            count_cons = 0;
            len = s.Length;
            for (i = 0; i < len; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                {
                    count_vowel++;
                }
                else
                {
                    count_cons++;
                }
            }
            Console.WriteLine("No of vowels from the string : " + count_vowel);
            Console.WriteLine("No of consonants from the string : " + count_cons);
            Console.ReadKey();
        }
    }
    class TaskString10
    // 10.Write a Java program to find reverse of a string.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string :");
            string str = Console.ReadLine();
            string strRev = " ";
            for (int i = str.Length - 1; i >= 0; i--)
                strRev = strRev + str[i];
            Console.WriteLine("String in reverse order is: " + strRev);
            Console.ReadKey();
        }
    }
    class TaskString11
    // 11.Write a Java program to reverse order of words in a given string.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string :");
            string str = Console.ReadLine();
            string strRev = " ";
            for (int i = str.Length - 1; i >= 0; i--)
                strRev = strRev + str[i];
            Console.WriteLine("String in reverse order is: " + strRev);
            Console.ReadKey();
        }
    }
    class TaskString12
    // 12.Write a Java program to find highest frequency character in a string.
    {
        static int ASCII_SIZE = 256;

        static char gethighestfrequencyChar(String str)
        {
            int[] count = new int[ASCII_SIZE];
            int len = str.Length;
            for (int i = 0; i < len; i++)
                count[str[i]]++;
            int max = -1;
            char result = ' ';
            for (int i = 0; i < len; i++)
            {
                if (max < count[str[i]])
                {
                    max = count[str[i]];
                    result = str[i];
                }
            }
            return result;
        }
        static void Main()
        {
            Console.WriteLine("Enter string :");
            String str = Console.ReadLine();
            Console.Write("Highest frequency character is " + gethighestfrequencyChar(str));
            Console.ReadKey();
        }
    }
    class TaskString13
    // 13.Write a Java program to find total number of alphabets, digits or special character in a string.
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
    class TaskString14
    // 14.Write a program using Regular Expression to check valid mobile number or not .Use matches method
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            if (isValid(str))
            {
                Console.WriteLine("Valid Mobile Number");
            }
            else
            {
                Console.WriteLine("Invalid Mobile Number");
            }
            Console.ReadKey();
        }
        public static bool isValid(string str)
        {
            string strRegex = "@^(0|91)?[6-9][0-9]{9}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(str))
                return (true);
            else
                return (false);
        }
    }
    class TaskString15
    // 15.Write a java program to find the duplicate words and their number of occurrences in a string
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
            TaskString15.FindOccuranceChar(ch);
            Console.ReadKey();
        }
    }
    class TaskString16
    // 16.Write a java program to check whether two strings are anagram or not?
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
    class TaskString17
    // 17.Write a java program to reverse a given string with preserving the position of spaces
    {
        static void reverses(string str)
        {
            char[] inputArray = str.ToCharArray();
            char[] result = new char[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == ' ')
                {
                    result[i] = ' ';
                }
            }
            int j = result.Length - 1;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] != ' ')
                {
                    if (result[j] == ' ')
                    {
                        j--;
                    }
                    result[j] = inputArray[i];
                    j--;
                }
            }
            for (int i = 0; i < result.Length; i++)
                Console.Write(result[i]);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string :");
            string str = Console.ReadLine();
            reverses(str);
            Console.ReadKey();
        }
    }
    class TaskString18
    // 18.WAP to find longest word in the given sentence
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
    class TaskString19
    // 19.How do you swap two string variables without using third or temp variable in java
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String 1 : ");
            String str1 = Console.ReadLine();
            Console.WriteLine("Enter String 2 :");
            string str2 = Console.ReadLine();
            Console.WriteLine("\nStrings before swap");
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            str1 = str1 + str2;
            str2 = str1.Substring(0, str1.Length - str2.Length);
            str1 = str1.Substring(str2.Length);
            Console.WriteLine("\nStrings after swap");
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.ReadKey();
        }
    }
    class TaskString20
    // 20.Accept email_id from user and check valid or not(should contain @,.)
    {
        public static void Main(string[] args)
        {
            var emailAddresses = new List<string>
            {
                "tony@example.com",
                "tony.stark@example.net",
                "tony@example.co.uk",
                "tony@example",

                "tony.example.com",
                "tony@stark@example.net",
                "tony@.example.co.uk"
            };
            Console.Title = "Email address validation";
            foreach (var emailAddress in emailAddresses)
                Console.WriteLine($"{emailAddress,-37} --> {(IsValid(emailAddress) ? "Valid" : "Invalid")}");
            Console.ReadLine();
            Console.ReadKey();
        }
        private static bool IsValid(string email)
        {
            var valid = true;
            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }
            return valid;
        }
    }
    class TaskString21
    // 21.Accept sentence replace each vowel by next consecutive character
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string :");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                {

                }
            }
            Console.ReadKey();
        }
    }
    class TaskString22
    // 22.Create an array of 10 names sort in descending order
    {
        static void Main(string[] args)
        {
            int i, j;
            string t;
            Console.WriteLine("Enter size for array:");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter string array:");
            string[] str = new string[s];
            for (i = 0; i < s; i++)
            {
                str[i] = Console.ReadLine();
            }
            for (i = 0; i < s; i++)
            {
                for (j = 0; j < s - 1; j++)
                {
                    if (str[j + 1].CompareTo(str[j]) > 0)
                    {
                        t = str[j + 1];
                        str[j + 1] = str[j];
                        str[j] = t;
                    }
                }
            }
            Console.WriteLine("Sorted string array is:");
            for (i = 0; i < s; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
