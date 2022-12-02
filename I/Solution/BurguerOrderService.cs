namespace SOLID.I.Solution;

internal class BurguerOrderService : IBurguerOrderService {
    public void OrderBurguer(int quantity) {
        // Order Burguer
        Console.WriteLine("Ordering {0} Burguer(s)", quantity);
    }
}