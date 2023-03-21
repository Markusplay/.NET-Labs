using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class GetCompanyToUpper : ICommand
    {
        private DataProvider service;
        private Result result;

        public GetCompanyToUpper(DataProvider service, Result result)
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
