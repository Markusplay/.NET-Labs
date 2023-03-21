using Lab_1_test.Interfaces;

namespace Lab1.Collection
{
    public class EmployeeSalaryInfo: IEmployeeSalaryInfo
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal Salary { get; set; }
    }
}
