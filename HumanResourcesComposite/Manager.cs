public class Manager : IEmployee
{
    public string Name { get; private set; }
    public decimal Salary { get; private set; }

    public List<IEmployee> Employees = new List<IEmployee>();

    public Manager(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    public void AddEmployee(IEmployee employee)
    {
        Employees.Add(employee);
    }

    public void RemoveEmployee(IEmployee employee)
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
