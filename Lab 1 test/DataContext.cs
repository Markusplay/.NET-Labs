using Lab_1_test.Enum;
using Lab_1_test.Enums;
using Lab_1_test.Interfaces;
using Lab1.Collection;

namespace Lab_1_test
{
    public class Datacontext : IDataContext
    {

        public IEnumerable<Employee> Employees => new List<Employee>
        {
            new Employee()
            {
                FirstName = "Михайло",
                MiddleName = "Олександрович",
                LastName = "Шило",
                BirthDate = new DateTime(2004, 3, 12),
                EmploymentStartDate = new DateTime(2018, 2, 10),
                TaxId = 1,
                Specialty = SpecialityType.Backend,
                RollNumber = 1,
                Education = EducationType.Backelor
            },
            new Employee()
            {
                FirstName = "Клим",
                MiddleName = "Олександрович",
                LastName = "Шевченко",
                BirthDate = new DateTime(1991, 11, 23),
                EmploymentStartDate = new DateTime(2020, 4, 3),
                TaxId = 2,
                Specialty = SpecialityType.Frontend,
                RollNumber = 2,
                Education = EducationType.Backelor,
            },
            new Employee()
            {
                FirstName = "Микита",
                MiddleName = "Володимирович",
                LastName = "Бірюк",
                BirthDate = new DateTime(2001, 1, 15),
                EmploymentStartDate = new DateTime(2020, 1, 2),
                TaxId = 3,
                Specialty = SpecialityType.Frontend,
                RollNumber = 3,
                Education = EducationType.Master,
            },
            new Employee()
            {
                FirstName = "Анастісія",
                MiddleName = "Юріївна",
                LastName = "Мельник",
                BirthDate = new DateTime(1986, 4, 26),
                EmploymentStartDate = new DateTime(2014, 11, 11),
                TaxId = 5,
                Specialty = SpecialityType.Design,
                RollNumber = 5,
                Education = EducationType.Backelor,
            },
            new Employee()
            {
                FirstName = "Павло",
                MiddleName = "Сергійович",
                LastName = "Кокізюк",
                BirthDate = new DateTime(2004, 6, 2),
                EmploymentStartDate = new DateTime(2023, 3, 5),
                TaxId = 4,
                Specialty = SpecialityType.DevOps,
                RollNumber = 4,
                Education = EducationType.Master,
            }
        };

        public IEnumerable<Employee> Employees2 => new List<Employee>
        {
            new Employee()
            {
                FirstName = "Михайло",
                MiddleName = "Петрович",
                LastName = "Драгоманов",
                BirthDate = new DateTime(1994, 9, 22),
                EmploymentStartDate = new DateTime(2018, 6, 8),
                TaxId = 6,
                Specialty = SpecialityType.Embedded,
                RollNumber = 6,
                Education = EducationType.Master
            },
            new Employee()
            {
                FirstName = "Олег",
                MiddleName = "Боросович",
                LastName = "Кравчук",
                BirthDate = new DateTime(1991, 11, 23),
                EmploymentStartDate = new DateTime(2020, 4, 3),
                TaxId = 7,
                Specialty = SpecialityType.Frontend,
                RollNumber = 7,
                Education = EducationType.Backelor,
            },
        };

        public IEnumerable<Company> Companies => new List<Company>()
        {
            new Company()
            {
                Id = 1,
                Name = "Mircosoft",
            },
            new Company()
            {
                Id = 2,
                Name = "Amazon"
            },
            new Company()
            {
                Id = 3,
                Name="Facebook"
            },
            new Company()
            {
                Id = 4,
                Name="Google"
            },
            new Company()
            {
                Id = 5,
                Name="Intel"
            },
        };

        public IEnumerable<SalaryPerMonth> Salaries => new List<SalaryPerMonth>()
        {
            new SalaryPerMonth()
            {
                TaxId = 1,
                Month = Month.January,
                Salary = 2000
            },
            new SalaryPerMonth()
            {
                TaxId = 1,
                Month = Month.June,
                Salary = 1000
            },

            new SalaryPerMonth()
            {
                TaxId = 3,
                 Month = Month.January,
                Salary = 1232
            },

            new SalaryPerMonth()
            {
                TaxId = 2,
                Month = Month.January,
                Salary = 900
            },


            new SalaryPerMonth()
            {
                TaxId = 4,
                Month = Month.May,
                Salary = 653
            },

            new SalaryPerMonth()
            {
                TaxId = 4,
                Month = Month.January,
                Salary = 8899
            },

        };

        public IEnumerable<EmployeeCompany> EmployeeCompanies => new List<EmployeeCompany>()
        {
            new EmployeeCompany()
            {
                Id=1,
                EmployeeId=1,
                CompanyId=3,
            },
            new EmployeeCompany()
            {
                Id=2,
                EmployeeId=2,
                CompanyId=1,
            },
            new EmployeeCompany()
            {
                Id=3,
                EmployeeId=3,
                CompanyId=2,
            },
               new EmployeeCompany()
            {
                Id=4,
                EmployeeId=4,
                CompanyId=2,
            },
            new EmployeeCompany()
            {
                Id=5,
                EmployeeId=3,
                CompanyId=3,
            },
            new EmployeeCompany()
            {
                Id=6,
                EmployeeId=3,
                CompanyId=2,
            },
            new EmployeeCompany()
            {
                Id=6,
                EmployeeId=4,
                CompanyId=4,
            },
        };

    }
}
