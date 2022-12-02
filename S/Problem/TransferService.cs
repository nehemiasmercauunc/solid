namespace SOLID.S.Problem;
public class TransferService
{
    // The problem is that this class is responsible for two things:
    // 1. Transfer money
    // 2. Write transfer to the database
    // 3. Send email
    public bool MakeTransaction(string fromAccount, string toAccount, decimal amount)
    {
        // Transfer money from one account to another
        //1. Check if the account to is valid
        if(!this.IsAccountValid(toAccount)){
            return false;
        }

        //2. Check if the account from has enough money
        if(!this.HasEnoughMoney(fromAccount, amount)){
            return false;
        }

        //3. Transfer the money from account from to account to
        SendMoney(fromAccount, toAccount, amount);

        //4. Write the transaction to the database
        WriteTransaction(fromAccount, toAccount, amount);
        
        //5. Send email to the account owner
        SendEmail(fromAccount, toAccount, amount);
        return true;
    }

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

    public void SendMoney(string fromAccount, string toAccount, decimal amount)
    {
        // Transfer the money from account from to account to
        Console.WriteLine("3.Transfering the money from account from to account to");
    }

    public void WriteTransaction(string fromAccount, string toAccount, decimal amount)
    {
        // Write the transaction to the database
        Console.WriteLine("4.Writing the transaction to the database");
    }

    public void SendEmail(string fromAccount, string toAccount, decimal amount)
    {
        // Send email to the account owner
        Console.WriteLine("5.Sending email to the account owner");
    }


}   
