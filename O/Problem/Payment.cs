namespace SOLID.O.Problem;

public class Payment
{
    public void Pay(SOLID.O.Buy buy, PaymetType paymetType)
    {
        if (paymetType == PaymetType.CreditCard)
        {
            Console.WriteLine("Payment with Credit Card");//programacion de pago con tarjeta de credito
        }
        else if (paymetType == PaymetType.DebitCard)
        {
            Console.WriteLine("Payment with Debit Card");//programacion de pago con tarjeta de debito
        }
        else if (paymetType == PaymetType.Cash)
        {
            Console.WriteLine("Payment with Cash");//programacion de pago en efectivo
        }
        else if (paymetType == PaymetType.QR)
        {
            Console.WriteLine("Payment with QR");//programacion de pago con QR
        }
    }
}