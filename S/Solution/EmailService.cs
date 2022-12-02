namespace SOLID.S.Solution;

public interface IEmailService {
    void SendEmail(string fromAccount, string toAccount, decimal amount);
}

public class EmailService : IEmailService {
    public void SendEmail(string fromAccount, string toAccount, decimal amount)
    {
        // Send email to the account owner
        Console.WriteLine("5.Sending email to the account owner");
    }
}