using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class GetAverageSalary : ICommand
    {
        private Operation operation;
        private Result result;

        public GetAverageSalary(Operation operation, Result result)
        {
            this.operation = operation;
            this.result = result;
        }

        public void Execute()
        {
            var res = operation.GetAverageSalary();
            result.ShowAverageSalary(res);
        }
    }
}
