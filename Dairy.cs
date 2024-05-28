public class Dairy : Product
{
    private DateTime ExpirationDate { get; set; }

    public Dairy(string name, decimal price, DateTime expirationDate) : base(name, price)
    {
        ExpirationDate = expirationDate;
    }

    public override string Display()
    {
        return $"{Name} - {Price:F2} EUR, Expires on: {ExpirationDate.ToShortDateString()}";
    }
}
