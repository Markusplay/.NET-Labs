using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class SortEmployeesCommand : ICommand
    {
        private Operation operation;
        private Result result;

        public SortEmployeesCommand(Operation operation, Result result)
        {
            this.operation = operation;
            this.result = result;
        }

        public void Execute()
        {
            var res = operation.SortEmployees();
            result.ShowSortedEmployees(res);
        }
    }
}
