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
            List<string> results = new List<string>();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hallocol\source\repos\BasicGages\BasicGages\GageDB.mdf;Integrated Security=True");
          
            SqlCommand comms = new SqlCommand("SELECT GageNum, GageType, Status, LastCal, CalDueDate, CurrentLoc, StorageLoc, isActive FROM GageTable");
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
        public static void LoadDataIntoListView(ListView listView)
        {
            // Clear any existing items in the ListView
            listView.Items.Clear();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hallocol\source\repos\BasicGages\BasicGages\GageDB.mdf;Integrated Security=True");

            SqlCommand comms = new SqlCommand();
            using (conn)
            {
                conn.Open();
                comms.Connection = conn;
                comms.CommandText = "SELECT GageNum, GageType, Status, LastCal, CalDueDate, CurrentLoc, StorageLoc, isActive FROM GageTable";

                // Execute the SQL command and retrieve the data
                using (SqlDataReader reader = comms.ExecuteReader())
                {
                    // Loop through each row in the result set
                    while (reader.Read())
                    {
                        // Create a new ListViewItem to hold the row data
                        ListViewItem item = new ListViewItem(reader["GageNum"].ToString());

                        // Add the remaining columns to the ListViewItem
                        item.SubItems.Add(reader["GageType"].ToString());
                        item.SubItems.Add(reader["Status"].ToString());
                        item.SubItems.Add(reader["LastCal"].ToString());
                        item.SubItems.Add(reader["CalDueDate"].ToString());
                        item.SubItems.Add(reader["CurrentLoc"].ToString());
                        item.SubItems.Add(reader["StorageLoc"].ToString());
                        item.SubItems.Add(reader["isActive"].ToString());

                        // Add the ListViewItem to the ListView
                        listView.Items.Add(item);
                    }
                }
            }
        }

    }

}
