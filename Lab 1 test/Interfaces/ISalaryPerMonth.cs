using Lab_1_test.Enum;

namespace Lab_1_test.Interfaces
{
    public interface ISalaryPerMonth
    {
        int TaxId { get; set; }
        Month Month { get; set; }
        decimal Salary { get; set; }
        string ToString();
    }
}
