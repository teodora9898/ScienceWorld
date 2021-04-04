
namespace ScienceWorld.Forms
{
    partial class OtherArticlesForm
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
            this.otherArticlesListBox = new System.Windows.Forms.ListBox();
            this.titleComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fieldComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createrComboBox = new System.Windows.Forms.ComboBox();
            this.showArticleButton = new System.Windows.Forms.Button();
            this.articleCommentsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // otherArticlesListBox
            // 
            this.otherArticlesListBox.FormattingEnabled = true;
            this.otherArticlesListBox.ItemHeight = 20;
            this.otherArticlesListBox.Location = new System.Drawing.Point(93, 198);
            this.otherArticlesListBox.Name = "otherArticlesListBox";
            this.otherArticlesListBox.Size = new System.Drawing.Size(613, 104);
            this.otherArticlesListBox.TabIndex = 0;
            // 
            // titleComboBox
            // 
            this.titleComboBox.FormattingEnabled = true;
            this.titleComboBox.Location = new System.Drawing.Point(254, 139);
            this.titleComboBox.Name = "titleComboBox";
            this.titleComboBox.Size = new System.Drawing.Size(151, 28);
            this.titleComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose science field:";
            // 
            // fieldComboBox
            // 
            this.fieldComboBox.FormattingEnabled = true;
            this.fieldComboBox.Location = new System.Drawing.Point(254, 42);
            this.fieldComboBox.Name = "fieldComboBox";
            this.fieldComboBox.Size = new System.Drawing.Size(151, 28);
            this.fieldComboBox.TabIndex = 3;
            this.fieldComboBox.SelectedIndexChanged += new System.EventHandler(this.fieldComboBox_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose article title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose article creator:";
            // 
            // createrComboBox
            // 
            this.createrComboBox.FormattingEnabled = true;
            this.createrComboBox.Location = new System.Drawing.Point(254, 85);
            this.createrComboBox.Name = "createrComboBox";
            this.createrComboBox.Size = new System.Drawing.Size(151, 28);
            this.createrComboBox.TabIndex = 6;
            this.createrComboBox.SelectedIndexChanged += new System.EventHandler(this.createrComboBox_SelectedIndexChanged);
            // 
            // showArticleButton
            // 
            this.showArticleButton.Location = new System.Drawing.Point(93, 343);
            this.showArticleButton.Name = "showArticleButton";
            this.showArticleButton.Size = new System.Drawing.Size(109, 29);
            this.showArticleButton.TabIndex = 7;
            this.showArticleButton.Text = "Show article";
            this.showArticleButton.UseVisualStyleBackColor = true;
            this.showArticleButton.Click += new System.EventHandler(this.showArticleButton_Click);
            // 
            // articleCommentsButton
            // 
            this.articleCommentsButton.Location = new System.Drawing.Point(254, 343);
            this.articleCommentsButton.Name = "articleCommentsButton";
            this.articleCommentsButton.Size = new System.Drawing.Size(134, 29);
            this.articleCommentsButton.TabIndex = 8;
            this.articleCommentsButton.Text = "Show comments";
            this.articleCommentsButton.UseVisualStyleBackColor = true;
            this.articleCommentsButton.Click += new System.EventHandler(this.articleCommentsButton_Click);
            // 
            // OtherArticlesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.articleCommentsButton);
            this.Controls.Add(this.showArticleButton);
            this.Controls.Add(this.createrComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fieldComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleComboBox);
            this.Controls.Add(this.otherArticlesListBox);
            this.Name = "OtherArticlesForm";
            this.Text = "OtherArticlesForm";
            this.Load += new System.EventHandler(this.OtherArticlesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox otherArticlesListBox;
        private System.Windows.Forms.ComboBox titleComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fieldComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox createrComboBox;
        private System.Windows.Forms.Button showArticleButton;
        private System.Windows.Forms.Button articleCommentsButton;
    }
}