using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHotel2
{
    public class Person(string name, int age, string employeeId, DateTime startDate, decimal salary)
    {
        public string Name = name;
        public int Age = age;
        public string EmployeeId = employeeId;
        public DateTime startDate = startDate;
        public decimal Salary = salary;
    public void PrintInfo()
    {
        Console.WriteLine($"Namn: {Name}, Ålder: {Age}");
    }
    public void Introduce()
    {
        Console.WriteLine($"Hej, jag heter {Name} och är {Age} år gammal.");
    }  
    }
}
