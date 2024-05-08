namespace MessageBoxDemo
{
    partial class Form1
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
            this.messageBoxBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageBoxBtn
            // 
            this.messageBoxBtn.Location = new System.Drawing.Point(350, 222);
            this.messageBoxBtn.Name = "messageBoxBtn";
            this.messageBoxBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.messageBoxBtn.Size = new System.Drawing.Size(147, 37);
            this.messageBoxBtn.TabIndex = 0;
            this.messageBoxBtn.Text = "Message Box";
            this.messageBoxBtn.UseVisualStyleBackColor = true;
            this.messageBoxBtn.Click += new System.EventHandler(this.messageBoxBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.messageBoxBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button messageBoxBtn;
    }
}

