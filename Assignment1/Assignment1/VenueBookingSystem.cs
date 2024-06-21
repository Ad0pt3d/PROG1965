using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment1
{
    public partial class VenueBookingSystem : Form
    {
        private Venue venue;

        private Button[,] seatButtons; // array of type button

        public VenueBookingSystem()
        {
            InitializeComponent();

            venue = new Venue(3, 4); // create a venue object with 3 rows and 4 columns

            seatButtons = new Button[3, 4]; // create buttons for array 3 by 4

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    switch (row)
                    {
                        case 0:
                            seatButtons[row, col] = (Button)Controls[$"btnA{col + 1}"]; // assign row 1 to row A buttons on form
                            seatButtons[row, col].BackColor = Color.Lime;
                            break;
                        case 1:
                            seatButtons[row, col] = (Button)Controls[$"btnB{col + 1}"]; // assign row 2 to row B buttons on form
                            seatButtons[row, col].BackColor = Color.Lime;
                            break;
                        case 2:
                            seatButtons[row, col] = (Button)Controls[$"btnC{col + 1}"]; // assign row 3 to row C buttons on form
                            seatButtons[row, col].BackColor = Color.Lime;
                            break;
                    }
                }
            }

            UpdateSummary();
        }

        private void SeatButton_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender; // get sender as button
            string seat = btn.Text;
            int row = 0;
            int col = int.Parse(Convert.ToString(seat[1])) - 1; // convert btn text to int 

            // assign each letter to row number
            switch (seat[0])
            {
                case 'A':
                    row = 0;
                    break;
                case 'B':
                    row = 1;
                    break;
                case 'C':
                    row = 2;
                    break;
            }

            string status = venue.GetSeatStatus(row, col);
            if (status != "Available")
            {
                ttSeatHover.Show($"Booked by: {status}", seatButtons[row, col]); // tooltip show
            }
        }   

        private void btnBook_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text;
            if (string.IsNullOrWhiteSpace(name) || lstBoxRows.SelectedIndex == -1 || lstBoxColumns.SelectedIndex == -1)
            {
                lblMessage.Text = "Please enter a name and select a seat.";
                return;
            }

            int row = lstBoxRows.SelectedIndex;
            int col = lstBoxColumns.SelectedIndex;

            if (venue.BookSeat(row, col, name))
            {
                lblMessage.Text = $"{name} was booked in seat {seatButtons[row, col].Text}.";
                seatButtons[row, col].BackColor = Color.Red;
            }
            else
            {
                lblMessage.Text = $"{seatButtons[row, col].Text} is already taken.";
            }

            UpdateSummary();
        }

        private void bntAddToWaitList_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text;
            if (venue.AvailableSeatsCount() > 0)
            {
                lblMessage.Text = "Seats are available.";
                return;
            }

            venue.AddToWaitingList(name);
            lblMessage.Text = $"{name} was added to the waiting list.";
            UpdateSummary();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            if (lstBoxRows.SelectedIndex == -1 || lstBoxColumns.SelectedIndex == -1)
            {
                lblMessage.Text = "Please select a seat to check status.";
                return;
            }

            int row = lstBoxRows.SelectedIndex;
            int col = lstBoxColumns.SelectedIndex;
            string status = venue.GetSeatStatus(row, col);
            lblMessage.Text = $"{seatButtons[row, col].Text}: {status}";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (lstBoxRows.SelectedIndex == -1 || lstBoxColumns.SelectedIndex == -1)
            {
                lblMessage.Text = "Please select a seat to cancel.";
                return;
            }

            int row = lstBoxRows.SelectedIndex;
            int col = lstBoxColumns.SelectedIndex;
            if (venue.CancelBooking(row, col))
            {
                lblMessage.Text = $"Cancelled booking for {seatButtons[row, col].Text}.";
                if (venue.WaitingListCount() > 0)
                {
                    seatButtons[row, col].BackColor = Color.Red;
                }
                seatButtons[row, col].BackColor = Color.Lime;
            }
            else
            {
                lblMessage.Text = $"{seatButtons[row, col].Text} is available.";
            }

            UpdateSummary();
        }

        private void btnFillAllSeats_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                lblMessage.Text = "Please enter a name.";
                return;
            }

            venue.FillAllSeats(name);
            lblMessage.Text = "All seats have been filled.";

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (venue.GetSeatStatus(row, col) != "Available")
                    {
                        seatButtons[row, col].BackColor = Color.Red;
                    }
                }
            }

            UpdateSummary();
        }

        private void btnCancelAllBookings_Click(object sender, EventArgs e)
        {
            venue.CancelAllBookings();
            lblMessage.Text = "All bookings have been canceled.";

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    seatButtons[row, col].BackColor = Color.Lime;
                }
            }

            UpdateSummary();
        }

        private void UpdateSummary()
        {
            int totalSeats = 12;
            int availableSeats = venue.AvailableSeatsCount();
            int waitingListCount = venue.WaitingListCount();
            lblSummary.Text = $"Total Capacity: {totalSeats}, Seats Available: {availableSeats} (i.e. at {(availableSeats * 100) / totalSeats}% capacity), Waiting List: {waitingListCount}";
        }
    }
}
