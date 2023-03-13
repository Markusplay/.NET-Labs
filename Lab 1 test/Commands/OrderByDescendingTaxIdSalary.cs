using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class OrderByDescendingTaxIdSalary : ICommand
    {
        private Operation operation;
        private Result result;

        public OrderByDescendingTaxIdSalary(Operation operation, Result result)
        {
            this.operation = operation;
            this.result = result;
        }

        public void Execute()
        {
            var res = operation.OrderByDescendingTaxIdSalary();
            result.ShowOrderByDescendingSalary(res);
        }
    }
}
