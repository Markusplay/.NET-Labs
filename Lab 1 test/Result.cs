using Lab_1_test.Enum;
using Lab1.Collection;

namespace Lab_1_test
{
    public class Result
    {
        public void ShowError()
        {
            Console.WriteLine("Ви ввели некоректне значення");
        }

        public void ShowSortedEmployees(IOrderedEnumerable<Employee> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.LastName} {item.FirstName} {item.MiddleName}");
            }
        }

        public void ShowSpecialist(IEnumerable<Employee> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.LastName} {item.FirstName} {item.Education}");
            }
        }

        public void ShowLowestSalary(int res)
        {
            Console.WriteLine("Найменша зарплатня = " + res);
        }

        public void ShowFiveYearDateReverse(IEnumerable<Employee> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.LastName} {item.FirstName} {item.EmploymentStartDate}");
            }
        }

        public void ShowAverageSalary(double res)
        {
            Console.WriteLine("Середня зарплатня працівників = " + Math.Round(res));
        }

        public void ShowMaxSalary(int res)
        {
            Console.WriteLine("Максимальна зарплатня працівників = " + res);
        }

        public void ShowHighSalary(int res)
        {
            Console.WriteLine("Всьго таких працівників:" + res);
        }

        public void ShowOrderByDescendingSalary(List<SalaryPerMonth> res)
        {
            foreach (var item in res)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void ShowCompanyToUpper(List<string> res)
        {
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        public void ShowBorndedBefore(int res)
        {
            Console.WriteLine("Кількість робітників, що народилися до вказаного року = " + res);
        }

        public void ShowGroupBySpeciality(IEnumerable<IGrouping<SpecialityType, Employee>> res)
        {
            foreach (var item in res)
            {
                Console.WriteLine(item.Key + ":");
                foreach (var item2 in item)
                {
                    Console.WriteLine($"    {item2.FirstName} {item2.LastName} {item2.Salaries}");
                }
            }
        }

        public void ShowTwoEmployees(IEnumerable<Employee> res)
        {
            foreach (var item in res)
            {
                Console.WriteLine($"{item.LastName} {item.FirstName} {item.MiddleName}");
            }
        }

        public void ShowEmployeeyToLower(List<string> res)
        {
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        public void ShowEmployeeSlaryJoined(List<EmployeeSalaryInfo> res)
        {
            foreach (var item in res)
            {
                Console.WriteLine($"{item.LastName} {item.FirstName} {item.Salary}");
            }
        }

        public void ShowGetWhile(IEnumerable<EmployeeCompany> res)
        {
            foreach (var item in res)
            {
                Console.WriteLine($"Id компанії - {item.CompanyId} Id працівника - {item.EmployeeId}");
            }
        }

        public void ShowDeleteDublicateEmployees(List<int> res)
        {
            foreach (var item in res)
            {
                Console.WriteLine($"Унікальні Id запису - {item}");
            }
        }



        public void EmployeeWithSpeciality(bool res)
        {
            if (res)
            {
                Console.WriteLine("Існує");
            }
            else
            {
                Console.WriteLine("Не існує");
            }
        }


        public void ShowUnionEmployees(List<Employee> res)
        {
            foreach (var item in res)
            {
                Console.WriteLine($"{item.LastName} {item.FirstName} {item.MiddleName}");
            }
        }

        public void ShowShSurname(IEnumerable<Employee> res)
        {
            foreach (var item in res)
            {
                Console.WriteLine(item.LastName);
            }
        }

        public void ShowAllSameSalaryInMonthNow(bool res)
        {
            if (res)
            {
                Console.WriteLine("Існує");
            }
            else
            {
                Console.WriteLine("Не існує");
            }
        }

    }
}
