using System;
using System.Windows.Forms;

namespace ScienceWorld.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UserFormButton_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.ShowDialog();

        }

        private void articlesButton_Click(object sender, EventArgs e)
        {
            ArticleForm articleForm = new ArticleForm();
            articleForm.ShowDialog();
        }
    }
}
