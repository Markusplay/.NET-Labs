using Lab_1_test.Enum;
using Lab_1_test.Enums;
using Lab_1_test.Interfaces;
using Lab1.Collection;

namespace Lab_1_test
{
    //DAL => DataProvider/Repository - renamed service to DataProvider
    //DI => DataProvider I IDataProvider
    public class DataProvider: IDataProvider
    {
        Datacontext context = new Datacontext();

        public IOrderedEnumerable<Employee> SortEmployees() =>
            from e in context.Employees
            orderby e.LastName
            select e;


        public IEnumerable<Employee> GetSpecialist() =>
            from e in context.Employees
            where e.Education == EducationType.Master
            select e;


        //should be decimal - done
        public decimal GetLowestSalary() =>
            context.Salaries.Min(s => s.Salary);


        public IEnumerable<Employee> GetYearDateReverse(int year) =>
            context.Employees.Where(e => DateTime.Now.Year - e.EmploymentStartDate.Year > year).Reverse();


        public decimal GetAverageSalary() =>
            context.Salaries.Average(s => s.Salary);


        public decimal GetMaxSalary() =>
            context.Salaries.Max(s => s.Salary);


        public int HighSalaryCount(int n) =>
            context.Employees.Join(context.Salaries, e => e.TaxId, s => s.TaxId, (e, s) => new
            {
                Employee = e,
                SalaryPerMonth = s
            })
            .Where(x => x.SalaryPerMonth.Salary > n)
            .Select(x => x.Employee)
            .Count();


        public List<SalaryPerMonth> OrderByDescendingTaxIdSalary() =>
            context.Salaries.OrderByDescending(x => x.TaxId).ToList();


        public List<string> GetCompanyToUpper() =>
            context.Companies.Select(e => e.Name.ToUpper()).ToList();


        public int GetBorndedBefore(int year) =>
            context.Employees.Where(e => e.BirthDate.Year < year).Count();


        public IEnumerable<IGrouping<SpecialityType, Employee>> GroupBySpeciality() =>
            context.Employees.GroupBy(x => x.Specialty);


        public IEnumerable<Employee> GetFirstEmployees() =>
            context.Employees.OrderBy(e => e.FirstName).Take(1);
        //.
        public List<string> EmployeeyToLower() =>
            context.Employees.Select(e => $"{e.FirstName.ToLower()} {e.LastName.ToLower()} {e.MiddleName?.ToLower()}").ToList();

        public List<EmployeeSalaryInfo> GetEmployeeSalaryJoined() =>
            (from emp in context.Employees
             join sal in context.Salaries
             on emp.TaxId equals sal.TaxId
             select new EmployeeSalaryInfo
             {
                 FirstName = emp.FirstName,
                 LastName = emp.LastName,
                 Salary = sal.Salary
             }).ToList();

        //arg naming - done
        public IEnumerable<EmployeeCompany> GetWhile(int companyId) =>
            context.EmployeeCompanies.TakeWhile(x => x.CompanyId != companyId);


        public List<int> DeleteDublicateEmployees() =>
            context.EmployeeCompanies.Select(e => e.Id).Distinct().ToList();


        public bool EmployeeWithSpeciality(SpecialityType specialty) =>
            context.Employees.Any(x => x.Specialty == specialty);


        public List<Employee> GetUnionEmployees() => context.Employees.Union(context.Employees2).ToList();


        public IEnumerable<Employee> FindShSurname(string letter) =>
            from employee in context.Employees
            where employee.LastName.StartsWith(letter)
            select employee;

        public bool AllSameSalaryInMonthNow(decimal salary) => context.Salaries.All(s => s.Salary == salary);
    }
}
