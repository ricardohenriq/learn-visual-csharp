namespace ClassesObjetos
{
    partial class DeleteAccount
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
            this.correntistaComboBox = new System.Windows.Forms.ComboBox();
            this.correntistaLabel = new System.Windows.Forms.Label();
            this.encerrarContaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // correntistaComboBox
            // 
            this.correntistaComboBox.FormattingEnabled = true;
            this.correntistaComboBox.Location = new System.Drawing.Point(136, 36);
            this.correntistaComboBox.Name = "correntistaComboBox";
            this.correntistaComboBox.Size = new System.Drawing.Size(121, 21);
            this.correntistaComboBox.TabIndex = 0;
            this.correntistaComboBox.Text = "CORRENTISTA";
            // 
            // correntistaLabel
            // 
            this.correntistaLabel.AutoSize = true;
            this.correntistaLabel.Location = new System.Drawing.Point(30, 39);
            this.correntistaLabel.Name = "correntistaLabel";
            this.correntistaLabel.Size = new System.Drawing.Size(60, 13);
            this.correntistaLabel.TabIndex = 1;
            this.correntistaLabel.Text = "Correntista:";
            // 
            // encerrarContaButton
            // 
            this.encerrarContaButton.Location = new System.Drawing.Point(89, 120);
            this.encerrarContaButton.Name = "encerrarContaButton";
            this.encerrarContaButton.Size = new System.Drawing.Size(94, 23);
            this.encerrarContaButton.TabIndex = 2;
            this.encerrarContaButton.Text = "Encerrar Conta";
            this.encerrarContaButton.UseVisualStyleBackColor = true;
            this.encerrarContaButton.Click += new System.EventHandler(this.encerrarContaButton_Click);
            // 
            // DeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.encerrarContaButton);
            this.Controls.Add(this.correntistaLabel);
            this.Controls.Add(this.correntistaComboBox);
            this.Name = "DeleteAccount";
            this.Text = "Delete Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox correntistaComboBox;
        private System.Windows.Forms.Label correntistaLabel;
        private System.Windows.Forms.Button encerrarContaButton;
    }
}