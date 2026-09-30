using System;

namespace HotelSystem;

public class ReservationCreator
{
    private readonly List<Guest> _guests;

    public ReservationCreator(List<Guest> guests)
    {
        _guests = guests;
    }
    
    public Reservation Create(Room room,DateTime checkIn,DateTime checkOut)
    {
        if(room.IsUnderMaintenance)
             throw new ArgumentException(
                "Room Is Not available now."
            );
         
          if (checkOut <= checkIn)
        {
            throw new ArgumentException(
                "Check-out date must be after check-in date."
            );
        }

         foreach( var guest in _guests)
        {
            var reservations=guest.Reservations;
            if(reservations.Count==0)
            break;

            foreach(var reservation in reservations)
            {
                if (reservation.Room != room)
                    continue;

                if (reservation.Status == ReservationStatus.Cancelled ||
                    reservation.Status == ReservationStatus.CheckedOut)
                    continue;

                bool overlaps =
                    checkIn < reservation.CheckOutDate &&
                    checkOut > reservation.CheckInDate;

                if (overlaps)
                    throw new InvalidOperationException(
                        "Room is already reserved for these dates.");
            }

           
        }

         return new Reservation(checkIn,checkOut,room);

        

    }
}
