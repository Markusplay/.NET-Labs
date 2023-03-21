using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class AllSameSalaryInMonthNow : ICommand
    {
        private DataProvider service;
        private Result result;

        public AllSameSalaryInMonthNow(DataProvider service, Result result)
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
                bool res = service.AllSameSalaryInMonthNow(salary);
                result.ShowAllSameSalaryInMonthNow(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
