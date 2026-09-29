using System;

namespace HotelSystem;

public class Hotel
{
     private readonly List<Guest> _guests = new();
    private readonly List<Room> _rooms = new();

    public IReadOnlyList<Guest> Guests => _guests;
    public IReadOnlyList<Room> Rooms => _rooms;

    

}
