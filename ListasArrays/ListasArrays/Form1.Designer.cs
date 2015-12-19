namespace ListasArrays
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
            this.listButton = new System.Windows.Forms.Button();
            this.arrayButton = new System.Windows.Forms.Button();
            this.hashTableButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(102, 38);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(75, 23);
            this.listButton.TabIndex = 0;
            this.listButton.Text = "List";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // arrayButton
            // 
            this.arrayButton.Location = new System.Drawing.Point(102, 67);
            this.arrayButton.Name = "arrayButton";
            this.arrayButton.Size = new System.Drawing.Size(75, 23);
            this.arrayButton.TabIndex = 1;
            this.arrayButton.Text = "Array";
            this.arrayButton.UseVisualStyleBackColor = true;
            this.arrayButton.Click += new System.EventHandler(this.arrayButton_Click);
            // 
            // hashTableButton
            // 
            this.hashTableButton.Location = new System.Drawing.Point(102, 96);
            this.hashTableButton.Name = "hashTableButton";
            this.hashTableButton.Size = new System.Drawing.Size(75, 23);
            this.hashTableButton.TabIndex = 2;
            this.hashTableButton.Text = "Hash Table";
            this.hashTableButton.UseVisualStyleBackColor = true;
            this.hashTableButton.Click += new System.EventHandler(this.hashTableButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.hashTableButton);
            this.Controls.Add(this.arrayButton);
            this.Controls.Add(this.listButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button arrayButton;
        private System.Windows.Forms.Button hashTableButton;
    }
}

