namespace ManipularStrings
{
    partial class manipularStrings
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
            this.concatenacaoButton = new System.Windows.Forms.Button();
            this.interpolacaoButton = new System.Windows.Forms.Button();
            this.splitButton = new System.Windows.Forms.Button();
            this.toUpperButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.substringButton = new System.Windows.Forms.Button();
            this.indexOfButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // concatenacaoButton
            // 
            this.concatenacaoButton.Location = new System.Drawing.Point(99, 31);
            this.concatenacaoButton.Name = "concatenacaoButton";
            this.concatenacaoButton.Size = new System.Drawing.Size(85, 23);
            this.concatenacaoButton.TabIndex = 0;
            this.concatenacaoButton.Text = "Concatenação";
            this.concatenacaoButton.UseVisualStyleBackColor = true;
            this.concatenacaoButton.Click += new System.EventHandler(this.concatenacaoButton_Click);
            // 
            // interpolacaoButton
            // 
            this.interpolacaoButton.Location = new System.Drawing.Point(99, 61);
            this.interpolacaoButton.Name = "interpolacaoButton";
            this.interpolacaoButton.Size = new System.Drawing.Size(85, 23);
            this.interpolacaoButton.TabIndex = 1;
            this.interpolacaoButton.Text = "Interpolação";
            this.interpolacaoButton.UseVisualStyleBackColor = true;
            this.interpolacaoButton.Click += new System.EventHandler(this.interpolacaoButton_Click);
            // 
            // splitButton
            // 
            this.splitButton.Location = new System.Drawing.Point(102, 90);
            this.splitButton.Name = "splitButton";
            this.splitButton.Size = new System.Drawing.Size(75, 23);
            this.splitButton.TabIndex = 2;
            this.splitButton.Text = "Split";
            this.splitButton.UseVisualStyleBackColor = true;
            this.splitButton.Click += new System.EventHandler(this.splitButton_Click);
            // 
            // toUpperButton
            // 
            this.toUpperButton.Location = new System.Drawing.Point(102, 120);
            this.toUpperButton.Name = "toUpperButton";
            this.toUpperButton.Size = new System.Drawing.Size(75, 23);
            this.toUpperButton.TabIndex = 3;
            this.toUpperButton.Text = "To Upper";
            this.toUpperButton.UseVisualStyleBackColor = true;
            this.toUpperButton.Click += new System.EventHandler(this.toUpperButton_Click);
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(102, 150);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(75, 23);
            this.replaceButton.TabIndex = 4;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // substringButton
            // 
            this.substringButton.Location = new System.Drawing.Point(102, 180);
            this.substringButton.Name = "substringButton";
            this.substringButton.Size = new System.Drawing.Size(75, 23);
            this.substringButton.TabIndex = 5;
            this.substringButton.Text = "Substring";
            this.substringButton.UseVisualStyleBackColor = true;
            this.substringButton.Click += new System.EventHandler(this.substringButton_Click);
            // 
            // indexOfButton
            // 
            this.indexOfButton.Location = new System.Drawing.Point(102, 210);
            this.indexOfButton.Name = "indexOfButton";
            this.indexOfButton.Size = new System.Drawing.Size(75, 23);
            this.indexOfButton.TabIndex = 6;
            this.indexOfButton.Text = "IndexOf";
            this.indexOfButton.UseVisualStyleBackColor = true;
            this.indexOfButton.Click += new System.EventHandler(this.indexOfButton_Click);
            // 
            // manipularStrings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.indexOfButton);
            this.Controls.Add(this.substringButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.toUpperButton);
            this.Controls.Add(this.splitButton);
            this.Controls.Add(this.interpolacaoButton);
            this.Controls.Add(this.concatenacaoButton);
            this.Name = "manipularStrings";
            this.Text = "Manipular Strings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button concatenacaoButton;
        private System.Windows.Forms.Button interpolacaoButton;
        private System.Windows.Forms.Button splitButton;
        private System.Windows.Forms.Button toUpperButton;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button substringButton;
        private System.Windows.Forms.Button indexOfButton;
    }
}

