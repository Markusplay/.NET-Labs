using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class AllSameSalaryInMonthNow : ICommand
    {
        private Operation operation;
        private Result result;

        public AllSameSalaryInMonthNow(Operation operation, Result result)
        {
            this.operation = operation;
            this.result = result;
        }

        public void Execute()
        {
            Console.WriteLine("Ввведіть зарплатню:");
            try
            {
                int salary = int.Parse(Console.ReadLine());
                bool res = operation.AllSameSalaryInMonthNow(salary);
                result.ShowAllSameSalaryInMonthNow(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
