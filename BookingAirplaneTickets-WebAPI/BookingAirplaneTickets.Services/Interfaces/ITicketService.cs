using BookingAirplaneTickets.Models;
using BookingAirplaneTickets.Shared.Enums;
using System.Collections.Generic;

namespace BookingAirplaneTickets.Services.Interfaces
{
    public interface ITicketService
    {
        void AddTicket(TicketDto ticketDto);

        IEnumerable<TicketDto> GetTickets(AirLines? airline);

        TicketDto GetTicket(int ticketId);

        void UpdateTicket(TicketDto ticketDto);

        void DeleteTicket(int ticketId);


    }
}
