using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    internal class ConcertTicket
    {
        private double _Price;
        private string _ConcertName;
        private string _Seat;
        private string _ID;

        //properties
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
            get { if (_Seat == null)
                    return "No Seat Allocated";
                else
                    return _Seat; }
            set { _Seat = value; }
        }
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        //Constructors
        //
        public ConcertTicket(int SeatPrice, string Name, string ConcertSeat, string SeatID)
        {
            Price = SeatPrice;
            ConcertName = Name;
            Seat = ConcertSeat;
            ID = SeatID;
        }
        public ConcertTicket(int SeatPrice, string Name, string SeatID)
        {
            Price = SeatPrice;
            ConcertName = Name;
            ID = SeatID;
        }

        //Methods
       public string OutputStatus()
        {
            string Output = ConcertName + " : " + String.Format("{0:C}", _Price) + "\nSeat: " + Seat + "\nTicket Holder ID: " + ID + "\n";
            return Output;
        }

        public string OutputStatus(int UserID)
        {
            string Output = ConcertName + " : " + String.Format("{0:C}", _Price) + "\nSeat: " + Seat + "\nTicket Holder ID: " + ID + "\nRequested by: " + UserID + "\n";
            return Output;
        }

 
    }
}
