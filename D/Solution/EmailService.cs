namespace SOLID.D.Solution;

public class EmailService : IEventNotificationService {
    public void LogEvent(string message) {
        // Send email
        Console.WriteLine("Sending Email: {0}", message);
    }
}