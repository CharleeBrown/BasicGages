using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;

namespace BasicGages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        
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
            foreach (ColumnHeader header in listView1.Columns)
            {
                header.Width = -1; // -2 means "auto-size to contents"
            }
            
            GetData.LoadDataIntoListView(listView1);

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(listView1.SelectedItems[0].SubItems[2].Text);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* Form2.ActiveForm.Show();*/
        }
      
        public void DataObject()
        {
            /*string chars = test[0];
            Label lbl = new Label()
            {
                Text = chars,
                Location = new Point(30, 40)
            };
*/
            Form2 form= new Form2();
            /*form.Controls.Add(lbl);*/
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataObject();

        }
    }
}