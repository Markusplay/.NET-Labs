
using Lab_1_test.Interfaces;

namespace Lab1.Collection
{
    public class EmployeeCompany: IEmployeeCompany
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int EmployeeId { get; set; }
        public override string ToString()
        {
            return "Id компанії = " + CompanyId + ",id працівника = " + EmployeeId;
        }
    }
}
