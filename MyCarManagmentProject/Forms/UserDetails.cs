using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCarManagmentProject.Forms
{
    public partial class UserDetails : Form
    {
        private int _userId;

        public UserDetails(int userId)
        {
            InitializeComponent();
            _userId = userId;

        }



        private void UserDetails_Load(object sender, EventArgs e)
        {
            SelectedUser = GetUserDetails(_userId);
            SetDesigner();
        }


        private Person GetUserDetails(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CarShop"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM USERS WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);


                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Person customer = new Person
                        {
                            Id = Convert.ToInt32(reader["ID"]),
                            Name = reader["Name"].ToString(),
                            LastName = reader["LASTNAME"].ToString(),
                        };


                        return customer; // فقط یک شخص
                    }
                }
            }

            return null; // اگر شخص پیدا نشد
        }

        public Person SelectedUser { get; set; }

        public void SetDesigner()
        {
            if (SelectedUser == null) return;

            lblUserId.Text ="ID: "+ SelectedUser.Id.ToString();
            lblName.Text ="Name: "+ SelectedUser.Name;
            lblLastName.Text ="LastName: "+ SelectedUser.LastName;
          

        }
    }
}
