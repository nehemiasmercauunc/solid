namespace SOLID.I.Problem;

internal class BurguerOrderService : IFoodOrderService {
    public void OrderBurguer(int quantity) {
        // Order Burguer
        Console.WriteLine("Ordering {0} Burguer(s)", quantity);
    }

    public void OrderPizza(int quantity) {
        throw new System.NotImplementedException();
    }

    public void OrderSalad(int quantity) {
        throw new System.NotImplementedException();
    }
}