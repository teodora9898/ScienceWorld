using ScienceWorld.Queries;
using System;
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
            if (UserQueries.GetUserByUsername(usernameTextBox.Text).username == usernameTextBox.Text)
            {
                MessageBox.Show("This username already exists! Please choose another one!");
            }
            else
            {
                UserQueries.AddUser(nameTextBox.Text, surnameTextBox.Text, passwordTextBox.Text, usernameTextBox.Text, emailTextBox.Text, descriptionTextBox.Text, birthdayDateTimePicker.Value.ToString("yyyy'-'MM'-'dd"), townTextBox.Text);
                MessageBox.Show("You have successfully signed up! Please sign in now!");
            }
        }
    }
}
