
namespace ScienceWorld.Forms
{
    partial class ArticleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myArticlesButton = new System.Windows.Forms.Button();
            this.Articles = new System.Windows.Forms.ListBox();
            this.addArticleButton = new System.Windows.Forms.Button();
            this.deleteArticleButton = new System.Windows.Forms.Button();
            this.otherArticlesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myArticlesButton
            // 
            this.myArticlesButton.Location = new System.Drawing.Point(66, 311);
            this.myArticlesButton.Name = "myArticlesButton";
            this.myArticlesButton.Size = new System.Drawing.Size(114, 46);
            this.myArticlesButton.TabIndex = 0;
            this.myArticlesButton.Text = "My articles";
            this.myArticlesButton.UseVisualStyleBackColor = true;
            this.myArticlesButton.Click += new System.EventHandler(this.myArticlesButton_Click);
            // 
            // Articles
            // 
            this.Articles.FormattingEnabled = true;
            this.Articles.ItemHeight = 20;
            this.Articles.Location = new System.Drawing.Point(66, 35);
            this.Articles.Name = "Articles";
            this.Articles.Size = new System.Drawing.Size(633, 124);
            this.Articles.TabIndex = 1;
            // 
            // addArticleButton
            // 
            this.addArticleButton.Location = new System.Drawing.Point(238, 311);
            this.addArticleButton.Name = "addArticleButton";
            this.addArticleButton.Size = new System.Drawing.Size(114, 46);
            this.addArticleButton.TabIndex = 2;
            this.addArticleButton.Text = "Add article";
            this.addArticleButton.UseVisualStyleBackColor = true;
            this.addArticleButton.Click += new System.EventHandler(this.addArticleButton_Click);
            // 
            // deleteArticleButton
            // 
            this.deleteArticleButton.Location = new System.Drawing.Point(408, 311);
            this.deleteArticleButton.Name = "deleteArticleButton";
            this.deleteArticleButton.Size = new System.Drawing.Size(114, 46);
            this.deleteArticleButton.TabIndex = 3;
            this.deleteArticleButton.Text = "Delete article";
            this.deleteArticleButton.UseVisualStyleBackColor = true;
            // 
            // otherArticlesButton
            // 
            this.otherArticlesButton.Location = new System.Drawing.Point(585, 311);
            this.otherArticlesButton.Name = "otherArticlesButton";
            this.otherArticlesButton.Size = new System.Drawing.Size(114, 46);
            this.otherArticlesButton.TabIndex = 4;
            this.otherArticlesButton.Text = "Other Articles";
            this.otherArticlesButton.UseVisualStyleBackColor = true;
            this.otherArticlesButton.Click += new System.EventHandler(this.otherArticlesButton_Click);
            // 
            // ArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.otherArticlesButton);
            this.Controls.Add(this.deleteArticleButton);
            this.Controls.Add(this.addArticleButton);
            this.Controls.Add(this.Articles);
            this.Controls.Add(this.myArticlesButton);
            this.Name = "ArticleForm";
            this.Text = "ArticleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button myArticlesButton;
        private System.Windows.Forms.ListBox Articles;
        private System.Windows.Forms.Button addArticleButton;
        private System.Windows.Forms.Button deleteArticleButton;
        private System.Windows.Forms.Button otherArticlesButton;
    }
}