namespace ScienceWorld.Forms
{
    partial class MainForm
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
            this.UserFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserFormButton
            // 
            this.UserFormButton.Location = new System.Drawing.Point(65, 60);
            this.UserFormButton.Name = "UserFormButton";
            this.UserFormButton.Size = new System.Drawing.Size(108, 39);
            this.UserFormButton.TabIndex = 0;
            this.UserFormButton.Text = "User";
            this.UserFormButton.UseVisualStyleBackColor = true;
            this.UserFormButton.Click += new System.EventHandler(this.UserFormButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 314);
            this.Controls.Add(this.UserFormButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserFormButton;
    }
}