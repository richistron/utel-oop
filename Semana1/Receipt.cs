namespace Semana1;

public class Receipt
{
    private readonly string _name;
    public double Amount { get; }

    public Receipt(string name, double amount)
    {
        _name = name;
        Amount = amount;
    }

    public void PrintDetails()
    {
        Separator.Separate("Details", () =>
        {
            Console.WriteLine("Receipt name: {0}", _name);
            Console.WriteLine("Receipt amount: {0}", Amount);
        });
    }
}