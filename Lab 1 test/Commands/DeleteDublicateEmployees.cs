using Lab_1_test.Interfaces;
namespace Lab_1_test.Commands
{
    public class DeleteDublicateEmployees : ICommand
    {
        private Service service;
        private Result result;

        public DeleteDublicateEmployees(Service service, Result result)
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
