namespace Semana2;

public class BaseRoom : IRoom
{
    public int Persons { get; set; }
    public bool Available { get; set; }
    public int RoomNumber { get; set; }
    public decimal RoomPrice { get; set; }

    public BaseRoom(int roomNumber, bool available)
    {
        RoomNumber = roomNumber;
        Available = available;
    }
}