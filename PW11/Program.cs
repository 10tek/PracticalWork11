using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW11
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                Name = "123",
                Vacancy = Vacancies.Boss,
                Salary = 123123,
                ReceiptDate = new int[] { 20,02,2019 }
            };
        }
    }
}
