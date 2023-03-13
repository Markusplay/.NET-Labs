using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class FindShSurname : ICommand
    {
        private Operation operation;
        private Result result;

        public FindShSurname(Operation operation, Result result)
        {
            this.operation = operation;
            this.result = result;
        }

        public void Execute()
        {
            var res = operation.FindShSurname("Ш");
            result.ShowShSurname(res);
        }
    }
}
