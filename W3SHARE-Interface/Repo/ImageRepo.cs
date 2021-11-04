using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using W3SHARE_Interface.Models;

namespace W3SHARE_Interface.Repo
{

    

    public class ImageRepo
    {
        private string connectionString = "Data Source=DESKTOP-LBGUC1G;Initial Catalog=W3SHARE-PROD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlDataReader reader;

        public ImageRepo()
        {
            con = new SqlConnection(connectionString);
            con.ConnectionString = connectionString;
            con.Open();

            //con.Close();
        }

        public void AddImage(ImageDTO imageDTO)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                //remember to add user who uploaded the image
                String sql = ("INSERT INTO dbo.tbl_image (tbl_image_Geolocation,tbl_image_Tags,tbl_image_CaptureDate,tbl_image_CaptureBy,tbl_image_url,fk_tbl_user) VALUES ('" + imageDTO.Geolocation + "','" + imageDTO.Tags + "','" + imageDTO.CaptureDate + "','" + imageDTO.CapturedBy + "','" + imageDTO.ImageURL + "','" + imageDTO.User + "')");

                command = new SqlCommand(sql, con);

                adapter.InsertCommand = new SqlCommand(sql, con);
                adapter.InsertCommand.ExecuteNonQuery();

                command.Dispose();
                con.Close();
            }

        }

       

    }

    

    //get all images of user
    //param (id)
    //return list imagedto

    //get all images of all users
    //param ()
    //return list dto

    //update image meta data 
    //param (imagedto)
    //return bool

    //DETE image meta data
    //param (id)
    //return bool 
}
