using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class GetYearDateReverse : ICommand
    {
        private Operation operation;
        private Result result;

        public GetYearDateReverse(Operation operation, Result result)
        {
            this.operation = operation;
            this.result = result;
        }

        public void Execute()
        {
            Console.WriteLine("Ввведіть рік:");
            try
            {
                int year = int.Parse(Console.ReadLine());
                var res = operation.GetYearDateReverse(year);
                result.ShowFiveYearDateReverse(res);
            }
            catch (Exception)
            {
                Console.WriteLine("Введіть рік цифрою");
            }
        }
    }
}
