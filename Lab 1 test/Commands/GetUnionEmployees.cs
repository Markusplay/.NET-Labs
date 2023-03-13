using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class GetUnionEmployees : ICommand
    {
        private Operation operation;
        private Result result;

        public GetUnionEmployees(Operation operation, Result result)
        {
            this.operation = operation;
            this.result = result;
        }

        public void Execute()
        {
            var res = operation.GetUnionEmployees();
            result.ShowUnionEmployees(res);
        }
    }
}
