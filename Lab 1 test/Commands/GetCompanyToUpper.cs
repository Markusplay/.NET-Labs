using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class GetCompanyToUpper : ICommand
    {
        private Operation operation;
        private Result result;

        public GetCompanyToUpper(Operation operation, Result result)
        {
            this.operation = operation;
            this.result = result;
        }

        public void Execute()
        {
            var res = operation.GetCompanyToUpper();
            result.ShowCompanyToUpper(res);
        }
    }
}
