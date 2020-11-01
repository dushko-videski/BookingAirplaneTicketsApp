using BookingAirplaneTickets.DomainModels.Enums;
using BookingAirplaneTickets.Models;
using System.Collections.Generic;

namespace BookingAirplaneTickets.Services.Interfaces
{
    public interface ITicketService
    {
        void AddTicket(TicketDto ticketDto);

        IEnumerable<TicketDto> GetTickets(AirLines airline);

        void UpdateTicket(TicketDto ticketDto);

        void DeleteTicket(int ticketId);


    }
}
