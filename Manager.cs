using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHotel2
{
    public class Manager : Person
    {
        public string Department { get; set; }

        public Manager(string name, int age, string employeeId, DateTime startDate, decimal salary, string department) :
            base(name, age, employeeId, startDate, salary)
        {
            
        }
    }
}
