using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject.PropertyPrograms
{
    class Car_1
    {
        int cmodel_no;
        String c_name;
        int c_price;
        String c_color;
        public int CModel_no
        {
            set
            {
                cmodel_no = value;
            }
            get
            {
                return cmodel_no;
            }
        }
        public string C_Name
        {
            set
            {
                c_name = value;
            }
            get
            {
                return c_name;
            }
        }
        public int C_Price
        {
            set
            {
                c_price = value;
            }
            get
            {
                return c_price;
            }
        }
        public string C_Color
        {
            set
            {
                c_color = value;
            }
            get
            {
                return c_color;
            }
        }
    }
    class CarInfo
    {
        static void Main(string[] args)
        {
            Car_1 c = new Car_1();
            c.CModel_no = 2022;
            c.C_Name = "Swift";
            c.C_Price = 960000;
            c.C_Color = "White";
            Console.WriteLine("Model no.=" + c.CModel_no);
            Console.WriteLine("Car Name=" + c.C_Name);
            Console.WriteLine("Car Price=" + c.C_Price);
            Console.WriteLine("Car Color=" + c.C_Color);
            Console.ReadKey();
        }
    }
}
