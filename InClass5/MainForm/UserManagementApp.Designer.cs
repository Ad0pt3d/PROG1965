namespace MainForm
{
    partial class UserManagementApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpNewUser = new GroupBox();
            dtpDateCreated = new DateTimePicker();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnGetNewId = new Button();
            txtId = new TextBox();
            btnAddNewUser = new Button();
            lblDateCreated = new Label();
            lblPassword = new Label();
            lblUsername = new Label();
            lblId = new Label();
            grpOtherStuff = new GroupBox();
            rtbAllPhrases = new RichTextBox();
            btnShowAllPhrases = new Button();
            btnSavePhrase = new Button();
            txtPhrase = new TextBox();
            lblPhrase = new Label();
            rtbMessages = new RichTextBox();
            grpNewUser.SuspendLayout();
            grpOtherStuff.SuspendLayout();
            SuspendLayout();
            // 
            // grpNewUser
            // 
            grpNewUser.Controls.Add(dtpDateCreated);
            grpNewUser.Controls.Add(txtPassword);
            grpNewUser.Controls.Add(txtUsername);
            grpNewUser.Controls.Add(btnGetNewId);
            grpNewUser.Controls.Add(txtId);
            grpNewUser.Controls.Add(btnAddNewUser);
            grpNewUser.Controls.Add(lblDateCreated);
            grpNewUser.Controls.Add(lblPassword);
            grpNewUser.Controls.Add(lblUsername);
            grpNewUser.Controls.Add(lblId);
            grpNewUser.Location = new Point(35, 35);
            grpNewUser.Name = "grpNewUser";
            grpNewUser.Size = new Size(355, 238);
            grpNewUser.TabIndex = 1;
            grpNewUser.TabStop = false;
            grpNewUser.Text = "New User:";
            // 
            // dtpDateCreated
            // 
            dtpDateCreated.Location = new Point(124, 162);
            dtpDateCreated.Name = "dtpDateCreated";
            dtpDateCreated.Size = new Size(205, 23);
            dtpDateCreated.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(124, 117);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(205, 23);
            txtPassword.TabIndex = 7;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(124, 71);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(205, 23);
            txtUsername.TabIndex = 6;
            // 
            // btnGetNewId
            // 
            btnGetNewId.Location = new Point(254, 30);
            btnGetNewId.Name = "btnGetNewId";
            btnGetNewId.Size = new Size(75, 23);
            btnGetNewId.TabIndex = 5;
            btnGetNewId.Text = "Get New ID";
            btnGetNewId.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLight;
            txtId.Enabled = false;
            txtId.Location = new Point(124, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 2;
            // 
            // btnAddNewUser
            // 
            btnAddNewUser.Location = new Point(22, 201);
            btnAddNewUser.Name = "btnAddNewUser";
            btnAddNewUser.Size = new Size(119, 23);
            btnAddNewUser.TabIndex = 4;
            btnAddNewUser.Text = "Add New User";
            btnAddNewUser.UseVisualStyleBackColor = true;
            // 
            // lblDateCreated
            // 
            lblDateCreated.AutoSize = true;
            lblDateCreated.Location = new Point(22, 168);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(78, 15);
            lblDateCreated.TabIndex = 3;
            lblDateCreated.Text = "Date Created:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(22, 120);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(22, 74);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(22, 33);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // grpOtherStuff
            // 
            grpOtherStuff.Controls.Add(rtbAllPhrases);
            grpOtherStuff.Controls.Add(btnShowAllPhrases);
            grpOtherStuff.Controls.Add(btnSavePhrase);
            grpOtherStuff.Controls.Add(txtPhrase);
            grpOtherStuff.Controls.Add(lblPhrase);
            grpOtherStuff.Location = new Point(411, 35);
            grpOtherStuff.Name = "grpOtherStuff";
            grpOtherStuff.Size = new Size(360, 238);
            grpOtherStuff.TabIndex = 2;
            grpOtherStuff.TabStop = false;
            grpOtherStuff.Text = "Other Stuff:";
            // 
            // rtbAllPhrases
            // 
            rtbAllPhrases.Location = new Point(16, 117);
            rtbAllPhrases.Name = "rtbAllPhrases";
            rtbAllPhrases.Size = new Size(328, 107);
            rtbAllPhrases.TabIndex = 4;
            rtbAllPhrases.Text = "";
            // 
            // btnShowAllPhrases
            // 
            btnShowAllPhrases.Location = new Point(215, 74);
            btnShowAllPhrases.Name = "btnShowAllPhrases";
            btnShowAllPhrases.Size = new Size(129, 23);
            btnShowAllPhrases.TabIndex = 3;
            btnShowAllPhrases.Text = "Show All Phrases";
            btnShowAllPhrases.UseVisualStyleBackColor = true;
            // 
            // btnSavePhrase
            // 
            btnSavePhrase.Location = new Point(16, 74);
            btnSavePhrase.Name = "btnSavePhrase";
            btnSavePhrase.Size = new Size(103, 23);
            btnSavePhrase.TabIndex = 2;
            btnSavePhrase.Text = "Save Phrase";
            btnSavePhrase.UseVisualStyleBackColor = true;
            // 
            // txtPhrase
            // 
            txtPhrase.Location = new Point(67, 31);
            txtPhrase.Name = "txtPhrase";
            txtPhrase.Size = new Size(277, 23);
            txtPhrase.TabIndex = 1;
            // 
            // lblPhrase
            // 
            lblPhrase.AutoSize = true;
            lblPhrase.Location = new Point(16, 34);
            lblPhrase.Name = "lblPhrase";
            lblPhrase.Size = new Size(45, 15);
            lblPhrase.TabIndex = 0;
            lblPhrase.Text = "Phrase:";
            // 
            // rtbMessages
            // 
            rtbMessages.Location = new Point(35, 279);
            rtbMessages.Name = "rtbMessages";
            rtbMessages.Size = new Size(355, 63);
            rtbMessages.TabIndex = 4;
            rtbMessages.Text = "";
            // 
            // UserManagementApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 362);
            Controls.Add(rtbMessages);
            Controls.Add(grpOtherStuff);
            Controls.Add(grpNewUser);
            Name = "UserManagementApp";
            Text = "Users";
            grpNewUser.ResumeLayout(false);
            grpNewUser.PerformLayout();
            grpOtherStuff.ResumeLayout(false);
            grpOtherStuff.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpNewUser;
        private Label lblId;
        private Button btnAddNewUser;
        private Label lblDateCreated;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtId;
        private Button btnGetNewId;
        private TextBox txtUsername;
        private DateTimePicker dtpDateCreated;
        private TextBox txtPassword;
        private GroupBox grpOtherStuff;
        private RichTextBox rtbAllPhrases;
        private Button btnShowAllPhrases;
        private Button btnSavePhrase;
        private TextBox txtPhrase;
        private Label lblPhrase;
        private RichTextBox rtbMessages;
    }
}
