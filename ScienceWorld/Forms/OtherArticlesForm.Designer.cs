
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
            this.SuspendLayout();
            // 
            // otherArticlesListBox
            // 
            this.otherArticlesListBox.FormattingEnabled = true;
            this.otherArticlesListBox.ItemHeight = 20;
            this.otherArticlesListBox.Location = new System.Drawing.Point(77, 50);
            this.otherArticlesListBox.Name = "otherArticlesListBox";
            this.otherArticlesListBox.Size = new System.Drawing.Size(613, 104);
            this.otherArticlesListBox.TabIndex = 0;
            // 
            // OtherArticlesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.otherArticlesListBox);
            this.Name = "OtherArticlesForm";
            this.Text = "OtherArticlesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox otherArticlesListBox;
    }
}