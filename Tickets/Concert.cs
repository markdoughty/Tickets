using System;
using System.Collections.Generic;


namespace Tickets
{
    internal class Concert
    {
        private string _bandName;
        
        //properties
        public string BandName
        {
            get { return bandName; }
            set { _bandName = value; }
        }

        private List<ConcertTicket> _concertTickets;

        //Constructors
        public Concert(string name)
        {
            BandName = name;
            _concertTickets = new List<ConcertTicket>();
        }

        //methods
        public void AddConcertTicket(ConcertTicket ct)
        {
            if (ct.ConcertName != BandName)
            {
                throw new WrongConcertException($"Sorry - this is the wrong concert, this is {ct.ConcertName}");
            }
            if (ct == null)
            {
                throw new NullException("Sorry - concert ticket can't be null");
            }
            if (Bandname == null)
            {
                throw new InvalidOperationException("Sorry - Bandname is not set");
            }
            else
            {
                _concertTickets.Add(ct);
            }
        }

        public void OutputAllSeats()
        {
            if(_concertTickets == null || _concertTickets.count == 0)
            {
                Console.WriteLine("No concert tickets available.");
                return;
            }
            foreach (ConcertTicket ct in _concertTickets)
            {
                if(ct == null)
                {
                    Console.writeline("Error: Found a null ticket in the list.")
                    continue;
                }
                Console.WriteLine(ct.OutputStatus());
            }
        }
    }
    internal class WrongConcertException:Exception
    {
        public WrongConcertException(string message): base (message) { }
    }
}
