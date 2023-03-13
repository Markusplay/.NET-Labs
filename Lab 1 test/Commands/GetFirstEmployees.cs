using Lab_1_test.Interfaces;


namespace Lab_1_test.Commands
{
    public class GetFirstEmployees : ICommand
    {
        private Operation operation;
        private Result result;

        public GetFirstEmployees(Operation operation, Result result)
        {
            this.operation = operation;
            this.result = result;
        }

        public void Execute()
        {
            var res = operation.GetFirstEmployees();
            result.ShowTwoEmployees(res);
        }
    }
}
