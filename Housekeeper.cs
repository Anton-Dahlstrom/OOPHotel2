using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHotel2
{
    public class Housekeeper : Employee
    {
        public override void Work()
        {
            Console.WriteLine($"{Name} städar hotelrummen.");
        }
    }
}
