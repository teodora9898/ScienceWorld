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
    public partial class CommentForm : Form
    {
        public CommentForm()
        {
            InitializeComponent();
        }

        private void deleteCommentButton_Click(object sender, EventArgs e)
        {
            if (allCommentsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select comment from the list!");
            }
            else
            {
                int index = allCommentsListBox.SelectedIndex;
                var comments = CommentQueries.GetAllComments();
                var comment = comments[index];
                if (comment.username != Global.ActiveUser.username)
                {
                    MessageBox.Show("You can not delete comment which you did not post!");
                }
                var dateadded = comment.dateadded.ToString("yyyy-MM-dd HH:mm:ss");
                CommentQueries.DeleteComment(dateadded);
                if (CommentQueries.GetCommentByDateAndUsername(allCommentsListBox.SelectedItem.ToString(), dateadded) == null)
                {
                    MessageBox.Show("You have successfully deleted comment!");
                    allCommentsListBox.Items.Clear();

                    var commentsList = CommentQueries.GetAllComments();
                    foreach (var item in commentsList)
                    {
                        allCommentsListBox.Items.Add(item.text);
                    }
                }
                
            }

        }

        private void addCommentButton_Click(object sender, EventArgs e)
        { 
            if (String.IsNullOrEmpty(myCommentTextBox.Text.ToString()))
            {
                MessageBox.Show("Please write your comment in textbox!"); 
            }
            else
            {
                allCommentsListBox.Items.Clear();

                CommentQueries.AddCommentForArticle(myCommentTextBox.Text);
                var comments = CommentQueries.GetAllComments();
                foreach (var item in comments)
                {
                    allCommentsListBox.Items.Add(item.text);
                }
            }
        }

        private void updateCommentButton_Click(object sender, EventArgs e)
        {
            var comments = CommentQueries.GetAllComments();
            int index = allCommentsListBox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Please select comment to update!");
            }
            else if (comments[index].username != Global.ActiveUser.username)
            {
                MessageBox.Show("You can not update comment which is not yours!");
            }
            else if (String.IsNullOrEmpty(myCommentTextBox.Text))
            {
                MessageBox.Show("Please write new version of comment in textbox");
            }
            else
            {
                allCommentsListBox.Items.Clear();
                var comment = comments[index];
                var dateadded = comment.dateadded.ToString("yyyy-MM-dd HH:mm:ss");
                CommentQueries.UpdateComment(dateadded, myCommentTextBox.Text.ToString());
                var commentsList = CommentQueries.GetAllComments();
                foreach (var item in commentsList)
                {
                    allCommentsListBox.Items.Add(item.text);
                }
            }
        }

        private void CommentForm_Load(object sender, EventArgs e)
        {
            //ovo treba prepraviti za article
            var comments = CommentQueries.GetAllComments();
            foreach (var item in comments)
            {
                allCommentsListBox.Items.Add(item.text);
            }
        }
    }
}
