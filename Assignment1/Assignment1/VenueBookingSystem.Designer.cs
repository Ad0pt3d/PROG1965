namespace Assignment1
{
    partial class VenueBookingSystem
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
            this.lblSummary = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lstBoxRows = new System.Windows.Forms.ListBox();
            this.lstBoxColumns = new System.Windows.Forms.ListBox();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bntAddToWaitList = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnFillAllSeats = new System.Windows.Forms.Button();
            this.btnCancelAllBookings = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnA1 = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnA3 = new System.Windows.Forms.Button();
            this.btnA4 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnB4 = new System.Windows.Forms.Button();
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.btnC4 = new System.Windows.Forms.Button();
            this.ttSeatHover = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(10, 10);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(50, 13);
            this.lblSummary.TabIndex = 0;
            this.lblSummary.Text = "Summary";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(525, 351);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(155, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(522, 335);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "CustomerName:";
            // 
            // lstBoxRows
            // 
            this.lstBoxRows.FormattingEnabled = true;
            this.lstBoxRows.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.lstBoxRows.Location = new System.Drawing.Point(541, 74);
            this.lstBoxRows.Name = "lstBoxRows";
            this.lstBoxRows.Size = new System.Drawing.Size(90, 121);
            this.lstBoxRows.TabIndex = 3;
            // 
            // lstBoxColumns
            // 
            this.lstBoxColumns.FormattingEnabled = true;
            this.lstBoxColumns.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.lstBoxColumns.Location = new System.Drawing.Point(657, 74);
            this.lstBoxColumns.Name = "lstBoxColumns";
            this.lstBoxColumns.Size = new System.Drawing.Size(90, 121);
            this.lstBoxColumns.TabIndex = 4;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(538, 58);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(37, 13);
            this.lblRows.TabIndex = 5;
            this.lblRows.Text = "Rows:";
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(654, 58);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(50, 13);
            this.lblColumns.TabIndex = 6;
            this.lblColumns.Text = "Columns:";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(476, 240);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 7;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(557, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bntAddToWaitList
            // 
            this.bntAddToWaitList.Location = new System.Drawing.Point(638, 240);
            this.bntAddToWaitList.Name = "bntAddToWaitList";
            this.bntAddToWaitList.Size = new System.Drawing.Size(109, 23);
            this.bntAddToWaitList.TabIndex = 9;
            this.bntAddToWaitList.Text = "Add to Wait List";
            this.bntAddToWaitList.UseVisualStyleBackColor = true;
            this.bntAddToWaitList.Click += new System.EventHandler(this.bntAddToWaitList_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(476, 269);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(75, 23);
            this.btnStatus.TabIndex = 10;
            this.btnStatus.Text = "Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnFillAllSeats
            // 
            this.btnFillAllSeats.Location = new System.Drawing.Point(557, 269);
            this.btnFillAllSeats.Name = "btnFillAllSeats";
            this.btnFillAllSeats.Size = new System.Drawing.Size(75, 23);
            this.btnFillAllSeats.TabIndex = 11;
            this.btnFillAllSeats.Text = "Fill All Seats";
            this.btnFillAllSeats.UseVisualStyleBackColor = true;
            this.btnFillAllSeats.Click += new System.EventHandler(this.btnFillAllSeats_Click);
            // 
            // btnCancelAllBookings
            // 
            this.btnCancelAllBookings.Location = new System.Drawing.Point(638, 269);
            this.btnCancelAllBookings.Name = "btnCancelAllBookings";
            this.btnCancelAllBookings.Size = new System.Drawing.Size(109, 23);
            this.btnCancelAllBookings.TabIndex = 12;
            this.btnCancelAllBookings.Text = "Cancel All Bookings";
            this.btnCancelAllBookings.UseVisualStyleBackColor = true;
            this.btnCancelAllBookings.Click += new System.EventHandler(this.btnCancelAllBookings_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 428);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 13;
            this.lblMessage.Text = "Message";
            // 
            // btnA1
            // 
            this.btnA1.Location = new System.Drawing.Point(10, 210);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(45, 30);
            this.btnA1.TabIndex = 14;
            this.btnA1.Text = "A1";
            this.btnA1.UseVisualStyleBackColor = true;
            this.btnA1.MouseHover += new System.EventHandler(this.SeatButton_MouseHover);
            // 
            // btnA2
            // 
            this.btnA2.Location = new System.Drawing.Point(60, 210);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(45, 30);
            this.btnA2.TabIndex = 15;
            this.btnA2.Text = "A2";
            this.btnA2.UseVisualStyleBackColor = true;
            this.btnA2.MouseHover += new System.EventHandler(this.SeatButton_MouseHover);
            // 
            // btnA3
            // 
            this.btnA3.Location = new System.Drawing.Point(110, 210);
            this.btnA3.Name = "btnA3";
            this.btnA3.Size = new System.Drawing.Size(45, 30);
            this.btnA3.TabIndex = 16;
            this.btnA3.Text = "A3";
            this.btnA3.UseVisualStyleBackColor = true;
            this.btnA3.MouseHover += new System.EventHandler(this.SeatButton_MouseHover);
            // 
            // btnA4
            // 
            this.btnA4.Location = new System.Drawing.Point(160, 210);
            this.btnA4.Name = "btnA4";
            this.btnA4.Size = new System.Drawing.Size(45, 30);
            this.btnA4.TabIndex = 17;
            this.btnA4.Text = "A4";
            this.btnA4.UseVisualStyleBackColor = true;
            this.btnA4.MouseHover += new System.EventHandler(this.SeatButton_MouseHover);
            // 
            // btnB1
            // 
            this.btnB1.Location = new System.Drawing.Point(10, 246);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(45, 30);
            this.btnB1.TabIndex = 18;
            this.btnB1.Text = "B1";
            this.btnB1.UseVisualStyleBackColor = true;
            this.btnB1.MouseHover += new System.EventHandler(this.SeatButton_MouseHover);
            // 
            // btnB2
            // 
            this.btnB2.Location = new System.Drawing.Point(61, 246);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(45, 30);
            this.btnB2.TabIndex = 19;
            this.btnB2.Text = "B2";
            this.btnB2.UseVisualStyleBackColor = true;
            this.btnB2.MouseHover += new System.EventHandler(this.SeatButton_MouseHover);
            // 
            // btnB3
            // 
            this.btnB3.Location = new System.Drawing.Point(110, 246);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(45, 30);
            this.btnB3.TabIndex = 20;
            this.btnB3.Text = "B3";
            this.btnB3.UseVisualStyleBackColor = true;
            this.btnB3.MouseHover += new System.EventHandler(this.SeatButton_MouseHover);
            // 
            // btnB4
            // 
            this.btnB4.Location = new System.Drawing.Point(160, 246);
            this.btnB4.Name = "btnB4";
            this.btnB4.Size = new System.Drawing.Size(45, 30);
            this.btnB4.TabIndex = 21;
            this.btnB4.Text = "B4";
            this.btnB4.UseVisualStyleBackColor = true;
            this.btnB4.MouseHover += new System.EventHandler(this.SeatButton_MouseHover);
            // 
            // btnC1
            // 
            this.btnC1.Location = new System.Drawing.Point(10, 282);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(45, 30);
            this.btnC1.TabIndex = 22;
            this.btnC1.Text = "C1";
            this.btnC1.UseVisualStyleBackColor = true;
            this.btnC1.MouseHover += new System.EventHandler(this.SeatButton_MouseHover);
            // 
            // btnC2
            // 
            this.btnC2.Location = new System.Drawing.Point(61, 282);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(45, 30);
            this.btnC2.TabIndex = 23;
            this.btnC2.Text = "C2";
            this.btnC2.UseVisualStyleBackColor = true;
            this.btnC2.MouseHover += new System.EventHandler(this.SeatButton_MouseHover);
            // 
            // btnC3
            // 
            this.btnC3.Location = new System.Drawing.Point(110, 282);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(45, 30);
            this.btnC3.TabIndex = 24;
            this.btnC3.Text = "C3";
            this.btnC3.UseVisualStyleBackColor = true;
            this.btnC3.MouseHover += new System.EventHandler(this.SeatButton_MouseHover);
            // 
            // btnC4
            // 
            this.btnC4.Location = new System.Drawing.Point(160, 282);
            this.btnC4.Name = "btnC4";
            this.btnC4.Size = new System.Drawing.Size(45, 30);
            this.btnC4.TabIndex = 25;
            this.btnC4.Text = "C4";
            this.btnC4.UseVisualStyleBackColor = true;
            this.btnC4.MouseHover += new System.EventHandler(this.SeatButton_MouseHover);
            // 
            // VenueBookingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnC4);
            this.Controls.Add(this.btnC3);
            this.Controls.Add(this.btnC2);
            this.Controls.Add(this.btnC1);
            this.Controls.Add(this.btnB4);
            this.Controls.Add(this.btnB3);
            this.Controls.Add(this.btnB2);
            this.Controls.Add(this.btnA1);
            this.Controls.Add(this.btnB1);
            this.Controls.Add(this.btnA4);
            this.Controls.Add(this.btnA3);
            this.Controls.Add(this.btnA2);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCancelAllBookings);
            this.Controls.Add(this.btnFillAllSeats);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.bntAddToWaitList);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.lblColumns);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.lstBoxColumns);
            this.Controls.Add(this.lstBoxRows);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblSummary);
            this.Name = "VenueBookingSystem";
            this.Text = "Venue Booking System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.ListBox lstBoxRows;
        private System.Windows.Forms.ListBox lstBoxColumns;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button bntAddToWaitList;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnFillAllSeats;
        private System.Windows.Forms.Button btnCancelAllBookings;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.Button btnA4;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnB4;
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.Button btnC4;
        private System.Windows.Forms.ToolTip ttSeatHover;
    }
}

