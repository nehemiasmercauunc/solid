namespace SOLID.D.Solution;

public class SmsService : IEventNotificationService {
    public void LogEvent(string message) {
        // Send SMS
        Console.WriteLine("Sending SMS: {0}", message);
    }
}