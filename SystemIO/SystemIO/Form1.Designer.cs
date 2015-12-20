namespace SystemIO
{
    partial class SystemIO
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
            this.fileUrlLabel = new System.Windows.Forms.Label();
            this.fileUrlTextBox = new System.Windows.Forms.TextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.textoLabel = new System.Windows.Forms.Label();
            this.mesageTextBox = new System.Windows.Forms.TextBox();
            this.salvarTextoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileUrlLabel
            // 
            this.fileUrlLabel.AutoSize = true;
            this.fileUrlLabel.Location = new System.Drawing.Point(24, 41);
            this.fileUrlLabel.Name = "fileUrlLabel";
            this.fileUrlLabel.Size = new System.Drawing.Size(85, 13);
            this.fileUrlLabel.TabIndex = 0;
            this.fileUrlLabel.Text = "URL do arquivo:";
            // 
            // fileUrlTextBox
            // 
            this.fileUrlTextBox.Location = new System.Drawing.Point(115, 38);
            this.fileUrlTextBox.Name = "fileUrlTextBox";
            this.fileUrlTextBox.Size = new System.Drawing.Size(157, 20);
            this.fileUrlTextBox.TabIndex = 1;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(95, 75);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 2;
            this.openFileButton.Text = "Abrir Arquivo";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // textoLabel
            // 
            this.textoLabel.AutoSize = true;
            this.textoLabel.Location = new System.Drawing.Point(27, 108);
            this.textoLabel.Name = "textoLabel";
            this.textoLabel.Size = new System.Drawing.Size(37, 13);
            this.textoLabel.TabIndex = 3;
            this.textoLabel.Text = "Texto:";
            // 
            // mesageTextBox
            // 
            this.mesageTextBox.Location = new System.Drawing.Point(115, 108);
            this.mesageTextBox.Multiline = true;
            this.mesageTextBox.Name = "mesageTextBox";
            this.mesageTextBox.Size = new System.Drawing.Size(157, 134);
            this.mesageTextBox.TabIndex = 4;
            // 
            // salvarTextoButton
            // 
            this.salvarTextoButton.Location = new System.Drawing.Point(95, 269);
            this.salvarTextoButton.Name = "salvarTextoButton";
            this.salvarTextoButton.Size = new System.Drawing.Size(75, 23);
            this.salvarTextoButton.TabIndex = 5;
            this.salvarTextoButton.Text = "Salvar Texto";
            this.salvarTextoButton.UseVisualStyleBackColor = true;
            this.salvarTextoButton.Click += new System.EventHandler(this.salvarTextoButton_Click);
            // 
            // SystemIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 313);
            this.Controls.Add(this.salvarTextoButton);
            this.Controls.Add(this.mesageTextBox);
            this.Controls.Add(this.textoLabel);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.fileUrlTextBox);
            this.Controls.Add(this.fileUrlLabel);
            this.Name = "SystemIO";
            this.Text = "SystemIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileUrlLabel;
        private System.Windows.Forms.TextBox fileUrlTextBox;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Label textoLabel;
        private System.Windows.Forms.TextBox mesageTextBox;
        private System.Windows.Forms.Button salvarTextoButton;
    }
}

