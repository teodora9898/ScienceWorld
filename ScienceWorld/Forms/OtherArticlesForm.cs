using ScienceWorld.Entities;
using ScienceWorld.Queries;
using System;
using System.Windows.Forms;

namespace ScienceWorld.Forms
{
    public partial class OtherArticlesForm : Form
    {
        public OtherArticlesForm()
        {
            InitializeComponent();
        }

        private void OtherArticlesForm_Load(object sender, EventArgs e)
        {
            var types = Enum.GetValues(typeof(Enums.ScienceField));
            foreach (var t in types)
            {
                fieldComboBox.Items.Add(t);
            }
        }

        private void fieldComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            createrComboBox.Items.Clear();
            var articles = ArticleQueries.GetArticleByOnlyScienceField(fieldComboBox.SelectedItem.ToString());
            foreach (Article art in articles)
            {
                createrComboBox.Items.Add(art.username);
            }
        }

        private void createrComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            titleComboBox.Items.Clear();
            var articles = ArticleQueries.GetArticleByScienceField(createrComboBox.SelectedItem.ToString(), fieldComboBox.SelectedItem.ToString());
            foreach(Article art in articles)
            {
                titleComboBox.Items.Add(art.title);
            }
        }

        private void showArticleButton_Click(object sender, EventArgs e)
        {
            var articles = ArticleQueries.GetArticleByScienceFieldAndTitle(createrComboBox.SelectedItem.ToString(), fieldComboBox.SelectedItem.ToString(), titleComboBox.SelectedItem.ToString());
            foreach (Article art in articles)
            {
                otherArticlesListBox.Items.Add(art.articletext);
            }
        }

        private void articleCommentsButton_Click(object sender, EventArgs e)
        {
            if (otherArticlesListBox.SelectedIndex > -1)
            {
                var articles = ArticleQueries.GetArticleByScienceFieldAndTitle(createrComboBox.SelectedItem.ToString(), fieldComboBox.SelectedItem.ToString(), titleComboBox.SelectedItem.ToString());
                var art = articles[otherArticlesListBox.SelectedIndex];
                Global.GlobalArticle = art;
                CommentForm commentForm = new CommentForm();
                commentForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You have to choose an article you want to show comments for!");
            }
        }
    }
}
