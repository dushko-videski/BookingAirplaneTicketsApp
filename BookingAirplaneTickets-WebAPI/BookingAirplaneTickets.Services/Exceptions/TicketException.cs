using System;

namespace BookingAirplaneTickets.Services.Exceptions
{
    public class TicketException : Exception
    {
        public TicketException(string message)
            : base(message)
        {
        }

    }
}
