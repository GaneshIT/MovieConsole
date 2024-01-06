using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieConsole
{
    internal class Booking : User
    {
        public Booking(int id, string name, string email) : base(id, name, email)
        {
        }

        public void AddBooking(string date,string status,string email)
        {
            string userEmail=email;
            Console.WriteLine("Booking:"+ userEmail + date+status);
        }
        public string BookingStatus(int bookingId)
        {
            string status = "";
            if (bookingId == 100)
            {
                status = "Booked";
            }
            else
            {
                status = "Pending";
            }
            return status;
        }
        public string BookingStatus(string date)
        {
            string msg = "";
            if (date == "3/1/2024")
                msg= "Booked";
            return msg;
        }
        public void BookingStatus(string name,string date)
        {
        }

    }
}
