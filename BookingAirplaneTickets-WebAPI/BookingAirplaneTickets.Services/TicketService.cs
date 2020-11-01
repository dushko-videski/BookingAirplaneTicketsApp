using BookingAirplaneTickets.DataAccess;
using BookingAirplaneTickets.DomainModels;
using BookingAirplaneTickets.DomainModels.Enums;
using BookingAirplaneTickets.Models;
using BookingAirplaneTickets.Services.Exceptions;
using BookingAirplaneTickets.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

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
            if (ticketDto.AirLine == AirLines.AirLine_A && ticketDto.TrolleyBag == null)
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
            if (ticketDto.AirLine == AirLines.AirLine_B)
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


        public IEnumerable<TicketDto> GetTickets(AirLines airline)
        {
            if (airline == AirLines.AirLine_A)
            {
                return _ticketRepository.GetAll()
                    .Where(t => t.AirLine == airline)
                    .Select(t => new TicketDto()
                    {
                        Id = t.Id,
                        AirLine = t.AirLine,
                        FirstName = t.FirstName,
                        LastName = t.LastName,
                        DateOfBirth = t.DateOfBirth,
                        PassportNo = t.PassportNo,
                        Origin = t.Origin,
                        Destination = t.Destination,
                        Departure = t.Departure,
                        Return = t.Return,
                        FreeCarryOnBag = t.FreeCarryOnBag,
                        TrolleyBag = t.TrolleyBag,
                        CheckedInBag = t.CheckedInBag,
                    });
            }
            return _ticketRepository.GetAll()
                    .Where(t => t.AirLine == airline)
                    .Select(t => new TicketDto()
                    {
                        Id = t.Id,
                        AirLine = t.AirLine,
                        FirstName = t.FirstName,
                        LastName = t.LastName,
                        DateOfBirth = t.DateOfBirth,
                        PassportNo = t.PassportNo,
                        LoyalMemberId = t.LoyalMemberId,
                        UseLoyalMemberCredits = t.UseLoyalMemberCredits,
                        Origin = t.Origin,
                        Destination = t.Destination,
                        Departure = t.Departure,
                        Return = t.Return,
                        FreeCarryOnBag = t.FreeCarryOnBag,
                        CheckedInBag = t.CheckedInBag
                    });
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
