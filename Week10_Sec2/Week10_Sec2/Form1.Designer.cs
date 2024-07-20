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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtProvinceCode = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnNumberCheck = new Button();
            label4 = new Label();
            label5 = new Label();
            txtTaxRate = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 108);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Province Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 147);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "label";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 184);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 2;
            label3.Text = "label";
            // 
            // txtProvinceCode
            // 
            txtProvinceCode.Location = new Point(358, 105);
            txtProvinceCode.Name = "txtProvinceCode";
            txtProvinceCode.Size = new Size(125, 27);
            txtProvinceCode.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(358, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(358, 181);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // btnNumberCheck
            // 
            btnNumberCheck.Location = new Point(572, 99);
            btnNumberCheck.Name = "btnNumberCheck";
            btnNumberCheck.Size = new Size(137, 29);
            btnNumberCheck.TabIndex = 6;
            btnNumberCheck.Text = "Number Check";
            btnNumberCheck.UseVisualStyleBackColor = true;
            btnNumberCheck.Click += btnNumberCheck_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(199, 227);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 7;
            label4.Text = "Tax Rate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(199, 272);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 8;
            label5.Text = "Province Code";
            // 
            // txtTaxRate
            // 
            txtTaxRate.Location = new Point(358, 224);
            txtTaxRate.Name = "txtTaxRate";
            txtTaxRate.Size = new Size(125, 27);
            txtTaxRate.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTaxRate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnNumberCheck);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(txtProvinceCode);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtProvinceCode;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnNumberCheck;
        private Label label4;
        private Label label5;
        private TextBox txtTaxRate;
    }
}
