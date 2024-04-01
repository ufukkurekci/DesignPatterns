
// Observer Design Pattern - Behavioral Category //




//amazon.NotifyForProductName("iPhone 14");



interface IObserver
{
    string FullName { get; set; }
    void Notify(Product product);
}
