﻿namespace OOPHotel2;

public class Consultant : Person
{
    public string? ConsultingFirm { get; set; }
    public decimal HourlyRate { get; set; }
    
    public Consultant(string name, int age, DateTime startDate, string consultingFirm, decimal hourlyRate) : 
        base(name, age, null, startDate, 0)
    {
        Name = name;
        Age = age;
        ConsultingFirm = consultingFirm;
        HourlyRate = hourlyRate;
    }

    private string JobTitle { get; } = "Consultant";

    public void GiveAdvice()
    {
        Console.WriteLine($"{Name} the {JobTitle} is giving you advice.");
    }
}