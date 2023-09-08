namespace Semana2;

public class SingleRoom : BaseRoom
{
    public SingleRoom(int roomNumber, bool available) : base(roomNumber, available)
    {
        Persons = 1;
        RoomPrice = 750.20m;
    }
}