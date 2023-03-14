using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class HighSalaryCount : ICommand
    {
        private Service service;
        private Result result;

        public HighSalaryCount(Service service, Result result)
        {
            this.service = service;
            this.result = result;
        }

        public void Execute()
        {
            Console.WriteLine("Ввведіть зарплатню:");
            try
            {
                int salary = int.Parse(Console.ReadLine());
                var res = service.highSalaryCount(salary);
                result.ShowHighSalary(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
