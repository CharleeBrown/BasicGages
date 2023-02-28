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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Users newUser = new Users();

            newUser.SetUser(createUserTxt.Text, createVerifyPass.Text);

            MainForm form = new MainForm();
            LoginForm.ActiveForm.Close();
            form.ShowDialog();
            
        }
    }
}
