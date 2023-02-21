namespace BasicGages
{
    partial class Form2
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
            this.storageLocTxt = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.gageNumTxt = new System.Windows.Forms.TextBox();
            this.gageTypeTxt = new System.Windows.Forms.TextBox();
            this.statusTxt = new System.Windows.Forms.TextBox();
            this.activeTxt = new System.Windows.Forms.TextBox();
            this.currentLocTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lastCalDTP = new System.Windows.Forms.DateTimePicker();
            this.dueDateDTP = new System.Windows.Forms.DateTimePicker();
            this.interValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // storageLocTxt
            // 
            this.storageLocTxt.Location = new System.Drawing.Point(70, 248);
            this.storageLocTxt.Name = "storageLocTxt";
            this.storageLocTxt.Size = new System.Drawing.Size(141, 27);
            this.storageLocTxt.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(259, 303);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(135, 32);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Add new Gage";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // gageNumTxt
            // 
            this.gageNumTxt.Location = new System.Drawing.Point(70, 52);
            this.gageNumTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gageNumTxt.Name = "gageNumTxt";
            this.gageNumTxt.Size = new System.Drawing.Size(141, 27);
            this.gageNumTxt.TabIndex = 1;
            // 
            // gageTypeTxt
            // 
            this.gageTypeTxt.Location = new System.Drawing.Point(259, 52);
            this.gageTypeTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gageTypeTxt.Name = "gageTypeTxt";
            this.gageTypeTxt.Size = new System.Drawing.Size(141, 27);
            this.gageTypeTxt.TabIndex = 2;
            // 
            // statusTxt
            // 
            this.statusTxt.Location = new System.Drawing.Point(450, 52);
            this.statusTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(141, 27);
            this.statusTxt.TabIndex = 3;
            // 
            // activeTxt
            // 
            this.activeTxt.Location = new System.Drawing.Point(259, 248);
            this.activeTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.activeTxt.Name = "activeTxt";
            this.activeTxt.Size = new System.Drawing.Size(141, 27);
            this.activeTxt.TabIndex = 9;
            // 
            // currentLocTxt
            // 
            this.currentLocTxt.Location = new System.Drawing.Point(450, 248);
            this.currentLocTxt.Name = "currentLocTxt";
            this.currentLocTxt.Size = new System.Drawing.Size(141, 27);
            this.currentLocTxt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gage Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gage Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Calibration Due Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Is Active";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Current Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Last Calibration Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Storage Location";
            // 
            // lastCalDTP
            // 
            this.lastCalDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lastCalDTP.Location = new System.Drawing.Point(70, 142);
            this.lastCalDTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastCalDTP.Name = "lastCalDTP";
            this.lastCalDTP.Size = new System.Drawing.Size(141, 27);
            this.lastCalDTP.TabIndex = 4;
            this.lastCalDTP.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dueDateDTP
            // 
            this.dueDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dueDateDTP.Location = new System.Drawing.Point(450, 142);
            this.dueDateDTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dueDateDTP.Name = "dueDateDTP";
            this.dueDateDTP.Size = new System.Drawing.Size(141, 27);
            this.dueDateDTP.TabIndex = 7;
            // 
            // interValue
            // 
            this.interValue.Location = new System.Drawing.Point(259, 142);
            this.interValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.interValue.MaxLength = 2;
            this.interValue.Name = "interValue";
            this.interValue.Size = new System.Drawing.Size(26, 27);
            this.interValue.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(259, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Calibration Interval";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Day",
            "Month",
            "Week",
            "Year"});
            this.comboBox1.Location = new System.Drawing.Point(292, 141);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 355);
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
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button saveButton;
        private Label label1;
        private TextBox gageNumTxt;
        private TextBox gageTypeTxt;
        private TextBox statusTxt;
        private TextBox activeTxt;
        private TextBox currentLocTxt;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        public TextBox storageLocTxt;
        private Label label8;
        private Label label9;
        private DateTimePicker lastCalDTP;
        private DateTimePicker dueDateDTP;
        private TextBox interValue;
        private Label label10;
        private ComboBox comboBox1;
    }
}