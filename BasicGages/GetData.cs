using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace BasicGages
{
    internal class GetData
    {

        public static List<string> PullData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hallocol\source\repos\BasicGages\BasicGages\GageDB.mdf;Integrated Security=True");
            List<string> results = new List<string>();
            SqlCommand comms = new SqlCommand("SELECT GageNum, GageType, Status, LastCal, CalDueDate FROM GageTable");
            using (conn)
            {
                conn.Open();
                comms.Connection = conn;
                SqlDataReader reader = comms.ExecuteReader();
                
                while (reader.Read())
                {
                    for(var i=0; i<reader.FieldCount; i++)
                    {
                        results.Add(reader[i].ToString()); 
                    }
                  
                }

                
            }
            conn.Close();
            return results;
        }

        public static void SetData(string GageNum, string GageType, string status, DateTime lastCal, DateTime dueDate, string currentLocation, string storageLocation, string active)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hallocol\source\repos\BasicGages\BasicGages\GageDB.mdf;Integrated Security=True");



            SqlCommand comms = new SqlCommand();
            comms.Connection = conn;
            comms.CommandText = $"INSERT INTO  GageTable VALUES ('{GageNum}', '{GageType}', '{status}', '{lastCal.Date}', '{dueDate.Date}','{currentLocation}', '{storageLocation}', '{active}')";
            using (conn)
            {
                conn.Open();
           
                comms.ExecuteNonQuery();                 
            }
            conn.Close();
            MessageBox.Show("Data Saved");

        }
    }

}
