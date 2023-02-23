﻿using Microsoft.Data.SqlClient;
using System.Configuration;

namespace BasicGages
{
    internal class GetData
    {


        public static void SetData(string GageNum, string GageType, string status, DateTime lastCal, DateTime dueDate, string currentLocation, string storageLocation, string intervalType, string intervalAmt, string active)
        {
            // Retrieving the connection string.
            string connectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            //  DateTime myDateTime = DateTime.Now;
 /*           string lastCalFormatted = lastCal.ToString("MM-dd-yyyy");
            string dueDateFormatted = dueDate.ToString("MM-dd-yyyy");*/
            // Setup for the SQL Commands
            SqlCommand comms = new SqlCommand();
            comms.Connection = conn;

            comms.Parameters.AddWithValue("@GageNum", GageNum);
            comms.Parameters.AddWithValue("@GageType", GageType);
            comms.Parameters.AddWithValue("@status", status);
            comms.Parameters.AddWithValue("@lastCal", lastCal.ToShortDateString());
            comms.Parameters.AddWithValue("@dueDate", dueDate.ToShortDateString());
            comms.Parameters.AddWithValue("@currentLocation", currentLocation);
            comms.Parameters.AddWithValue("@storageLocation", storageLocation);
            comms.Parameters.AddWithValue("@intervalType", intervalType);
            comms.Parameters.AddWithValue("@intervalAmt", intervalAmt);
            comms.Parameters.AddWithValue("@active", active);

            comms.CommandText = "INSERT INTO GageTable VALUES (@GageNum, @GageType, @status, @lastCal, @dueDate, @currentLocation, @storageLocation, @active, @intervalAmt,@intervalType) ";


            using (conn)
            {
                conn.Open();
                try
                {
                    // Opening the connection and executing the query with the connection.


                    comms.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    // Writing any errors to the console and rolling back the transaction.
                    MessageBox.Show(ex.Message + " " + ex.StackTrace + " " + ex.Source);
                }
                finally
                {
                    // Committing the query and notifying the user.

                    MessageBox.Show("Data Saved");
                }

                // Closing the connection.
                conn.Close();
            }


        }
        public static void LoadDataIntoListView(ListView listView)
        {
            // Clear any existing items in the ListView
            listView.BeginUpdate();
            listView.Items.Clear();
            string connectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comms = new SqlCommand();
            using (conn)
            {
                conn.Open();
                comms.Connection = conn;
                comms.CommandText = "SELECT GageNum, GageType, Status, LastCal, CalDueDate, CurrentLoc, StorageLoc, IntervalAmt, IntervalType, isActive FROM GageTable";

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
                        item.SubItems.Add(reader["intervalType"].ToString());
                        item.SubItems.Add(reader["intervalAmt"].ToString());
                        item.SubItems.Add(reader["isActive"].ToString());

                        // Add the ListViewItem to the ListView
                        
                        listView.Items.Add(item);

                    }

                }

            }
            listView.EndUpdate();
            listView.Refresh();

        }


    }


}
