using System;
using System.Collections.Generic;
using System.Text;
using TratamentoExcecoes02.Entities.Exceptions;

namespace TratamentoExcecoes02.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }


        public Reservation()
        {

        }
        public Reservation(int room, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DomainException("Error in reservation: Check-out date must be after check-in");

            }

            RoomNumber = room;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn); // diminui checkout = checkout
            return (int)duration.TotalDays;
        }
        public override string ToString()
        {
            return "Room" + RoomNumber +
                ", checkIn" + CheckIn.ToString("dd/MM/yyyy")
                + ", checkout: " + CheckOut.ToString("dd/MM//yyyy")
                + ", " + Duration() +
                " nights";
        }
        public void updateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now; // atual
            if (checkin < now || checkout < now)
            {
                throw new DomainException("Error in reservation: Reservation dates for update must be future dates");
            }
            if (checkout <= checkin)
            {
                throw new DomainException("Error in reservation: Check-out date must be after check-in");

            }

            CheckIn = checkin;
            CheckOut = checkout;

        }
    }
}
