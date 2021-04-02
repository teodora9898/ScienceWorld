using System;
using System.Windows.Forms;


namespace ScienceWorld.Forms
{
    public partial class AddArticleForm : Form
    {
        public AddArticleForm()
        {
            InitializeComponent();
        }

        private void addArticleButton_Click(object sender, EventArgs e)
        {
            Queries.ArticleQueries.AddArticle(titleTextBox.Text, scienceFieldComboBox.SelectedItem.ToString(), Article.Text, DateTime.Now.ToString("yyyy'-'MM'-'dd"));
        }

        private void AddArticleForm_Load(object sender, EventArgs e)
        {
            var types = Enum.GetValues(typeof(Enums.ScienceField));
            foreach(var t in types)
            {
                scienceFieldComboBox.Items.Add(t);
            }
        }
    }
}
