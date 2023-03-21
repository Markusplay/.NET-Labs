using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class GroupBySpeciality : ICommand
    {
        private DataProvider service;
        private Result result;

        public GroupBySpeciality(DataProvider service, Result result)
        {
            this.service = service;
            this.result = result;
        }

        public void Execute()
        {
            var res = service.GroupBySpeciality();
            result.ShowGroupBySpeciality(res);
        }
    }
}
