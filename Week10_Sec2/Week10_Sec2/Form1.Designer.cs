namespace Week10_Sec2
{
    partial class Form1
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
            lblTitle = new Label();
            lblProvinceCode = new Label();
            lblName = new Label();
            lblCountryCode = new Label();
            lblTaxCode = new Label();
            lblTaxRate = new Label();
            lblFedTax = new Label();
            lblFirstPostCode = new Label();
            txtProvinceCode = new TextBox();
            txtName = new TextBox();
            txtCountryCode = new TextBox();
            txtTaxCode = new TextBox();
            txtTaxRate = new TextBox();
            txtFedTax = new TextBox();
            txtFirstPostCode = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btbClose = new Button();
            btnFindCode = new Button();
            btnFindName = new Button();
            txtFindCode = new TextBox();
            txtFindName = new TextBox();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(113, 54);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(223, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Province Post Codes";
            // 
            // lblProvinceCode
            // 
            lblProvinceCode.AutoSize = true;
            lblProvinceCode.Location = new Point(113, 104);
            lblProvinceCode.Name = "lblProvinceCode";
            lblProvinceCode.Size = new Size(84, 15);
            lblProvinceCode.TabIndex = 1;
            lblProvinceCode.Text = "Province Code";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(113, 138);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblCountryCode
            // 
            lblCountryCode.AutoSize = true;
            lblCountryCode.Location = new Point(113, 177);
            lblCountryCode.Name = "lblCountryCode";
            lblCountryCode.Size = new Size(81, 15);
            lblCountryCode.TabIndex = 3;
            lblCountryCode.Text = "Country Code";
            // 
            // lblTaxCode
            // 
            lblTaxCode.AutoSize = true;
            lblTaxCode.Location = new Point(113, 221);
            lblTaxCode.Name = "lblTaxCode";
            lblTaxCode.Size = new Size(55, 15);
            lblTaxCode.TabIndex = 4;
            lblTaxCode.Text = "Tax Code";
            // 
            // lblTaxRate
            // 
            lblTaxRate.AutoSize = true;
            lblTaxRate.Location = new Point(113, 269);
            lblTaxRate.Name = "lblTaxRate";
            lblTaxRate.Size = new Size(50, 15);
            lblTaxRate.TabIndex = 5;
            lblTaxRate.Text = "Tax Rate";
            // 
            // lblFedTax
            // 
            lblFedTax.AutoSize = true;
            lblFedTax.Location = new Point(113, 316);
            lblFedTax.Name = "lblFedTax";
            lblFedTax.Size = new Size(73, 15);
            lblFedTax.TabIndex = 6;
            lblFedTax.Text = "Incl Fed Tax?";
            // 
            // lblFirstPostCode
            // 
            lblFirstPostCode.AutoSize = true;
            lblFirstPostCode.Location = new Point(113, 366);
            lblFirstPostCode.Name = "lblFirstPostCode";
            lblFirstPostCode.Size = new Size(112, 15);
            lblFirstPostCode.TabIndex = 7;
            lblFirstPostCode.Text = "1st Letter Post Code";
            // 
            // txtProvinceCode
            // 
            txtProvinceCode.Location = new Point(280, 101);
            txtProvinceCode.Name = "txtProvinceCode";
            txtProvinceCode.Size = new Size(161, 23);
            txtProvinceCode.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(280, 135);
            txtName.Name = "txtName";
            txtName.Size = new Size(161, 23);
            txtName.TabIndex = 9;
            // 
            // txtCountryCode
            // 
            txtCountryCode.Location = new Point(280, 174);
            txtCountryCode.Name = "txtCountryCode";
            txtCountryCode.Size = new Size(161, 23);
            txtCountryCode.TabIndex = 10;
            // 
            // txtTaxCode
            // 
            txtTaxCode.Location = new Point(280, 218);
            txtTaxCode.Name = "txtTaxCode";
            txtTaxCode.Size = new Size(161, 23);
            txtTaxCode.TabIndex = 11;
            // 
            // txtTaxRate
            // 
            txtTaxRate.Location = new Point(280, 266);
            txtTaxRate.Name = "txtTaxRate";
            txtTaxRate.Size = new Size(161, 23);
            txtTaxRate.TabIndex = 12;
            // 
            // txtFedTax
            // 
            txtFedTax.Location = new Point(280, 313);
            txtFedTax.Name = "txtFedTax";
            txtFedTax.Size = new Size(161, 23);
            txtFedTax.TabIndex = 13;
            // 
            // txtFirstPostCode
            // 
            txtFirstPostCode.Location = new Point(280, 363);
            txtFirstPostCode.Name = "txtFirstPostCode";
            txtFirstPostCode.Size = new Size(161, 23);
            txtFirstPostCode.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(521, 100);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 23);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(521, 129);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 23);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(521, 158);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 23);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btbClose
            // 
            btbClose.Location = new Point(521, 187);
            btbClose.Name = "btbClose";
            btbClose.Size = new Size(92, 23);
            btbClose.TabIndex = 18;
            btbClose.Text = "Close";
            btbClose.UseVisualStyleBackColor = true;
            // 
            // btnFindCode
            // 
            btnFindCode.Location = new Point(521, 216);
            btnFindCode.Name = "btnFindCode";
            btnFindCode.Size = new Size(92, 23);
            btnFindCode.TabIndex = 19;
            btnFindCode.Text = "Find By Code";
            btnFindCode.UseVisualStyleBackColor = true;
            btnFindCode.Click += btnFindCode_Click;
            // 
            // btnFindName
            // 
            btnFindName.Location = new Point(521, 245);
            btnFindName.Name = "btnFindName";
            btnFindName.Size = new Size(92, 23);
            btnFindName.TabIndex = 20;
            btnFindName.Text = "Find By Name";
            btnFindName.UseVisualStyleBackColor = true;
            // 
            // txtFindCode
            // 
            txtFindCode.Location = new Point(619, 216);
            txtFindCode.Name = "txtFindCode";
            txtFindCode.Size = new Size(90, 23);
            txtFindCode.TabIndex = 21;
            // 
            // txtFindName
            // 
            txtFindName.Location = new Point(619, 246);
            txtFindName.Name = "txtFindName";
            txtFindName.Size = new Size(90, 23);
            txtFindName.TabIndex = 22;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(521, 371);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(53, 15);
            lblMessage.TabIndex = 23;
            lblMessage.Text = "message";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMessage);
            Controls.Add(txtFindName);
            Controls.Add(txtFindCode);
            Controls.Add(btnFindName);
            Controls.Add(btnFindCode);
            Controls.Add(btbClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtFirstPostCode);
            Controls.Add(txtFedTax);
            Controls.Add(txtTaxRate);
            Controls.Add(txtTaxCode);
            Controls.Add(txtCountryCode);
            Controls.Add(txtName);
            Controls.Add(txtProvinceCode);
            Controls.Add(lblFirstPostCode);
            Controls.Add(lblFedTax);
            Controls.Add(lblTaxRate);
            Controls.Add(lblTaxCode);
            Controls.Add(lblCountryCode);
            Controls.Add(lblName);
            Controls.Add(lblProvinceCode);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Province Post Codes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblProvinceCode;
        private Label lblName;
        private Label lblCountryCode;
        private Label lblTaxCode;
        private Label lblTaxRate;
        private Label lblFedTax;
        private Label lblFirstPostCode;
        private TextBox txtProvinceCode;
        private TextBox txtName;
        private TextBox txtCountryCode;
        private TextBox txtTaxCode;
        private TextBox txtTaxRate;
        private TextBox txtFedTax;
        private TextBox txtFirstPostCode;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btbClose;
        private Button btnFindCode;
        private Button btnFindName;
        private TextBox txtFindCode;
        private TextBox txtFindName;
        private Label lblMessage;
    }
}
