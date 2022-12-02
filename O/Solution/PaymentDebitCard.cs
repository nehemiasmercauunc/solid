namespace SOLID.O.Solution;

public class PaymentDebitCard : IPaymentType
{
    public void Pay(SOLID.O.Buy buy)
    {
        Console.WriteLine("Payment with Debit card");
        // Pagar con tarjeta de débito
    }
}