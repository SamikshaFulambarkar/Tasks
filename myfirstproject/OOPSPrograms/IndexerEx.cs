using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.OOPSPrograms
{
    class IndexerEx
    {
        int[] count = new int[5];
        public int this[int i]
        {
            get { return count[i]; }
            set { count[i] = value; }
        }
        static void Main(string[] args)
        {
            IndexerEx IE = new IndexerEx();
            IE[0] = 10;
            IE[1] = 20;
            IE[2] = 30;
            IE[3] = 40;
            IE[4] = 50;
            for (int i = 0; i < 5; i++)
                Console.Write(IE[i] + " ");
            Console.ReadKey();
        }
    }
    class IndexerEx1
    {
        string[] names = new string[5];
        public string this[int i]
        {
            get { return names[i]; }
            set { names[i] = value; }
        }
        static void Main(string[] args)
        {
            IndexerEx1 IE1 = new IndexerEx1();
            IE1[0] = "Shreya";
            IE1[1] = "Neha";
            IE1[2] = "Snehal";
            IE1[3] = "Samiksha";
            IE1[4] = "Pooja";
            for (int i = 0; i < 5; i++)
                Console.Write(IE1[i] + "   ");
            Console.ReadKey();
        }
    }
}
