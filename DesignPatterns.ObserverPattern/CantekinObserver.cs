
// Observer Design Pattern - Behavioral Category //




//amazon.NotifyForProductName("iPhone 14");




class CantekinObserver : IObserver
{
    public string FullName { get; set; }

    public CantekinObserver(string fullName)
    {
        FullName = fullName;
    }

    public void Notify(Product product)
    {
        Console.WriteLine($"{FullName}, Product {product.Name} in stock now!");
    }
}
