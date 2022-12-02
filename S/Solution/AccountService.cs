namespace SOLID.S.Solution;

public interface IAccountService {
    bool IsAccountValid(string accountNumber);
    bool HasEnoughMoney(string accountNumber, decimal amount);
}

public class AccountService : IAccountService {
    public bool IsAccountValid(string accountNumber)
    {
        // Check if the account is valid
        Console.WriteLine("1.Checking if the account is valid");
        return true;
    }

    public bool HasEnoughMoney(string accountNumber, decimal amount)
    {
        // Check if the account has enough money
        Console.WriteLine("2.Checking if the account has enough money");
        return true;
    }
}