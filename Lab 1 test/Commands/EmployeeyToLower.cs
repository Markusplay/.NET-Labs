using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class EmployeeyToLower : ICommand
    {
        private Operation operation;
        private Result result;

        public EmployeeyToLower(Operation operation, Result result)
        {
            this.operation = operation;
            this.result = result;
        }

        public void Execute()
        {
            var res = operation.EmployeeyToLower();
            result.ShowEmployeeyToLower(res);
        }
    }
}
