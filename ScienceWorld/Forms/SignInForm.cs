using ScienceWorld.Queries;
using System;
using System.Windows.Forms;

namespace ScienceWorld.Forms
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            var user = UserQueries.GetUserByUsernameAndPassword(usernameSignInTextBox.Text, passwordSignInTextBox.Text);
            if (user == null)
            {
                MessageBox.Show("Username or password is incorrect! Please try again!");
            }
            else
            {
                Global.ActiveUser = user;
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();

            }
        }
    }
}
