namespace BasicGages
{
    partial class EditGageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.interValue = new System.Windows.Forms.TextBox();
            this.dueDateDTP = new System.Windows.Forms.DateTimePicker();
            this.lastCalDTP = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusTxt = new System.Windows.Forms.TextBox();
            this.activeTxt = new System.Windows.Forms.TextBox();
            this.currentLocTxt = new System.Windows.Forms.TextBox();
            this.gageTypeTxt = new System.Windows.Forms.TextBox();
            this.gageNumTxt = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.storageLocTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Day",
            "Month",
            "Week",
            "Year"});
            this.comboBox1.Location = new System.Drawing.Point(261, 145);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 28);
            this.comboBox1.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Calibration Interval";
            // 
            // interValue
            // 
            this.interValue.Location = new System.Drawing.Point(228, 146);
            this.interValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.interValue.MaxLength = 2;
            this.interValue.Name = "interValue";
            this.interValue.Size = new System.Drawing.Size(26, 27);
            this.interValue.TabIndex = 27;
            // 
            // dueDateDTP
            // 
            this.dueDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dueDateDTP.Location = new System.Drawing.Point(419, 146);
            this.dueDateDTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dueDateDTP.Name = "dueDateDTP";
            this.dueDateDTP.Size = new System.Drawing.Size(141, 27);
            this.dueDateDTP.TabIndex = 29;
            // 
            // lastCalDTP
            // 
            this.lastCalDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lastCalDTP.Location = new System.Drawing.Point(39, 146);
            this.lastCalDTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastCalDTP.Name = "lastCalDTP";
            this.lastCalDTP.Size = new System.Drawing.Size(141, 27);
            this.lastCalDTP.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Storage Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Last Calibration Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Current Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Is Active";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Calibration Due Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Gage Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Gage Number";
            // 
            // statusTxt
            // 
            this.statusTxt.Location = new System.Drawing.Point(419, 56);
            this.statusTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(141, 27);
            this.statusTxt.TabIndex = 25;
            // 
            // activeTxt
            // 
            this.activeTxt.Location = new System.Drawing.Point(228, 252);
            this.activeTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.activeTxt.Name = "activeTxt";
            this.activeTxt.Size = new System.Drawing.Size(141, 27);
            this.activeTxt.TabIndex = 32;
            // 
            // currentLocTxt
            // 
            this.currentLocTxt.Location = new System.Drawing.Point(419, 252);
            this.currentLocTxt.Name = "currentLocTxt";
            this.currentLocTxt.Size = new System.Drawing.Size(141, 27);
            this.currentLocTxt.TabIndex = 35;
            // 
            // gageTypeTxt
            // 
            this.gageTypeTxt.Location = new System.Drawing.Point(228, 56);
            this.gageTypeTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gageTypeTxt.Name = "gageTypeTxt";
            this.gageTypeTxt.Size = new System.Drawing.Size(141, 27);
            this.gageTypeTxt.TabIndex = 24;
            // 
            // gageNumTxt
            // 
            this.gageNumTxt.Location = new System.Drawing.Point(39, 56);
            this.gageNumTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gageNumTxt.Name = "gageNumTxt";
            this.gageNumTxt.Size = new System.Drawing.Size(141, 27);
            this.gageNumTxt.TabIndex = 23;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(228, 307);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(135, 32);
            this.saveButton.TabIndex = 33;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // storageLocTxt
            // 
            this.storageLocTxt.Location = new System.Drawing.Point(39, 252);
            this.storageLocTxt.Name = "storageLocTxt";
            this.storageLocTxt.Size = new System.Drawing.Size(141, 27);
            this.storageLocTxt.TabIndex = 30;
            // 
            // EditGageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 351);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.interValue);
            this.Controls.Add(this.dueDateDTP);
            this.Controls.Add(this.lastCalDTP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusTxt);
            this.Controls.Add(this.activeTxt);
            this.Controls.Add(this.currentLocTxt);
            this.Controls.Add(this.gageTypeTxt);
            this.Controls.Add(this.gageNumTxt);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.storageLocTxt);
            this.Name = "EditGageForm";
            this.Text = "EditGageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private Label label10;
        private TextBox interValue;
        private DateTimePicker dueDateDTP;
        private DateTimePicker lastCalDTP;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox statusTxt;
        private TextBox activeTxt;
        private TextBox currentLocTxt;
        private TextBox gageTypeTxt;
        private TextBox gageNumTxt;
        private Button saveButton;
        public TextBox storageLocTxt;
    }
}