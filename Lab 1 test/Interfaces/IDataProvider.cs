using Lab_1_test.Enum;
using Lab1.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_test.Interfaces
{
    internal interface IDataProvider
    {
        IOrderedEnumerable<Employee> SortEmployees();
        IEnumerable<Employee> GetSpecialist();
        decimal GetLowestSalary();
        IEnumerable<Employee> GetYearDateReverse(int year);
        decimal GetAverageSalary();
        decimal GetMaxSalary();
        int HighSalaryCount(int n);
        List<SalaryPerMonth> OrderByDescendingTaxIdSalary();
        List<string> GetCompanyToUpper();
        int GetBorndedBefore(int year);
        IEnumerable<IGrouping<SpecialityType, Employee>> GroupBySpeciality();
        IEnumerable<Employee> GetFirstEmployees();
        List<string> EmployeeyToLower();
        List<EmployeeSalaryInfo> GetEmployeeSalaryJoined();
        IEnumerable<EmployeeCompany> GetWhile(int companyId);
        List<int> DeleteDublicateEmployees();
        bool EmployeeWithSpeciality(SpecialityType specialty);
        List<Employee> GetUnionEmployees();
        IEnumerable<Employee> FindShSurname(string letter);
        bool AllSameSalaryInMonthNow(decimal salary);
    }
}
