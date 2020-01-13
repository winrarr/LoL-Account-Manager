namespace LoL_Account_Manager
{
    partial class MainForm
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
            this.addAccountButton = new System.Windows.Forms.Button();
            this.accountListbox = new System.Windows.Forms.ListBox();
            this.serverCombobox = new System.Windows.Forms.ComboBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.updateAccountsButton = new System.Windows.Forms.Button();
            this.usernameCopyButton = new System.Windows.Forms.Button();
            this.passwordCopyButton = new System.Windows.Forms.Button();
            this.rankLabel = new System.Windows.Forms.Label();
            this.rankDisplayLabel = new System.Windows.Forms.Label();
            this.winrateLabel = new System.Windows.Forms.Label();
            this.winrateDisplayLabel = new System.Windows.Forms.Label();
            this.showPassWordCheckbox = new System.Windows.Forms.CheckBox();
            this.deleteAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addAccountButton
            // 
            this.addAccountButton.Location = new System.Drawing.Point(12, 233);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(102, 23);
            this.addAccountButton.TabIndex = 0;
            this.addAccountButton.Text = "Add Account";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // accountListbox
            // 
            this.accountListbox.FormattingEnabled = true;
            this.accountListbox.Location = new System.Drawing.Point(12, 47);
            this.accountListbox.Name = "accountListbox";
            this.accountListbox.Size = new System.Drawing.Size(211, 173);
            this.accountListbox.TabIndex = 1;
            this.accountListbox.SelectedIndexChanged += new System.EventHandler(this.accountListbox_SelectedIndexChanged);
            // 
            // serverCombobox
            // 
            this.serverCombobox.FormattingEnabled = true;
            this.serverCombobox.Items.AddRange(new object[] {
            "EUW1",
            "NA1",
            "EUN1",
            "TR1",
            "LA1",
            "OC1"});
            this.serverCombobox.Location = new System.Drawing.Point(12, 12);
            this.serverCombobox.Name = "serverCombobox";
            this.serverCombobox.Size = new System.Drawing.Size(70, 21);
            this.serverCombobox.TabIndex = 2;
            this.serverCombobox.SelectedIndexChanged += new System.EventHandler(this.serverCombobox_SelectedIndexChanged);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(88, 267);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(135, 20);
            this.usernameTextbox.TabIndex = 3;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(88, 293);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(135, 20);
            this.passwordTextbox.TabIndex = 4;
            this.passwordTextbox.PasswordChar = '•';
            // 
            // updateAccountsButton
            // 
            this.updateAccountsButton.Location = new System.Drawing.Point(12, 357);
            this.updateAccountsButton.Name = "updateAccountsButton";
            this.updateAccountsButton.Size = new System.Drawing.Size(211, 23);
            this.updateAccountsButton.TabIndex = 5;
            this.updateAccountsButton.Text = "Update Accounts";
            this.updateAccountsButton.UseVisualStyleBackColor = true;
            this.updateAccountsButton.Click += new System.EventHandler(this.updateAccountsButton_Click);
            // 
            // usernameCopyButton
            // 
            this.usernameCopyButton.Location = new System.Drawing.Point(12, 265);
            this.usernameCopyButton.Name = "usernameCopyButton";
            this.usernameCopyButton.Size = new System.Drawing.Size(70, 23);
            this.usernameCopyButton.TabIndex = 6;
            this.usernameCopyButton.Text = "Username:";
            this.usernameCopyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameCopyButton.UseVisualStyleBackColor = true;
            this.usernameCopyButton.Click += new System.EventHandler(this.usernameCopyButton_Click);
            // 
            // passwordCopyButton
            // 
            this.passwordCopyButton.Location = new System.Drawing.Point(12, 291);
            this.passwordCopyButton.Name = "passwordCopyButton";
            this.passwordCopyButton.Size = new System.Drawing.Size(70, 23);
            this.passwordCopyButton.TabIndex = 7;
            this.passwordCopyButton.Text = "Password:";
            this.passwordCopyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordCopyButton.UseVisualStyleBackColor = true;
            this.passwordCopyButton.Click += new System.EventHandler(this.passwordCopyButton_Click);
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.Location = new System.Drawing.Point(13, 321);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(36, 13);
            this.rankLabel.TabIndex = 8;
            this.rankLabel.Text = "Rank:";
            // 
            // rankDisplayLabel
            // 
            this.rankDisplayLabel.AutoSize = true;
            this.rankDisplayLabel.Location = new System.Drawing.Point(66, 321);
            this.rankDisplayLabel.Name = "rankDisplayLabel";
            this.rankDisplayLabel.Size = new System.Drawing.Size(0, 13);
            this.rankDisplayLabel.TabIndex = 9;
            // 
            // winrateLabel
            // 
            this.winrateLabel.AutoSize = true;
            this.winrateLabel.Location = new System.Drawing.Point(13, 338);
            this.winrateLabel.Name = "winrateLabel";
            this.winrateLabel.Size = new System.Drawing.Size(47, 13);
            this.winrateLabel.TabIndex = 10;
            this.winrateLabel.Text = "Winrate:";
            // 
            // winrateDisplayLabel
            // 
            this.winrateDisplayLabel.AutoSize = true;
            this.winrateDisplayLabel.Location = new System.Drawing.Point(66, 338);
            this.winrateDisplayLabel.Name = "winrateDisplayLabel";
            this.winrateDisplayLabel.Size = new System.Drawing.Size(0, 13);
            this.winrateDisplayLabel.TabIndex = 11;
            // 
            // showPassWordCheckbox
            // 
            this.showPassWordCheckbox.AutoSize = true;
            this.showPassWordCheckbox.Location = new System.Drawing.Point(120, 16);
            this.showPassWordCheckbox.Name = "showPassWordCheckbox";
            this.showPassWordCheckbox.Size = new System.Drawing.Size(102, 17);
            this.showPassWordCheckbox.TabIndex = 12;
            this.showPassWordCheckbox.Text = "Show Password";
            this.showPassWordCheckbox.UseVisualStyleBackColor = true;
            this.showPassWordCheckbox.CheckedChanged += new System.EventHandler(this.showPassWordCheckbox_CheckedChanged);
            // 
            // deleteAccountButton
            // 
            this.deleteAccountButton.Location = new System.Drawing.Point(120, 233);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.Size = new System.Drawing.Size(103, 23);
            this.deleteAccountButton.TabIndex = 13;
            this.deleteAccountButton.Text = "Delete Account";
            this.deleteAccountButton.UseVisualStyleBackColor = true;
            this.deleteAccountButton.Click += new System.EventHandler(this.deleteAccountButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 392);
            this.Controls.Add(this.deleteAccountButton);
            this.Controls.Add(this.showPassWordCheckbox);
            this.Controls.Add(this.winrateDisplayLabel);
            this.Controls.Add(this.winrateLabel);
            this.Controls.Add(this.rankDisplayLabel);
            this.Controls.Add(this.rankLabel);
            this.Controls.Add(this.passwordCopyButton);
            this.Controls.Add(this.usernameCopyButton);
            this.Controls.Add(this.updateAccountsButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.serverCombobox);
            this.Controls.Add(this.accountListbox);
            this.Controls.Add(this.addAccountButton);
            this.Name = "MainForm";
            this.Text = "Account Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.ListBox accountListbox;
        private System.Windows.Forms.ComboBox serverCombobox;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button updateAccountsButton;
        private System.Windows.Forms.Button usernameCopyButton;
        private System.Windows.Forms.Button passwordCopyButton;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.Label rankDisplayLabel;
        private System.Windows.Forms.Label winrateLabel;
        private System.Windows.Forms.Label winrateDisplayLabel;
        private System.Windows.Forms.CheckBox showPassWordCheckbox;
        private System.Windows.Forms.Button deleteAccountButton;
    }
}

