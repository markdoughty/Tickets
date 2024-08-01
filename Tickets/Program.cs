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
          
            ConcertTicket ConcertTicketInstance1 = new ConcertTicket(40, "The Band", "A1", "Amy");
            ConcertTicket ConcertTicketInstance2 = new ConcertTicket(10, "The Band", "Bill");

            Concert ConcertInstance = new Concert("The Band");

            try
            {
                ConcertInstance.AddConcertTicket(ConcertTicketInstance1);
                ConcertInstance.AddConcertTicket(ConcertTicketInstance2);
            }
            catch(Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            ConcertInstance.OutputAllSeats();


        }
    }
}
