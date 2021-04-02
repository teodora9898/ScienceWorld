using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

        private void commentsButton_Click(object sender, EventArgs e)
        {
            CommentForm commentForm = new CommentForm();
            commentForm.ShowDialog();
        }
    }
}
