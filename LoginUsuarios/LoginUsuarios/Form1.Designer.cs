namespace LoginUsuarios
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.singUpGroupBox = new System.Windows.Forms.GroupBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passwordSingUpTextBox = new System.Windows.Forms.TextBox();
            this.loginSingUptextBox = new System.Windows.Forms.TextBox();
            this.passwordSingUpLabel = new System.Windows.Forms.Label();
            this.loginSingUpLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.singUpButton = new System.Windows.Forms.Button();
            this.listAllButton = new System.Windows.Forms.Button();
            this.listOneButton = new System.Windows.Forms.Button();
            this.loginGroupBox.SuspendLayout();
            this.singUpGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.loginButton);
            this.loginGroupBox.Controls.Add(this.passwordTextBox);
            this.loginGroupBox.Controls.Add(this.loginTextBox);
            this.loginGroupBox.Controls.Add(this.passwordLabel);
            this.loginGroupBox.Controls.Add(this.loginLabel);
            resources.ApplyResources(this.loginGroupBox, "loginGroupBox");
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.TabStop = false;
            // 
            // loginLabel
            // 
            resources.ApplyResources(this.loginLabel, "loginLabel");
            this.loginLabel.Name = "loginLabel";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.Name = "passwordLabel";
            // 
            // loginTextBox
            // 
            resources.ApplyResources(this.loginTextBox, "loginTextBox");
            this.loginTextBox.Name = "loginTextBox";
            // 
            // passwordTextBox
            // 
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.Name = "passwordTextBox";
            // 
            // loginButton
            // 
            resources.ApplyResources(this.loginButton, "loginButton");
            this.loginButton.Name = "loginButton";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // singUpGroupBox
            // 
            this.singUpGroupBox.Controls.Add(this.singUpButton);
            this.singUpGroupBox.Controls.Add(this.nameTextBox);
            this.singUpGroupBox.Controls.Add(this.passwordSingUpTextBox);
            this.singUpGroupBox.Controls.Add(this.loginSingUptextBox);
            this.singUpGroupBox.Controls.Add(this.passwordSingUpLabel);
            this.singUpGroupBox.Controls.Add(this.loginSingUpLabel);
            this.singUpGroupBox.Controls.Add(this.nameLabel);
            resources.ApplyResources(this.singUpGroupBox, "singUpGroupBox");
            this.singUpGroupBox.Name = "singUpGroupBox";
            this.singUpGroupBox.TabStop = false;
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // passwordSingUpTextBox
            // 
            resources.ApplyResources(this.passwordSingUpTextBox, "passwordSingUpTextBox");
            this.passwordSingUpTextBox.Name = "passwordSingUpTextBox";
            // 
            // loginSingUptextBox
            // 
            resources.ApplyResources(this.loginSingUptextBox, "loginSingUptextBox");
            this.loginSingUptextBox.Name = "loginSingUptextBox";
            // 
            // passwordSingUpLabel
            // 
            resources.ApplyResources(this.passwordSingUpLabel, "passwordSingUpLabel");
            this.passwordSingUpLabel.Name = "passwordSingUpLabel";
            // 
            // loginSingUpLabel
            // 
            resources.ApplyResources(this.loginSingUpLabel, "loginSingUpLabel");
            this.loginSingUpLabel.Name = "loginSingUpLabel";
            // 
            // nameTextBox
            // 
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
            this.nameTextBox.Name = "nameTextBox";
            // 
            // singUpButton
            // 
            resources.ApplyResources(this.singUpButton, "singUpButton");
            this.singUpButton.Name = "singUpButton";
            this.singUpButton.UseVisualStyleBackColor = true;
            this.singUpButton.Click += new System.EventHandler(this.singUpButton_Click);
            // 
            // listAllButton
            // 
            resources.ApplyResources(this.listAllButton, "listAllButton");
            this.listAllButton.Name = "listAllButton";
            this.listAllButton.UseVisualStyleBackColor = true;
            // 
            // listOneButton
            // 
            resources.ApplyResources(this.listOneButton, "listOneButton");
            this.listOneButton.Name = "listOneButton";
            this.listOneButton.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listOneButton);
            this.Controls.Add(this.listAllButton);
            this.Controls.Add(this.singUpGroupBox);
            this.Controls.Add(this.loginGroupBox);
            this.Name = "login";
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.singUpGroupBox.ResumeLayout(false);
            this.singUpGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.GroupBox singUpGroupBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox passwordSingUpTextBox;
        private System.Windows.Forms.TextBox loginSingUptextBox;
        private System.Windows.Forms.Label passwordSingUpLabel;
        private System.Windows.Forms.Label loginSingUpLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button singUpButton;
        private System.Windows.Forms.Button listAllButton;
        private System.Windows.Forms.Button listOneButton;
    }
}

