using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class GetWhile : ICommand
    {
        private Service service;
        private Result result;

        public GetWhile(Service service, Result result)
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
