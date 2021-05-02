using ScienceWorld.Entities;
using ScienceWorld.Queries;
using System;
using System.Windows.Forms;

namespace ScienceWorld.Forms
{
    public partial class ArticleForm : Form
    {
        public ArticleForm()
        {
            InitializeComponent();
        }

        private void otherArticlesButton_Click(object sender, EventArgs e)
        {
            OtherArticlesForm otherArticlesForm = new OtherArticlesForm();
            otherArticlesForm.ShowDialog();
        }

        private void myArticlesButton_Click(object sender, EventArgs e)
        {
            if (articleTitleComboBox != null)
            {
                Articles.Items.Clear();
                var articles = ArticleQueries.GetArticleByScienceFieldAndTitle(Global.ActiveUser.username, fieldOfScienceComboBox.SelectedItem.ToString(), articleTitleComboBox.SelectedItem.ToString());
                foreach (Article art in articles)
                {
                    Articles.Items.Add(art.articletext);
                }
            }
            else
            {
                MessageBox.Show("You have to choose science field and title of an article you want!");
            }
        }

        private void addArticleButton_Click(object sender, EventArgs e)
        {
            AddArticleForm addArticleForm = new AddArticleForm();
            addArticleForm.ShowDialog();
        }

        private void deleteArticleButton_Click(object sender, EventArgs e)
        {
            if (Articles.SelectedIndex > -1)
            {
                ArticleQueries.DeleteArticle(Global.ActiveUser.username, fieldOfScienceComboBox.SelectedItem.ToString(), articleTitleComboBox.SelectedItem.ToString());
                Articles.Items.RemoveAt(Articles.SelectedIndex);
            }
            else
            {
                MessageBox.Show("You have to choose an article you want to delete first!");
            }
        }

        private void ArticleForm_Load(object sender, EventArgs e)
        {
            var types = Enum.GetValues(typeof(Enums.ScienceField));
            foreach (var t in types)
            {
                fieldOfScienceComboBox.Items.Add(t);
            }
        }

        private void fieldOfScienceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            articleTitleComboBox.Items.Clear();
            articleTitleComboBox.Items.Clear();
            var articles = ArticleQueries.GetArticleByScienceField(Global.ActiveUser.username, fieldOfScienceComboBox.SelectedItem.ToString());
            foreach (Article art in articles)
            {
                articleTitleComboBox.Items.Add(art.title);
            }
        }
    }
}
