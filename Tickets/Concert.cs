using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    internal class Concert
    {
        private string _bandName; 
        private List<ConcertTicket> ConcertTickets;

        //properties
        public string BandName
        {
            get => _bandName; //=> makes the code look better and more understandbale for future imrpovements
            set => _bandName = value;
        }


        public Concert(string bandName)
        {
            BandName = bandName;
            ConcertTickets = new List<ConcertTicket>();
        }

        //methods
        //ct expanded into full variable for better understandability
        public void AddConcertTicket(ConcertTicket concertTicket)
        {
            if (concertTicket.ConcertName != BandName)
            {
                throw new WrongConcertException("Sorry - this is the wrong concert");
            }

            ConcertTickets.Add(concertTicket);
        }

        public void OutputAllSeats()
        {
            //replaces the "ct"
            foreach (var concertTicket in ConcertTickets)
            {
                Console.WriteLine(concertTicket.OutputStatus());
            }
        }
    }
}
