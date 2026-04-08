using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddSingleton<INotifier, CloudSmsAdapter>(provider => new CloudSmsAdapter(
    new CloudSmsService(),
    "555-1234"
));
services.AddSingleton<OrderService>();

var serviceProvider = services.BuildServiceProvider();
var orderService = serviceProvider.GetService<OrderService>();

orderService.CompleteOrder(10);
