Store store = new Store();

store.AddProduct(new Dairy("Milk", 1.5m, DateTime.Now.AddDays(10)));
store.AddProduct(new Dairy("Cheese", 2.5m, DateTime.Now.AddMonths(1)));
store.AddProduct(new Dairy("Yogurt", 2, DateTime.Now.AddDays(20)));
store.AddProduct(new Bakery("Bagel", 1.2m, false));
store.AddProduct(new Bakery("Muffin", 1.5m, true));
store.AddProduct(new Bakery("Bun", 0.5m, false));

Console.WriteLine("STORE:\n");

Console.WriteLine("Available Products: ");
store.ShowProducts();

while (true)
{
    Console.WriteLine("_________________________________");
    Console.WriteLine("\nChoose an action:");
    Console.WriteLine("1 - Add to cart");
    Console.WriteLine("2 - Show cart");
    Console.WriteLine("3 - Remove from cart");
    Console.WriteLine("4 - Calculate bill");
    Console.WriteLine("5 - Exit");
    Console.Write("\nEnter your choice: ");
    string choice = Console.ReadLine();
    Console.Write("\n");

    switch (choice)
    {
        case "1":
            Console.Write("Enter the name of the product to add to cart: ");
            string productNameToAdd = Console.ReadLine();
            bool foundToAdd = false;
            foreach (var product in store.Products)
            {
                if (product.Name.Equals(productNameToAdd, StringComparison.OrdinalIgnoreCase))
                {
                    store.AddToCart(product);
                    foundToAdd = true;
                    break;
                }
            }
            if (!foundToAdd)
            {
                Console.WriteLine($"Product '{productNameToAdd}' not found.");
            }
            if (int.TryParse(productNameToAdd, out _))
            {
                Console.WriteLine("Invalid input. Please enter the name of the product.");
                break;
            }
            break;
        case "2":
            if (store.IsListEmpty(store.Cart))
            {
                Console.WriteLine("Your cart is empty Nothing to show.");
            }
            else
            {
                store.ShowCart();
            }
            break;
        case "3":
            if (store.IsListEmpty(store.Cart))
            {
                Console.WriteLine("Your cart is empty. Nothing to remove.");
            }
            else
            {
                Console.Write("Enter the name of the product to remove from cart: ");
                string productNameToRemove = Console.ReadLine();
                bool foundToRemove = false;
                foreach (var product in store.Cart)
                {
                    if (product.Name.Equals(productNameToRemove, StringComparison.OrdinalIgnoreCase))
                    {
                        store.RemoveFromCart(product);
                        foundToRemove = true;
                        break;
                    }
                }
                if (!foundToRemove)
                {
                    Console.WriteLine($"Product '{productNameToRemove}' is not in your cart.");
                }
                if (int.TryParse(productNameToRemove, out _))
                {
                    Console.WriteLine("Invalid input. Please enter the name of the product.");
                    break;
                }
            }
            break;
        case "4":
            decimal total = store.CalculateTotal();
            Console.WriteLine($"Total bill: {total:F2} EUR");
            break;
        case "5":
            Console.WriteLine("Goodbye!");
            return;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}
