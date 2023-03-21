using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class GetAverageSalary : ICommand
    {
        //Interfaces
        private DataProvider service;
        private Result result;

        //interfaces
        public GetAverageSalary(DataProvider service, Result result)
        {
            this.service = service;
            this.result = result;
        }

        public void Execute()
        {
            var res = service.GetAverageSalary();
            result.ShowAverageSalary(res);
        }
    }
}
