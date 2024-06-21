namespace InClass3
{
    partial class GradeBookApp
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.grpStatistics = new System.Windows.Forms.GroupBox();
            this.lblNumOfFailures = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.lblNumOfRecords = new System.Windows.Forms.Label();
            this.lbl_NumOfFailures = new System.Windows.Forms.Label();
            this.lbl_Average = new System.Windows.Forms.Label();
            this.lbl_Maximum = new System.Windows.Forms.Label();
            this.lbl_Minimum = new System.Windows.Forms.Label();
            this.lbl_NumOfRecords = new System.Windows.Forms.Label();
            this.btnRecordGrade = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.grpStatistics.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(20, 20);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(78, 13);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(20, 63);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(39, 13);
            this.lblGrade.TabIndex = 1;
            this.lblGrade.Text = "Grade:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.SystemColors.Window;
            this.txtStudentName.Location = new System.Drawing.Point(100, 17);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(0);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(171, 20);
            this.txtStudentName.TabIndex = 2;
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(100, 60);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(0);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(171, 20);
            this.txtGrade.TabIndex = 3;
            // 
            // grpStatistics
            // 
            this.grpStatistics.Controls.Add(this.lblNumOfFailures);
            this.grpStatistics.Controls.Add(this.lblAverage);
            this.grpStatistics.Controls.Add(this.lblMaximum);
            this.grpStatistics.Controls.Add(this.lblMinimum);
            this.grpStatistics.Controls.Add(this.lblNumOfRecords);
            this.grpStatistics.Controls.Add(this.lbl_NumOfFailures);
            this.grpStatistics.Controls.Add(this.lbl_Average);
            this.grpStatistics.Controls.Add(this.lbl_Maximum);
            this.grpStatistics.Controls.Add(this.lbl_Minimum);
            this.grpStatistics.Controls.Add(this.lbl_NumOfRecords);
            this.grpStatistics.Location = new System.Drawing.Point(359, 20);
            this.grpStatistics.Name = "grpStatistics";
            this.grpStatistics.Size = new System.Drawing.Size(200, 161);
            this.grpStatistics.TabIndex = 4;
            this.grpStatistics.TabStop = false;
            this.grpStatistics.Text = "Statistics";
            // 
            // lblNumOfFailures
            // 
            this.lblNumOfFailures.AutoSize = true;
            this.lblNumOfFailures.Location = new System.Drawing.Point(117, 135);
            this.lblNumOfFailures.Margin = new System.Windows.Forms.Padding(0);
            this.lblNumOfFailures.Name = "lblNumOfFailures";
            this.lblNumOfFailures.Size = new System.Drawing.Size(13, 13);
            this.lblNumOfFailures.TabIndex = 14;
            this.lblNumOfFailures.Text = "1";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(117, 107);
            this.lblAverage.Margin = new System.Windows.Forms.Padding(0);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(28, 13);
            this.lblAverage.TabIndex = 13;
            this.lblAverage.Text = "50.0";
            // 
            // lblMaximum
            // 
            this.lblMaximum.AutoSize = true;
            this.lblMaximum.Location = new System.Drawing.Point(117, 79);
            this.lblMaximum.Margin = new System.Windows.Forms.Padding(0);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(34, 13);
            this.lblMaximum.TabIndex = 12;
            this.lblMaximum.Text = "100.0";
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Location = new System.Drawing.Point(117, 51);
            this.lblMinimum.Margin = new System.Windows.Forms.Padding(0);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(22, 13);
            this.lblMinimum.TabIndex = 11;
            this.lblMinimum.Text = "1.0";
            // 
            // lblNumOfRecords
            // 
            this.lblNumOfRecords.AutoSize = true;
            this.lblNumOfRecords.Location = new System.Drawing.Point(117, 20);
            this.lblNumOfRecords.Margin = new System.Windows.Forms.Padding(0);
            this.lblNumOfRecords.Name = "lblNumOfRecords";
            this.lblNumOfRecords.Size = new System.Drawing.Size(13, 13);
            this.lblNumOfRecords.TabIndex = 10;
            this.lblNumOfRecords.Text = "1";
            // 
            // lbl_NumOfFailures
            // 
            this.lbl_NumOfFailures.AutoSize = true;
            this.lbl_NumOfFailures.Location = new System.Drawing.Point(10, 135);
            this.lbl_NumOfFailures.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_NumOfFailures.Name = "lbl_NumOfFailures";
            this.lbl_NumOfFailures.Size = new System.Drawing.Size(65, 13);
            this.lbl_NumOfFailures.TabIndex = 9;
            this.lbl_NumOfFailures.Text = "# of failures:";
            // 
            // lbl_Average
            // 
            this.lbl_Average.AutoSize = true;
            this.lbl_Average.Location = new System.Drawing.Point(10, 107);
            this.lbl_Average.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Average.Name = "lbl_Average";
            this.lbl_Average.Size = new System.Drawing.Size(50, 13);
            this.lbl_Average.TabIndex = 8;
            this.lbl_Average.Text = "Average:";
            // 
            // lbl_Maximum
            // 
            this.lbl_Maximum.AutoSize = true;
            this.lbl_Maximum.Location = new System.Drawing.Point(10, 79);
            this.lbl_Maximum.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Maximum.Name = "lbl_Maximum";
            this.lbl_Maximum.Size = new System.Drawing.Size(54, 13);
            this.lbl_Maximum.TabIndex = 7;
            this.lbl_Maximum.Text = "Maximum:";
            // 
            // lbl_Minimum
            // 
            this.lbl_Minimum.AutoSize = true;
            this.lbl_Minimum.Location = new System.Drawing.Point(10, 51);
            this.lbl_Minimum.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Minimum.Name = "lbl_Minimum";
            this.lbl_Minimum.Size = new System.Drawing.Size(51, 13);
            this.lbl_Minimum.TabIndex = 6;
            this.lbl_Minimum.Text = "Minimum:";
            // 
            // lbl_NumOfRecords
            // 
            this.lbl_NumOfRecords.AutoSize = true;
            this.lbl_NumOfRecords.Location = new System.Drawing.Point(10, 20);
            this.lbl_NumOfRecords.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_NumOfRecords.Name = "lbl_NumOfRecords";
            this.lbl_NumOfRecords.Size = new System.Drawing.Size(67, 13);
            this.lbl_NumOfRecords.TabIndex = 5;
            this.lbl_NumOfRecords.Text = "# of records:";
            // 
            // btnRecordGrade
            // 
            this.btnRecordGrade.Location = new System.Drawing.Point(23, 100);
            this.btnRecordGrade.Name = "btnRecordGrade";
            this.btnRecordGrade.Size = new System.Drawing.Size(125, 23);
            this.btnRecordGrade.TabIndex = 15;
            this.btnRecordGrade.Text = "Record Grade";
            this.btnRecordGrade.UseVisualStyleBackColor = true;
            this.btnRecordGrade.Click += new System.EventHandler(this.btnRecordGrade_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusStrip});
            this.statusStrip.Location = new System.Drawing.Point(0, 188);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(571, 22);
            this.statusStrip.TabIndex = 16;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatusStrip
            // 
            this.lblStatusStrip.Name = "lblStatusStrip";
            this.lblStatusStrip.Size = new System.Drawing.Size(269, 17);
            this.lblStatusStrip.Text = "No grades recorded yet - please enter your grades";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(20, 137);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(55, 13);
            this.lblErrorMessage.TabIndex = 17;
            this.lblErrorMessage.Text = "Error Msg:";
            // 
            // GradeBookApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 210);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnRecordGrade);
            this.Controls.Add(this.grpStatistics);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblStudentName);
            this.Name = "GradeBookApp";
            this.Text = "Form1";
            this.grpStatistics.ResumeLayout(false);
            this.grpStatistics.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.GroupBox grpStatistics;
        private System.Windows.Forms.Label lbl_NumOfRecords;
        private System.Windows.Forms.Label lbl_Minimum;
        private System.Windows.Forms.Label lblNumOfRecords;
        private System.Windows.Forms.Label lbl_NumOfFailures;
        private System.Windows.Forms.Label lbl_Average;
        private System.Windows.Forms.Label lbl_Maximum;
        private System.Windows.Forms.Label lblNumOfFailures;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Button btnRecordGrade;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusStrip;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}

