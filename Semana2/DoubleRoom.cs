namespace Semana2;

public class DoubleRoom : BaseRoom
{
    public DoubleRoom(int roomNumber, bool available) : base(roomNumber, available)
    {
        Persons = 2;
        RoomPrice = 1550;
    }
}