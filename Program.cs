namespace OOPHotel2
{
    internal class Program
    {
        static void Main()
        {
            // Skapa en Manager
            Manager manager = new Manager
            {
                Name = "Lisa Ledarsson",
                Age = 40,
                EmployeeId = "M001",
                StartDate = new DateTime(2020, 1, 1),
                Salary = 50000m,
                Department = "Administration"
            };

            // Skapa en Employee
            Employee employee = new Employee
            {
                Name = "Erik Eriksson",
                Age = 30,
                EmployeeId = "E001",
                StartDate = new DateTime(2022, 3, 15),
                Salary = 30000m,
                JobTitle = "Receptionist",
                Department = "Front Desk"
            };

            // Anropa metoder för att testa
            Console.WriteLine("Manager:");
            manager.PrintInfo();
            manager.Introduce();
            manager.HoldMeeting();

            Console.WriteLine("\nEmployee:");
            employee.PrintInfo();
            employee.Introduce();
            employee.Work();

            // Skapa ett Housekeeper-objekt
            Housekeeper anna = new Housekeeper();
            anna.Name = "Anna Clean";
            anna.Age = 32;
            anna.PrintInfo(); // Skriver ut namn och ålder
            anna.Work(); // Skriver ut att Anna städar hotellrummen
            
            Consultant consultant = new Consultant
            {
                Name = "Eva Expert",
                Age = 35,
                EmployeeId = "C001",
                StartDate = new DateTime(2023, 1, 1),
                Salary = 0, // Konsulter har ofta inte fast lön
                HourlyRate = 1000,
                ConsultingFirm = "Hotell Experterna AB"
            };

            Console.WriteLine("Consultant:");
            consultant.PrintInfo();
            consultant.Introduce();
            consultant.GiveAdvice();
            Console.WriteLine($"Hourly Rate: {consultant.HourlyRate}");
            Console.WriteLine($"Consulting Firm: {consultant.ConsultingFirm}");
        }
    }
}
