using Lab1.Collection;

namespace Lab_1_test.Interfaces
{
    public interface IDataContext
    {
        IEnumerable<Employee> Employees { get; }
        IEnumerable<Company> Companies { get; }
        IEnumerable<SalaryPerMonth> Salaries { get; }
    }
}
