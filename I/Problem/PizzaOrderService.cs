namespace SOLID.I.Problem;

internal class PizzaOrderService : IFoodOrderService {
    public void OrderBurguer(int quantity) {
        throw new System.NotImplementedException();
    }

    public void OrderPizza(int quantity) {
        // Order Pizza
        Console.WriteLine("Ordering {0} pizza(s)", quantity);
    }

    public void OrderSalad(int quantity) {
        throw new System.NotImplementedException();
    }
}