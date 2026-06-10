OrderManager orderManager = new();
InventoryService inventoryService = new();
NotificationService notificationService = new();

Order order = new();

orderManager.Attach(inventoryService);
orderManager.Attach(notificationService);
orderManager.CreateOrder(order);
