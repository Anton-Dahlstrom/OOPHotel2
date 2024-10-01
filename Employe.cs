using System.Runtime.InteropServices.JavaScript;

namespace OOPHotel2;

public class Employe : Person
{
    public string JobTitle { get; set; }
    public string Department { get; set; }

    public Employe(string name, int age, string employeeId, DateTime startDate, decimal salary) : 
        base(name, age, employeeId, startDate, salary)
    {
        
    }
}