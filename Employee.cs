﻿using System.Runtime.InteropServices.JavaScript;

namespace OOPHotel2;

public class Employee : Person
{
    public string? JobTitle { get; set; }
    public string? Department { get; set; }

    public Employee(string name, int age, string? employeeId, DateTime startDate, decimal salary, string jobTitle, string department) : 
        base(name, age, employeeId, startDate, salary)
    {
        JobTitle = jobTitle;
        Department = department;
    }

    public Employee()
    {
        
    }

    public virtual void Work()
    {
        Console.WriteLine($"{Name} the {JobTitle} is working");
    }
    public override void DoWork()
    {
        Console.WriteLine($"{Name} the {JobTitle} is working.");
    }
}