public class Store
{
    public List<Product> Products { get; private set; } = new();
    public List<Product> Cart { get; private set; } = new();

    public bool IsListEmpty<L>(List<L> list)
    {
        return list == null || list.Count == 0;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void ShowProducts()
    {
        for (int i = 0; i < Products.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Products[i].Display()}");
        }
    }

    public void AddToCart(Product product)
    {
        if (product != null)
        {
            Cart.Add(product);
            Console.WriteLine($"Added {product.Name} to the cart.");
        }
        else
        {
            Console.WriteLine("Cannot add null product to the cart.");
        }
    }

    public void RemoveFromCart(Product product)
    {
        if (product != null)
        {
            Cart.Remove(product);
            Console.WriteLine($"Removed {product.Name} from the cart.");
        }
        else
        {
            Console.WriteLine("Cannot remove null product from the cart.");
        }
    }

    public void ShowCart()
    {
        Console.WriteLine("Your cart:");
        for (int i = 0; i < Cart.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Cart[i].Display()}");
        }
    }

    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (var product in Cart)
        {
            total += product.Price;
        }
        return total;
    }
}