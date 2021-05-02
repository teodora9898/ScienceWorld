
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
            this.fieldOfScienceComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.articleTitleComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // myArticlesButton
            // 
            this.myArticlesButton.Location = new System.Drawing.Point(66, 358);
            this.myArticlesButton.Name = "myArticlesButton";
            this.myArticlesButton.Size = new System.Drawing.Size(114, 54);
            this.myArticlesButton.TabIndex = 0;
            this.myArticlesButton.Text = "Show my articles";
            this.myArticlesButton.UseVisualStyleBackColor = true;
            this.myArticlesButton.Click += new System.EventHandler(this.myArticlesButton_Click);
            // 
            // Articles
            // 
            this.Articles.FormattingEnabled = true;
            this.Articles.ItemHeight = 20;
            this.Articles.Location = new System.Drawing.Point(66, 190);
            this.Articles.Name = "Articles";
            this.Articles.Size = new System.Drawing.Size(633, 124);
            this.Articles.TabIndex = 1;
            // 
            // addArticleButton
            // 
            this.addArticleButton.Location = new System.Drawing.Point(229, 358);
            this.addArticleButton.Name = "addArticleButton";
            this.addArticleButton.Size = new System.Drawing.Size(114, 54);
            this.addArticleButton.TabIndex = 2;
            this.addArticleButton.Text = "Add article";
            this.addArticleButton.UseVisualStyleBackColor = true;
            this.addArticleButton.Click += new System.EventHandler(this.addArticleButton_Click);
            // 
            // deleteArticleButton
            // 
            this.deleteArticleButton.Location = new System.Drawing.Point(414, 358);
            this.deleteArticleButton.Name = "deleteArticleButton";
            this.deleteArticleButton.Size = new System.Drawing.Size(114, 54);
            this.deleteArticleButton.TabIndex = 3;
            this.deleteArticleButton.Text = "Delete article";
            this.deleteArticleButton.UseVisualStyleBackColor = true;
            this.deleteArticleButton.Click += new System.EventHandler(this.deleteArticleButton_Click);
            // 
            // otherArticlesButton
            // 
            this.otherArticlesButton.Location = new System.Drawing.Point(585, 358);
            this.otherArticlesButton.Name = "otherArticlesButton";
            this.otherArticlesButton.Size = new System.Drawing.Size(114, 54);
            this.otherArticlesButton.TabIndex = 4;
            this.otherArticlesButton.Text = "Other Articles";
            this.otherArticlesButton.UseVisualStyleBackColor = true;
            this.otherArticlesButton.Click += new System.EventHandler(this.otherArticlesButton_Click);
            // 
            // fieldOfScienceComboBox
            // 
            this.fieldOfScienceComboBox.FormattingEnabled = true;
            this.fieldOfScienceComboBox.Location = new System.Drawing.Point(229, 29);
            this.fieldOfScienceComboBox.Name = "fieldOfScienceComboBox";
            this.fieldOfScienceComboBox.Size = new System.Drawing.Size(165, 28);
            this.fieldOfScienceComboBox.TabIndex = 5;
            this.fieldOfScienceComboBox.SelectedIndexChanged += new System.EventHandler(this.fieldOfScienceComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose science field:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choose article title:";
            // 
            // articleTitleComboBox
            // 
            this.articleTitleComboBox.FormattingEnabled = true;
            this.articleTitleComboBox.Location = new System.Drawing.Point(229, 91);
            this.articleTitleComboBox.Name = "articleTitleComboBox";
            this.articleTitleComboBox.Size = new System.Drawing.Size(165, 28);
            this.articleTitleComboBox.TabIndex = 8;
            // 
            // ArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.articleTitleComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fieldOfScienceComboBox);
            this.Controls.Add(this.otherArticlesButton);
            this.Controls.Add(this.deleteArticleButton);
            this.Controls.Add(this.addArticleButton);
            this.Controls.Add(this.Articles);
            this.Controls.Add(this.myArticlesButton);
            this.Name = "ArticleForm";
            this.Text = "ArticleForm";
            this.Load += new System.EventHandler(this.ArticleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button myArticlesButton;
        private System.Windows.Forms.ListBox Articles;
        private System.Windows.Forms.Button addArticleButton;
        private System.Windows.Forms.Button deleteArticleButton;
        private System.Windows.Forms.Button otherArticlesButton;
        private System.Windows.Forms.ComboBox fieldOfScienceComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox articleTitleComboBox;
    }
}