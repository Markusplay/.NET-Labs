using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class GetUnionEmployees : ICommand
    {
        private Service service;
        private Result result;

        public GetUnionEmployees(Service service, Result result)
        {
            this.service = service;
            this.result = result;
        }

        public void Execute()
        {
            var res = service.GetUnionEmployees();
            result.ShowUnionEmployees(res);
        }
    }
}
