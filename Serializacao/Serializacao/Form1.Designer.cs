namespace Serializacao
{
    partial class serializacao
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
            this.toJSONButton = new System.Windows.Forms.Button();
            this.fromJSONButton = new System.Windows.Forms.Button();
            this.toXMLButton = new System.Windows.Forms.Button();
            this.FromXMLButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toJSONButton
            // 
            this.toJSONButton.Location = new System.Drawing.Point(35, 89);
            this.toJSONButton.Name = "toJSONButton";
            this.toJSONButton.Size = new System.Drawing.Size(75, 23);
            this.toJSONButton.TabIndex = 0;
            this.toJSONButton.Text = "To JSON";
            this.toJSONButton.UseVisualStyleBackColor = true;
            this.toJSONButton.Click += new System.EventHandler(this.toJSONButton_Click);
            // 
            // fromJSONButton
            // 
            this.fromJSONButton.Location = new System.Drawing.Point(168, 89);
            this.fromJSONButton.Name = "fromJSONButton";
            this.fromJSONButton.Size = new System.Drawing.Size(75, 23);
            this.fromJSONButton.TabIndex = 1;
            this.fromJSONButton.Text = "From JSON";
            this.fromJSONButton.UseVisualStyleBackColor = true;
            this.fromJSONButton.Click += new System.EventHandler(this.fromJSONButton_Click);
            // 
            // toXMLButton
            // 
            this.toXMLButton.Location = new System.Drawing.Point(35, 131);
            this.toXMLButton.Name = "toXMLButton";
            this.toXMLButton.Size = new System.Drawing.Size(75, 23);
            this.toXMLButton.TabIndex = 2;
            this.toXMLButton.Text = "To XML";
            this.toXMLButton.UseVisualStyleBackColor = true;
            this.toXMLButton.Click += new System.EventHandler(this.toXMLButton_Click);
            // 
            // FromXMLButton
            // 
            this.FromXMLButton.Location = new System.Drawing.Point(168, 131);
            this.FromXMLButton.Name = "FromXMLButton";
            this.FromXMLButton.Size = new System.Drawing.Size(75, 23);
            this.FromXMLButton.TabIndex = 3;
            this.FromXMLButton.Text = "From XML";
            this.FromXMLButton.UseVisualStyleBackColor = true;
            this.FromXMLButton.Click += new System.EventHandler(this.FromXMLButton_Click);
            // 
            // serializacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.FromXMLButton);
            this.Controls.Add(this.toXMLButton);
            this.Controls.Add(this.fromJSONButton);
            this.Controls.Add(this.toJSONButton);
            this.Name = "serializacao";
            this.Text = "Serialização";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toJSONButton;
        private System.Windows.Forms.Button fromJSONButton;
        private System.Windows.Forms.Button toXMLButton;
        private System.Windows.Forms.Button FromXMLButton;
    }
}

