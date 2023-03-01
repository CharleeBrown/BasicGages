using Microsoft.VisualBasic;
using System;
using System.Configuration;
using System.Drawing.Text;
using System.Net;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Security.Principal;



namespace BasicGages
{
    public partial class MainForm : Form
    {
        
       
        public MainForm()
        {
            InitializeComponent();
            
            // Protecting the connection string
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSection section = config.GetSection("connectionStrings");
            if (!section.SectionInformation.IsProtected)
            {
                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                config.Save();
            }

            // Setting up the List View Columns and View
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Gage Number");
            listView1.Columns.Add("Gage Type");
            listView1.Columns.Add("Status");
            listView1.Columns.Add("Last Calibration Date");
            listView1.Columns.Add("Calibration Due Date");
            listView1.Columns.Add("Current Location");
            listView1.Columns.Add("Storage Location");
            listView1.Columns.Add("Interval Type");
            listView1.Columns.Add("Interval Amount");
            listView1.Columns.Add("Is it Active?");

            listView1.View = View.Details;
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.Columns[0].Width = 0;
            // Loading the data into the List View
            GetData.LoadDataIntoListView(listView1);
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void DataObject()
        {
            AddGageForm AddGageForm = new AddGageForm();
            AddGageForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataObject();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            GetData.LoadDataIntoListView(listView1);
        }
        private void MainForm_Activated(object sender, EventArgs e)
        {
          // GetData.LoadDataIntoListView(listView1);
            
            
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            // Creating the Context Menu
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem View = new ToolStripMenuItem();
            ToolStripMenuItem Edit = new ToolStripMenuItem();
            ToolStripMenuItem Delete = new ToolStripMenuItem();

            // Adding text
            View.Text = "View";
            Edit.Text = "Edit";
            Delete.Text = "Delete";

            // setting event handlers.
            View.Click += View_Click;
            Edit.Click += Edit_Click;
            Delete.Click += Delete_Click;

            // Adding items to the range.
            ToolStripItem[] items = { View, Edit, Delete };

            // Adding items to the menu
            menu.Items.AddRange(items);
            
             if (e.Button == MouseButtons.Left)
            {
                // Display the menu when a listview item is clicked.
                var focusedItem = listView1.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    menu.Show(Cursor.Position);
                }
            }


                
        }

        private void Delete_Click(object? sender, EventArgs e)
        {
            var clickedItem = listView1.SelectedItems[0];
            Console.WriteLine(clickedItem.Text);

            int ID = Convert.ToInt32(clickedItem.Text);
            string gageNumber = clickedItem.SubItems[1].Text;
            string gageType = clickedItem.SubItems[2].Text;

            GetData.DeleteData(ID, gageNumber, gageType);
            clickedItem.Remove();
        }
        private void Edit_Click(object? sender, EventArgs e)
        {
            var clickedItem = listView1.SelectedItems[0];

            // Retrieve the gage information from the clicked item
            string ID = Convert.ToString(clickedItem.Text);
            string gageNumber = clickedItem.SubItems[1].Text;
            string gageType = clickedItem.SubItems[2].Text;
            string gageStatus = clickedItem.SubItems[3].Text;
            DateTime lastCalDate = Convert.ToDateTime(clickedItem.SubItems[4].Text);
            DateTime dueDate = Convert.ToDateTime(clickedItem.SubItems[5].Text);
            string currentLoc = clickedItem.SubItems[6].Text;
            string storageLoc = clickedItem.SubItems[7].Text;
            string intervalType = clickedItem.SubItems[8].Text;
            string intervalAmt = clickedItem.SubItems[9].Text;
            string active = clickedItem.SubItems[10].Text;

            EditGageForm editGage = new EditGageForm(Convert.ToInt32(ID),gageNumber, gageType, gageStatus, lastCalDate, dueDate, currentLoc, storageLoc, intervalType, intervalAmt, active);
            editGage.ShowDialog();
        }

        private void View_Click(object? sender, EventArgs e)
        {
            var clickedItem = listView1.SelectedItems[0];

            // Retrieve the gage information from the clicked item
            string gageNumber = clickedItem.SubItems[1].Text;
            string gageType = clickedItem.SubItems[2].Text;
            string gageStatus = clickedItem.SubItems[3].Text;
            DateTime lastCalDate = Convert.ToDateTime(clickedItem.SubItems[4].Text);
            DateTime dueDate = Convert.ToDateTime(clickedItem.SubItems[5].Text);
            string currentLoc = clickedItem.SubItems[6].Text;
            string storageLoc = clickedItem.SubItems[7].Text;
            string intervalType = clickedItem.SubItems[8].Text;
            string intervalAmt = clickedItem.SubItems[9].Text;
            string active = clickedItem.SubItems[10].Text;


            // Create a new instance of the GageDetailsForm and pass the gage information
            var gageDetailsForm = new ReviewGageForm(gageNumber, gageType, gageStatus, lastCalDate, dueDate, currentLoc, storageLoc, intervalType, intervalAmt, active);
            gageDetailsForm.Text = gageNumber + " - " + gageType;
            // Display the GageDetailsForm
            gageDetailsForm.ShowDialog();
           // throw new NotImplementedException();
        }

        
    }
    }

