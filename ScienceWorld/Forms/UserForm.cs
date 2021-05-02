using ScienceWorld.Queries;
using System;
using System.Windows.Forms;

namespace ScienceWorld.Forms
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void updatePasswordButton_Click(object sender, EventArgs e)
        {
            UserQueries.UpdatePassword(newPasswordTextBox.Text);
        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            UserQueries.DeleteUsersAccount();
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name != "Form1")
                    f.Close();
            }
        }
    }
}
