﻿using Lab_1_test.Interfaces;

namespace Lab_1_test.Commands
{
    public class GetAverageSalary : ICommand
    {
        private Service service;
        private Result result;

        public GetAverageSalary(Service service, Result result)
        {
            this.service = service;
            this.result = result;
        }

        public void Execute()
        {
            var res = service.GetAverageSalary();
            result.ShowAverageSalary(res);
        }
    }
}
