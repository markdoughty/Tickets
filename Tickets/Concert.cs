using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    internal class Concert
    {
        private string _BandName;
        //properties
        public string BandName
        {
            get { return _BandName; }
            set { _BandName = value; }
        }

        List<ConcertTicket> concert;
        public Concert(string name)
        {
            BandName = name;
            concert = new List<ConcertTicket>();
        }

        //methods
        public void AddConcertTicket(ConcertTicket Ticket)
        {
            if (Ticket.ConcertName != BandName)
            {
                throw new WrongConcertException("Sorry - this is the wrong concert");
            }
            else
            {
                concert.Add(Ticket);
            }
        }

        public void OutputAllSeats()
        {
            foreach (ConcertTicket Ticket in concert)
            {
                Console.WriteLine(Ticket.OutputStatus());
            }
        }
    }
}
