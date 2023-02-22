using System.Configuration;

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

            listView1.Columns.Add("Gage Number");
            listView1.Columns.Add("Gage Type");
            listView1.Columns.Add("Status");
            listView1.Columns.Add("Last Calibration Date");
            listView1.Columns.Add("Calibration Due Date");
            listView1.Columns.Add("Current Location");
            listView1.Columns.Add("Storage Location");
            listView1.Columns.Add("Is it Active?");

            listView1.View = View.Details;
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            // Loading the data into the List View
            GetData.LoadDataIntoListView(listView1);
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            var clickedItem = listView1.SelectedItems[0];

            // Retrieve the gage information from the clicked item
            string gageNumber = clickedItem.Text;
            string gageType = clickedItem.SubItems[1].Text;
            string gageStatus = clickedItem.SubItems[2].Text;
            DateTime lastCalDate = Convert.ToDateTime(clickedItem.SubItems[3].Text);
            DateTime dueDate = Convert.ToDateTime(clickedItem.SubItems[4].Text);
            string currentLoc = clickedItem.SubItems[5].Text;
            string storageLoc = clickedItem.SubItems[6].Text;
            string active = clickedItem.SubItems[7].Text;

            // Create a new instance of the GageDetailsForm and pass the gage information
            var gageDetailsForm = new ReviewGageForm(gageNumber, gageType, gageStatus, lastCalDate, dueDate, currentLoc, storageLoc, active);
            gageDetailsForm.Text = gageNumber + " - " + gageType;
            // Display the GageDetailsForm
            gageDetailsForm.ShowDialog();

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
            GetData.LoadDataIntoListView(listView1);
            
            
        }
    }
}