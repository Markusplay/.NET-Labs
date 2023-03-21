using Lab_1_test.Enum;
using Lab_1_test.Enums;
using Lab_1_test.Interfaces;

namespace Lab1.Collection
{
    public class Employee: IEmployee
    {
        public int Id { get; set; }
        //todo ? - got it
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public EducationType Education { get; set; }
        public SpecialityType Specialty { get; set; }
        public int? RollNumber { get; set; }
        public int? TaxId { get; set; }
        public DateTime EmploymentStartDate { get; set; }
        public List<SalaryPerMonth>? Salaries { get; set; }
    }
}
