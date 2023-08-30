namespace Semana1;

public class ReceiptManager
{
    private readonly List<Receipt> _receipts = new List<Receipt>();

    public ReceiptManager()
    {
        _receipts.Add(new Receipt("Netflix payment", 15));
        _receipts.Add(new Receipt("Internet Bill", 25));
    }

    public void PrintAll()
    {
        foreach (var receipt in _receipts)
            receipt.PrintDetails();
    }

    public void SumAll()
    {
        double total = 0;
        foreach (var receipt in _receipts)
            total += receipt.Amount;
        Separator.Separate("Total", () => Console.WriteLine("Total Amount: {0}", total));
    }
}