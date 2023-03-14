using Lab_1_test.Interfaces;


namespace Lab_1_test.Commands
{
    public class GetEmployeeSalaryJoined : ICommand
    {
        private Service service;
        private Result result;

        public GetEmployeeSalaryJoined(Service service, Result result)
        {
            this.service = service;
            this.result = result;
        }

        public void Execute()
        {
            var res = service.GetEmployeeSalaryJoined();
            result.ShowEmployeeSlaryJoined(res);
        }
    }
}
