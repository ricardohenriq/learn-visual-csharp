namespace ClasseAbstrata
{
    partial class ClasseAbstrata
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
            this.createContaPoupancaButton = new System.Windows.Forms.Button();
            this.createContaCorrenteButton = new System.Windows.Forms.Button();
            this.createContaButton = new System.Windows.Forms.Button();
            this.atributoEstaticoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createContaPoupancaButton
            // 
            this.createContaPoupancaButton.Location = new System.Drawing.Point(81, 47);
            this.createContaPoupancaButton.Name = "createContaPoupancaButton";
            this.createContaPoupancaButton.Size = new System.Drawing.Size(101, 23);
            this.createContaPoupancaButton.TabIndex = 0;
            this.createContaPoupancaButton.Text = "Conta Poupanca";
            this.createContaPoupancaButton.UseVisualStyleBackColor = true;
            this.createContaPoupancaButton.Click += new System.EventHandler(this.createContaPoupancaButton_Click);
            // 
            // createContaCorrenteButton
            // 
            this.createContaCorrenteButton.Location = new System.Drawing.Point(81, 93);
            this.createContaCorrenteButton.Name = "createContaCorrenteButton";
            this.createContaCorrenteButton.Size = new System.Drawing.Size(101, 23);
            this.createContaCorrenteButton.TabIndex = 1;
            this.createContaCorrenteButton.Text = "Conta Corrente";
            this.createContaCorrenteButton.UseVisualStyleBackColor = true;
            this.createContaCorrenteButton.Click += new System.EventHandler(this.createContaCorrenteButton_Click);
            // 
            // createContaButton
            // 
            this.createContaButton.Location = new System.Drawing.Point(93, 140);
            this.createContaButton.Name = "createContaButton";
            this.createContaButton.Size = new System.Drawing.Size(75, 23);
            this.createContaButton.TabIndex = 2;
            this.createContaButton.Text = "Conta";
            this.createContaButton.UseVisualStyleBackColor = true;
            this.createContaButton.Click += new System.EventHandler(this.createContaButton_Click);
            // 
            // atributoEstaticoButton
            // 
            this.atributoEstaticoButton.Location = new System.Drawing.Point(84, 190);
            this.atributoEstaticoButton.Name = "atributoEstaticoButton";
            this.atributoEstaticoButton.Size = new System.Drawing.Size(98, 23);
            this.atributoEstaticoButton.TabIndex = 3;
            this.atributoEstaticoButton.Text = "Atributo Estatico";
            this.atributoEstaticoButton.UseVisualStyleBackColor = true;
            this.atributoEstaticoButton.Click += new System.EventHandler(this.atributoEstaticoButton_Click);
            // 
            // ClasseAbstrata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.atributoEstaticoButton);
            this.Controls.Add(this.createContaButton);
            this.Controls.Add(this.createContaCorrenteButton);
            this.Controls.Add(this.createContaPoupancaButton);
            this.Name = "ClasseAbstrata";
            this.Text = "Classe Abstrata";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createContaPoupancaButton;
        private System.Windows.Forms.Button createContaCorrenteButton;
        private System.Windows.Forms.Button createContaButton;
        private System.Windows.Forms.Button atributoEstaticoButton;
    }
}

