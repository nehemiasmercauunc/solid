namespace SOLID.I.Solution;

internal class SaladOrderService : ISaladOrderService {
    public void OrderSalad(int quantity) {
        // Order salad
        Console.WriteLine("Ordering {0} Salad(s)", quantity);
    }
}