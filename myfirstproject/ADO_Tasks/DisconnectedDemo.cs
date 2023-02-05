using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace myfirstproject.ADO_Tasks
{
    class DisconnectedDemo
    {
        String strConnection = "";
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataAdapter ad;
        DataSet ds;

        public DisconnectedDemo(string strConnection)
        {
            this.strConnection = strConnection;
        }
        public void ConnectData()
        {
            con = new SqlConnection(strConnection);
            con.Open();
            Console.WriteLine("..Connected..");
        }
        public void FetchData()
        {
            ConnectData();
            cmd = new SqlCommand("select * from book", con);
            ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "Books");
            foreach (DataRow dr in ds.Tables["Books"].Rows)
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] + " " + dr[3]);
            }
        }
        public void InsertData()
        {
            ConnectData();
            ad.InsertCommand = new SqlCommand("insert into book(book_id,price)values(255,700)", con);
            ad.InsertCommand.ExecuteNonQuery();
        }
        public void UpdateData()
        {
            ConnectData();
            ad.UpdateCommand = new SqlCommand("update book set price =800 where book_id= 255", con);
            ad.UpdateCommand.ExecuteNonQuery();
        }
        public void DeleteData()
        {
            ConnectData();
            ad.DeleteCommand = new SqlCommand("Delete from book where book_id=255", con);
            ad.DeleteCommand.ExecuteNonQuery();
        }
        static void Main(string[] args)
        {
            try
            {
                string strcon = "Data Source=DESKTOP-N9NMKAP;Initial Catalog=BookInfo;Integrated Security=True";
                DisconnectedDemo ds = new DisconnectedDemo(strcon);
                ds.ConnectData();
                ds.FetchData();
                Console.WriteLine(".....................");
                ds.InsertData();
                ds.FetchData();
                Console.WriteLine("........................");
                /*ds.UpdateData();
                ds.FetchData();
                Console.WriteLine("........................");
                ds.DeleteData();
                ds.FetchData();*/
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
