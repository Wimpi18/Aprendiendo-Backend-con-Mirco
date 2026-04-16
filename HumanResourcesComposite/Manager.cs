public class Manager : IEmployee
{
    public string Name { get; private set; }
    public decimal Salary { get; private set; }

    public List<IEmployee> Employees { get; private set; }

    public Manager(string name, decimal salary, List<IEmployee> employees)
    {
        Name = name;
        Salary = salary;
        Employees = employees;
    }

    public void AddEmployee(IEmployee employee)
    {
        Employees.Add(employee);
    }

    public void QuitEmployee(IEmployee employee)
    {
        Employees.Remove(employee);
    }

    public void ShowDetails()
    {
        Console.WriteLine($"+ Manager: {Name}, Salary: ${Salary}");

        foreach (var e in Employees)
        {
            e.ShowDetails();
        }
    }
}
