
// Factory Method Design Pattern - Creational Category //




class VeggiePizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Veggie Pizza Prepared");
    }

    public void Bake()
    {
        Console.WriteLine("Veggie Pizza Baked");
    }

    public void Cut()
    {
        Console.WriteLine("Veggie Pizza Cut");
    }
}
