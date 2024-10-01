using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHotel2
{
    public class Person(string name, int age, string employeeId, DateTime startDate, decimal salary)
    {
        protected string Name = name;
        protected int Age = age;
        protected string EmployeeId = employeeId;
        protected DateTime startDate = startDate;
        protected decimal Salary = salary;
    public void PrintInfo()
    {
        Console.WriteLine($"Namn: {Name}, Ålder: {Age}");
    }
    public void Introduce()
    {
        Console.WriteLine($"Hej, jag heter {Name} och är {Age} år gammal.");
    }   Console.WriteLine();
    }
}
