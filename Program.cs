namespace OOPHotel2
{
    internal class Program
    {
        static void Main()
        {
            DateTime starDate = new DateTime(2024, 10, 02);
            Consultant consultant = new Consultant("Mauricio", 26, starDate, "MC Consulting", 10000);
            
            Console.WriteLine(consultant.Name);
            Console.WriteLine(consultant.Age);
            Console.WriteLine(consultant.StartDate);
            Console.WriteLine(consultant.ConsultingFirm);
            Console.WriteLine(consultant.HourlyRate);
        }
    }
}
