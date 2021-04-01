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
    }
}
