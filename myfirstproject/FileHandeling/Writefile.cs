using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace myfirstproject.FileHandeling
{
    class Writefile
    {
        public void WriteData()
        {
            FileStream fs = new FileStream("C://Users/dhuma/OneDrive/Desktop/MyFirstFile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("enter the text to write in file");

            string str = Console.ReadLine();
            sw.WriteLine(str);
            Console.WriteLine("file write successfully");
            sw.Flush();
            sw.Close();
        }
        static void Main(string[] args)
        {
            Writefile f = new Writefile();
            f.WriteData();
            Console.ReadKey();
        }
    }
}
