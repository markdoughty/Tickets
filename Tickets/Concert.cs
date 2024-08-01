using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    internal class Concert
    {

        private static List<string> _TicketIds = new List<string>(); //a list of ticket ids already added.

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
        public void AddConcertTicket(ConcertTicket ct)
        {
            if (ct.ConcertName != BandName)
            {
                throw new WrongConcertException("Sorry - this is the wrong concert");
            }

            if (_TicketIds.Contains(ct.ID))
            {
                throw new Exception("A ticket with this id has already been added.");
            }

            else
            {
                concert.Add(ct);
                _TicketIds.Add(ct.ID);
            }
        }

        public void OutputAllSeats()
        {
            foreach (ConcertTicket ct in concert)
            {
                Console.WriteLine(ct.OutputStatus());
            }
        }
    }
}
