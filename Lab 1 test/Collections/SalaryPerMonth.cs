using System;
using System.Collections.Generic;
using Lab_1_test.Enum;
using Lab_1_test.Interfaces;

namespace Lab1.Collection
{
    public class SalaryPerMonth: ISalaryPerMonth
    {
        public int TaxId { get; set; }
        public Month Month { get; set; }
        public int Salary { get; set; }

        //List<Employee> Employees { get; set; }
        public override string ToString()
        {
            return "\nРеєстраційний номер облікової картки:" + TaxId + "\nЗарплата за місяць " + Month + " = " + Salary + ".";
        }
    }
}
