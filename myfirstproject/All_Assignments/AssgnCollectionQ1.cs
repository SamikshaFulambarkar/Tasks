using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace myfirstproject.All_Assignments
{
    class AssgnCollectionQ1
        // Write a code to remove duplicate elements from above list. Final Arraylist should contain(Sun, Mon, Sat); //
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Sun");
            al.Add("Mon");

            for (int i = 0; i < al.Count; i++)
            {
                for (int j = i + 1; j < al.Count; j++)
                {
                    if (al[i].Equals(al[j]))
                    {
                        al.RemoveAt(j);
                        j--;
                    }
                }
            }
            foreach (string str in al)
            {
                Console.Write(str + "  ");
            }
            Console.ReadKey();
        }
    }
    class AssgnCollectionQ2
    // 2.	Sort Arraylist of String in reverse order of its natural sorting. 
    {
        static void Main(string[] args)
        {
            List<string> sl = new List<string>()
            {
                "Mango","Apple","Strawberry","Orange","Grapes"
            };
            for (int i = 0; i < sl.Count; i++)
            {
                for (int j = 0; j < sl.Count - 1; j++)
                {
                    if (sl[j].CompareTo(sl[j + 1]) > 0)
                    {
                        string t = sl[j];
                        sl[j] = sl[j + 1];
                        sl[j + 1] = t;
                    }
                }
            }
            foreach (string item in sl)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
    class AssgnCollectionQ3
        /* 3.	 The encryption of alphabets are to be done as follows:	[2]

                A=1,B=2,C=3,Z=26

                The potential of a word is found by adding the encrypted value of the alphabets.

                Example: KITE

                Potential = 11 + 9 + 20 + 5 = 45

                Accept a sentence Decode the words according to their potential and arrange them in ascending order.

                Output the result in format given below:
                Input:THE SKY IS THE LIMIT.
                POTENTIAL:THE= 33, SKY= 55, IS= 28, THE= 33, LIMIT= 63
                Output :IS THE THE SKY LIMIT */

    {
        public static int WordPotential(string word)
        {
            string str = word.ToUpper();
            int potential = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    potential = potential + str[i] - 64;
                }
            }
            return potential;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();

            string[] words = str.Split();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (WordPotential(words[i]) > WordPotential(words[j]))
                    {
                        string temp = words[i];
                        words[i] = words[j];
                        words[j] = temp;
                    }
                }
            }
            foreach (var item in words)
            {
                Console.Write(item + "  ");
            }
            Console.ReadKey();
        }
    }
    class AssgnCollectionQ4
    {
        class Player
        {
            public int pid;
            public string pname;
            public string country;
            public string team;
            public Player(int pid, string pname, string country, string team)
            {
                this.pid = pid;
                this.pname = pname;
                this.country = country;
                this.team = team;
            }
        }
        static void Main(string[] args)
        {
            int i, j, cnt;
            List<Player> p = new List<Player>();
            p.Add(new Player(12, "MS Dhoni", "India", "CSK"));
            p.Add(new Player(13, "Bravo", "West Indies", "CSK"));
            p.Add(new Player(14, "David Warner", "Australia", "SRH"));
            p.Add(new Player(15, "KL Rahul", "India", "DD"));
            p.Add(new Player(16, "Josh", "Australia", "CSK"));
            p.Add(new Player(17, "Tim", "Australia", "CSK"));
            p.Add(new Player(18, "Rohit", "India", "MI"));
            Dictionary<string, int> dt = new Dictionary<string, int>();
            for(i=0; i<p.Count; i++)
            {
                for(j=0; i<p.Count; j++)
                {
                    if(p[i].team==p[j].team&&p[i].country=="Australia"&&p[j].country=="Australia")
                    {
                        cnt++;
                        j--;
                    }
                }
                if(!dt.ContainsKey(p[i].team))
                {
                    dt.Add(p[i].team,cnt);
                }
            }
            foreach(KeyValuePair<string, int>kv in dt)
            {
                Console.WriteLine(kv.Key+"  "+kv.Value);
            }
        }
    }
    class AssgnCollectionQ5
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(2, "Samiksha");
            ht.Add(6, "mumbai");
            ht.Add("Rahul", "nagpur");
            ht.Add(4, "akash");
            ht.Add(5, "banglore");
            ht.Add(7, "Nitin");
            ht.Add("jalgaon", "muktainagar");
            ht.Add(8, "pune");

            ICollection keys = ht.Keys;
            Console.WriteLine("Enter Key");
            var key = Console.ReadLine();
            Console.WriteLine("Enter value to update");
            var value = Console.ReadLine();
            foreach (var item in keys)
            {
                if (item.Equals(key))
                {
                    ht[key] = value;
                }
            }

            /*foreach (DictionaryEntry kv in ht)
            {
                if (ht.ContainsKey(key))
                {
                    ht[kv.Key] = value;
                    //ht.Remove(kv);
                    //ht.Add(kv.Key, value);
                }
            }*/
            foreach (DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key + "  " + kv.Value);
            }
            Console.ReadKey();
        }
    }
    class AssgnCollectionQ6
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(2, "Samiksha");
            ht.Add(6, "mumbai");
            ht.Add("raj", "nagpur");
            ht.Add(4, "akash");
            ht.Add(5, "banglore");
            ht.Add(7, "rahul");

            ArrayList al = new ArrayList(ht.Keys);
            Console.WriteLine("Set of Keys : ");
            foreach (var item in al)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine("\nWhole Hashtable : ");
            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key + "  " + de.Value);
            }
            Console.ReadKey();
        }
    }
    class AssgnCollectionQ7
    // Create a HashTable  where key is integers 1 to 10 and string is number in Words. Remove entry for which number is divisible by 3.
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable()
            {
                {1, "One" },
                {2, "Two" },
                {3, "Three" },
                {4, "Four" },
                {5, "Five" },
                {6, "Six" },
                {7, "Seven" },
                {8, "Eight" },
                {9, "Nine" },
                {10, "Ten" },
            };
            // Dictionary<int, string> dt = new Dictionary<int, string>((IDictionary<int, string>)ht);
            foreach (DictionaryEntry de in ht)
            {
                if (Convert.ToInt32(de.Key) % 3 == 0)
                {

                    ht.Remove(de.Key);
                }
            }
            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key + "  " + de.Value);
            }
            Console.ReadKey();
        }
    }
    class AssgnCollectionQ8
    //ArrayList Contains
    //al.Add("pune");
    //al.Add("Mumbai");
    //al.Add("pune");
    //al.Add("Mumbai");
    //al.Add("Nasik");
    //al.Add("pune");
    //Create a HashTable which contain String as key and Integer as value key is name of city and value
    //is frequency of that city.
    //("pune",3);
    //("Mumbai",2);
    //Print hashtable using Foreach loop.
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("Nasik");
            al.Add("pune");
            Hashtable ht = new Hashtable();
            for (int i = 0; i < al.Count; i++)
            {
                int cnt = 1;
                for (int j = i + 1; j < al.Count; j++)
                {
                    if (al[i].Equals(al[j]))
                    {
                        cnt++;
                        al.RemoveAt(j);
                        j--;
                    }
                }
                ht.Add(al[i], cnt);
            }
            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key + "  " + de.Value);
            }
            Console.ReadKey();
        }
    }
 }

