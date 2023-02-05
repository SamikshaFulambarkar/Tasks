using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace myfirstproject.ADO_Tasks
{
    class CRUD_Operation
    {
        String strConnection = "";
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataAdapter ad;
        DataSet ds;

        public CRUD_Operation(string strConnection)
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
            cmd = new SqlCommand("select * from Fruit", con);
            ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "Fruits");
            foreach (DataRow dr in ds.Tables["Fruits"].Rows)
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
            }
        }
        public void InsertData()
        {
            ConnectData();
            ad.InsertCommand = new SqlCommand("insert into Fruit(Fruit_Id,Fruit_Name,price)values(@ID, @Name, @Fruit_Price)", con);
            var idpara = cmd.Parameters.Add("@ID", SqlDbType.Int);
            Console.WriteLine("Enter Fruit ID :");
            cmd.Parameters["@ID"].Value = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fruit name :");
            string Fruit_Name = Console.ReadLine();
            cmd.Parameters.AddWithValue("@Name", Fruit_Name);
            ad.InsertCommand.ExecuteNonQuery();
        }
        public void UpdateData()
        {
            ConnectData();
            ad.UpdateCommand = new SqlCommand(("update Fruit set Fruit_Name=@Name where Fruit_Id=@fruitid"),con);
            var idpara = cmd.Parameters.Add("@fruitid", SqlDbType.Int);
            Console.WriteLine("Enter Fruit id :");
            cmd.Parameters["@fruitid"].Value = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new Fruit Name :");
            int Name = int.Parse(Console.ReadLine());
            cmd.Parameters.AddWithValue("@newprice", Name);
            ad.UpdateCommand.ExecuteNonQuery();
        }
        public void DeleteData()
        {
            ConnectData();
            ad.DeleteCommand = new SqlCommand("Delete from Fruit where Fruit_Id=111", con);
            ad.DeleteCommand.ExecuteNonQuery();
        }
        static void Main(string[] args)
        {
            try
            {
                string strcon = "Data Source=DESKTOP-N9NMKAP;Initial Catalog=FruitFarm;Integrated Security=True";
                CRUD_Operation CO = new CRUD_Operation(strcon);
                CO.ConnectData();
                CO.FetchData();
                Console.WriteLine(".....................");
                CO.InsertData();
                CO.FetchData();
                Console.WriteLine("........................");
                CO.UpdateData();
                CO.FetchData();
                Console.WriteLine("........................");
                CO.DeleteData();
                CO.FetchData();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
