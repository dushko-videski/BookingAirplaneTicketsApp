using BookingAirplaneTickets.DomainModels;
using BookingAirplaneTickets.Models;
using System;

namespace BookingAirplaneTickets.Services.Helpers
{
    public static class MapingTickets
    {

        public static Ticket MapTicket(TicketDto ticketDto)
        {
            return new Ticket()
            {
                Id = ticketDto.Id,
                AirLine = ticketDto.AirLine,
                FirstName = ticketDto.FirstName,
                LastName = ticketDto.LastName,
                DateOfBirth = ticketDto.DateOfBirth,
                PassportNo = ticketDto.PassportNo,
                LoyalMemberId = ticketDto.LoyalMemberId,
                UseLoyalMemberCredits = ticketDto.UseLoyalMemberCredits,
                Origin = ticketDto.Origin,
                Destination = ticketDto.Destination,
                Departure = ticketDto.Departure.Date,
                Return = ticketDto.Return,
                FreeCarryOnBag = ticketDto.FreeCarryOnBag,
                TrolleyBag = ticketDto.TrolleyBag,
                CheckedInBag = ticketDto.CheckedInBag,
                CreatedOn = DateTime.UtcNow.Date
            };
        }

        public static TicketDto MapTicketDto(Ticket t)
        {
            return new TicketDto()
            {
                Id = t.Id,
                AirLine = t.AirLine,
                FirstName = t.FirstName,
                LastName = t.LastName,
                DateOfBirth = t.DateOfBirth.Date,
                PassportNo = t.PassportNo,
                LoyalMemberId = t.LoyalMemberId,
                UseLoyalMemberCredits = t.UseLoyalMemberCredits,
                Origin = t.Origin,
                Destination = t.Destination,
                Departure = t.Departure.Date,
                Return = t.Return.Date,
                FreeCarryOnBag = t.FreeCarryOnBag,
                TrolleyBag = t.TrolleyBag,
                CheckedInBag = t.CheckedInBag
            };
        }


        public static void UpdateTicket(TicketDto ticketDto, Ticket ticket)
        {
            ticket.AirLine = ticketDto.AirLine;
            ticket.FirstName = ticketDto.FirstName;
            ticket.LastName = ticketDto.LastName;
            ticket.DateOfBirth = ticketDto.DateOfBirth.Date;
            ticket.PassportNo = ticketDto.PassportNo;
            ticket.LoyalMemberId = ticketDto.LoyalMemberId;
            ticket.UseLoyalMemberCredits = ticketDto.UseLoyalMemberCredits;
            ticket.Origin = ticketDto.Origin;
            ticket.Destination = ticketDto.Destination;
            ticket.Departure = ticketDto.Departure.Date;
            ticket.Return = ticketDto.Return.Date;
            ticket.FreeCarryOnBag = ticketDto.FreeCarryOnBag;
            ticket.TrolleyBag = ticketDto.TrolleyBag;
            ticket.CheckedInBag = ticketDto.CheckedInBag;
            ticket.CreatedOn = DateTime.UtcNow.Date;
        }

    }
}
