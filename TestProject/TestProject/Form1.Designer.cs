namespace TestProject
{
    partial class Form1
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
            this.topLeftButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // topLeftButton
            // 
            this.topLeftButton.Location = new System.Drawing.Point(12, 12);
            this.topLeftButton.Name = "topLeftButton";
            this.topLeftButton.Size = new System.Drawing.Size(75, 23);
            this.topLeftButton.TabIndex = 0;
            this.topLeftButton.Text = "Top Left";
            this.topLeftButton.Click += new System.EventHandler(this.topLeftButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 278);
            this.Controls.Add(this.topLeftButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton topLeftButton;
    }
}

