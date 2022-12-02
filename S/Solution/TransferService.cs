namespace SOLID.S.Solution;
public class TransferService
{
    private readonly IEmailService _emailService;
    private readonly IDBWriterService _dbWriterService;
    private readonly IAccountService _accountService;

    public TransferService(IEmailService emailService, IDBWriterService dbWriterService, IAccountService accountService)
    {
        _emailService = emailService;
        _dbWriterService = dbWriterService;
        _accountService = accountService;
    }


    public bool MakeTransaction(string fromAccount, string toAccount, decimal amount)
    {
        // Transfer money from one account to another
        //1. Check if the account to is valid
        if(!_accountService.IsAccountValid(toAccount)){
            return false;
        }

        //2. Check if the account from has enough money
        if(!_accountService.HasEnoughMoney(fromAccount, amount)){
            return false;
        }

        //3. Transfer the money from account from to account to
        SendMoney(fromAccount, toAccount, amount);

        //4. Write the transaction to the database
        _dbWriterService.WriteTransaction(fromAccount, toAccount, amount);
        
        //5. Send email to the account owner
        _emailService.SendEmail(fromAccount, toAccount, amount);
        return true;
    }


    public void SendMoney(string fromAccount, string toAccount, decimal amount)
    {
        // Transfer the money from account from to account to
        Console.WriteLine("3.Transfering the money from account from to account to");
    }



}   
