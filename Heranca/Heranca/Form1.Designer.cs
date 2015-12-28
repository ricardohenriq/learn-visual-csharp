namespace Heranca
{
    partial class ZooHome
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
            this.singUpButton = new System.Windows.Forms.Button();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.typeEntityLabel = new System.Windows.Forms.Label();
            this.typeEntityComboBox = new System.Windows.Forms.ComboBox();
            this.entityTypeLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.borndateLabel = new System.Windows.Forms.Label();
            this.borndateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.specieLabel = new System.Windows.Forms.Label();
            this.specieTextBox = new System.Windows.Forms.TextBox();
            this.originLabel = new System.Windows.Forms.Label();
            this.originTextBox = new System.Windows.Forms.TextBox();
            this.functionLabel = new System.Windows.Forms.Label();
            this.functionTextBox = new System.Windows.Forms.TextBox();
            this.addGroupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // singUpButton
            // 
            this.singUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singUpButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.singUpButton.Location = new System.Drawing.Point(3, 187);
            this.singUpButton.Name = "singUpButton";
            this.singUpButton.Size = new System.Drawing.Size(75, 23);
            this.singUpButton.TabIndex = 2;
            this.singUpButton.Text = "Cadastrar";
            this.singUpButton.UseVisualStyleBackColor = true;
            this.singUpButton.Click += new System.EventHandler(this.singUpButton_Click);
            // 
            // addGroupBox
            // 
            this.addGroupBox.AutoSize = true;
            this.addGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addGroupBox.Controls.Add(this.flowLayoutPanel1);
            this.addGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.addGroupBox.Location = new System.Drawing.Point(12, 12);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(216, 264);
            this.addGroupBox.TabIndex = 0;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Cadastro";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.typeEntityLabel);
            this.flowLayoutPanel1.Controls.Add(this.typeEntityComboBox);
            this.flowLayoutPanel1.Controls.Add(this.entityTypeLabel);
            this.flowLayoutPanel1.Controls.Add(this.typeComboBox);
            this.flowLayoutPanel1.Controls.Add(this.borndateLabel);
            this.flowLayoutPanel1.Controls.Add(this.borndateDateTimePicker);
            this.flowLayoutPanel1.Controls.Add(this.idLabel);
            this.flowLayoutPanel1.Controls.Add(this.idTextBox);
            this.flowLayoutPanel1.Controls.Add(this.specieLabel);
            this.flowLayoutPanel1.Controls.Add(this.specieTextBox);
            this.flowLayoutPanel1.Controls.Add(this.originLabel);
            this.flowLayoutPanel1.Controls.Add(this.originTextBox);
            this.flowLayoutPanel1.Controls.Add(this.functionLabel);
            this.flowLayoutPanel1.Controls.Add(this.functionTextBox);
            this.flowLayoutPanel1.Controls.Add(this.singUpButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 26);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(203, 213);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // typeEntityLabel
            // 
            this.typeEntityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeEntityLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.typeEntityLabel.Location = new System.Drawing.Point(3, 0);
            this.typeEntityLabel.Name = "typeEntityLabel";
            this.typeEntityLabel.Size = new System.Drawing.Size(70, 13);
            this.typeEntityLabel.TabIndex = 17;
            this.typeEntityLabel.Text = "Cadastro:";
            // 
            // typeEntityComboBox
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.typeEntityComboBox, true);
            this.typeEntityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeEntityComboBox.FormattingEnabled = true;
            this.typeEntityComboBox.Location = new System.Drawing.Point(79, 3);
            this.typeEntityComboBox.Name = "typeEntityComboBox";
            this.typeEntityComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.typeEntityComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeEntityComboBox.TabIndex = 18;
            this.typeEntityComboBox.Text = "CATEGORIA";
            this.typeEntityComboBox.SelectedIndexChanged += new System.EventHandler(this.typeEntityComboBox_SelectedIndexChanged);
            // 
            // entityTypeLabel
            // 
            this.entityTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entityTypeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.entityTypeLabel.Location = new System.Drawing.Point(3, 27);
            this.entityTypeLabel.Name = "entityTypeLabel";
            this.entityTypeLabel.Size = new System.Drawing.Size(70, 13);
            this.entityTypeLabel.TabIndex = 19;
            this.entityTypeLabel.Text = "Tipo:";
            // 
            // typeComboBox
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.typeComboBox, true);
            this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(79, 30);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 20;
            this.typeComboBox.Text = "TIPO";
            // 
            // borndateLabel
            // 
            this.borndateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borndateLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.borndateLabel.Location = new System.Drawing.Point(3, 54);
            this.borndateLabel.Name = "borndateLabel";
            this.borndateLabel.Size = new System.Drawing.Size(70, 13);
            this.borndateLabel.TabIndex = 31;
            this.borndateLabel.Text = "Nascimento:";
            // 
            // borndateDateTimePicker
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.borndateDateTimePicker, true);
            this.borndateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borndateDateTimePicker.Location = new System.Drawing.Point(79, 57);
            this.borndateDateTimePicker.Name = "borndateDateTimePicker";
            this.borndateDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.borndateDateTimePicker.TabIndex = 33;
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.idLabel.Location = new System.Drawing.Point(3, 80);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(70, 13);
            this.idLabel.TabIndex = 32;
            this.idLabel.Text = "ID:";
            // 
            // idTextBox
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.idTextBox, true);
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(79, 83);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(121, 20);
            this.idTextBox.TabIndex = 34;
            // 
            // specieLabel
            // 
            this.specieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specieLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.specieLabel.Location = new System.Drawing.Point(3, 106);
            this.specieLabel.Name = "specieLabel";
            this.specieLabel.Size = new System.Drawing.Size(70, 13);
            this.specieLabel.TabIndex = 21;
            this.specieLabel.Text = "Especie:";
            // 
            // specieTextBox
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.specieTextBox, true);
            this.specieTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specieTextBox.Location = new System.Drawing.Point(79, 109);
            this.specieTextBox.Name = "specieTextBox";
            this.specieTextBox.Size = new System.Drawing.Size(121, 20);
            this.specieTextBox.TabIndex = 27;
            // 
            // originLabel
            // 
            this.originLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.originLabel.Location = new System.Drawing.Point(3, 132);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(70, 13);
            this.originLabel.TabIndex = 22;
            this.originLabel.Text = "Origem:";
            // 
            // originTextBox
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.originTextBox, true);
            this.originTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originTextBox.Location = new System.Drawing.Point(79, 135);
            this.originTextBox.Name = "originTextBox";
            this.originTextBox.Size = new System.Drawing.Size(121, 20);
            this.originTextBox.TabIndex = 28;
            // 
            // functionLabel
            // 
            this.functionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.functionLabel.Location = new System.Drawing.Point(3, 158);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(70, 13);
            this.functionLabel.TabIndex = 25;
            this.functionLabel.Text = "Função:";
            // 
            // functionTextBox
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.functionTextBox, true);
            this.functionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionTextBox.Location = new System.Drawing.Point(79, 161);
            this.functionTextBox.Name = "functionTextBox";
            this.functionTextBox.Size = new System.Drawing.Size(121, 20);
            this.functionTextBox.TabIndex = 30;
            // 
            // ZooHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(245, 289);
            this.Controls.Add(this.addGroupBox);
            this.Name = "ZooHome";
            this.Text = "Zoo Home";
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button singUpButton;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label typeEntityLabel;
        private System.Windows.Forms.ComboBox typeEntityComboBox;
        private System.Windows.Forms.Label entityTypeLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label specieLabel;
        private System.Windows.Forms.TextBox specieTextBox;
        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.TextBox originTextBox;
        private System.Windows.Forms.Label functionLabel;
        private System.Windows.Forms.TextBox functionTextBox;
        private System.Windows.Forms.Label borndateLabel;
        private System.Windows.Forms.DateTimePicker borndateDateTimePicker;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
    }
}

