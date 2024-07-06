namespace InClass4
{
    partial class InClass4Form
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
            this.animalsLbl = new System.Windows.Forms.Label();
            this.animalsLstBox = new System.Windows.Forms.ListBox();
            this.speakBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // animalsLbl
            // 
            this.animalsLbl.AutoSize = true;
            this.animalsLbl.Location = new System.Drawing.Point(12, 3);
            this.animalsLbl.Name = "animalsLbl";
            this.animalsLbl.Size = new System.Drawing.Size(46, 13);
            this.animalsLbl.TabIndex = 0;
            this.animalsLbl.Text = "Animals:";
            // 
            // animalsLstBox
            // 
            this.animalsLstBox.FormattingEnabled = true;
            this.animalsLstBox.Location = new System.Drawing.Point(12, 19);
            this.animalsLstBox.Name = "animalsLstBox";
            this.animalsLstBox.Size = new System.Drawing.Size(120, 95);
            this.animalsLstBox.TabIndex = 1;
            // 
            // speakBtn
            // 
            this.speakBtn.Location = new System.Drawing.Point(157, 19);
            this.speakBtn.Name = "speakBtn";
            this.speakBtn.Size = new System.Drawing.Size(120, 95);
            this.speakBtn.TabIndex = 2;
            this.speakBtn.Text = "Speak";
            this.speakBtn.UseVisualStyleBackColor = true;
            this.speakBtn.Click += new System.EventHandler(this.speakBtn_Click);
            // 
            // InClass4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 127);
            this.Controls.Add(this.speakBtn);
            this.Controls.Add(this.animalsLstBox);
            this.Controls.Add(this.animalsLbl);
            this.Name = "InClass4Form";
            this.Text = "InClass4 Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label animalsLbl;
        private System.Windows.Forms.ListBox animalsLstBox;
        private System.Windows.Forms.Button speakBtn;
    }
}

