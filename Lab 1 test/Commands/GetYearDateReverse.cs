using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class GetYearDateReverse : ICommand
    {
        private DataProvider service;
        private Result result;

        public GetYearDateReverse(DataProvider service, Result result)
        {
            this.service = service;
            this.result = result;
        }

        public void Execute()
        {
            Console.WriteLine("Ввведіть рік:");
            try
            {
                int year = int.Parse(Console.ReadLine());
                var res = service.GetYearDateReverse(year);
                result.ShowFiveYearDateReverse(res);
            }
            catch (Exception)
            {
                Console.WriteLine("Введіть рік цифрою");
            }
        }
    }
}
