using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RafiMiah_MidTerm
{
    public partial class MidTerm : Form
    {
        public MidTerm()
        {
            InitializeComponent();
        }

        private string Reverse(string text)
        {
            string reversedString;

            char[] stringArray = text.ToCharArray();
            Array.Reverse(stringArray);
            reversedString = new string(stringArray);

            return reversedString;
        }

        private void btnRegExOne_Click(object sender, EventArgs e)
        {
            string userInput;

            Regex patternOne = new Regex(@"^(\d{2}-\d{3}-\d{3}-\d{4})$");
            Match matchedPatternOne = patternOne.Match(txtInput.Text);

            if (matchedPatternOne.Success)
            {
                userInput = matchedPatternOne.Groups[1].Value;

                richTxtOutput.Text = $"{userInput} matches the pattern ##-###-###-####";
            } 
            else
            {
                userInput = txtInput.Text;

                richTxtOutput.Text = $"{userInput} does not match the pattern ##-###-###-####";
            }
        }

        private void btnRegExTwo_Click(object sender, EventArgs e)
        {
            string userInput;

            Regex patternTwo = new Regex(@"^(\d{2}\s\(\d{3}\)\s\d{3}-\d{4})$");
            Match matchedPatternTwo = patternTwo.Match(txtInput.Text);

            if (matchedPatternTwo.Success)
            {
                userInput = matchedPatternTwo.Groups[1].Value;

                richTxtOutput.Text = $"{userInput} matches the pattern ## (###) ###-####";
            }
            else
            {
                userInput = txtInput.Text;

                richTxtOutput.Text = $"{userInput} does not match the pattern ## (###) ###-####";
            }
        }

        private void btnCheckPalindrome_Click(object sender, EventArgs e)
        {
            Regex palindromeLengthPattern = new Regex(@"^(\d{3,9})$");
            Match matchedPalindromePattern = palindromeLengthPattern.Match(txtPalindrome.Text);


            string userInput = txtPalindrome.Text;
            if (matchedPalindromePattern.Success)
            {
                string reverseUserInput = Reverse(userInput);

                if (userInput == reverseUserInput)
                {
                    MessageBox.Show($"The entered value {userInput} is a palindrome.\nEntered Value: {userInput} | Reveresed Value: {reverseUserInput}",
                        "Palindrome Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show($"The entered value {userInput} is not a palindrome.\nEntered Value: {userInput} | Reveresed Value: {reverseUserInput}",
                        "Palindrome Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Please enter a number that is greater than 2 digits, and less than 10 digits, and not negative.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int[] studentIdRecords = new int[5];
        string[] studentNameRecords = new string[5];
        int[] studentGradeRecords = new int[5];

        int studentId = 0;
        string studentName = "";
        int studentGrade = 0;

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            

            if (Convert.ToInt32(txtStudentId.Text.Trim()) > 0) 
            {
                studentId = Convert.ToInt32(txtStudentId.Text.Trim());
            }
            else
            {
                lblErrors.Text = "Student Id must be greater than 0";
            }
            
            studentName = txtStudentName.Text.Trim();

            if (Convert.ToInt32(txtStudentGrade.Text.Trim()) < 0 || Convert.ToInt32(txtStudentGrade.Text.Trim()) > 100)
            {
                lblErrors.Text = "Student Grade must be between 0 and 100";
            }
            else
            {
                studentGrade = Convert.ToInt32(txtStudentGrade.Text.Trim());
            }

            for (int i = 0; i < studentIdRecords.Length; i++)
            {
                if (studentIdRecords[i] == studentId)
                {
                    break;
                }
                else if (studentIdRecords[i] == 0)
                {
                    studentIdRecords[i] = studentId;
                    break;
                }
            }            

            for (int i = 0; i < studentNameRecords.Length; i++)
            {

                if (studentNameRecords[i] == studentName)
                {
                    break;
                }
                else if (studentNameRecords[i] == null)
                {
                    studentNameRecords[i] = studentName;
                    break;
                }
            }

            for (int i = 0; i < studentGradeRecords.Length; i++)
            {
                if (studentGradeRecords[i] == studentGrade)
                {
                    break;
                }
                else if (studentGradeRecords[i] == 0)
                {
                    studentGradeRecords[i] = studentGrade;
                    break;
                }
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtStudentId.Text.Trim()) > 0)
            {
                studentId = Convert.ToInt32(txtStudentId.Text.Trim());
            }
            else
            {
                lblErrors.Text = "Student Id must be greater than 0";
            }

            if (Convert.ToInt32(txtStudentGrade.Text.Trim()) < 0 || Convert.ToInt32(txtStudentGrade.Text.Trim()) > 100)
            {
                lblErrors.Text = "Student Grade must be between 0 and 100";
            }
            else
            {
                studentGrade = Convert.ToInt32(txtStudentGrade.Text.Trim());
            }

            for (int i = 0; i < studentIdRecords.Length; i++)
            {
                if (studentIdRecords[i] == studentId)
                {
                    break;
                }
            }

            for (int i = 0; i < studentGradeRecords.Length; i++)
            {
                if (studentGradeRecords[i] == studentGrade)
                {
                    studentGradeRecords[i] = studentGrade;
                    break;
                }
            }
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtStudentId.Text.Trim()) > 0)
            {
                studentId = Convert.ToInt32(txtStudentId.Text.Trim());
            }
            else
            {
                lblErrors.Text = "Student Id must be greater than 0";
            }

            for (int i = 0; i < studentIdRecords.Length; i++)
            {
                if (studentIdRecords[i] == studentId)
                {
                    richStudentRecords.Text = $"Student Id: {studentIdRecords[i]} " +
                        $"| Student Name: {studentNameRecords[i]} | Student Grade: {studentGradeRecords[i]}";
                }
                else
                {
                    lblErrors.Text = "Student cannot be found";
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < studentIdRecords.Length; i++)
            {
                richStudentRecords.Text += $"\nStudent Id: {studentIdRecords[i]} " +
                        $"| Student Name: {studentNameRecords[i]} | Student Grade: {studentGradeRecords[i]}";
            }
        }
    }
}
