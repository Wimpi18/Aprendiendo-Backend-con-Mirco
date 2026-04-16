public class Manager : IEmployee
{
    public string Name { get; private set; }
    public decimal Salary { get; private set; }

    private readonly List<IEmployee> _employees = [];

    public Manager(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    public void AddEmployee(IEmployee employee)
    {
        _employees.Add(employee);
    }

    public void RemoveEmployee(IEmployee employee)
    {
        _employees.Remove(employee);
    }

    public void ShowDetails()
    {
        Console.WriteLine($"+ Manager: {Name}, Salary: ${Salary}");

        foreach (var e in _employees)
        {
            e.ShowDetails();
        }
    }

    public decimal CalculateTotalBudget()
    {
        decimal totalSalary = Salary;
        foreach (var e in _employees)
        {
            totalSalary += e.CalculateTotalBudget();
        }
        return totalSalary;
    }
}
