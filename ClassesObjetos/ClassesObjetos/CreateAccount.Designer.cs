namespace ClassesObjetos
{
    partial class CreateAccount
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
            this.depositoLabel = new System.Windows.Forms.Label();
            this.titualLabel = new System.Windows.Forms.Label();
            this.depositoTextBox = new System.Windows.Forms.TextBox();
            this.titularTextBox = new System.Windows.Forms.TextBox();
            this.criarConta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // depositoLabel
            // 
            this.depositoLabel.AutoSize = true;
            this.depositoLabel.Location = new System.Drawing.Point(23, 34);
            this.depositoLabel.Name = "depositoLabel";
            this.depositoLabel.Size = new System.Drawing.Size(52, 13);
            this.depositoLabel.TabIndex = 0;
            this.depositoLabel.Text = "Deposito:";
            // 
            // titualLabel
            // 
            this.titualLabel.AutoSize = true;
            this.titualLabel.Location = new System.Drawing.Point(23, 68);
            this.titualLabel.Name = "titualLabel";
            this.titualLabel.Size = new System.Drawing.Size(39, 13);
            this.titualLabel.TabIndex = 1;
            this.titualLabel.Text = "Titular:";
            // 
            // depositoTextBox
            // 
            this.depositoTextBox.Location = new System.Drawing.Point(121, 34);
            this.depositoTextBox.Name = "depositoTextBox";
            this.depositoTextBox.Size = new System.Drawing.Size(137, 20);
            this.depositoTextBox.TabIndex = 2;
            // 
            // titularTextBox
            // 
            this.titularTextBox.Location = new System.Drawing.Point(121, 68);
            this.titularTextBox.Name = "titularTextBox";
            this.titularTextBox.Size = new System.Drawing.Size(137, 20);
            this.titularTextBox.TabIndex = 3;
            // 
            // criarConta
            // 
            this.criarConta.Location = new System.Drawing.Point(94, 115);
            this.criarConta.Name = "criarConta";
            this.criarConta.Size = new System.Drawing.Size(75, 23);
            this.criarConta.TabIndex = 4;
            this.criarConta.Text = "Criar Conta";
            this.criarConta.UseVisualStyleBackColor = true;
            this.criarConta.Click += new System.EventHandler(this.criarConta_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.criarConta);
            this.Controls.Add(this.titularTextBox);
            this.Controls.Add(this.depositoTextBox);
            this.Controls.Add(this.titualLabel);
            this.Controls.Add(this.depositoLabel);
            this.Name = "CreateAccount";
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label depositoLabel;
        private System.Windows.Forms.Label titualLabel;
        private System.Windows.Forms.TextBox depositoTextBox;
        private System.Windows.Forms.TextBox titularTextBox;
        private System.Windows.Forms.Button criarConta;
    }
}