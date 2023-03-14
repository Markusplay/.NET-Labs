using Lab_1_test.Commands;
using System.Text;

namespace Lab_1_test
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            new ConsoleMenu();
            Result result = new Result();
            Service service = new Service();
            MenuInvoker invoker = new MenuInvoker();
            invoker.AddCommand(new SortEmployeesCommand(service, result));
            invoker.AddCommand(new GetSpecialistCommand(service, result));
            invoker.AddCommand(new GetLowestSalary(service, result));
            invoker.AddCommand(new GetYearDateReverse(service, result));
            invoker.AddCommand(new GetAverageSalary(service, result));
            invoker.AddCommand(new GetMaxSalary(service, result));
            invoker.AddCommand(new HighSalaryCount(service, result));
            invoker.AddCommand(new OrderByDescendingTaxIdSalary(service, result));
            invoker.AddCommand(new GetCompanyToUpper(service, result));
            invoker.AddCommand(new GetBorndedBefore(service, result));
            invoker.AddCommand(new GroupBySpeciality(service, result));
            invoker.AddCommand(new GetFirstEmployees(service, result));
            invoker.AddCommand(new EmployeeyToLower(service, result));
            invoker.AddCommand(new GetEmployeeSalaryJoined(service, result));
            invoker.AddCommand(new GetWhile(service, result));
            invoker.AddCommand(new DeleteDublicateEmployees(service, result));
            invoker.AddCommand(new EmployeeWithSpeciality(service, result));
            invoker.AddCommand(new GetUnionEmployees(service, result));
            invoker.AddCommand(new FindShSurname(service, result));
            invoker.AddCommand(new AllSameSalaryInMonthNow(service, result));

            while (true)
            {
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Введені некоректні дані");
                    continue;
                }

                invoker.ExecuteCommand(choice - 1);
            }
        }
    }
}
