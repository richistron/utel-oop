namespace Semana2;

public interface IRoom
{
    public int Persons { get; }
    public bool Available { get; }
    public int RoomNumber { get; }
    public decimal RoomPrice { get; }
}