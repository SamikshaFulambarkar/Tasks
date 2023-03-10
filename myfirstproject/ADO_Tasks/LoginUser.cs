using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace myfirstproject.ADO_Tasks
{
    public class Car
    {
        public int Model_No { get; set; }
        public String Car_Name { get; set; }
        public int Car_Price { get; set; }
    }
    public class Usertable
    {
        public string email_id { get; set; }
        public string password { get; set; }
        public int role { get; set; }
    }
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
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            reader.Close();
        }
        public int ValidateUser(string userid)
        {
            int n = 0;
            string querystring = "select role from Usertable where email_id=" + "'" + userid + "'";
            try
            {
                cmd = new SqlCommand(querystring, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    n = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            reader.Close();
            return n;
        }
        public void FetchOne(string email)
        {
            try
            {
                string querystring = "select * from Usertable where email_id=" + email;
                cmd = new SqlCommand(querystring, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(0) + "  " + reader.GetInt32(1));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            reader.Close();
        }
        public void SignUp()
        {
            try
            {
                string querystring = "insert into Usertable(email_id, password) values(@UserID, @UserPassword)";
                cmd = new SqlCommand(querystring, con);
                Console.WriteLine("Enter User ID :");
                string ID = Console.ReadLine();
                cmd.Parameters.AddWithValue("@UserID", ID);
                Console.WriteLine("Enter Password :");
                string Pass = Console.ReadLine();
                cmd.Parameters.AddWithValue("@UserPassword", Pass);
                int x = cmd.ExecuteNonQuery();
                if (x != 0)
                {
                    Console.WriteLine("SignUp Successfully........");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public bool Login(ref int roleid)
        {
            bool res = false;
            try
            {
                Console.WriteLine("Enter User ID :");
                string ID = Console.ReadLine();
                Console.WriteLine("Enter Password :");
                string Pass = Console.ReadLine();
                Console.WriteLine("Enter Role :");
                int R = int.Parse(Console.ReadLine());
                string querystring = "select * from Usertable";
                cmd = new SqlCommand(querystring, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var email_id = reader.GetString(0);
                    var password = reader.GetString(1);
                    var role = reader.GetInt32(2);
                    if (ID == email_id && Pass == password && R==role)
                    {
                        roleid = role;
                        res = true;
                    }
                }
            }
            catch(Exception e)
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
            reader.Close();
        }
        public void UpdateDataCar_Price()
        {
            try
            {
                string querystr = "update Car set Car_Price=@Price where Model_No= @model_no";
                cmd = new SqlCommand(querystr, con);
                var idpara = cmd.Parameters.Add("@model_no", SqlDbType.Int);
                Console.WriteLine("enter the Model No :");
                int x = int.Parse(Console.ReadLine());
                cmd.Parameters["@model_no"].Value = x;
                Console.WriteLine("enter the car price for update");
                int c_price = int.Parse(Console.ReadLine());
                cmd.Parameters.AddWithValue("@Price", c_price);
                int a = cmd.ExecuteNonQuery();
                if (x != 0)
                {
                    Console.WriteLine("Updated Successfully...");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            reader.Close();
        }
        public void UpdateDataCar_Name()
        {
            try
            {
                string querystr = "update Car set Car_Name=@Name where Model_No= @model_no";
                cmd = new SqlCommand(querystr, con);
                var idpara = cmd.Parameters.Add("@model_no", SqlDbType.Int);
                Console.WriteLine("enter the Model No :");
                int x = int.Parse(Console.ReadLine());
                cmd.Parameters["@model_no"].Value = x;
                Console.WriteLine("enter the car name for update");
                string c_name = Console.ReadLine();
                cmd.Parameters.AddWithValue("@Name", c_name);
                int a = cmd.ExecuteNonQuery();
                if (x != 0)
                {
                    Console.WriteLine("Updated Successfully...");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            reader.Close();
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
        public void Display_One()
        {
            try
            {
                Console.WriteLine("Enter Model No :");
                int M_No = int.Parse(Console.ReadLine());
                string querystring = "select * from Car where Model_No=" + M_No;
                cmd = new SqlCommand(querystring, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetInt32(0) + " " + reader.GetString(1) + " " + reader.GetInt32(2));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            reader.Close();
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
            bool res = false;
            int role = 0;
            Console.WriteLine("\t\t\t\t Select Operation :");
            Console.WriteLine("\n\t\t\t\tPress 1 To Login\n\t\t\t\tPress 2 To SignUp");
            do
            {
                Console.WriteLine("\nEnter the choice");
                int no = int.Parse(Console.ReadLine());
                switch (no)
                {
                    case 1:
                        Console.WriteLine("Enter Details");
                        res = l.Login(ref role);
                        Console.WriteLine("");
                        if (!res)
                        {
                            Console.WriteLine("Incorrect User ID or Password or role_id Please enter correct details");
                            l.SignUp();
                            res = l.Login(ref role);
                        }
                        break;
                    case 2:
                        l.SignUp();
                        Console.WriteLine("Please Login with your Details");
                        res = l.Login(ref role);
                        break;
                }
            } while (!res);
            if (role == 1)
            {
                Console.WriteLine("\t\t\t\t WELCOME TO CAR HOUSE :");
                Console.WriteLine("\n\t\t\t\tPress 1 To Insert Data\n\t\t\t\tPress 2 To Update Data" +
                    $"\n\t\t\t\tPress 3 To Delete Data\n\t\t\t\tPress 4 To Display One Data" +
                    $"\n\t\t\t\tPress 5 To Display All Data\n\t\t\t\tPress 6 To Exit");
                bool ToStop = false;
                char keyPressed = ' ';
                do
                {
                    Console.WriteLine("Enter the choice");
                    int no = int.Parse(Console.ReadLine());
                    switch (no)
                    {
                        case 1:
                            l.InsertData();
                            break;
                        case 2:
                            Console.WriteLine("Update Data");
                            do
                            {
                                Console.WriteLine("\n\t\t\t\tPress 10 To Update Car_Name Data\n\t\t\t\tPress 20 To Update Car_Price Data" +
                                $"\n\t\t\t\tPress 30 To Exit");
                                Console.WriteLine("Enter the choice");
                                int key = int.Parse(Console.ReadLine());
                                switch(key)
                                {
                                    case 10:
                                        l.UpdateDataCar_Name();
                                        break;
                                    case 20:
                                        l.UpdateDataCar_Price();
                                        break;
                                    case 30:
                                        ToStop = true;
                                        break;
                                    default:
                                        Console.WriteLine("Invalid key");
                                        break;
                                }
                            } while (!ToStop);
                            break;
                        case 3:
                            l.DeleteData();
                            break;
                        case 4:
                            l.Display_One();
                            break;
                        case 5:
                            l.Display_All_Data();
                            break;
                        case 6:
                            ToStop = true;
                            break;
                        default:
                            Console.WriteLine("Invalid key");
                            break;
                    }
                    Console.WriteLine("Do you want to continue? ......");
                    Console.WriteLine("Press Y or y to countinue...");
                    keyPressed = Convert.ToChar(Console.ReadLine());
                } while (keyPressed == 'y' || keyPressed == 'Y');
            }
            else if (role == 2)
            {
                Console.WriteLine("\t\t\t\t WELCOME TO CAR HOUSE :");
                Console.WriteLine("\n\t\t\t\tPress 1 To Display One Data\n\t\t\t\tPress 2 To Display_All_Data" +
                    $"\n\t\t\t\tPress 3 To Exit");
                bool ToStop = false;
                do
                {
                    Console.WriteLine("Enter the choice");
                    int no = int.Parse(Console.ReadLine());
                    switch (no)
                    {
                        case 1:
                            l.Display_One();
                            break;
                        case 2:
                            l.Display_All_Data();
                            break;
                        case 3:
                            ToStop = true;
                            break;
                        default:
                            Console.WriteLine("Invalid key");
                            break;
                    }
                } while (!ToStop);
            }
            else
            {
                Console.WriteLine("User role is not valid");
            }
            Console.ReadKey();
        }
    }
}

            
        
    

    

