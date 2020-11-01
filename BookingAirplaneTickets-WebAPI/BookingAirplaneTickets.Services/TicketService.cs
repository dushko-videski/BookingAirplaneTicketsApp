using BookingAirplaneTickets.DataAccess;
using BookingAirplaneTickets.DomainModels;
using BookingAirplaneTickets.DomainModels.Enums;
using BookingAirplaneTickets.Models;
using BookingAirplaneTickets.Services.Exceptions;
using BookingAirplaneTickets.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace BookingAirplaneTickets.Services
{
    public class TicketService : ITicketService
    {
        private readonly IRepository<Ticket> _ticketRepository;

        public TicketService(IRepository<Ticket> ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }


        public void AddTicket(TicketDto ticketDto)
        {
            if ((int)ticketDto.AirLine == 1 && ticketDto.TrolleyBag == null)
            {
                throw new TicketException("Trolley Bag field is required");
            }

            if ((int)ticketDto.AirLine == 1)
            {
                Ticket ticket = new Ticket()
                {
                    AirLine = ticketDto.AirLine,
                    FirstName = ticketDto.FirstName,
                    LastName = ticketDto.LastName,
                    DateOfBirth = ticketDto.DateOfBirth,
                    PassportNo = ticketDto.PassportNo,
                    Origin = ticketDto.Origin,
                    Destination = ticketDto.Destination,
                    Departure = ticketDto.Departure,
                    Return = ticketDto.Return,
                    FreeCarryOnBag = ticketDto.FreeCarryOnBag,
                    TrolleyBag = (int)ticketDto.TrolleyBag,
                    CheckedInBag = ticketDto.CheckedInBag,
                    CreatedOn = DateTime.UtcNow

                };
                _ticketRepository.Insert(ticket);
            }
            if ((int)ticketDto.AirLine == 2)
            {
                Ticket ticket = new Ticket()
                {
                    AirLine = ticketDto.AirLine,
                    FirstName = ticketDto.FirstName,
                    LastName = ticketDto.LastName,
                    DateOfBirth = ticketDto.DateOfBirth,
                    PassportNo = ticketDto.PassportNo,
                    LoyalMemberId = ticketDto.LoyalMemberId,
                    UseLoyalMemberCredits = ticketDto.UseLoyalMemberCredits,
                    Origin = ticketDto.Origin,
                    Destination = ticketDto.Destination,
                    Departure = ticketDto.Departure,
                    Return = ticketDto.Return,
                    FreeCarryOnBag = ticketDto.FreeCarryOnBag,
                    CheckedInBag = (int)ticketDto.TrolleyBag,
                    CreatedOn = DateTime.UtcNow
                };
                _ticketRepository.Insert(ticket);
            }
        }


        public IEnumerable<TicketDto> GetTickets(AirLines airline, int ticketId)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteTicket(int ticketId)
        {
            throw new System.NotImplementedException();
        }


        public void UpdateTicket(TicketDto ticketDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
