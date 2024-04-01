
// Observer Design Pattern - Behavioral Category //




//amazon.NotifyForProductName("iPhone 14");

class Amazon
{
    private Dictionary<IObserver, Product> observers = new();

    public void Register(IObserver observer, Product product)
    {
        observers.TryAdd(observer, product);
    }

    public void UnRegister(IObserver observer) 
    {
        observers.Remove(observer);
    }

    public void NotifyAll()
    {
        foreach (var kv in observers)
        {
            kv.Key.Notify(kv.Value);
        }
    }

    public void NotifyForProductName(string productName)
    {
        foreach (var kv in observers)
        {
            if (kv.Value.Name == productName)
                kv.Key.Notify(kv.Value);
        }
    }
}
