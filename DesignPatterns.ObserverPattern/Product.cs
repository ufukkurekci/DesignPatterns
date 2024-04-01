
// Observer Design Pattern - Behavioral Category //




//amazon.NotifyForProductName("iPhone 14");






class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}