namespace SOLID.O.Solution;

public class PaymentCash : IPaymentType
{
    public void Pay(SOLID.O.Buy buy)
    {
        // Pagar con efectivo
        Console.WriteLine("Payment with cash");
    }
}