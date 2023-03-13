using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class GetMaxSalary : ICommand
    {
        private Operation operation;
        private Result result;

        public GetMaxSalary(Operation operation, Result result)
        {
            this.operation = operation;
            this.result = result;
        }

        public void Execute()
        {
            var res = operation.GetMaxSalary();
            result.ShowMaxSalary(res);
        }
    }
}
