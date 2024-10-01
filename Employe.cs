using System.Runtime.InteropServices.JavaScript;

namespace OOPHotel2;

public class Employee : Person
{
    public string JobTitle { get; set; }
    public string Department { get; set; }

    public Employee(string name, int age, string employeeId, DateTime startDate, decimal salary) : 
        base(name, age, employeeId, startDate, salary)
    {
        
    }
}