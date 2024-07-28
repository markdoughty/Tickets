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
            ConcertTicket ct1 = new ConcertTicket(40, "The Band", "A1", "ID1");
            ConcertTicket ct2 = new ConcertTicket(10, "The Band", "ID2");

            Concert NewConcert = new Concert("The Band");

            try
            {
                NewConcert.AddConcertTicket(ct1);
                NewConcert.AddConcertTicket(ct2);
            }
            catch (WrongConcertException ex)
            {
                Console.WriteLine(ex.Message);
            }

            NewConcert.OutputAllSeats();
        }
    }

    internal class Concert
    {
        private string _BandName;

        // Property
        public string BandName
        {
            get { return _BandName; }
            set { _BandName = value; }
        }

        List<ConcertTicket> concert;

        // Constructor
        public Concert(string name)
        {
            BandName = name;
            concert = new List<ConcertTicket>();
        }

        // Methods
        public void AddConcertTicket(ConcertTicket ct)
        {
            if (ct.ConcertName != BandName)
            {
                throw new WrongConcertException("Sorry - this is the wrong concert");
            }
            else
            {
                concert.Add(ct);
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

    internal class ConcertTicket
    {
        private double _Price;
        private string _ConcertName;
        private string _Seat;
        private string _ID;

        // Properties
        public double Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        public string ConcertName
        {
            get { return _ConcertName; }
            set { _ConcertName = value; }
        }

        public string Seat
        {
            get
            {
                return _Seat ?? "No Seat Allocated";
            }
            set { _Seat = value; }
        }

        public string ID
        {
            get { return _ID; }
            private set { _ID = value; }
        }

        // Constructors
        public ConcertTicket(double price, string concertName, string seat, string id)
        {
            Price = price;
            ConcertName = concertName;
            Seat = seat;
            ID = id;
        }

        public ConcertTicket(double price, string concertName, string id)
        {
            Price = price;
            ConcertName = concertName;
            Seat = "No Seat Allocated"; // Assign default value
            ID = id;
        }

        // Methods
        public string OutputStatus()
        {
            return $"{ConcertName} : {Price:C}\nSeat: {Seat}\nTicket Holder ID: {ID}\n";
        }

        public string OutputStatus(int userId)
        {
            return $"{ConcertName} : {Price:C}\nSeat: {Seat}\nTicket Holder ID: {ID}\nRequested by: {userId}\n";
        }
    }

    public class WrongConcertException : Exception
    {
        public WrongConcertException(string message) : base(message)
        {
        }
    }
}
