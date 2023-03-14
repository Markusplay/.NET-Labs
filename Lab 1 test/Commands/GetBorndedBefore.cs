using Lab_1_test.Interfaces;
using Lab1;

namespace Lab_1_test.Commands
{
    public class GetBorndedBefore : ICommand
    {
        private Service service;
        private Result result;

        public GetBorndedBefore(Service service, Result result)
        {
            this.service = service;
            this.result = result;
        }

        public void Execute()
        {
            Console.WriteLine("Введіть рік:");
            try
            {
                int year = int.Parse(Console.ReadLine());
                var res = service.GetBorndedBefore(year);
                result.ShowBorndedBefore(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
