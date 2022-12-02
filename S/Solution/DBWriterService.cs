namespace SOLID.S.Solution;

public interface IDBWriterService{
    void WriteTransaction(string fromAccount, string toAccount, decimal amount);
}

public class DBWriterService : IDBWriterService {
    public void WriteTransaction(string fromAccount, string toAccount, decimal amount)
    {
        // Write the transaction to the database
        Console.WriteLine("4.Writing the transaction to the database");
    }
}