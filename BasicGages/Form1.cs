using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;

namespace BasicGages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            ListViewItem main = new ListViewItem("Cheese");
            listView1.FullRowSelect = true;
           
            
            main.SubItems.Add("News");
            main.SubItems.Add("Cook");
            listView1.Items.Add(main);
            listView1.Columns.Add("Title");
            listView1.Columns.Add("Title");
            listView1.Columns.Add("Title");

            listView1.View = View.Details;
            
          
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