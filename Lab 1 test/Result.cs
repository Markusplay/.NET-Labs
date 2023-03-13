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

        //1
        public void ShowSortedEmployees(IOrderedEnumerable<Employee> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.LastName} {item.FirstName} {item.MiddleName}");
            }
        }

        //2
        public void ShowSpecialist(IEnumerable<Employee> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.LastName} {item.FirstName} {item.Education}");
            }
        }

        //3
        public void ShowLowestSalary(int res)
        {
            Console.WriteLine("Найменша зарплатня = " + res);
        }

        //4
        public void ShowFiveYearDateReverse(IEnumerable<Employee> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.LastName} {item.FirstName} {item.EmploymentStartDate}");
            }
        }

        //5
        public void ShowAverageSalary(double res)
        {
            Console.WriteLine("Середня зарплатня працівників = " + Math.Round(res));
        }

        //6
        public void ShowMaxSalary(int res)
        {
            Console.WriteLine("Максимальна зарплатня працівників = " + res);
        }

        //7
        public void ShowHighSalary(int res)
        {
            Console.WriteLine("Всьго таких працівників:" + res);
        }

        //8
        public void ShowOrderByDescendingSalary(List<SalaryPerMonth> res)
        {
            foreach (var item in res)
            {
                Console.WriteLine(item.ToString());
            }
        }

        //9
        public void ShowCompanyToUpper(List<string> res)
        {
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        //10
        public void ShowBorndedBefore(int res)
        {
            Console.WriteLine("Кількість робітників, що народилися до вказаного року = " + res);
        }

        //11
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

        //12
        public void ShowTwoEmployees(IEnumerable<Employee> res)
        {
            foreach (var item in res)
            {
                Console.WriteLine($"{item.LastName} {item.FirstName} {item.MiddleName}");
            }
        }

        //13
        public void ShowEmployeeyToLower(List<string> res)
        {
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        //14
        public void ShowEmployeeSlaryJoined(List<EmployeeSalaryInfo> res)
        {
            foreach (var item in res)
            {
                Console.WriteLine($"{item.LastName} {item.FirstName} {item.Salary}");
            }
        }

        //15
        public void ShowGetWhile(IEnumerable<EmployeeCompany> res)
        {
            foreach (var item in res)
            {
                Console.WriteLine($"Id компанії - {item.CompanyId} Id працівника - {item.EmployeeId}");
            }
        }

        //16
        public void ShowDeleteDublicateEmployees(List<int> res)
        {
            foreach (var item in res)
            {
                Console.WriteLine($"Унікальні Id запису - {item}");
            }
        }



        //17
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


        //18
        public void ShowUnionEmployees(List<Employee> res)
        {
            foreach (var item in res)
            {
                Console.WriteLine($"{item.LastName} {item.FirstName} {item.MiddleName}");
            }
        }

        //19
        public void ShowShSurname(IEnumerable<Employee> res)
        {
            foreach (var item in res)
            {
                Console.WriteLine(item.LastName);
            }
        }

        //20
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
