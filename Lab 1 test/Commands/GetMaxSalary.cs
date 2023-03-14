using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class GetMaxSalary : ICommand
    {
        private Service service;
        private Result result;

        public GetMaxSalary(Service service, Result result)
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
