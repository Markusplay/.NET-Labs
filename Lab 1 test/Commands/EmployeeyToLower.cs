using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class EmployeeyToLower : ICommand
    {
        private DataProvider service;
        private Result result;

        public EmployeeyToLower(DataProvider service, Result result)
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
