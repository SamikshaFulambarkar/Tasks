using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace myfirstproject.FileHandeling
{
    [Serializable]
    class Employee
    {
        public int id;
        public string name;
        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    class EmpSerialization
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(101, "Shreya");
            IFormatter f = new BinaryFormatter();
            Stream stream = new FileStream("D://MyEmployeeSerialization.txt", FileMode.Create, FileAccess.Write);
            f.Serialize(stream, emp);
            stream.Close();
            Console.ReadLine();
        }
    }
    class EmpDeserialize
    {
        static void Main(string[] args)
        {
            Stream s = new FileStream("D://MyEmployeeSerialization.txt", FileMode.Open, FileAccess.Read);
            IFormatter f = new BinaryFormatter();
            Employee e = (Employee)f.Deserialize(s);
            Console.WriteLine(e.id+"  "+e.name);
            Console.ReadLine();
        }
    }
}
