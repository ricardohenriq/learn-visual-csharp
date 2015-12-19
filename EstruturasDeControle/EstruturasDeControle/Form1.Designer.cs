namespace EstruturasDeControle
{
    partial class estruturaControle
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
            this.verificarIf = new System.Windows.Forms.Button();
            this.idadeLabel = new System.Windows.Forms.Label();
            this.idadeTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.verificarSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // verificarIf
            // 
            this.verificarIf.Location = new System.Drawing.Point(92, 129);
            this.verificarIf.Name = "verificarIf";
            this.verificarIf.Size = new System.Drawing.Size(75, 23);
            this.verificarIf.TabIndex = 0;
            this.verificarIf.Text = "Verificar";
            this.verificarIf.UseVisualStyleBackColor = true;
            this.verificarIf.Click += new System.EventHandler(this.verificar_Click);
            // 
            // idadeLabel
            // 
            this.idadeLabel.AutoSize = true;
            this.idadeLabel.Location = new System.Drawing.Point(34, 50);
            this.idadeLabel.Name = "idadeLabel";
            this.idadeLabel.Size = new System.Drawing.Size(37, 13);
            this.idadeLabel.TabIndex = 1;
            this.idadeLabel.Text = "Idade:";
            // 
            // idadeTextBox
            // 
            this.idadeTextBox.Location = new System.Drawing.Point(120, 42);
            this.idadeTextBox.Name = "idadeTextBox";
            this.idadeTextBox.Size = new System.Drawing.Size(110, 20);
            this.idadeTextBox.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(120, 85);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(110, 20);
            this.nomeTextBox.TabIndex = 3;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(33, 85);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 4;
            this.nomeLabel.Text = "Nome:";
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Location = new System.Drawing.Point(33, 182);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(88, 13);
            this.numeroLabel.TabIndex = 5;
            this.numeroLabel.Text = "Inrira um número:";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Location = new System.Drawing.Point(138, 182);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(92, 20);
            this.numeroTextBox.TabIndex = 6;
            // 
            // verificarSwitch
            // 
            this.verificarSwitch.Location = new System.Drawing.Point(92, 227);
            this.verificarSwitch.Name = "verificarSwitch";
            this.verificarSwitch.Size = new System.Drawing.Size(75, 23);
            this.verificarSwitch.TabIndex = 7;
            this.verificarSwitch.Text = "Verificar";
            this.verificarSwitch.UseVisualStyleBackColor = true;
            this.verificarSwitch.Click += new System.EventHandler(this.verificarSwitch_Click);
            // 
            // estruturaControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.verificarSwitch);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.numeroLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.idadeTextBox);
            this.Controls.Add(this.idadeLabel);
            this.Controls.Add(this.verificarIf);
            this.Name = "estruturaControle";
            this.Text = "Estruturas de Controle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button verificarIf;
        private System.Windows.Forms.Label idadeLabel;
        private System.Windows.Forms.TextBox idadeTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.Button verificarSwitch;
    }
}

