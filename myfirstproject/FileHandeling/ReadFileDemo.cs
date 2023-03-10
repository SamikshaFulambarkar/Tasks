using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace myfirstproject.FileHandeling
{
    class ReadFileDemo
    {
        public void ReadFile()
        {
            StreamReader sr = new StreamReader("C://Users/dhuma/OneDrive/Desktop/MyFirstFile.txt");
            Console.WriteLine("my file data is....");
            string st = sr.ReadLine();
            while (st != null)
            {
                Console.WriteLine(st);
                st = sr.ReadLine();
            }
            sr.Close();
        }
        static void Main(string[] args)
        {
            ReadFileDemo d = new ReadFileDemo();
            d.ReadFile();
            Console.ReadKey();
        }
    }
}
