namespace SOLID.O.Solution;

public class Payment
{
    private readonly IPaymentType _paymetType;
    public Payment(IPaymentType paymetType)
    {
        _paymetType = paymetType;
    }

    public void MakePayments(SOLID.O.Buy buy)
    {
        _paymetType.Pay(buy);
    }

}