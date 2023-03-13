using Lab_1_test.Interfaces;


namespace Lab_1_test.Commands
{
    public class GetEmployeeSalaryJoined : ICommand
    {
        private Operation operation;
        private Result result;

        public GetEmployeeSalaryJoined(Operation operation, Result result)
        {
            this.operation = operation;
            this.result = result;
        }

        public void Execute()
        {
            var res = operation.GetEmployeeSalaryJoined();
            result.ShowEmployeeSlaryJoined(res);
        }
    }
}
