namespace BasicGages
{
    public partial class ReviewGageForm : Form
    {
        private string gageNum;
        private string gageType;
        private string status;
        private DateTime lastCal;
        private DateTime dueDate;
        private string currentLoc;
        private string storageLoc;
        private string active;
        private int gageSerialNumber;

        public ReviewGageForm(string gageNumber, string gageType, string gageStatus, DateTime lastCal, DateTime dueDate, string currentLoc, string storageLoc, string active)
        {
            InitializeComponent();
            this.gageNum = gageNumber;
            this.gageType = gageType;
            this.status = gageStatus;
            this.lastCal = lastCal;
            this.dueDate = dueDate;
            this.currentLoc = currentLoc;
            this.storageLoc = storageLoc;
            this.active = active;
            DisplayGageInformation();
        }
        private void DisplayGageInformation()
        {
            // Display the gage information in the form controls
            gageNumViewTxt.Text = gageNum;
            gageTypeViewTxt.Text = gageType;
            statusViewTxt.Text = status;
            lastCalDTPView.Value = lastCal;
            dueDateDTPView.Value = dueDate;
            currentLocViewTxt.Text = currentLoc;
            storageLocViewTxt.Text = storageLoc;

            //serialNumberLabel.Text = gageSerialNumber.ToString();
        }
    }
}
