namespace InClass2
{
    partial class ClockDateAlarm
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
            this.components = new System.ComponentModel.Container();
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.AmPmLabel = new System.Windows.Forms.Label();
            this.CurrentSecondLabel = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.AlarmTimer = new System.Windows.Forms.Timer(this.components);
            this.AlarmPictureBox = new System.Windows.Forms.PictureBox();
            this.AlarmTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AlarmTimeLabel = new System.Windows.Forms.Label();
            this.DotwLabel = new System.Windows.Forms.Label();
            this.CurrentDayLabel = new System.Windows.Forms.Label();
            this.CurrentDateLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.AlarmStatusLabel = new System.Windows.Forms.Label();
            this.AlarmOnButton = new System.Windows.Forms.Button();
            this.AlarmOffButton = new System.Windows.Forms.Button();
            this.StopAlarmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.BackColor = System.Drawing.Color.White;
            this.CurrentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTimeLabel.Location = new System.Drawing.Point(219, 9);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CurrentTimeLabel.Size = new System.Drawing.Size(263, 97);
            this.CurrentTimeLabel.TabIndex = 0;
            this.CurrentTimeLabel.Text = "00:00";
            this.CurrentTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AmPmLabel
            // 
            this.AmPmLabel.AutoSize = true;
            this.AmPmLabel.BackColor = System.Drawing.Color.White;
            this.AmPmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmPmLabel.Location = new System.Drawing.Point(488, 69);
            this.AmPmLabel.Name = "AmPmLabel";
            this.AmPmLabel.Size = new System.Drawing.Size(67, 37);
            this.AmPmLabel.TabIndex = 1;
            this.AmPmLabel.Text = "AM";
            // 
            // CurrentSecondLabel
            // 
            this.CurrentSecondLabel.BackColor = System.Drawing.Color.White;
            this.CurrentSecondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentSecondLabel.Location = new System.Drawing.Point(488, 9);
            this.CurrentSecondLabel.Name = "CurrentSecondLabel";
            this.CurrentSecondLabel.Size = new System.Drawing.Size(67, 37);
            this.CurrentSecondLabel.TabIndex = 2;
            this.CurrentSecondLabel.Text = "00";
            this.CurrentSecondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClockTimer
            // 
            this.ClockTimer.Tick += new System.EventHandler(this.CurrentTimeTimer_Tick);
            // 
            // AlarmPictureBox
            // 
            this.AlarmPictureBox.Image = global::InClass2.Properties.Resources.businessman_with_money;
            this.AlarmPictureBox.Location = new System.Drawing.Point(488, 136);
            this.AlarmPictureBox.Name = "AlarmPictureBox";
            this.AlarmPictureBox.Size = new System.Drawing.Size(300, 196);
            this.AlarmPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AlarmPictureBox.TabIndex = 3;
            this.AlarmPictureBox.TabStop = false;
            // 
            // AlarmTimePicker
            // 
            this.AlarmTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.AlarmTimePicker.Location = new System.Drawing.Point(45, 161);
            this.AlarmTimePicker.Name = "AlarmTimePicker";
            this.AlarmTimePicker.Size = new System.Drawing.Size(237, 44);
            this.AlarmTimePicker.TabIndex = 4;
            this.AlarmTimePicker.Value = new System.DateTime(2024, 5, 29, 12, 0, 0, 0);
            // 
            // AlarmTimeLabel
            // 
            this.AlarmTimeLabel.AutoSize = true;
            this.AlarmTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.AlarmTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmTimeLabel.Location = new System.Drawing.Point(41, 138);
            this.AlarmTimeLabel.Name = "AlarmTimeLabel";
            this.AlarmTimeLabel.Size = new System.Drawing.Size(88, 20);
            this.AlarmTimeLabel.TabIndex = 5;
            this.AlarmTimeLabel.Text = "Alarm Time";
            // 
            // DotwLabel
            // 
            this.DotwLabel.AutoSize = true;
            this.DotwLabel.BackColor = System.Drawing.Color.Transparent;
            this.DotwLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotwLabel.Location = new System.Drawing.Point(491, 349);
            this.DotwLabel.Name = "DotwLabel";
            this.DotwLabel.Size = new System.Drawing.Size(127, 20);
            this.DotwLabel.TabIndex = 6;
            this.DotwLabel.Text = "Day of the Week";
            // 
            // CurrentDayLabel
            // 
            this.CurrentDayLabel.BackColor = System.Drawing.Color.White;
            this.CurrentDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDayLabel.Location = new System.Drawing.Point(488, 369);
            this.CurrentDayLabel.Name = "CurrentDayLabel";
            this.CurrentDayLabel.Size = new System.Drawing.Size(225, 37);
            this.CurrentDayLabel.TabIndex = 7;
            this.CurrentDayLabel.Text = "Wednesday";
            this.CurrentDayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentDateLabel
            // 
            this.CurrentDateLabel.BackColor = System.Drawing.Color.White;
            this.CurrentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDateLabel.Location = new System.Drawing.Point(46, 369);
            this.CurrentDateLabel.Name = "CurrentDateLabel";
            this.CurrentDateLabel.Size = new System.Drawing.Size(225, 37);
            this.CurrentDateLabel.TabIndex = 8;
            this.CurrentDateLabel.Text = "01:01:0001";
            this.CurrentDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(49, 349);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(44, 20);
            this.DateLabel.TabIndex = 9;
            this.DateLabel.Text = "Date";
            // 
            // AlarmStatusLabel
            // 
            this.AlarmStatusLabel.AutoSize = true;
            this.AlarmStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.AlarmStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmStatusLabel.Location = new System.Drawing.Point(49, 276);
            this.AlarmStatusLabel.Name = "AlarmStatusLabel";
            this.AlarmStatusLabel.Size = new System.Drawing.Size(148, 20);
            this.AlarmStatusLabel.TabIndex = 10;
            this.AlarmStatusLabel.Text = "Alarm Status: Off";
            // 
            // AlarmOnButton
            // 
            this.AlarmOnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmOnButton.Location = new System.Drawing.Point(45, 214);
            this.AlarmOnButton.Name = "AlarmOnButton";
            this.AlarmOnButton.Size = new System.Drawing.Size(107, 33);
            this.AlarmOnButton.TabIndex = 11;
            this.AlarmOnButton.Text = "Alarm On";
            this.AlarmOnButton.UseVisualStyleBackColor = true;
            this.AlarmOnButton.Click += new System.EventHandler(this.AlarmOnButton_Click);
            // 
            // AlarmOffButton
            // 
            this.AlarmOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmOffButton.Location = new System.Drawing.Point(175, 214);
            this.AlarmOffButton.Name = "AlarmOffButton";
            this.AlarmOffButton.Size = new System.Drawing.Size(107, 33);
            this.AlarmOffButton.TabIndex = 12;
            this.AlarmOffButton.Text = "Alarm Off";
            this.AlarmOffButton.UseVisualStyleBackColor = true;
            this.AlarmOffButton.Click += new System.EventHandler(this.AlarmOffButton_Click);
            // 
            // StopAlarmButton
            // 
            this.StopAlarmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.StopAlarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopAlarmButton.Location = new System.Drawing.Point(296, 257);
            this.StopAlarmButton.Name = "StopAlarmButton";
            this.StopAlarmButton.Size = new System.Drawing.Size(169, 49);
            this.StopAlarmButton.TabIndex = 13;
            this.StopAlarmButton.Text = "Stop Alarm";
            this.StopAlarmButton.UseVisualStyleBackColor = false;
            this.StopAlarmButton.Click += new System.EventHandler(this.StopAlarmButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StopAlarmButton);
            this.Controls.Add(this.AlarmOffButton);
            this.Controls.Add(this.AlarmOnButton);
            this.Controls.Add(this.AlarmStatusLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.CurrentDateLabel);
            this.Controls.Add(this.CurrentDayLabel);
            this.Controls.Add(this.DotwLabel);
            this.Controls.Add(this.AlarmTimeLabel);
            this.Controls.Add(this.AlarmTimePicker);
            this.Controls.Add(this.AlarmPictureBox);
            this.Controls.Add(this.CurrentSecondLabel);
            this.Controls.Add(this.AmPmLabel);
            this.Controls.Add(this.CurrentTimeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ClockDateAlarm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlarmPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentTimeLabel;
        private System.Windows.Forms.Label AmPmLabel;
        private System.Windows.Forms.Label CurrentSecondLabel;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Timer AlarmTimer;
        private System.Windows.Forms.PictureBox AlarmPictureBox;
        private System.Windows.Forms.DateTimePicker AlarmTimePicker;
        private System.Windows.Forms.Label AlarmTimeLabel;
        private System.Windows.Forms.Label DotwLabel;
        private System.Windows.Forms.Label CurrentDayLabel;
        private System.Windows.Forms.Label CurrentDateLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label AlarmStatusLabel;
        private System.Windows.Forms.Button AlarmOnButton;
        private System.Windows.Forms.Button AlarmOffButton;
        private System.Windows.Forms.Button StopAlarmButton;
    }
}

