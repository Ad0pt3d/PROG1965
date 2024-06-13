using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* GradeBookApp.cs
     * An app that records students grades and gives statistics about the list
     * of grades. (i.e. All grades entered, minimum grade, maximum grade, average grade,
     * and all failure grades. It has basic validation and status messages to inform
     * the user what is happening.
     * 
     * Revision History:
     *      Rafi Miah & Danial Tossel, 2024.06.12: Created
     */

namespace InClass3
{
    public partial class GradeBookApp : Form
    {
        private GradeBook gradeBook;  // Declare gradeBook variable of type GradeBook

        public GradeBookApp()
        {
            InitializeComponent();
            gradeBook = new GradeBook(); // Creates gradebook object from GradeBook class
            grpStatistics.Visible = false; // Sets groupbox for statistics to hidden
            lblErrorMessage.Visible = false; // Sets label for error messages to hidden
        }

        /* A Grade class that stores student names and grades. Also
         * checks validation against empty name and grades below 0 or
         * above 100 and errors if validation fails.
         */
        public class Grade
        {
            public string studentName;
            public double numericGrade;

            
            public Grade(string studentName, double numericGrade)
            {
                // If statement to check if studentName is empty.
                if (string.IsNullOrEmpty(studentName))
                {
                    throw new ArgumentException("The student name cannot be empty."); // Throws and error if empty string.
                }

                // If statement to check if numericGrade is less than 0 or greater than 100.
                if (numericGrade < 0 || numericGrade > 100)
                {
                    throw new ArgumentException("The numeric grade must be a valid number between 0.0 and 100.0."); // Throws and error if greater than 100 or less than 0.
                }

                this.studentName = studentName;
                this.numericGrade = numericGrade;
            }  
        }

        /* A GradeBook class that stores all grades in a list as well as methods
         * to add grades to list check how many grades are entered, the minimum grade,
         * maximum grade, average grade, and how many failure grades
         */
        public class GradeBook
        {
            private List<Grade> grades; // Declare variable called grades as a list that is of type Grade

            public GradeBook()
            {
                grades = new List<Grade>(); // Assign grades to a new list of type Grade
            }

            public void AddGrade(Grade grade)
            {
                grades.Add(grade); // Add grade to grades list
            }

            public int NumberOfGrades => grades.Count; // A lambda function to return the amount of grades in the list


            public double MinimumGrade()
            {
                double minGrade = 0.0;

                if (grades.Count > 0)
                {
                    // Uses the Min() method on the list of grades and calls with a selector parameter
                    // because the list isn't explicitly a numerical value.
                    minGrade = grades.Min(mGrade => mGrade.numericGrade);
                }

                return minGrade;
            }

            public double MaximumGrade()
            {
                double maxGrade = 0.0;

                if (grades.Count > 0)
                {
                    // Uses the Max() method on the list of grades and calls with a selector parameter
                    // because the list isn't explicitly a numerical value.
                    maxGrade = grades.Max(mGrade => mGrade.numericGrade);
                }

                return maxGrade;
            }

            public double AverageGrade()
            {
                double averageGrade = 0.0;

                if (grades.Count > 0)
                {
                    // Uses the Average() method on the list of grades and calls with a selector parameter
                    // because the list isn't explicitly a numerical value.
                    averageGrade = grades.Average(aGrade => aGrade.numericGrade);
                }

                return averageGrade;
            }

            public int NumberOfFailures()
            {
                int numOfFailures = 0;

                if (grades.Count > 0)
                {
                    // Uses the Count() method on the list of grades and calls with a selector parameter
                    // because the list isn't explicitly a numerical value.
                    numOfFailures = grades.Count(aGrade => aGrade.numericGrade < 55); // Counts all grades under 55
                }

                return numOfFailures;
            }
        }

        private void btnRecordGrade_Click(object sender, EventArgs e)
        {
            string studentName = "";
            double numericGrade = 0.0;

            // If string is empty or null
            if (string.IsNullOrEmpty(txtStudentName.Text))
            {
                lblErrorMessage.Text = "The student name cannot be empty."; // Writes error message
                txtStudentName.BackColor = Color.FromArgb(255, 255, 192, 192); // Sets textbox color to red
                lblErrorMessage.Visible = true; // Makes error message visible
            }
            else
            {
                studentName = txtStudentName.Text; 
                txtStudentName.BackColor = SystemColors.Window; // Sets textbox color to default
                lblErrorMessage.Visible = false; // Hides error message
            }

            if (double.TryParse(txtGrade.Text, out numericGrade))
            {
                try
                {
                    if (numericGrade < 0 || numericGrade > 100)
                    {
                        lblErrorMessage.Text = "The numeric grade must be a valid number between 0.0 and 100.0."; // Writes error message
                        txtGrade.BackColor = Color.FromArgb(255, 255, 192, 192); // Sets textbox color to red
                        lblErrorMessage.Visible = true; // Makes error message visible
                    }
                    else
                    {
                        Grade grade = new Grade(studentName, numericGrade); // Creates a new grade class with the current parameters
                        gradeBook.AddGrade(grade); // Adds the grade to the list in gradeBook
                        UpdateStatistics();
                        lblStatusStrip.Text = $"The grade {studentName} ({numericGrade:#.#}) was recorded."; // Text for status strip
                        grpStatistics.Visible = true; // Makes groupbox for statistics visible
                        txtGrade.BackColor = SystemColors.Window; // Sets textbox color to default
                        lblErrorMessage.Visible = false; // Hides error message
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("An error has occurred");
                }
            }
            else
            {
                lblErrorMessage.Text = "The numeric grade must be a valid number between 0.0 and 100.0."; // Writes error message
                txtGrade.BackColor = Color.FromArgb(255, 255, 192, 192); // Sets textbox color to red
                lblErrorMessage.Visible = true; // Makes error message visible
            }

            
        }

        private void UpdateStatistics()
        {
            lblNumOfRecords.Text = $"{gradeBook.NumberOfGrades}";
            lblMinimum.Text = $"{gradeBook.MinimumGrade():#.#}";
            lblMaximum.Text = $"{gradeBook.MaximumGrade():#.#}";
            lblAverage.Text = $"{gradeBook.AverageGrade():#.#}";
            lblNumOfFailures.Text = $"{gradeBook.NumberOfFailures()}";
        }
    }

    
}
