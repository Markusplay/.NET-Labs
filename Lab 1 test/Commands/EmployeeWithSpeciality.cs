using Lab_1_test.Enum;
using Lab_1_test.Interfaces;
namespace Lab_1_test.Commands
{
    public class EmployeeWithSpeciality : ICommand
    {
        private Service service;
        private Result result;

        public EmployeeWithSpeciality(Service service, Result result)
        {
            this.service = service;
            this.result = result;
        }

        public void Execute()
        {
            var res = service.EmployeeWithSpeciality(SpecialityType.Frontend);
            result.EmployeeWithSpeciality(res);
        }
    }
}
