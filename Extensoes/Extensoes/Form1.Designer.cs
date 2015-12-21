namespace Extensoes
{
    partial class Extensoes
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
            this.stringExtensionsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stringExtensionsButton
            // 
            this.stringExtensionsButton.Location = new System.Drawing.Point(87, 112);
            this.stringExtensionsButton.Name = "stringExtensionsButton";
            this.stringExtensionsButton.Size = new System.Drawing.Size(93, 23);
            this.stringExtensionsButton.TabIndex = 0;
            this.stringExtensionsButton.Text = "StringExtensions";
            this.stringExtensionsButton.UseVisualStyleBackColor = true;
            this.stringExtensionsButton.Click += new System.EventHandler(this.stringExtensionsButton_Click);
            // 
            // Extensoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.stringExtensionsButton);
            this.Name = "Extensoes";
            this.Text = "Extensões";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stringExtensionsButton;
    }
}

