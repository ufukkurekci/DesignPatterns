
// Observer Design Pattern - Behavioral Category //




//amazon.NotifyForProductName("iPhone 14");





class SalihObserver: IObserver
{
    public string FullName { get; set; }

    public SalihObserver(string fullName)
    {
        FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
    }

    public void Notify(Product product)
    {
        Console.WriteLine($"{FullName}, Product {product.Name} in stock now!");
    }
}
