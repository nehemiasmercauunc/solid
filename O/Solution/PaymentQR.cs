namespace SOLID.O.Solution;

public class PaymentQR : IPaymentType
{
    public void Pay(SOLID.O.Buy buy)
    {
        // Pagar con QR
        Console.WriteLine("Payment with QR");
    }
}