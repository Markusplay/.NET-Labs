using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class GetWhile : ICommand
    {
        private DataProvider service;
        private Result result;

        public GetWhile(DataProvider service, Result result)
        {
            this.service = service;
            this.result = result;
        }

        public void Execute()
        {
            Console.WriteLine("Введіть id: ");
            try
            {
                int id = int.Parse(Console.ReadLine());
                var res = service.GetWhile(id);
                result.ShowGetWhile(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
