using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace myfirstproject.ADO_Tasks
{
    class AccessDB
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;

        public AccessDB()
        {
            con = DBConnection.GetMyConnection();
            Console.WriteLine("Connection Done..........");
            con.Open();
        }
        public void FetchData()
        {
            string querystring = "select * from book";
            cmd = new SqlCommand(querystring, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0)+"  "+reader.GetString(1));
            }
            reader.Close();
        }
        public void FetchOne(int bid)
        {
            string querystring = "select * from book where book_id=" + bid;
            cmd = new SqlCommand(querystring, con);
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0)+"  "+reader.GetString(1)+"  "+reader.GetInt32(2));
            }
            reader.Close();
        }
        public void InsertData()
        {
            cmd = new SqlCommand("insert into book(book_id,book_name,price)values(100,'WingsOf_Fire',800)", con);
            int x= cmd.ExecuteNonQuery();
            if(x!=0)
            {
                Console.WriteLine("Done..........");
            }
        }
        public void UpdateData(int bid, int newprice)
        {
            string querystring = "update book set price=" + newprice + "where book_id=" + bid;
            cmd = new SqlCommand(querystring, con);
            int x = cmd.ExecuteNonQuery();
            if(x!=0)
            {
                Console.WriteLine("Data Updated.............");
            }
        }
        public void DeleteData(int bid)
        {
            string querystring = "delete book where book_id=" + bid;
            cmd = new SqlCommand(querystring, con);
            int x = cmd.ExecuteNonQuery();
            if(x!=0)
            {
                Console.WriteLine("Data Deleted............");
            }
        }
        public void InsertDynamic()
        {
            cmd.CommandText = "insert into book(book_id, book_name) values(@ID, @Name)";
            var idpara = cmd.Parameters.Add("@ID", SqlDbType.Int);
            Console.WriteLine("Enter book id :");
            cmd.Parameters["@ID"].Value = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter book name :");
            string book_name = Console.ReadLine();
            cmd.Parameters.AddWithValue("@Name", book_name);
            int x = cmd.ExecuteNonQuery();
            if(x!=0)
            {
                Console.WriteLine("Insert Done..........");
            }
        }
        public void UpadateDynamic()
        {
            cmd.CommandText = "update book set price=@newprice where book_id=@bookid";
            var idpara = cmd.Parameters.Add("@bookid", SqlDbType.Int);
            Console.WriteLine("Enter book id :");
            cmd.Parameters["@bookid"].Value = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new price :");
            int newprice = int.Parse(Console.ReadLine());
            cmd.Parameters.AddWithValue("@newprice", newprice);
            int x = cmd.ExecuteNonQuery();
            if (x != 0)
            {
                Console.WriteLine("Update Done..........");
            }
        }
        public void DeleteDynamic()
        {
            cmd.CommandText = "delete book where book_id=@bookid";
            var idpara = cmd.Parameters.Add("@bookid", SqlDbType.Int);
            Console.WriteLine("Enter book id :");
            cmd.Parameters["@bookid"].Value = int.Parse(Console.ReadLine());
            int x = cmd.ExecuteNonQuery();
            if (x != 0)
            {
                Console.WriteLine("Delete Done..........");
            }
        }
        static void Main(string[] args)
        {
            AccessDB a = new AccessDB();
            a.FetchData();
            Console.WriteLine("...................");
            //a.FetchOne(240);
            Console.WriteLine("...................");
            //a.InsertData();
            Console.WriteLine("...................");
            //a.UpdateData(101, 500);
            Console.WriteLine("...................");
            //a.DeleteData(100);
            Console.WriteLine("...................");
            a.InsertDynamic();
            Console.WriteLine("...................");
            a.UpadateDynamic();
            Console.WriteLine("...................");
            a.FetchData();
            Console.WriteLine("...................");
            a.DeleteDynamic();
            a.FetchData();
            Console.ReadKey();
        }
    }
}
