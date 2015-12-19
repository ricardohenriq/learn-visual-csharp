namespace ClassesObjetos
{
    partial class Home
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
            this.criarContaButton = new System.Windows.Forms.Button();
            this.sacarButton = new System.Windows.Forms.Button();
            this.depositarButton = new System.Windows.Forms.Button();
            this.deleteAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // criarContaButton
            // 
            this.criarContaButton.Location = new System.Drawing.Point(31, 39);
            this.criarContaButton.Name = "criarContaButton";
            this.criarContaButton.Size = new System.Drawing.Size(82, 23);
            this.criarContaButton.TabIndex = 0;
            this.criarContaButton.Text = "Criar Conta";
            this.criarContaButton.UseVisualStyleBackColor = true;
            this.criarContaButton.Click += new System.EventHandler(this.criarContaButton_Click);
            // 
            // sacarButton
            // 
            this.sacarButton.Location = new System.Drawing.Point(151, 39);
            this.sacarButton.Name = "sacarButton";
            this.sacarButton.Size = new System.Drawing.Size(89, 23);
            this.sacarButton.TabIndex = 1;
            this.sacarButton.Text = "Sacar";
            this.sacarButton.UseVisualStyleBackColor = true;
            this.sacarButton.Click += new System.EventHandler(this.sacarButton_Click);
            // 
            // depositarButton
            // 
            this.depositarButton.Location = new System.Drawing.Point(31, 92);
            this.depositarButton.Name = "depositarButton";
            this.depositarButton.Size = new System.Drawing.Size(82, 23);
            this.depositarButton.TabIndex = 2;
            this.depositarButton.Text = "Depositar";
            this.depositarButton.UseVisualStyleBackColor = true;
            this.depositarButton.Click += new System.EventHandler(this.depositarButton_Click);
            // 
            // deleteAccount
            // 
            this.deleteAccount.Location = new System.Drawing.Point(151, 92);
            this.deleteAccount.Name = "deleteAccount";
            this.deleteAccount.Size = new System.Drawing.Size(89, 23);
            this.deleteAccount.TabIndex = 3;
            this.deleteAccount.Text = "Encerrar Conta";
            this.deleteAccount.UseVisualStyleBackColor = true;
            this.deleteAccount.Click += new System.EventHandler(this.deleteAccount_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.deleteAccount);
            this.Controls.Add(this.depositarButton);
            this.Controls.Add(this.sacarButton);
            this.Controls.Add(this.criarContaButton);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button criarContaButton;
        private System.Windows.Forms.Button sacarButton;
        private System.Windows.Forms.Button depositarButton;
        private System.Windows.Forms.Button deleteAccount;
    }
}

