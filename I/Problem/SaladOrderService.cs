namespace SOLID.I.Problem;

internal class SaladOrderService : IFoodOrderService {
    public void OrderBurguer(int quantity) {
        throw new System.NotImplementedException();
    }

    public void OrderPizza(int quantity) {
        throw new System.NotImplementedException();
    }

    public void OrderSalad(int quantity) {
        // Order Salad
        Console.WriteLine("Ordering {0} Salad(s)", quantity);
    }
}