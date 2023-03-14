using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class OrderByDescendingTaxIdSalary : ICommand
    {
        private Service service;
        private Result result;

        public OrderByDescendingTaxIdSalary(Service service, Result result)
        {
            this.service = service;
            this.result = result;
        }

        public void Execute()
        {
            var res = service.OrderByDescendingTaxIdSalary();
            result.ShowOrderByDescendingSalary(res);
        }
    }
}
