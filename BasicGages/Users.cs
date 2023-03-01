using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Security.Cryptography;
using System.Drawing.Text;
using Microsoft.IdentityModel.Tokens;

namespace BasicGages
{
    internal class Users
    {
        private string _user = "";
        private string _main = "";


        public void SetUser(string userName, string password, Form form)
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
                SqlTransaction transaction = null;
                try
                {
                    // Open the connection
                  
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    // Setting up the commands
                    comms.Connection = conn;
                    comms.Transaction = transaction;
                    comms.Parameters.AddWithValue("@user", userName);
                    comms.Parameters.AddWithValue("@pass", hashedPassword);
                    comms.CommandText = "INSERT INTO Users (userName, mainHash) VALUES (@user, @pass)";

                    comms.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Create Sucessfully!");

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


            MessageBox.Show("Logged In!");
            form.Close();
            //LoginForm.ActiveForm.Close();
            MainForm main = new MainForm();
            main.ShowDialog();
        }
      

        public void LoginUser(string userName, string password, Form form)
        {
            
            // Hashing the password input by the user.
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
                SqlTransaction transaction = null;

                try
                {
                    // Open the connection

                    conn.Open();
                    transaction = conn.BeginTransaction();
                    // Setting up the commands
                    comms.Connection = conn;
                    comms.Transaction = transaction;
                    comms.Parameters.AddWithValue("@user", userName);
                    
                    // Grabbing information to compare by username
                    comms.CommandText = "SELECT * FROM Users WHERE Username = @user";

                    //
                    SqlDataReader reader =  comms.ExecuteReader();
                    while (reader.Read())
                    {
                        _user = reader["Username"].ToString();
                        _main = reader["mainHash"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " " + ex.Source);
                }
                finally
                {
                    conn.Close();
                }
            }
            if (String.IsNullOrEmpty(userName)|| String.IsNullOrEmpty(hashedPassword) && userName!= _user || hashedPassword != _main)
            {
                MessageBox.Show("Incorrect Credentials");
            }
            else { 
                MessageBox.Show("Logged In!");

                var th = new Thread(() => Application.Run(new MainForm()));
                th.SetApartmentState(ApartmentState.STA); // Deprecation Fix
                th.Start();

                form.Close();
            }
        }
    }
}
