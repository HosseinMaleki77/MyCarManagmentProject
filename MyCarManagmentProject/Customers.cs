//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MyCarManagmentProject
//{

   
//    public static class Repository<T> where T : class
//    {
//        public static void InsertPerson(string name)
//        {

//            //string name = txtFirstName.Text;
//            //string lastname = txtLastName.Text;
//            //string username = txtRPassword.Text;
//            //string password = txtRPassword.Text;




//            string connectionString = "Data Source=.;Initial Catalog=CarShop;Integrated Security=True;";


//            using (SqlConnection conn = new SqlConnection(connectionString))
//            {
//                string query = $"INSERT INTO CUSTOMERS (NAME, LASTNAME, USERNAME, [PASSWORD]) VALUES (@Name, @LASTNAME, @USERNAME, @PASSWORD)";
//                SqlCommand cmd = new SqlCommand(query, conn);
//                cmd.Parameters.AddWithValue("@NAME", name);
//                //cmd.Parameters.AddWithValue("@LASTNAME", lastname);
//                //cmd.Parameters.AddWithValue("@USERNAME", username);
//                //cmd.Parameters.AddWithValue("@PASSWORD", password);




//                conn.Open();
//                cmd.ExecuteNonQuery();
//            }

//        }
//    }
//}
