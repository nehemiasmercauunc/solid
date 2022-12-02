namespace SOLID.I.Solution;

internal class PizzaOrderService : IPizzaOrderService {
    public void OrderPizza(int quantity) {
        // Order Pizza
        Console.WriteLine("Ordering {0} Pizza(s)", quantity);
    }
}