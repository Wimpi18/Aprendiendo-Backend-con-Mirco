List<IEmployee> employees = new List<IEmployee>();
employees.Add(new Developer("Jairo", 332m));
employees.Add(new Developer("Mariana", 333.2m));

Manager emily = new Manager("Emily", 332m, new List<IEmployee> { new Developer("Nahuel", 213) });
employees.Add(emily);

Manager winsor = new Manager("Winsor", 2500.43m, employees);

emily.ShowDetails();
