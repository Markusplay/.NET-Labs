using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class FindShSurname : ICommand
    {
        private Service service;
        private Result result;

        public FindShSurname(Service service, Result result)
        {
            this.service = service;
            this.result = result;
        }

        public void Execute()
        {
            var res = service.FindShSurname("Ш");
            result.ShowShSurname(res);
        }
    }
}
