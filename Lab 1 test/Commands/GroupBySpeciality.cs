using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class GroupBySpeciality : ICommand
    {
        private Operation operation;
        private Result result;

        public GroupBySpeciality(Operation operation, Result result)
        {
            this.operation = operation;
            this.result = result;
        }

        public void Execute()
        {
            var res = operation.GroupBySpeciality();
            result.ShowGroupBySpeciality(res);
        }
    }
}
