using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace myfirstproject.ADO_Tasks
{
    class DBConnection2
    {
        public static SqlConnection GetMyConnection()
        {
            SqlConnection con = null;
            try
            {
                string constring = "server=DESKTOP-N9NMKAP;Initial Catalog=FruitFarm;Integrated Security=True";
                con = new SqlConnection(constring);
                return con;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return con;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DBConnection.GetMyConnection());
            Console.ReadKey();
        }
    }
}
