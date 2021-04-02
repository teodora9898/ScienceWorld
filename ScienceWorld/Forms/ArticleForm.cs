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
            var articles = ArticleQueries.GetArticleByUsername(Global.ActiveUser.username);
            foreach(Article art in articles)
            {
                Articles.Items.Add(art.articletext);
            }
        }

        private void addArticleButton_Click(object sender, EventArgs e)
        {
            AddArticleForm addArticleForm = new AddArticleForm();
            addArticleForm.ShowDialog();
        }
    }
}
