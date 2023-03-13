using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class GetLowestSalary : ICommand
    {
        private Operation operation;
        private Result result;

        public GetLowestSalary(Operation operation, Result result)
        {
            this.operation = operation;
            this.result = result;
        }

        public void Execute()
        {
            var res = operation.GetLowestSalary();
            result.ShowLowestSalary(res);
        }
    }
}
