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
            Operation operation = new Operation();
            MenuInvoker invoker = new MenuInvoker();
            invoker.AddCommand(new SortEmployeesCommand(operation, result));
            invoker.AddCommand(new GetSpecialistCommand(operation, result));
            invoker.AddCommand(new GetLowestSalary(operation, result));
            invoker.AddCommand(new GetYearDateReverse(operation, result));
            invoker.AddCommand(new GetAverageSalary(operation, result));
            invoker.AddCommand(new GetMaxSalary(operation, result));
            invoker.AddCommand(new highSalaryCount(operation, result));
            invoker.AddCommand(new OrderByDescendingTaxIdSalary(operation, result));
            invoker.AddCommand(new GetCompanyToUpper(operation, result));
            invoker.AddCommand(new GetBorndedBefore(operation, result));
            invoker.AddCommand(new GroupBySpeciality(operation, result));
            invoker.AddCommand(new GetFirstEmployees(operation, result));
            invoker.AddCommand(new EmployeeyToLower(operation, result));
            invoker.AddCommand(new GetEmployeeSalaryJoined(operation, result));
            invoker.AddCommand(new GetWhile(operation, result));
            invoker.AddCommand(new DeleteDublicateEmployees(operation, result));
            invoker.AddCommand(new EmployeeWithSpeciality(operation, result));
            invoker.AddCommand(new GetUnionEmployees(operation, result));
            invoker.AddCommand(new FindShSurname(operation, result));
            invoker.AddCommand(new AllSameSalaryInMonthNow(operation, result));

            while (true)
            {
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                invoker.ExecuteCommand(choice - 1);
            }
        }
    }
}
