using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClass2
{
    /* ClockDateAlarm.cs
     * A Windows Forms App that has a clock (hours:minutes:seconds) in am/pm format
     * with current date and day of the week, along with an alarm with alarm status.
     * A picture will display when the current time is equal to the alarm time,
     * the user can adjust the alarm by clicking each hh:mm:ss am spot and changing the number
     * 
     * Revision History:
     *      Rafi Miah & Danial Tossel, 2024.05.29: Created
     */

    public partial class ClockDateAlarm : Form
    {
        bool alarmActive = false; // Used for if alarm is activated

        public ClockDateAlarm()
        {
            InitializeComponent();
        }

        // Method called when form loads
        private void ClockDateAlarm_Load(object sender, EventArgs e)
        {
            ClockTimer.Start(); // Starts timer for clock
            CurrentDayLabel.Text = DateTime.Today.ToString("dddd"); // Sets label to current day of the week
            CurrentDateLabel.Text = DateTime.Today.ToString("MM:dd:yyyy"); // Sets label to current date (dd:mm:yyyy)

            AlarmPictureBox.Visible = false; // Hides alarm picture
            StopAlarmButton.Visible = false; // Hides stop alarm button
        }

        // Method called each timer tick
        private void CurrentTimeTimer_Tick(object sender, EventArgs e)
        {
            string currentTimeFull = DateTime.Now.ToString("T"); // To set variable to current time in (hh:mm:ss am/pm) format
            string currentTime;
            string currentSecond;
            string amPM;

            // Statement used to adjust the variables to each definition
            if (currentTimeFull[1] == ':')
            {
                currentTime = currentTimeFull.Remove(4);
                currentSecond = currentTimeFull.Remove(0, 5);
                currentSecond = currentSecond.Remove(3);
                amPM = currentTimeFull.Remove(0, 7);
            }
            else
            {
                currentTime = currentTimeFull.Remove(5);
                currentSecond = currentTimeFull.Remove(0, 6);
                currentSecond = currentSecond.Remove(3);
                amPM = currentTimeFull.Remove(0, 8);
            }

            // Sets the labels to the variables
            CurrentTimeLabel.Text = currentTime;
            CurrentSecondLabel.Text = currentSecond;
            AmPmLabel.Text = amPM;

            // Alarm checker statement
            if (AlarmTimePicker.Text == currentTimeFull && alarmActive == true)
            {
                AlarmPictureBox.Visible = true;
                StopAlarmButton.Visible = true;
            }
        }

        // Method called when Alarm On button clicked
        private void AlarmOnButton_Click(object sender, EventArgs e)
        {
            alarmActive = true;
            AlarmStatusLabel.Text = "Alarm Status: On";
        }

        // Method called when Alarm Off button clicked
        private void AlarmOffButton_Click(object sender, EventArgs e)
        {
            alarmActive = false;
            AlarmStatusLabel.Text = "Alarm Status: Off";
        }

        // Method called when Stop Alarm button clicked
        private void StopAlarmButton_Click(object sender, EventArgs e)
        {
            AlarmPictureBox.Visible = false;
            alarmActive = false;
            AlarmStatusLabel.Text = "Alarm Status: Off";
            StopAlarmButton.Visible = false;
        }
    }
}
