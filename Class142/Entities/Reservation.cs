using System;
using Class142.Entities.Exceptions;

namespace Class142.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime ChekIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut < checkIn)
            {
                throw new DomainException("Error na reserva ! 2");
            }

            RoomNumber = roomNumber;
            ChekIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(ChekIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Error na reserva ! 1");
            }
            else if (checkOut < checkIn)
            {
                throw new DomainException("Error na reserva ! 2");
            }

            ChekIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + ChekIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
