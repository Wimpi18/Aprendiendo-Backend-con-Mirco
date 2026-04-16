public interface IEmployee
{
    string Name { get; }
    decimal Salary { get; }
    void ShowDetails();
    decimal CalculateTotalBudget();
}
