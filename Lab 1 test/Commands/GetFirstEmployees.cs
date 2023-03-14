using Lab_1_test.Interfaces;


namespace Lab_1_test.Commands
{
    public class GetFirstEmployees : ICommand
    {
        private Service service;
        private Result result;

        public GetFirstEmployees(Service service, Result result)
        {
            this.service = service;
            this.result = result;
        }

        public void Execute()
        {
            var res = service.GetFirstEmployees();
            result.ShowTwoEmployees(res);
        }
    }
}
