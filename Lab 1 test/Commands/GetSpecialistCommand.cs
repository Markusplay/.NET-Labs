using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class GetSpecialistCommand : ICommand
    {
        private DataProvider service;
        private Result result;

        public GetSpecialistCommand(DataProvider service, Result result)
        {
            this.service = service;
            this.result = result;
        }

        public void Execute()
        {
            var res = service.GetSpecialist();
            result.ShowSpecialist(res);
        }
    }
}
