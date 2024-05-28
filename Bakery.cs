public class Bakery : Product
{
    private bool IsGlutenFree { get; set; }

    public Bakery(string name, decimal price, bool isGlutenFree) : base(name, price)
    {
        IsGlutenFree = isGlutenFree;
    }
    public override string Display()
    {
        return $"{Name} - {Price:F2} EUR, Gluten-Free: {IsGlutenFree}";
    }

}