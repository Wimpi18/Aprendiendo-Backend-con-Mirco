Manager emily = new Manager("Emily", 332m);
emily.AddEmployee(new Developer("Nahuel", 213));

Manager winsor = new Manager("Winsor", 2500.43m);
winsor.AddEmployee(new Developer("Jairo", 332m));
winsor.AddEmployee(new Developer("Mariana", 333.2m));
winsor.AddEmployee(emily);

winsor.ShowDetails();
