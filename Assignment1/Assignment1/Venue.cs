using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment1
{
    // venue class

    public class Venue
    {
        private string[,] seats; // array for seats
        private Queue<string> waitingList; // a list for the waiting list of type Queue which follow FIFO rules

        // Class constructor
        public Venue(int rows, int columns)
        {
            seats = new string[rows, columns]; // assign seats
            waitingList = new Queue<string>(); // create waiting list
        }

        // BookSeat method
        public bool BookSeat(int row, int column, string name)
        {
            // if seat is empty assign to name
            if (seats[row, column] == null)
            {
                seats[row, column] = name;
                return true;
            }
            return false;
        }

        // AddToWaitingList method
        public void AddToWaitingList(string name)
        {
            waitingList.Enqueue(name); // adds name to waiting list queue
        }

        // GetSeatStatus method
        public string GetSeatStatus(int row, int column)
        {
            // if seat is empty returns "Available"
            if (seats[row, column] == null)
            {
                return "Available";
            }
            return seats[row, column]; // returns seat name if occupied          
        }

        // CancelBooking method
        public bool CancelBooking(int row, int column)
        {
            // if seat is occupied cancel booking
            if (seats[row, column] != null)
            {
                seats[row, column] = null;
                if (waitingList.Count > 0)
                {
                    seats[row, column] = waitingList.Dequeue(); // give canceled seat to waiting list
                }
                return true;
            }
            return false;
        }

        // FillAllSeats method
        public void FillAllSeats(string name)
        {
            for (int row = 0; row < seats.GetLength(0); row++)
            {
                for (int col = 0; col < seats.GetLength(1); col++)
                {
                    if (seats[row, col] == null)
                    {
                        seats[row, col] = name;
                    }
                }
            }
        }

        // CancelAllBookings method
        public void CancelAllBookings()
        {
            for (int row = 0; row < seats.GetLength(0); row++)
            {
                for (int col = 0; col < seats.GetLength(1); col++)
                {
                    seats[row, col] = null;
                }
            }
            waitingList.Clear(); // clears waiting list
        }

        // AvailableSeatsCount method
        public int AvailableSeatsCount()
        {
            int count = 0; // variable to count the seats available
            for (int row = 0; row < seats.GetLength(0); row++)
            {
                for (int col = 0; col < seats.GetLength(1); col++)
                {
                    if (seats[row, col] == null)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        // WaitingListCount method
        public int WaitingListCount()
        {
            return waitingList.Count;
        }

    }
}
