public class Developer : IEmployee
{
    public string Name { get; private set; }
    public decimal Salary { get; private set; }

    public Developer(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"- Developer: {Name}, Salary: ${Salary}");
    }

    public decimal CalculateTotalBudget()
    {
        return Salary;
    }
}
