namespace Lab_1_test.Interfaces
{
    public interface IEmployeeCompany
    {
        int Id { get; set; }
        int CompanyId { get; set; }
        int EmployeeId { get; set; }
        string ToString();
    }
}
