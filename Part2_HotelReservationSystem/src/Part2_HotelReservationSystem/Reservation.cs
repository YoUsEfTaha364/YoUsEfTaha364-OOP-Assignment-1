using System;
using System.Runtime.InteropServices;

namespace HotelSystem;

public class Reservation
{


    public Guid ReservationId { get; }

    public DateTime CheckInDate { get;  }
    public DateTime CheckOutDate { get;  }
    public ReservationStatus Status { get; private set; }
    public Room Room { get; set; }


    public Reservation(DateTime checkInDate, DateTime checkOutDate, Room room)
    {
        if (room.IsUnderMaintenance)
            throw new ArgumentException(
               "Room Is Not available now."
           );

        if (checkOutDate <= checkInDate)
        {
            throw new ArgumentException(
                "Check-out date must be after check-in date."
            );
        }

        ReservationId = Guid.NewGuid();
        CheckInDate = checkInDate;
        CheckOutDate = checkOutDate;
        Status = ReservationStatus.Pending;

        Room = room;
    }



    private bool IsGusetIn()
    {
        var Datenow = DateTime.Now;
        return Datenow >= CheckInDate && Datenow < CheckOutDate ? true : false;
    }
    private bool IsGusetOut()
    {
        var Datenow = DateTime.Now;
        return Datenow >= CheckOutDate ? true : false;
    }



    public void Confirm()
    {
        Status = ReservationStatus.Confirmed;
    }

    public void Cancel()
    {
        Status = ReservationStatus.Cancelled;
    }

    public void CheckIn()
    {
        if (Status != ReservationStatus.Confirmed)
        {
            throw new InvalidOperationException("Cannot check in a reservation that is not confirmed.");
        }

        if (IsGusetIn())
        {
            Status = ReservationStatus.CheckedIn;
        }
        else
        {
            throw new InvalidOperationException("Cannot check in before the check-in date.");
        }
    }

    public void CheckOut()
    {
        if (Status != ReservationStatus.CheckedIn)
        {
            throw new InvalidOperationException("Cannot check out a reservation that is not checked in.");
        }
        if (IsGusetOut())
        {
            Status = ReservationStatus.CheckedOut;
        }
        else
        {
            throw new InvalidOperationException("Cannot check out before the check-out date.");
        }
    }

    public decimal TotalCost()
    {
        var totalDays = (CheckOutDate - CheckInDate).Days;
        return totalDays * Room.NightlyRate;
    }




}
