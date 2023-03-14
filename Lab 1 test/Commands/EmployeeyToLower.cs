using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class EmployeeyToLower : ICommand
    {
        private Service service;
        private Result result;

        public EmployeeyToLower(Service service, Result result)
        {
            this.service = service;
            this.result = result;
        }

        public void Execute()
        {
            var res = service.EmployeeyToLower();
            result.ShowEmployeeyToLower(res);
        }
    }
}
