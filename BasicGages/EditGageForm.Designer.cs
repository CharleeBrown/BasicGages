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
            this.intervalTypeEdit = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.intervalEdit = new System.Windows.Forms.TextBox();
            this.dueDateDTP_Edit = new System.Windows.Forms.DateTimePicker();
            this.lastCalDTP_Edit = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusEdit = new System.Windows.Forms.TextBox();
            this.activeEdit = new System.Windows.Forms.TextBox();
            this.currentLocEdit = new System.Windows.Forms.TextBox();
            this.gageTypeEdit = new System.Windows.Forms.TextBox();
            this.gageNumEdit = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.storageLocEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // intervalTypeEdit
            // 
            this.intervalTypeEdit.FormattingEnabled = true;
            this.intervalTypeEdit.Items.AddRange(new object[] {
            "Day",
            "Month",
            "Week",
            "Year"});
            this.intervalTypeEdit.Location = new System.Drawing.Point(261, 145);
            this.intervalTypeEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.intervalTypeEdit.Name = "intervalTypeEdit";
            this.intervalTypeEdit.Size = new System.Drawing.Size(108, 28);
            this.intervalTypeEdit.TabIndex = 28;
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
            // intervalEdit
            // 
            this.intervalEdit.Location = new System.Drawing.Point(228, 146);
            this.intervalEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.intervalEdit.MaxLength = 2;
            this.intervalEdit.Name = "intervalEdit";
            this.intervalEdit.Size = new System.Drawing.Size(26, 27);
            this.intervalEdit.TabIndex = 27;
            // 
            // dueDateDTP_Edit
            // 
            this.dueDateDTP_Edit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dueDateDTP_Edit.Location = new System.Drawing.Point(419, 146);
            this.dueDateDTP_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dueDateDTP_Edit.Name = "dueDateDTP_Edit";
            this.dueDateDTP_Edit.Size = new System.Drawing.Size(141, 27);
            this.dueDateDTP_Edit.TabIndex = 29;
            // 
            // lastCalDTP_Edit
            // 
            this.lastCalDTP_Edit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lastCalDTP_Edit.Location = new System.Drawing.Point(39, 146);
            this.lastCalDTP_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastCalDTP_Edit.Name = "lastCalDTP_Edit";
            this.lastCalDTP_Edit.Size = new System.Drawing.Size(141, 27);
            this.lastCalDTP_Edit.TabIndex = 26;
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
            // statusEdit
            // 
            this.statusEdit.Location = new System.Drawing.Point(419, 56);
            this.statusEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusEdit.Name = "statusEdit";
            this.statusEdit.Size = new System.Drawing.Size(141, 27);
            this.statusEdit.TabIndex = 25;
            // 
            // activeEdit
            // 
            this.activeEdit.Location = new System.Drawing.Point(228, 252);
            this.activeEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.activeEdit.Name = "activeEdit";
            this.activeEdit.Size = new System.Drawing.Size(141, 27);
            this.activeEdit.TabIndex = 32;
            // 
            // currentLocEdit
            // 
            this.currentLocEdit.Location = new System.Drawing.Point(419, 252);
            this.currentLocEdit.Name = "currentLocEdit";
            this.currentLocEdit.Size = new System.Drawing.Size(141, 27);
            this.currentLocEdit.TabIndex = 35;
            // 
            // gageTypeEdit
            // 
            this.gageTypeEdit.Location = new System.Drawing.Point(228, 56);
            this.gageTypeEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gageTypeEdit.Name = "gageTypeEdit";
            this.gageTypeEdit.Size = new System.Drawing.Size(141, 27);
            this.gageTypeEdit.TabIndex = 24;
            // 
            // gageNumEdit
            // 
            this.gageNumEdit.Location = new System.Drawing.Point(39, 56);
            this.gageNumEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gageNumEdit.Name = "gageNumEdit";
            this.gageNumEdit.Size = new System.Drawing.Size(141, 27);
            this.gageNumEdit.TabIndex = 23;
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
            // storageLocEdit
            // 
            this.storageLocEdit.Location = new System.Drawing.Point(39, 252);
            this.storageLocEdit.Name = "storageLocEdit";
            this.storageLocEdit.Size = new System.Drawing.Size(141, 27);
            this.storageLocEdit.TabIndex = 30;
            // 
            // EditGageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 351);
            this.Controls.Add(this.intervalTypeEdit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.intervalEdit);
            this.Controls.Add(this.dueDateDTP_Edit);
            this.Controls.Add(this.lastCalDTP_Edit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusEdit);
            this.Controls.Add(this.activeEdit);
            this.Controls.Add(this.currentLocEdit);
            this.Controls.Add(this.gageTypeEdit);
            this.Controls.Add(this.gageNumEdit);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.storageLocEdit);
            this.Name = "EditGageForm";
            this.Text = "Edit Gage Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox intervalTypeEdit;
        private Label label10;
        private TextBox intervalEdit;
        private DateTimePicker dueDateDTP_Edit;
        private DateTimePicker lastCalDTP_Edit;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox statusEdit;
        private TextBox activeEdit;
        private TextBox currentLocEdit;
        private TextBox gageTypeEdit;
        private TextBox gageNumEdit;
        private Button saveButton;
        public TextBox storageLocEdit;
    }
}