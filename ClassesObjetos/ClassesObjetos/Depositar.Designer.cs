namespace ClassesObjetos
{
    partial class Depositar
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
            this.depositarButton = new System.Windows.Forms.Button();
            this.valorLabel = new System.Windows.Forms.Label();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.correntistaLabel = new System.Windows.Forms.Label();
            this.correntistasComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // depositarButton
            // 
            this.depositarButton.Location = new System.Drawing.Point(100, 106);
            this.depositarButton.Name = "depositarButton";
            this.depositarButton.Size = new System.Drawing.Size(75, 23);
            this.depositarButton.TabIndex = 0;
            this.depositarButton.Text = "Depositar";
            this.depositarButton.UseVisualStyleBackColor = true;
            this.depositarButton.Click += new System.EventHandler(this.depositarButton_Click);
            // 
            // valorLabel
            // 
            this.valorLabel.AutoSize = true;
            this.valorLabel.Location = new System.Drawing.Point(24, 43);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(34, 13);
            this.valorLabel.TabIndex = 1;
            this.valorLabel.Text = "Valor:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(120, 40);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(125, 20);
            this.valorTextBox.TabIndex = 2;
            // 
            // correntistaLabel
            // 
            this.correntistaLabel.AutoSize = true;
            this.correntistaLabel.Location = new System.Drawing.Point(24, 71);
            this.correntistaLabel.Name = "correntistaLabel";
            this.correntistaLabel.Size = new System.Drawing.Size(60, 13);
            this.correntistaLabel.TabIndex = 3;
            this.correntistaLabel.Text = "Correntista:";
            // 
            // correntistasComboBox
            // 
            this.correntistasComboBox.FormattingEnabled = true;
            this.correntistasComboBox.Location = new System.Drawing.Point(120, 68);
            this.correntistasComboBox.Name = "correntistasComboBox";
            this.correntistasComboBox.Size = new System.Drawing.Size(125, 21);
            this.correntistasComboBox.TabIndex = 4;
            this.correntistasComboBox.Text = "CORRENTISTA";
            // 
            // Depositar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.correntistasComboBox);
            this.Controls.Add(this.correntistaLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.valorLabel);
            this.Controls.Add(this.depositarButton);
            this.Name = "Depositar";
            this.Text = "Depositar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button depositarButton;
        private System.Windows.Forms.Label valorLabel;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Label correntistaLabel;
        private System.Windows.Forms.ComboBox correntistasComboBox;
    }
}