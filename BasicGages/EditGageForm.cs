using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BasicGages
{
    public partial class EditGageForm : Form
    {

        // Setup variables.
        private int ID;
        private string gageNum;
        private string gageType;
        private string status;
        private DateTime lastCal;
        private DateTime dueDate;
        private string currentLoc;
        private string storageLoc;
        private string intervalType;
        private string intervalAmt;
        private string active;
        private int gageSerialNumber;
        public EditGageForm(int ID, string gageNumber, string gageType, string gageStatus, DateTime lastCal, DateTime dueDate, string currentLoc, string storageLoc, string intervalType, string intervalAmt, string active)
        {
            InitializeComponent();
            this.ID = ID;
            this.gageNum = gageNumber;
            this.gageType = gageType;
            this.status = gageStatus;
            this.lastCal = lastCal;
            this.dueDate = dueDate;
            this.currentLoc = currentLoc;
            this.storageLoc = storageLoc;
            this.intervalType = intervalType;
            this.intervalAmt = intervalAmt;
            this.active = active;

            DisplayGageInformation();
       
        }
        private void DisplayGageInformation()
        {
            // Display the gage information in the form controls
            gageNumEdit.Text = gageNum;
            gageTypeEdit.Text = gageType;
            statusEdit.Text = status;
            lastCalDTP_Edit.Value = lastCal;
            dueDateDTP_Edit.Value = dueDate;
            currentLocEdit.Text = currentLoc;
            storageLocEdit.Text = storageLoc;
            intervalTypeEdit.Text = intervalType;
            intervalEdit.Text = intervalAmt;

        }

        private void saveButton_Click(object sender, EventArgs e)

        {
            // Updates the gage information and closes the form.
            MainForm form = new MainForm();
            GetData.UpdateData(ID, gageNumEdit.Text, gageTypeEdit.Text, statusEdit.Text, lastCalDTP_Edit.Value, dueDateDTP_Edit.Value, currentLocEdit.Text, storageLocEdit.Text, intervalTypeEdit.Text, intervalEdit.Text, activeEdit.Text, form.listView1);
            this.Close();
        }
    }
}
