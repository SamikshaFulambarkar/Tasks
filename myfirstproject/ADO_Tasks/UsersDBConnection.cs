using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace myfirstproject.ADO_Tasks
{
    class UsersDBConnection
    {
        String strConnection = "";
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataAdapter ad;
        DataSet ds;

        public UsersDBConnection(string strConnection)
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
            cmd = new SqlCommand("select * from Usertable", con);
            ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "UserTables");
            foreach (DataRow dr in ds.Tables["UserTables"].Rows)
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                string strcon = "Data Source=DESKTOP-N9NMKAP;Initial Catalog=Users;Integrated Security=True";
                UsersDBConnection u = new UsersDBConnection(strcon);
                u.ConnectData();
                u.FetchData();
                Console.WriteLine(".....................");
                /*u.InsertData();
                u.FetchData();
                Console.WriteLine("........................");
                u.UpdateData();
                u.FetchData();
                Console.WriteLine("........................");
                u.DeleteData();
                u.FetchData();*/
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
