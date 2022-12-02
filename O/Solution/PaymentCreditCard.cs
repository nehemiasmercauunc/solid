namespace SOLID.O.Solution;

public class PaymentCreditCard : IPaymentType
{
    public void Pay(SOLID.O.Buy buy)
    {
        // Pagar con tarjeta de crédito
        Console.WriteLine("Payment with Credit card");
    }
}