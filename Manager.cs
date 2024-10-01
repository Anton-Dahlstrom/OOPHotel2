using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHotel2
{
    internal class Manager(string department,  string name, int age, string employeeId, DateTime startDate, decimal salary) : Person(name, age, employeeId, startDate, salary)
    {
        string Department = department;
        public void HoldMeeting()
        {
            Console.WriteLine($"Manager {Name} is holding a meeting.");
        }
    }
}
