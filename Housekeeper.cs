
namespace OOPHotel2
{
    public class Housekeeper : Employee
    {
        public Housekeeper(){ 
            JobTitle = "Housekeeper";
            Department = "Housekeeping";
        }
        public Housekeeper(string name, int age, string? employeeId, DateTime startDate, decimal salary, string jobTitle) : base(name, age, employeeId, startDate, salary, "housekeeper", "housekeeping")
        {
        }
        public override void Work()
        {
            Console.WriteLine($"{Name} städar hotelrummen.");
        }
    }
}
