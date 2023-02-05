using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace myfirstproject.ADO_Tasks
{
    class LoginUser
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        public LoginUser()
        {
            con = DBConnection.GetMyConnection();
            Console.WriteLine("Connection Done..........");
            con.Open();
        }
        public void FetchUser()
        {
            try
            {
                string querystring = "select * from Usertable";
                cmd = new SqlCommand(querystring, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(0) + "  " + reader.GetString(1));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            reader.Close();
        }
        public void FetchOne(string email)
        {
            try
            {
                string querystring = "select * from Usertable where email_id=" + email;
                cmd = new SqlCommand(querystring, con);
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine(reader.GetString(0)+"  "+reader.GetInt32(1));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            reader.Close();
        }
        public bool Login()
        {
            bool res = false;
            try
            {
                Console.WriteLine("Enter User ID :");
                string ID = Console.ReadLine();
                Console.WriteLine("Enter Password :");
                string Pass = Console.ReadLine();
                string querystring = "select * from Usertable";
                cmd = new SqlCommand(querystring, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (ID == "samiksha@gmail.com" && Pass == "samiksha@99")
                    {
                        Console.WriteLine("Login Successfully");
                        res = true;
                    }
                    else
                    {
                        res = false;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            reader.Close();
            return res;
        }
        public void InsertData()
        {
            try
            {
                string querystring = "insert into Car(Model_No,Car_Name,Car_Price)values(@Id,@Name,@Price)";
                cmd = new SqlCommand(querystring, con);
                var idpara = cmd.Parameters.Add("@Id", SqlDbType.Int);
                cmd.Parameters.Add("@Price", SqlDbType.Int);
                Console.WriteLine("enter the Model No :");
                cmd.Parameters["@Id"].Value = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the Car Name");
                string c_name = Console.ReadLine();
                cmd.Parameters.AddWithValue("@Name", c_name);
                Console.WriteLine("enter the Price");
                cmd.Parameters["@Price"].Value = int.Parse(Console.ReadLine());
                int x = cmd.ExecuteNonQuery();
                if (x != 0)
                {
                    Console.WriteLine("Insert Successfully......");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void UpdateData()
        {
            string querystring = "select * from Car where Model_No=@ID";
            cmd = new SqlCommand(querystring, con);
            cmd.Parameters.Add("@ID", SqlDbType.Int);
            Console.WriteLine("enter the Model No :");
            int x = int.Parse(Console.ReadLine());
            cmd.Parameters["@ID"].Value = x;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0) + " " + reader.GetString(1) + " " + reader.GetInt32(0));
            }
            reader.Close();
            string querystr = "update Car set Car_Name=@Name where Model_No= @model_no";
            cmd = new SqlCommand(querystr, con);
            var idpara = cmd.Parameters.Add("@model_no", SqlDbType.Int);
            cmd.Parameters["@model_no"].Value = x;
            Console.WriteLine("enter the car name for update");
            string c_name = Console.ReadLine();
            cmd.Parameters.AddWithValue("@Name", c_name);
            int a = cmd.ExecuteNonQuery();
            if (a != 0)
            {
                Console.WriteLine("Updated Successfully...");
            }
        }
        public void DeleteData()
        {
            string querystring = "Delete from Car where Model_No=@model_no";
            cmd = new SqlCommand(querystring, con);
            var idpara = cmd.Parameters.Add("@model_no", SqlDbType.Int);
            Console.WriteLine("enter the Model No for Delete");
            int a = int.Parse(Console.ReadLine());
            cmd.Parameters["@model_no"].Value = a;
            int y = cmd.ExecuteNonQuery();
            if (a != 0)
            {
                Console.WriteLine("Deleted Successfully......");
            }
        }
        public void Display_All_Data()
        {
            string querystring = "select * from Car";
            cmd = new SqlCommand(querystring, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0) + " " + reader.GetString(1) + " " + reader.GetInt32(2));
            }
            reader.Close();
        }
        static void Main(string[] args)
        {
            LoginUser l = new LoginUser();
            Console.WriteLine("Enter 1 if you are Admin or Enter 0 if you are User");
            int R_ID = int.Parse(Console.ReadLine());
            if (R_ID == 1)
            {
                Console.WriteLine("\t\t\t\tADMIN PAGE:");
                bool res = l.Login();
                while (!res)
                {
                    Console.WriteLine("Incorrect User ID or Password Please enter correct details");
                    res = l.Login();
                }
                Console.WriteLine("\t\t\t\t WELCOME TO CAR HOUSE :");
                Console.WriteLine("\n\t\t\t\tPress 1 To Insert Data\n\t\t\t\tPress 2 To Update Data" +
                    $"\n\t\t\t\tPress 3 To Delete Data\n\t\t\t\tPress 4 To Display All Data\n\t\t\t\tPress 5 To Exit");
                bool ToStop = false;
                do
                {
                    Console.WriteLine("\nEnter the choice");
                    int key = int.Parse(Console.ReadLine());
                    switch (key)
                    {
                        case 1:
                            l.InsertData();
                            break;
                        case 2:
                            l.UpdateData();
                            break;
                        case 3:
                            l.DeleteData();
                            break;
                        case 4:
                            l.Display_All_Data();
                            break;
                        case 5:
                            ToStop = true;
                            break;
                        default:
                            Console.WriteLine("Invalid key");
                            break;
                    }

                } while (!ToStop);
            }
            else if(R_ID==0)
            {
                Console.WriteLine("\t\t\t\tUSER PAGE :");
                bool res = l.Login();
                while (!res)
                {
                    Console.WriteLine("Incorrect User ID or Password Please enter correct details");
                    res = l.Login();
                }
                Console.WriteLine("\t\t\t\t WELCOME TO CAR HOUSE :");
                Console.WriteLine("\n\t\t\t\tPress 1 To Display All Data\n\t\t\t\tPress 2 To Exit");
                bool ToStop = false;
                do
                {
                    Console.WriteLine("\nEnter the choice");
                    int key2 = int.Parse(Console.ReadLine());
                    switch (key2)
                    {
                        case 1:
                            l.Display_All_Data();
                            break;
                        case 2:
                            ToStop = true;
                            break;
                        default:
                            Console.WriteLine("Invalid key");
                            break;
                    }

                } while (!ToStop);
            }
            Console.ReadKey();
        }
    }
 }
    

