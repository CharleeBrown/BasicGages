namespace BasicGages
{
    partial class LoginForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.createBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.createVerifyPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createPass = new System.Windows.Forms.TextBox();
            this.createUserTxt = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginPassBox = new System.Windows.Forms.TextBox();
            this.userLoginBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(359, 272);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.createBtn);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.createVerifyPass);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.createPass);
            this.tabPage1.Controls.Add(this.createUserTxt);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(351, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create User";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(148, 190);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(107, 30);
            this.createBtn.TabIndex = 6;
            this.createBtn.Text = "Login";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Verify Password";
            // 
            // createVerifyPass
            // 
            this.createVerifyPass.Location = new System.Drawing.Point(131, 144);
            this.createVerifyPass.Name = "createVerifyPass";
            this.createVerifyPass.PasswordChar = '*';
            this.createVerifyPass.Size = new System.Drawing.Size(182, 27);
            this.createVerifyPass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // createPass
            // 
            this.createPass.Location = new System.Drawing.Point(131, 87);
            this.createPass.Name = "createPass";
            this.createPass.PasswordChar = '*';
            this.createPass.Size = new System.Drawing.Size(182, 27);
            this.createPass.TabIndex = 1;
            // 
            // createUserTxt
            // 
            this.createUserTxt.Location = new System.Drawing.Point(131, 30);
            this.createUserTxt.Name = "createUserTxt";
            this.createUserTxt.Size = new System.Drawing.Size(182, 27);
            this.createUserTxt.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.loginBtn);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.loginPassBox);
            this.tabPage2.Controls.Add(this.userLoginBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(351, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Login";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(127, 179);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(107, 30);
            this.loginBtn.TabIndex = 8;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username";
            // 
            // loginPassBox
            // 
            this.loginPassBox.Location = new System.Drawing.Point(127, 102);
            this.loginPassBox.Name = "loginPassBox";
            this.loginPassBox.Size = new System.Drawing.Size(182, 27);
            this.loginPassBox.TabIndex = 5;
            // 
            // userLoginBox
            // 
            this.userLoginBox.Location = new System.Drawing.Point(127, 45);
            this.userLoginBox.Name = "userLoginBox";
            this.userLoginBox.Size = new System.Drawing.Size(182, 27);
            this.userLoginBox.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 274);
            this.Controls.Add(this.tabControl1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button createBtn;
        private Label label5;
        private TextBox createVerifyPass;
        private Label label2;
        private Label label1;
        private TextBox createPass;
        private TextBox createUserTxt;
        private TabPage tabPage2;
        private Button loginBtn;
        private Label label3;
        private Label label4;
        private TextBox loginPassBox;
        private TextBox userLoginBox;
    }
}