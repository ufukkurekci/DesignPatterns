using DesignPatterns.FactoryMethodPattern.Car;


// Factory Method Design Pattern - Creational Category //


// pizzastore orneği

//PizzaStore ankaraPizzaStore = new AnkaraPizzaStore();
//PizzaStore istanbulPizzaStore = new IstanbulPizzaStore();

//IPizza cheesePizza = ankaraPizzaStore.OrderPizza("cheese");
//Console.WriteLine("Cheese pizza ordered in Ankara Store");

//IPizza veggiePizza = istanbulPizzaStore.OrderPizza("veggie");
//Console.WriteLine("Veggie pizza ordered in Istanbul Store");
//Console.ReadLine();


// arac orneği 

ICar sedan = CarFactory.CreateCar("sedan");
sedan.GenerateCar();

ICar suv = CarFactory.CreateCar("suv");
suv.GenerateCar();
