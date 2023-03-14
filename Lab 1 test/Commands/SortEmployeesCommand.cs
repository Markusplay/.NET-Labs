using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class SortEmployeesCommand : ICommand
    {
        private Service service;
        private Result result;

        public SortEmployeesCommand(Service service, Result result)
        {
            this.service = service;
            this.result = result;
        }

        public void Execute()
        {
            var res = service.SortEmployees();
            result.ShowSortedEmployees(res);
        }
    }
}
