using Lab_1_test.Interfaces;
namespace Lab_1_test.Commands
{
    public class DeleteDublicateEmployees : ICommand
    {
        private Operation operation;
        private Result result;

        public DeleteDublicateEmployees(Operation operation, Result result)
        {
            this.operation = operation;
            this.result = result;
        }

        public void Execute()
        {
            var res = operation.DeleteDublicateEmployees();
            result.ShowDeleteDublicateEmployees(res);
        }
    }
}
