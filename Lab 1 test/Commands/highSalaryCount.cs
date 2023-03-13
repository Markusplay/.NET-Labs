using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class highSalaryCount : ICommand
    {
        private Operation operation;
        private Result result;

        public highSalaryCount(Operation operation, Result result)
        {
            this.operation = operation;
            this.result = result;
        }

        public void Execute()
        {
            Console.WriteLine("Ввведіть зарплатню:");
            int salary = int.Parse(Console.ReadLine());
            var res = operation.highSalaryCount(salary);
            result.ShowHighSalary(res);
        }
    }
}
