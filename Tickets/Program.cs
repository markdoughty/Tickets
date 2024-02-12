using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcertTicket ct1 = new ConcertTicket(40, "The Band", "A1", 4);
            ConcertTicket ct2 = new ConcertTicket(10, "The Band", 5);

            Console.WriteLine(ct1.OutputStatus());
            Console.WriteLine(ct2.OutputStatus(1234));

        }
    }
}
