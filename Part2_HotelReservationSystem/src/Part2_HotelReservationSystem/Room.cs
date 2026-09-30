using System;

namespace HotelSystem;

public class Room
{

    public int RoomNumber { get; }
    public RoomType RoomType { get; }
    public decimal NightlyRate { get; private set; }
    public bool IsUnderMaintenance { get; private set; }
    public Room(int roomNumber, RoomType roomType, decimal nightlyrate)
    {
        RoomNumber = roomNumber;
        RoomType = roomType;
        NightlyRate = nightlyrate;
        
    }

    public void ChangeNightlyRate(decimal rate)
    {
        if (rate <= 0)
        {
            throw new ArgumentException("Rate must be greater than zero.");
        }
        NightlyRate = rate;
    }

    public void StartMaintenance()
    {
        IsUnderMaintenance = true;
    }

    public void EndMaintenance()
    {
        IsUnderMaintenance = false;
    }



}
