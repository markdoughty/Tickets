using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    internal class WrongConcertException : Exception
    {
        public WrongConcertException()
        {

        }
        public WrongConcertException(string message) : base(message)
        {

        }

    }
}
