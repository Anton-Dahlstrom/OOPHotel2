

namespace OOPHotel2
{
    public class Manager : Person
    {
        public string? Department { get; set; }

        public Manager(string name, int age, string? employeeId, DateTime startDate, decimal salary, string department) :
            base(name, age, employeeId, startDate, salary)
        {
            Department = department;
        }

        public Manager()
        {
            
        }
        public void HoldMeeting()
        {
            Console.WriteLine($"Manager {Name} is holding a meeting.");
        }
        public void PlanBudget()
        { 
            Console.WriteLine($"Manager {Name} from the {Department} department is planning the hotel budget.");
        }
        public override void DoWork()
        {
            Console.WriteLine($"{Name} the manager is managing.");
        }
    }
}
