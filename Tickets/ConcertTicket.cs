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
        private int _ID;

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
        public int ID
        {
            get { return _ID; }
            private set { _ID = value; }
        }
        //Constructors
        //
        public ConcertTicket(int P, string cn, string s, int id )
        {
            Price = P;
            ConcertName = cn;
            Seat = s;
            ID = id;
        }
        public ConcertTicket(int P, string cn, int id)
        {
            Price = P;
            ConcertName = cn;
            ID = id;
        }

        //Methods
       public string OutputStatus()
        {
            string output = ConcertName + " : " + String.Format("{0:C}", _Price) + "\n Seat: " + Seat + "\n Ticket Holder ID: " + ID;
            return output;
        }

        public string OutputStatus(int userid)
        {
            string output = ConcertName + " : " + String.Format("{0:C}", _Price) + "\n Seat: " + Seat + "\n Ticket Holder ID: " + ID + "\n Requested by: " + userid;
            return output;
        }
    }
}
