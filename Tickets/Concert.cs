using System;
using System.Collections.Generic;

namespace Tickets
{
    /// <summary>
    /// Represents a concert with a specific band.
    /// </summary>
    internal class Concert
    {
        private string _bandName; // Private field for the band name

        /// <summary>
        /// Gets or sets the name of the band.
        /// </summary>
        public string BandName
        {
            get { return _bandName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Band name cannot be null or empty.");
                _bandName = value;
            }
        }

        // Private list to store concert tickets
        private List<ConcertTicket> concertTickets;

        /// <summary>
        /// Initializes a new instance of the Concert class with the specified band name.
        /// </summary>
        /// <param name="name">The name of the band.</param>
        public Concert(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Band name cannot be null or empty.");
            
            BandName = name;
            concertTickets = new List<ConcertTicket>();
        }

        /// <summary>
        /// Adds a concert ticket to the list if it matches the band name.
        /// </summary>
        /// <param name="ct">The concert ticket to add.</param>
        public void AddConcertTicket(ConcertTicket ct)
        {
            if (ct == null)
                throw new ArgumentNullException(nameof(ct), "Concert ticket cannot be null.");

            if (ct.ConcertName != BandName)
            {
                throw new WrongConcertException("Sorry - this is the wrong concert");
            }
            else
            {
                concertTickets.Add(ct);
            }
        }

        /// <summary>
        /// Outputs the status of all seats (tickets) in the concert.
        /// </summary>
        public void OutputAllSeats()
        {
            foreach (ConcertTicket ct in concertTickets)
            {
                Console.WriteLine(ct.OutputStatus());
            }
        }
    }

    /// <summary>
    /// Represents a concert ticket.
    /// </summary>
    internal class ConcertTicket
    {
        public string ConcertName { get; set; }

        public string OutputStatus()
        {
            // Placeholder for the actual implementation
            return $"Ticket for {ConcertName}";
        }
    }

    /// <summary>
    /// Exception thrown when a wrong concert ticket is added.
    /// </summary>
    public class WrongConcertException : Exception
    {
        public WrongConcertException(string message) : base(message)
        {
        }
    }
}
