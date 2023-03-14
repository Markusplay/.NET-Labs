using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class GetLowestSalary : ICommand
    {
        private Service service;
        private Result result;

        public GetLowestSalary(Service service, Result result)
        {
            this.service = service;
            this.result = result;
        }

        public void Execute()
        {
            var res = service.GetLowestSalary();
            result.ShowLowestSalary(res);
        }
    }
}
