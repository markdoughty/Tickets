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
            set 
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Price can not be a negative integer");
                _price= value;
            }
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
            private set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ID can not be empty");
                _id= value;
            }
        }
        //Constructors
        //
        public ConcertTicket(int P, string cn, string s, string id )
        {
                Price = P;
                ConcertName = cn;
                Seat = s;
                ID = id;
        }
        public ConcertTicket(int P, string cn, string id)
        {
            Price = P;
            ConcertName = cn;
            ID = id;
        }

        //Methods
       public override string Tostring()
        {
            StringBuilder output = new StringBuilder();
           output.AppendLine($"{cn} : {P:C}");
           output.AppendLine($"Seat: {s}");
           output.AppendLine($"Ticket Holder ID: {id}");
           return output.Tostring();
        }

        public string ToString(int userid)
        {
            StringBuilder output= new StringBuilder();
            output.AppendLine($"{cn} : {P:C}");
            output.AppendLine($"Seat: {s}");
            output.AppendLine($"Ticket Holder ID: {id}");
            output.AppendLine($"Requested by: {userid}");
            return output.ToString();
        }

 
    }
}
