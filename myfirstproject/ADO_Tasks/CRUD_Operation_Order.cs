using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace myfirstproject.ADO_Tasks
{
    class CRUD_Operation_Order
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;

        public CRUD_Operation_Order()
        {
            con = DBConnection.GetMyConnection();
            Console.WriteLine("Connection Done..........");
            con.Open();
        }
        public void FetchData()
        {
            string querystring = "select * from order_details";
            cmd = new SqlCommand(querystring, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0) + "  " + reader.GetInt32(1) + "  " + reader.GetInt32(2));
            }
            reader.Close();
        }
        public void FetchOne(int o_id)
        {
            string querystring = "select * from order_details where oid=" + o_id;
            cmd = new SqlCommand(querystring, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0) + "  " + reader.GetInt32(1) + "  " + reader.GetInt32(2));
            }
            reader.Close();
        }
        public void InsertData()
        {
            cmd = new SqlCommand("insert into order_details(oid,bid,qty)values(50,1005,800)", con);
            int x = cmd.ExecuteNonQuery();
            if (x != 0)
            {
                Console.WriteLine("Done..........");
            }
        }
        public void UpdateData(int o_id, int newquantity)
        {
            string querystring = "update order_details set quantity=" + newquantity + "where oid=" + o_id;
            cmd = new SqlCommand(querystring, con);
            int x = cmd.ExecuteNonQuery();
            if (x != 0)
            {
                Console.WriteLine("Data Updated.............");
            }
        }
        public void DeleteData(int o_id)
        {
            string querystring = "delete order_details where oid=" + o_id;
            cmd = new SqlCommand(querystring, con);
            int x = cmd.ExecuteNonQuery();
            if (x != 0)
            {
                Console.WriteLine("Data Deleted............");
            }
        }
        public void InsertDynamic(object qty)
        {
            cmd.CommandText = "insert into order_details(oid, qty) values(@ID, @Qty)";
            var idpara = cmd.Parameters.Add("@ID", SqlDbType.Int);
            Console.WriteLine("Enter order id :");
            cmd.Parameters["@ID"].Value = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter order quantity :");
            cmd.Parameters["@Qty"].Value = int.Parse(Console.ReadLine());
            cmd.Parameters.AddWithValue("@Qty", qty);
            int x = cmd.ExecuteNonQuery();
            if (x != 0)
            {
                Console.WriteLine("Insert Done..........");
            }
        }
        public void UpadateDynamic(object newquantity)
        {
            cmd.CommandText = "update order_details set quantity=@newqty where oid=@orderid";
            var idpara = cmd.Parameters.Add("@orderid", SqlDbType.Int);
            Console.WriteLine("Enter order id :");
            cmd.Parameters["@orderid"].Value = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new quantity :");
            int newprice = int.Parse(Console.ReadLine());
            cmd.Parameters.AddWithValue("@newquantity", newquantity);
            int x = cmd.ExecuteNonQuery();
            if (x != 0)
            {
                Console.WriteLine("Update Done..........");
            }
        }
        public void DeleteDynamic()
        {
            cmd.CommandText = "delete order_details where oid=@orderid";
            var idpara = cmd.Parameters.Add("@orderid", SqlDbType.Int);
            Console.WriteLine("Enter order id :");
            cmd.Parameters["@orderid"].Value = int.Parse(Console.ReadLine());
            int x = cmd.ExecuteNonQuery();
            if (x != 0)
            {
                Console.WriteLine("Delete Done..........");
            }
        }
        static void Main(string[] args)
        {
            CRUD_Operation_Order o = new CRUD_Operation_Order();
            o.FetchData();
            o.FetchOne(10);
            //o.InsertData();
            //o.UpdateData(60, 750);
            //o.DeleteData(50);
            //o.FetchData();
            //o.InsertDynamic(600);
            o.UpadateDynamic(500);
            o.DeleteDynamic();
            o.FetchData();
            Console.ReadKey();
        }
    }
}
