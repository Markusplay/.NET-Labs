using Lab_1_test.Enum;
using Lab_1_test.Interfaces;
namespace Lab_1_test.Commands
{
    public class EmployeeWithSpeciality : ICommand
    {
        private Operation operation;
        private Result result;

        public EmployeeWithSpeciality(Operation operation, Result result)
        {
            this.operation = operation;
            this.result = result;
        }

        public void Execute()
        {
            var res = operation.EmployeeWithSpeciality(SpecialityType.Frontend);
            result.EmployeeWithSpeciality(res);
        }
    }
}
