

namespace OOPHotel2
{
    public class Manager : Person
    {
        public string? Department { get; set; }

        public Manager(string name, int age, string employeeId, DateTime startDate, decimal salary, string department) :
            base(name, age, employeeId, startDate, salary)
        {
            
        }

        public Manager()
        {
            
        }
        public void HoldMeeting()
        {
            Console.WriteLine($"Manager {Name} is holding a meeting.");
        }
    }
}
