OrderManager orderManager = new();
InventoryService inventoryService = new();
NotificationService notificationService = new();

orderManager.OrderCreated += inventoryService.Update;
orderManager.OrderCreated += notificationService.Update;

Order order = new() { Id = 101, CustomerEmail = "cliente@email.com" };
orderManager.CreateOrder(order);
