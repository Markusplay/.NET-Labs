using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class GetCompanyToUpper : ICommand
    {
        private Service service;
        private Result result;

        public GetCompanyToUpper(Service service, Result result)
        {
            this.service = service;
            this.result = result;
        }

        public void Execute()
        {
            var res = service.GetCompanyToUpper();
            result.ShowCompanyToUpper(res);
        }
    }
}
