using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Security.Cryptography;
namespace BasicGages
{
    internal class CreateUser
    {
        public static void SetUser(string userName, string password)
        {
            SHA256 sHA256 = SHA256.Create();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashedPasswordBytes = sHA256.ComputeHash(passwordBytes);
            string hashedPassword = BitConverter.ToString(hashedPasswordBytes).Replace("-", "");



            // Connection informatino for the database.
            string connectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comms = new SqlCommand();

            using (conn)
            {
                SqlTransaction transaction = transaction = conn.BeginTransaction();
                try
                {
                    // Open the connection
                  
                    conn.Open();

                    // Setting up the commands
                    comms.Connection = conn;
                    comms.Transaction = transaction;
                    comms.Parameters.AddWithValue("@user", userName);
                    comms.Parameters.AddWithValue("@pass", hashedPassword);
                    comms.CommandText = "INSERT INTO Users (userName, mainHash) VALUES (@user, @pass)";

                    comms.ExecuteNonQuery();
                    transaction.Commit();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + " " + ex.Source);
                    transaction.Commit();
                }
                finally
                {
                    conn.Close();
                }
            }

         

        }
    }
}
