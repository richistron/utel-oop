namespace Semana2;

public class BaseRoom : IRoom
{
    public int Persons { get; init; }
    public bool Available { get; }
    public int RoomNumber { get; }
    public decimal RoomPrice { get; init; }

    protected BaseRoom(int roomNumber, bool available)
    {
        RoomNumber = roomNumber;
        Available = available;
    }
}