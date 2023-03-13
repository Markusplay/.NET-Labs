using Lab_1_test.Interfaces;
using Lab1;

namespace Lab_1_test.Commands
{
    public class GetBorndedBefore : ICommand
    {
        private Operation operation;
        private Result result;

        public GetBorndedBefore(Operation operation, Result result)
        {
            this.operation = operation;
            this.result = result;
        }

        public void Execute()
        {
            Console.WriteLine("Введіть рік:");
            int year  = int.Parse(Console.ReadLine());
            var res = operation.GetBorndedBefore(year);
            result.ShowBorndedBefore(res);
        }
    }
}
