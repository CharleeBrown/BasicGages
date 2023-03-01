namespace BasicGages
{
    public partial class AddGageForm : Form
    {

        public AddGageForm()
        {
            
            InitializeComponent();
            gageNumTxt.Focus();
            GageInfo gages = new GageInfo();

            foreach(var item in gages.GageTypes())
            {
                gageTypeBox.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Saves the gage data.
            GetData.SetData(gageNumTxt.Text, gageTypeBox.SelectedItem.ToString(), statusTxt.Text, lastCalDTP.Value, dueDateDTP.Value, currentLocTxt.Text, storageLocTxt.Text,intervalType.SelectedItem.ToString(), intervalAmt.Text, activeTxt.Text);
            this.Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string info = intervalType.Text;

            // Switch to change the date as the interval is changed.
            switch (info)
            {
                case "Day":
                    dueDateDTP.Value = lastCalDTP.Value.AddDays(Convert.ToInt32(intervalAmt.Text));
                    break;
                case "Month":
                    dueDateDTP.Value = lastCalDTP.Value.AddMonths(Convert.ToInt32(intervalAmt.Text));
                    break;
                case "Week":
                    dueDateDTP.Value = lastCalDTP.Value.AddDays(Convert.ToInt32(intervalAmt.Text) * 7);
                    break;
                case "Year":
                    dueDateDTP.Value = lastCalDTP.Value.AddYears(Convert.ToInt32(intervalAmt.Text));
                    break;
            }

        }

        private void AddGageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // The listView in the MainForm should refresh when the AddGage form is closed.
            MainForm form = new MainForm();
            ListView list = form.listView1;
            GetData.LoadDataIntoListView(list);
        }

      
    }
}
