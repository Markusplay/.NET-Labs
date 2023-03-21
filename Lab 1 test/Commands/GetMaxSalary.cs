using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class GetMaxSalary : ICommand
    {
        private DataProvider service;
        private Result result;

        public GetMaxSalary(DataProvider service, Result result)
        {
            this.service = service;
            this.result = result;
        }

        public void Execute()
        {
            var res = service.GetMaxSalary();
            result.ShowMaxSalary(res);
        }
    }
}
