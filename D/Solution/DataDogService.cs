namespace SOLID.D.Solution;

public class DataDogService : IEventNotificationService {
    public void LogEvent(string message) {
        // Log event to DataDog
        Console.WriteLine("Logging Event: {0}", message);
    }
}