
using HotelSystem;

var room1=new Room(101,RoomType.Single,200);
var room2=new Room(105,RoomType.Double,400);
var room3=new Room(10,RoomType.Suite,440);
 

var guest1 = new Guest( "Yousef Taha", "01012345678");
var guest2 = new Guest( "Ahmed Mohamed", "01123456789");
var guest3 = new Guest( "Omar Hassan", "01234567890");

   List<Guest> guests=new List<Guest>(3);

   guests.Add(guest1);
   guests.Add(guest2);
   guests.Add(guest3);

var reservation=new ReservationCreator(guests);
// room2.StartMaintenance(); 

   var GuestReservation=reservation.Create(room2,new DateTime(2026,9,27),new DateTime(2026,9,29));
   GuestReservation.Confirm();

  guest1.AddReservation(GuestReservation);


guest1.PrintInfo();