using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using W3SHARE_Interface.Models;



namespace W3SHARE_Interface.Repo
{
    public class UsersRepo
    {

        private string connectionString = "Data Source=DESKTOP-LBGUC1G;Initial Catalog=W3SHARE-PROD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlDataReader reader;

        public UsersRepo()
        {
            con = new SqlConnection(connectionString);
            con.ConnectionString = connectionString;
            con.Open();

            //con.Close();
        }

        public bool AddUser (UsersDTO usersDTO)
        {
            using (SqlConnection conn = new SqlConnection())
            {

                String sql = ("INSERT INTO dbo.tbl_user (tbl_user_name,tbl_user_surname,tbl_user_email,tbl_user_password) VALUES ('" + usersDTO.Name +"','"+usersDTO.Surname + "','" + usersDTO.Email + "','" + usersDTO.Password + "')" );

                command = new SqlCommand(sql, con);

                command.Parameters.AddWithValue("@a", "Max");
                command.Parameters.AddWithValue("@b", "$1200");

                adapter.InsertCommand = new SqlCommand(sql, con);
                adapter.InsertCommand.ExecuteNonQuery();

                command.Dispose();
		        con.Close();
            }

            return true;
        }

        public UsersDTO ReturnUser(string email , string password)
        {
            UsersDTO user = new UsersDTO();
            int valuesReturned = 0;

            String sql = ("SELECT * FROM dbo.tbl_user WHERE tbl_user_email = '"+email+ "' AND tbl_user_password = '" + password + "' ");

            command = new SqlCommand(sql, con);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                valuesReturned++;

                user.ID = (int)reader.GetValue(4);
                user.Name = reader.GetValue(1).ToString();
                user.Surname = reader.GetValue(2).ToString();
                user.Email = reader.GetValue(3).ToString();
            }

            reader.Read();

            if (valuesReturned == 1 )
            {
                return user;
            }
            else
            {
                throw new Exception("No user returned");
            }

       
        }
    } 
}
