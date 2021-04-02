namespace ScienceWorld.Forms
{
    partial class CommentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.allCommentsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteCommentButton = new System.Windows.Forms.Button();
            this.myCommentTextBox = new System.Windows.Forms.TextBox();
            this.addCommentButton = new System.Windows.Forms.Button();
            this.updateCommentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Double click the item in the list below\r\nto see full comment";
            // 
            // allCommentsListBox
            // 
            this.allCommentsListBox.FormattingEnabled = true;
            this.allCommentsListBox.ItemHeight = 20;
            this.allCommentsListBox.Location = new System.Drawing.Point(24, 78);
            this.allCommentsListBox.Name = "allCommentsListBox";
            this.allCommentsListBox.Size = new System.Drawing.Size(195, 144);
            this.allCommentsListBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose comment from list above \r\nthen cilck button below to delete it";
            // 
            // deleteCommentButton
            // 
            this.deleteCommentButton.Location = new System.Drawing.Point(24, 288);
            this.deleteCommentButton.Name = "deleteCommentButton";
            this.deleteCommentButton.Size = new System.Drawing.Size(103, 50);
            this.deleteCommentButton.TabIndex = 3;
            this.deleteCommentButton.Text = "Delete comment";
            this.deleteCommentButton.UseVisualStyleBackColor = true;
            this.deleteCommentButton.Click += new System.EventHandler(this.deleteCommentButton_Click);
            // 
            // myCommentTextBox
            // 
            this.myCommentTextBox.Location = new System.Drawing.Point(386, 62);
            this.myCommentTextBox.Multiline = true;
            this.myCommentTextBox.Name = "myCommentTextBox";
            this.myCommentTextBox.Size = new System.Drawing.Size(226, 160);
            this.myCommentTextBox.TabIndex = 4;
            // 
            // addCommentButton
            // 
            this.addCommentButton.Location = new System.Drawing.Point(390, 255);
            this.addCommentButton.Name = "addCommentButton";
            this.addCommentButton.Size = new System.Drawing.Size(125, 49);
            this.addCommentButton.TabIndex = 5;
            this.addCommentButton.Text = "Add comment";
            this.addCommentButton.UseVisualStyleBackColor = true;
            this.addCommentButton.Click += new System.EventHandler(this.addCommentButton_Click);
            // 
            // updateCommentButton
            // 
            this.updateCommentButton.Location = new System.Drawing.Point(390, 331);
            this.updateCommentButton.Name = "updateCommentButton";
            this.updateCommentButton.Size = new System.Drawing.Size(125, 54);
            this.updateCommentButton.TabIndex = 6;
            this.updateCommentButton.Text = "Update comment";
            this.updateCommentButton.UseVisualStyleBackColor = true;
            this.updateCommentButton.Click += new System.EventHandler(this.updateCommentButton_Click);
            // 
            // CommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateCommentButton);
            this.Controls.Add(this.addCommentButton);
            this.Controls.Add(this.myCommentTextBox);
            this.Controls.Add(this.deleteCommentButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.allCommentsListBox);
            this.Controls.Add(this.label1);
            this.Name = "CommentForm";
            this.Text = "CommentForm";
            this.Load += new System.EventHandler(this.CommentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox allCommentsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteCommentButton;
        private System.Windows.Forms.TextBox myCommentTextBox;
        private System.Windows.Forms.Button addCommentButton;
        private System.Windows.Forms.Button updateCommentButton;
    }
}