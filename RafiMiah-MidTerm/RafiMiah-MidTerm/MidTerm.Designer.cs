namespace RafiMiah_MidTerm
{
    partial class MidTerm
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
            this.lblQuestionOne = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.richTxtOutput = new System.Windows.Forms.RichTextBox();
            this.btnRegExOne = new System.Windows.Forms.Button();
            this.btnRegExTwo = new System.Windows.Forms.Button();
            this.lblRegExValidation = new System.Windows.Forms.Label();
            this.lblQuestionTwo = new System.Windows.Forms.Label();
            this.lblMatchRegex = new System.Windows.Forms.Label();
            this.lblPatternsMatched = new System.Windows.Forms.Label();
            this.lblQuestionThree = new System.Windows.Forms.Label();
            this.txtPalindrome = new System.Windows.Forms.TextBox();
            this.btnCheckPalindrome = new System.Windows.Forms.Button();
            this.lblQuestionFour = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentGrade = new System.Windows.Forms.Label();
            this.txtStudentGrade = new System.Windows.Forms.TextBox();
            this.richStudentRecords = new System.Windows.Forms.RichTextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblErrors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestionOne
            // 
            this.lblQuestionOne.AutoSize = true;
            this.lblQuestionOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionOne.Location = new System.Drawing.Point(12, 9);
            this.lblQuestionOne.Name = "lblQuestionOne";
            this.lblQuestionOne.Size = new System.Drawing.Size(139, 29);
            this.lblQuestionOne.TabIndex = 0;
            this.lblQuestionOne.Text = "Question 1";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(17, 51);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(166, 22);
            this.txtInput.TabIndex = 1;
            // 
            // richTxtOutput
            // 
            this.richTxtOutput.Location = new System.Drawing.Point(17, 79);
            this.richTxtOutput.Name = "richTxtOutput";
            this.richTxtOutput.ReadOnly = true;
            this.richTxtOutput.Size = new System.Drawing.Size(166, 66);
            this.richTxtOutput.TabIndex = 2;
            this.richTxtOutput.Text = "";
            // 
            // btnRegExOne
            // 
            this.btnRegExOne.Location = new System.Drawing.Point(189, 79);
            this.btnRegExOne.Name = "btnRegExOne";
            this.btnRegExOne.Size = new System.Drawing.Size(160, 30);
            this.btnRegExOne.TabIndex = 3;
            this.btnRegExOne.Text = "##-###-###-####";
            this.btnRegExOne.UseVisualStyleBackColor = true;
            this.btnRegExOne.Click += new System.EventHandler(this.btnRegExOne_Click);
            // 
            // btnRegExTwo
            // 
            this.btnRegExTwo.Location = new System.Drawing.Point(189, 115);
            this.btnRegExTwo.Name = "btnRegExTwo";
            this.btnRegExTwo.Size = new System.Drawing.Size(160, 30);
            this.btnRegExTwo.TabIndex = 4;
            this.btnRegExTwo.Text = "## (###) ###-####";
            this.btnRegExTwo.UseVisualStyleBackColor = true;
            this.btnRegExTwo.Click += new System.EventHandler(this.btnRegExTwo_Click);
            // 
            // lblRegExValidation
            // 
            this.lblRegExValidation.Location = new System.Drawing.Point(189, 51);
            this.lblRegExValidation.Name = "lblRegExValidation";
            this.lblRegExValidation.Size = new System.Drawing.Size(160, 25);
            this.lblRegExValidation.TabIndex = 5;
            this.lblRegExValidation.Text = "RegEx Validation";
            this.lblRegExValidation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionTwo
            // 
            this.lblQuestionTwo.AutoSize = true;
            this.lblQuestionTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionTwo.Location = new System.Drawing.Point(363, 9);
            this.lblQuestionTwo.Name = "lblQuestionTwo";
            this.lblQuestionTwo.Size = new System.Drawing.Size(139, 29);
            this.lblQuestionTwo.TabIndex = 7;
            this.lblQuestionTwo.Text = "Question 2";
            // 
            // lblMatchRegex
            // 
            this.lblMatchRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchRegex.Location = new System.Drawing.Point(365, 51);
            this.lblMatchRegex.Name = "lblMatchRegex";
            this.lblMatchRegex.Size = new System.Drawing.Size(245, 25);
            this.lblMatchRegex.TabIndex = 8;
            this.lblMatchRegex.Text = "Words matching \\s\\w*z+\\w*";
            this.lblMatchRegex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPatternsMatched
            // 
            this.lblPatternsMatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatternsMatched.Location = new System.Drawing.Point(369, 76);
            this.lblPatternsMatched.Name = "lblPatternsMatched";
            this.lblPatternsMatched.Size = new System.Drawing.Size(241, 111);
            this.lblPatternsMatched.TabIndex = 9;
            this.lblPatternsMatched.Text = " dozen\r\n jazz\r\n pizza\r\n wiz\r\n zealot";
            this.lblPatternsMatched.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionThree
            // 
            this.lblQuestionThree.AutoSize = true;
            this.lblQuestionThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionThree.Location = new System.Drawing.Point(12, 199);
            this.lblQuestionThree.Name = "lblQuestionThree";
            this.lblQuestionThree.Size = new System.Drawing.Size(139, 29);
            this.lblQuestionThree.TabIndex = 10;
            this.lblQuestionThree.Text = "Question 3";
            // 
            // txtPalindrome
            // 
            this.txtPalindrome.Location = new System.Drawing.Point(17, 242);
            this.txtPalindrome.Name = "txtPalindrome";
            this.txtPalindrome.Size = new System.Drawing.Size(166, 22);
            this.txtPalindrome.TabIndex = 11;
            // 
            // btnCheckPalindrome
            // 
            this.btnCheckPalindrome.Location = new System.Drawing.Point(192, 242);
            this.btnCheckPalindrome.Name = "btnCheckPalindrome";
            this.btnCheckPalindrome.Size = new System.Drawing.Size(157, 23);
            this.btnCheckPalindrome.TabIndex = 12;
            this.btnCheckPalindrome.Text = "Check Palindrome";
            this.btnCheckPalindrome.UseVisualStyleBackColor = true;
            this.btnCheckPalindrome.Click += new System.EventHandler(this.btnCheckPalindrome_Click);
            // 
            // lblQuestionFour
            // 
            this.lblQuestionFour.AutoSize = true;
            this.lblQuestionFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionFour.Location = new System.Drawing.Point(12, 289);
            this.lblQuestionFour.Name = "lblQuestionFour";
            this.lblQuestionFour.Size = new System.Drawing.Size(139, 29);
            this.lblQuestionFour.TabIndex = 13;
            this.lblQuestionFour.Text = "Question 4";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStudentId.Location = new System.Drawing.Point(13, 335);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(93, 20);
            this.lblStudentId.TabIndex = 14;
            this.lblStudentId.Text = "Student ID:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(143, 335);
            this.txtStudentId.MaxLength = 5;
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(166, 22);
            this.txtStudentId.TabIndex = 15;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStudentName.Location = new System.Drawing.Point(13, 372);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(120, 20);
            this.lblStudentName.TabIndex = 16;
            this.lblStudentName.Text = "Student Name:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(143, 372);
            this.txtStudentName.MaxLength = 20;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(166, 22);
            this.txtStudentName.TabIndex = 17;
            // 
            // lblStudentGrade
            // 
            this.lblStudentGrade.AutoSize = true;
            this.lblStudentGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStudentGrade.Location = new System.Drawing.Point(13, 410);
            this.lblStudentGrade.Name = "lblStudentGrade";
            this.lblStudentGrade.Size = new System.Drawing.Size(122, 20);
            this.lblStudentGrade.TabIndex = 18;
            this.lblStudentGrade.Text = "Student Grade:";
            // 
            // txtStudentGrade
            // 
            this.txtStudentGrade.Location = new System.Drawing.Point(143, 408);
            this.txtStudentGrade.MaxLength = 3;
            this.txtStudentGrade.Name = "txtStudentGrade";
            this.txtStudentGrade.Size = new System.Drawing.Size(166, 22);
            this.txtStudentGrade.TabIndex = 19;
            // 
            // richStudentRecords
            // 
            this.richStudentRecords.Location = new System.Drawing.Point(336, 332);
            this.richStudentRecords.Name = "richStudentRecords";
            this.richStudentRecords.ReadOnly = true;
            this.richStudentRecords.Size = new System.Drawing.Size(456, 95);
            this.richStudentRecords.TabIndex = 20;
            this.richStudentRecords.Text = "";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(17, 452);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 21;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(98, 452);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateStudent.TabIndex = 22;
            this.btnUpdateStudent.Text = "Update";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(179, 452);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStudent.TabIndex = 23;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(260, 452);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 24;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.ForeColor = System.Drawing.Color.Red;
            this.lblErrors.Location = new System.Drawing.Point(14, 489);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(46, 16);
            this.lblErrors.TabIndex = 25;
            this.lblErrors.Text = "Errors:";
            // 
            // MidTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 518);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.richStudentRecords);
            this.Controls.Add(this.txtStudentGrade);
            this.Controls.Add(this.lblStudentGrade);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.lblQuestionFour);
            this.Controls.Add(this.btnCheckPalindrome);
            this.Controls.Add(this.txtPalindrome);
            this.Controls.Add(this.lblQuestionThree);
            this.Controls.Add(this.lblPatternsMatched);
            this.Controls.Add(this.lblMatchRegex);
            this.Controls.Add(this.lblQuestionTwo);
            this.Controls.Add(this.lblRegExValidation);
            this.Controls.Add(this.btnRegExTwo);
            this.Controls.Add(this.btnRegExOne);
            this.Controls.Add(this.richTxtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblQuestionOne);
            this.Name = "MidTerm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionOne;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RichTextBox richTxtOutput;
        private System.Windows.Forms.Button btnRegExOne;
        private System.Windows.Forms.Button btnRegExTwo;
        private System.Windows.Forms.Label lblRegExValidation;
        private System.Windows.Forms.Label lblQuestionTwo;
        private System.Windows.Forms.Label lblMatchRegex;
        private System.Windows.Forms.Label lblPatternsMatched;
        private System.Windows.Forms.Label lblQuestionThree;
        private System.Windows.Forms.TextBox txtPalindrome;
        private System.Windows.Forms.Button btnCheckPalindrome;
        private System.Windows.Forms.Label lblQuestionFour;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentGrade;
        private System.Windows.Forms.TextBox txtStudentGrade;
        private System.Windows.Forms.RichTextBox richStudentRecords;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblErrors;
    }
}

