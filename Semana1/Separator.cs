namespace Semana1;

public static class Separator
{
    public static void Separate(string msg, Action cb)
    {
        Console.WriteLine("==== {0} ====", msg);
        cb();
        Console.WriteLine("============= \n", "END");
    }
}