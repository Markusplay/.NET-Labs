using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class GetWhile : ICommand
    {
        private Operation operation;
        private Result result;

        public GetWhile(Operation operation, Result result)
        {
            this.operation = operation;
            this.result = result;
        }

        public void Execute()
        {
            Console.WriteLine("Введіть id: ");
            try
            {
                int id = int.Parse(Console.ReadLine());
                var res = operation.GetWhile(id);
                result.ShowGetWhile(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
