using System;

namespace HotelSystem;

public class Guest
{
    public Guid GuestId { get; }

    public string FullName { get; }
    public string PhoneNumber { get; }
    private List<Reservation> _reservations=new List<Reservation>();

    public IReadOnlyList<Reservation> Reservations { get; private set; }
    public Guest(string fullName, string phoneNumber)
    {
        if (string.IsNullOrEmpty(fullName))
            throw new Exception("Invaid Name ");

        if (string.IsNullOrEmpty(phoneNumber))
            throw new Exception("Invaid Phone Number ");

        GuestId = Guid.NewGuid();
        FullName = fullName;
        PhoneNumber = phoneNumber;
        Reservations=_reservations;
    }

    public void AddReservation(Reservation reservation)
    {
       
        _reservations.Add(reservation);
    }

    public void PrintInfo()
    {
        Console.WriteLine("==============================================");
        Console.WriteLine("                  GUEST INFO");
        Console.WriteLine("==============================================");

        Console.WriteLine($"Guest ID     : {GuestId}");
        Console.WriteLine($"Full Name    : {FullName}");
        Console.WriteLine($"Phone Number : {PhoneNumber}");
        Console.WriteLine($"Reservations : {Reservations.Count}");

        Console.WriteLine("----------------------------------------------");

        if (Reservations.Count == 0)
        {
            Console.WriteLine("No reservations found.");
        }
        else
        {
            foreach (var reservation in Reservations)
            {
                Console.WriteLine($"Reservation ID : {reservation.ReservationId}");
                Console.WriteLine($"Room Number    : {reservation.Room.RoomNumber}");
                Console.WriteLine($"Room Type      : {reservation.Room.RoomType}");
                Console.WriteLine($"Nightly Rate   : {reservation.Room.NightlyRate:C}");
                Console.WriteLine($"Check-in       : {reservation.CheckInDate:dd/MM/yyyy}");
                Console.WriteLine($"Check-out      : {reservation.CheckOutDate:dd/MM/yyyy}");
                Console.WriteLine($"Status         : {reservation.Status}");
                Console.WriteLine($"Total Cost     : {reservation.TotalCost()}");

                Console.WriteLine("----------------------------------------------");
            }
        }

        Console.WriteLine("==============================================");
    }

}
