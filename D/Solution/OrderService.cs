namespace SOLID.D.Solution;

public class Order {
    public int Quantity { get; set; }
    public string Product { get; set; }
}

public class OrderService {
    private readonly IEventNotificationService _eventNotificationService;

    public OrderService(IEventNotificationService eventNotificationService) {
        _eventNotificationService = eventNotificationService;
    }

    public void GenerateOrder(Order order){
        // Generate Order
        _eventNotificationService.LogEvent("Order Generated");
    }
}