public abstract class Product : IProduct
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    
    public Product(string name, decimal price) { Name = name; Price = price; }
    public virtual string Display()
    {
        return $"{Name} - {Price:F2} EUR";
    }
}