namespace Repeticao
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
            this.fatorialLabel = new System.Windows.Forms.Label();
            this.fatorialTextBox = new System.Windows.Forms.TextBox();
            this.verificarFatorialButton = new System.Windows.Forms.Button();
            this.contadorLabel = new System.Windows.Forms.Label();
            this.contadorTextBox = new System.Windows.Forms.TextBox();
            this.verificarContadorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fatorialLabel
            // 
            this.fatorialLabel.AutoSize = true;
            this.fatorialLabel.Location = new System.Drawing.Point(12, 13);
            this.fatorialLabel.Name = "fatorialLabel";
            this.fatorialLabel.Size = new System.Drawing.Size(44, 13);
            this.fatorialLabel.TabIndex = 0;
            this.fatorialLabel.Text = "Fatorial:";
            // 
            // fatorialTextBox
            // 
            this.fatorialTextBox.Location = new System.Drawing.Point(81, 10);
            this.fatorialTextBox.Name = "fatorialTextBox";
            this.fatorialTextBox.Size = new System.Drawing.Size(95, 20);
            this.fatorialTextBox.TabIndex = 1;
            // 
            // verificarFatorialButton
            // 
            this.verificarFatorialButton.Location = new System.Drawing.Point(197, 10);
            this.verificarFatorialButton.Name = "verificarFatorialButton";
            this.verificarFatorialButton.Size = new System.Drawing.Size(75, 23);
            this.verificarFatorialButton.TabIndex = 2;
            this.verificarFatorialButton.Text = "Verificar";
            this.verificarFatorialButton.UseVisualStyleBackColor = true;
            this.verificarFatorialButton.Click += new System.EventHandler(this.verificarFatorialButton_Click);
            // 
            // contadorLabel
            // 
            this.contadorLabel.AutoSize = true;
            this.contadorLabel.Location = new System.Drawing.Point(15, 66);
            this.contadorLabel.Name = "contadorLabel";
            this.contadorLabel.Size = new System.Drawing.Size(59, 13);
            this.contadorLabel.TabIndex = 3;
            this.contadorLabel.Text = "Contar até:";
            // 
            // contadorTextBox
            // 
            this.contadorTextBox.Location = new System.Drawing.Point(81, 63);
            this.contadorTextBox.Name = "contadorTextBox";
            this.contadorTextBox.Size = new System.Drawing.Size(95, 20);
            this.contadorTextBox.TabIndex = 4;
            // 
            // verificarContadorButton
            // 
            this.verificarContadorButton.Location = new System.Drawing.Point(197, 60);
            this.verificarContadorButton.Name = "verificarContadorButton";
            this.verificarContadorButton.Size = new System.Drawing.Size(75, 23);
            this.verificarContadorButton.TabIndex = 5;
            this.verificarContadorButton.Text = "Verificar";
            this.verificarContadorButton.UseVisualStyleBackColor = true;
            this.verificarContadorButton.Click += new System.EventHandler(this.verificarContadorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.verificarContadorButton);
            this.Controls.Add(this.contadorTextBox);
            this.Controls.Add(this.contadorLabel);
            this.Controls.Add(this.verificarFatorialButton);
            this.Controls.Add(this.fatorialTextBox);
            this.Controls.Add(this.fatorialLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fatorialLabel;
        private System.Windows.Forms.TextBox fatorialTextBox;
        private System.Windows.Forms.Button verificarFatorialButton;
        private System.Windows.Forms.Label contadorLabel;
        private System.Windows.Forms.TextBox contadorTextBox;
        private System.Windows.Forms.Button verificarContadorButton;
    }
}

