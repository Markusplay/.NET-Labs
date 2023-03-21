using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class FindShSurname : ICommand
    {
        private DataProvider service;
        private Result result;

        public FindShSurname(DataProvider service, Result result)
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
