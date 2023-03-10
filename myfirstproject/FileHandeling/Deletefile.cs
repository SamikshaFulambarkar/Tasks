using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace myfirstproject.FileHandeling
{
    class Deletefile
    {
        public void Deletefile1()
        {
            string str = "C://Users/dhuma/OneDrive/Desktop/MyFirstFile.txt";
            StreamWriter sw = new StreamWriter(str);
            if (File.Exists(str))
            {
                File.Delete(str);
                Console.WriteLine("file delete succesfullu");
            }
            sw.Close();
        }
        static void Main(string[] args)
        {
            Deletefile d = new Deletefile();
            d.Deletefile1();
            Console.ReadKey();
        }
    }
}
