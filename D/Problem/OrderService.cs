namespace SOLID.D.Problem;

public class Order {
    public int Quantity { get; set; }
    public string Product { get; set; }
}

public class DataDogService {
    public void LogEvent(string message) {
        // Log Event
        Console.WriteLine("Logging Event: {0}", message);
    }
}

public class OrderService {
    private readonly DataDogService _dataDogService;

    public OrderService(DataDogService dataDogService) {
        _dataDogService = dataDogService;
    }

    public void GenerateOrder(Order order){
        // Generate Order
        _dataDogService.LogEvent("Order Generated");
    }
}