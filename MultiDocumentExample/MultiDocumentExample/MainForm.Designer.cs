namespace MultiDocumentExample
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.secondFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thirdFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secondFormToolStripMenuItem,
            this.thirdFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // secondFormToolStripMenuItem
            // 
            this.secondFormToolStripMenuItem.Name = "secondFormToolStripMenuItem";
            this.secondFormToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.secondFormToolStripMenuItem.Text = "SecondForm";
            this.secondFormToolStripMenuItem.Click += new System.EventHandler(this.secondFormToolStripMenuItem_Click);
            // 
            // thirdFormToolStripMenuItem
            // 
            this.thirdFormToolStripMenuItem.Name = "thirdFormToolStripMenuItem";
            this.thirdFormToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.thirdFormToolStripMenuItem.Text = "ThirdForm";
            this.thirdFormToolStripMenuItem.Click += new System.EventHandler(this.thirdFormToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 476);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem secondFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thirdFormToolStripMenuItem;
    }
}

