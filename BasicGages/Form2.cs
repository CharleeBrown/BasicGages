using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicGages
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            gageNumTxt.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetData.SetData(gageNumTxt.Text, gageTypeTxt.Text, statusTxt.Text, lastCalDTP.Value.Date, dueDateDTP.Value.Date, currentLocTxt.Text, storageLocTxt.Text, activeTxt.Text);
            Form2.ActiveForm.Close();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string info = comboBox1.Text;

            switch(info)
            {
                case "Day":
                    dueDateDTP.Value = lastCalDTP.Value.AddDays(Convert.ToInt32(interValue.Text));
                    break;
                case "Month":
                    dueDateDTP.Value = lastCalDTP.Value.AddMonths(Convert.ToInt32(interValue.Text));
                    break;
                case "Week":
                    dueDateDTP.Value = lastCalDTP.Value.AddDays(Convert.ToInt32(interValue.Text) *7);
                    break;
                case "Year":
                    dueDateDTP.Value = lastCalDTP.Value.AddYears(Convert.ToInt32(interValue.Text));
                    break;
            }
                 
        }
    }
}
