using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Final_Project
{
    public class Server
    {
        public const string LocalConnectionString = @"Data Source =(localDB)\MSSQLLocalDB;AttachDbFilename=E:\Coding\FinalProjectWPF\WPF_Final_Project\LocalDatabase.mdf;Integrated Security = True;";

        public static object GetSKUInfo(int SKU)
        {
           
            Product product = new Product();

            var ServerConnectionString = new SqlConnectionStringBuilder();
            ServerConnectionString.DataSource = "steven3zx.database.windows.net";
            ServerConnectionString.UserID = "Steven3zx";
            ServerConnectionString.Password = "StevenGates885213";
            ServerConnectionString.InitialCatalog = "BMC";

            using (SqlConnection conn = new SqlConnection())
            {

                conn.ConnectionString = ServerConnectionString.ToString();
                
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Product WHERE SKU = @SKU", conn);
                command.Parameters.Add(new SqlParameter("SKU", SKU));
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        product.QuantityOnHand = Convert.ToInt32(reader[2].ToString());
                        product.QuantityInHastings = Convert.ToInt32(reader[3].ToString());
                        product.QuantityInKalamazoo = Convert.ToInt32(reader[4].ToString());
                        product.Price = Convert.ToDouble(reader[5].ToString());
                        product.Location = reader[6].ToString();
                        product.Photo = reader[7].ToString();
                    }
                }
            }

            return product;
            
        }

        public static object GetUPCInfo(long UPC)
        {
            Product product = new Product();

            var ServerConnectionString = new SqlConnectionStringBuilder();
            ServerConnectionString.DataSource = "steven3zx.database.windows.net";
            ServerConnectionString.UserID = "Steven3zx";
            ServerConnectionString.Password = "StevenGates885213";
            ServerConnectionString.InitialCatalog = "BMC";

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ServerConnectionString.ToString();
                
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Product WHERE UPC = @UPC", conn);
                command.Parameters.Add(new SqlParameter("UPC", UPC));
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        product.QuantityOnHand = Convert.ToInt32(reader[2].ToString());
                        product.QuantityInHastings = Convert.ToInt32(reader[3].ToString());
                        product.QuantityInKalamazoo = Convert.ToInt32(reader[4].ToString());
                        product.Price = Convert.ToDouble(reader[5].ToString());
                        product.Location = reader[6].ToString();
                        product.Photo = reader[7].ToString();

                    }
                }
            }
            return product;
        }
    }
}
