using ScienceWorld.Queries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScienceWorld.Forms
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            UserQueries.AddUser(nameTextBox.Text, surnameTextBox.Text, passwordTextBox.Text, usernameTextBox.Text, emailTextBox.Text, descriptionTextBox.Text, birthdayDateTimePicker.Value.ToString("yyyy'-'MM'-'dd"), townTextBox.Text);
        }
    }
}
