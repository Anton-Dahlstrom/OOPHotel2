using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace OOPHotel2
{
    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }

        public Person(string name, int age, string employeeId, DateTime startDate, decimal salary)
        {
            Name = name;
            Age = age;
            EmployeeId = employeeId;
            StartDate = startDate;
            Salary = salary;
        }
        public Person()
        {
            
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\nAge{Age}");
        }

        public void Introduce()
        {
            Console.WriteLine($"Hello my name is {Name} and I am {Age} years old");
        }
    }
}
