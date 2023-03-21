using Lab_1_test.Interfaces;
namespace Lab_1_test.Commands
{
    public class DeleteDublicateEmployees : ICommand
    {
        private DataProvider service;
        private Result result;

        public DeleteDublicateEmployees(DataProvider service, Result result)
        {
            this.service = service;
            this.result = result;
        }

        public void Execute()
        {
            var res = service.DeleteDublicateEmployees();
            result.ShowDeleteDublicateEmployees(res);
        }
    }
}
