using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHotel2
{
    internal class Person(string name, int age, string employeeId, DateTime startDate, decimal salary)
    {
        string Name = name;
        int Age = age;
        string EmployeeId = employeeId;
        DateTime startDate = startDate;
        decimal Salary = salary;
    public void PrintInfo()
    {
        Console.WriteLine($"Namn: {Name}, Ålder: {Age}");
    }
    public void Introduce()
    {
        Console.WriteLine($"Hej, jag heter {Name} och är {Age} år gammal.");

            Console.WriteLine();
    }
    }
}
