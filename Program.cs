using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employ1 = new Employee("Akin", "Wale", 2000.50M);
            Employee employ2 = new Employee("Florence", "Ariyo", 500.25M);

            Console.WriteLine("Employee 1 First Name: {0}", employ1.FirstName);
            Console.WriteLine("Employee 1 Last Name: {0}", employ1.LastName);
            Console.WriteLine("Employee 1 Salary: {0:C}", employ1.Salary);

            Console.WriteLine("Employee 2 First Name: {0}", employ2.FirstName);
            Console.WriteLine("Employee 2 Last Name: {0}", employ2.LastName);
            Console.WriteLine("Employee 2 Salary: {0:C}", employ2.Salary);

            Console.WriteLine();
            Console.WriteLine("After 10% raise");

            employ1.Salary = employ1.Salary * 1.1M;
            employ2.Salary = employ2.Salary * 1.1M;
            Console.WriteLine("Employee 1 new salary: {0:C}", employ1.Salary);
            Console.WriteLine("Employee 2 new salary: {0:C}", employ2.Salary);


            Console.ReadLine();


        }
    }
}