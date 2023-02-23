namespace BasicGages
{
    public partial class AddGageForm : Form
    {

        public AddGageForm()
        {
            
            InitializeComponent();
            gageNumTxt.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            GetData.SetData(gageNumTxt.Text, gageTypeTxt.Text, statusTxt.Text, lastCalDTP.Value, dueDateDTP.Value, currentLocTxt.Text, storageLocTxt.Text, activeTxt.Text);
            this.Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string info = comboBox1.Text;

            switch (info)
            {
                case "Day":
                    dueDateDTP.Value = lastCalDTP.Value.AddDays(Convert.ToInt32(interValue.Text));
                    break;
                case "Month":
                    dueDateDTP.Value = lastCalDTP.Value.AddMonths(Convert.ToInt32(interValue.Text));
                    break;
                case "Week":
                    dueDateDTP.Value = lastCalDTP.Value.AddDays(Convert.ToInt32(interValue.Text) * 7);
                    break;
                case "Year":
                    dueDateDTP.Value = lastCalDTP.Value.AddYears(Convert.ToInt32(interValue.Text));
                    break;
            }

        }

        private void AddGageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm form = new MainForm();
            ListView list = form.listView1;
            GetData.LoadDataIntoListView(list);
        }

      
    }
}
