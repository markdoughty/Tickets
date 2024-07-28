using System;

namespace Tickets
{
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
}
