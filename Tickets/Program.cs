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
          
            ConcertTicket ct1 = new ConcertTicket(40, "The Band", "A1", "Amy");
            ConcertTicket ct2 = new ConcertTicket(10, "The Band", "Bill");


            Concert NewConcert = new Concert("The Band");

            try
            {
                NewConcert.AddConcertTicket(ct1);
                NewConcert.AddConcertTicket(ct2);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            NewConcert.OutputAllSeats();


        }
    }
}
