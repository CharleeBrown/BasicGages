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


        public static void SetData(string GageNum, string GageType, string status, DateTime lastCal, DateTime dueDate, string currentLocation, string storageLocation, string active)
        {
            SqlConnection conn = new SqlConnection(@"//");



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
            SqlConnection conn = new SqlConnection(@"//");

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
                        DateTime timerOne = Convert.ToDateTime(reader["lastCal"]);
                        DateTime timerTwo = Convert.ToDateTime(reader["CalDueDate"]);
                        // Add the remaining columns to the ListViewItem
                        item.SubItems.Add(reader["GageType"].ToString());
                        item.SubItems.Add(reader["Status"].ToString());
                        item.SubItems.Add(timerOne.ToShortDateString());
                        item.SubItems.Add(timerTwo.ToShortDateString());
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
    public class MyClass
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return String.Format("Name: {0}, Value: {1:N2}", Name, Value);
        }
    }

}
