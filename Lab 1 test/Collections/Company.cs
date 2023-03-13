
using Lab_1_test.Interfaces;

namespace Lab1.Collection
{
    public class Company: ICompany
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public override string ToString()
        {
            return "Назва компанії - " + Name + ", id компанії = " + Id;
        }
    }
}
