namespace Database
{
    partial class database
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
            this.insertButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.updateBbutton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(103, 43);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 0;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(103, 82);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // updateBbutton
            // 
            this.updateBbutton.Location = new System.Drawing.Point(103, 122);
            this.updateBbutton.Name = "updateBbutton";
            this.updateBbutton.Size = new System.Drawing.Size(75, 23);
            this.updateBbutton.TabIndex = 2;
            this.updateBbutton.Text = "Update";
            this.updateBbutton.UseVisualStyleBackColor = true;
            this.updateBbutton.Click += new System.EventHandler(this.updateBbutton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(103, 164);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(103, 205);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(75, 23);
            this.countButton.TabIndex = 4;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateBbutton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.insertButton);
            this.Name = "database";
            this.Text = "Database";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button updateBbutton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button countButton;
    }
}

