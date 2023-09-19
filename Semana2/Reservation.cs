namespace Semana2;

public static class Reservation
{
    private static List<IRoom> AllRooms { get; } = new List<IRoom>
    {
        new SingleRoom(35, false),
        new SingleRoom(36, true),
        new SingleRoom(37, false),
        new DoubleRoom(40, false),
        new DoubleRoom(41, true),
        new DoubleRoom(42, true),
    };

    public static void Init()
    {
        Console.WriteLine("Welcome to No Tell Motel!");
        if (AskForReservation() == 'n')
            return;
        ShowAvailableRooms();
        BookRoom();
    }

    private static void BookRoom()
    {
        Console.WriteLine("What room would you like to choose?");
        while (true)
        {
            var input = Console.ReadLine();
            if (int.TryParse(input, out var roomNumber) && IsRoomAvailable(roomNumber) != null)
            {
                Console.WriteLine("You have successfully book room: {0}", roomNumber);
                break;
            }

            Console.WriteLine("Invalid option {0}", input);
        }
    }

    private static IRoom? IsRoomAvailable(int number) =>
        AllRooms.Find(r => r.RoomNumber == number && r.Available);

    private static void ShowAvailableRooms()
    {
        var available = AllRooms.FindAll(r => r.Available);
        Console.WriteLine("\t Our available rooms are:");
        foreach (var room in available)
        {
            Console.WriteLine("\t\t Room {0}", room.RoomNumber);
            Console.WriteLine("\t\t price {0}", room.RoomPrice);
            Console.WriteLine("\t\t Number of persons {0}", room.Persons);
        }
    }

    private static char AskForReservation()
    {
        char option;
        while (true)
        {
            Console.WriteLine("\t would you like to make a reservation? y/n");
            var input = Console.ReadLine();
            if (char.TryParse(input, out option) && option is 'y' or 'n')
                break;
            Console.WriteLine("\t invalid option");
        }

        return option;
    }
}