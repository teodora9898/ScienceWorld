
namespace ScienceWorld.Forms
{
    partial class AddArticleForm
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scienceFieldComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Article = new System.Windows.Forms.RichTextBox();
            this.addArticleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(321, 139);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(173, 27);
            this.titleTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            // 
            // scienceFieldComboBox
            // 
            this.scienceFieldComboBox.FormattingEnabled = true;
            this.scienceFieldComboBox.Location = new System.Drawing.Point(321, 36);
            this.scienceFieldComboBox.Name = "scienceFieldComboBox";
            this.scienceFieldComboBox.Size = new System.Drawing.Size(173, 28);
            this.scienceFieldComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Science field:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Science subfield:";
            // 
            // Article
            // 
            this.Article.Location = new System.Drawing.Point(133, 192);
            this.Article.Name = "Article";
            this.Article.Size = new System.Drawing.Size(401, 189);
            this.Article.TabIndex = 6;
            this.Article.Text = "";
            // 
            // addArticleButton
            // 
            this.addArticleButton.Location = new System.Drawing.Point(282, 398);
            this.addArticleButton.Name = "addArticleButton";
            this.addArticleButton.Size = new System.Drawing.Size(94, 29);
            this.addArticleButton.TabIndex = 7;
            this.addArticleButton.Text = "Add article";
            this.addArticleButton.UseVisualStyleBackColor = true;
            this.addArticleButton.Click += new System.EventHandler(this.addArticleButton_Click);
            // 
            // AddArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.addArticleButton);
            this.Controls.Add(this.Article);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scienceFieldComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleTextBox);
            this.Name = "AddArticleForm";
            this.Text = "AddArticleForm";
            this.Load += new System.EventHandler(this.AddArticleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox scienceFieldComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Article;
        private System.Windows.Forms.Button addArticleButton;
    }
}