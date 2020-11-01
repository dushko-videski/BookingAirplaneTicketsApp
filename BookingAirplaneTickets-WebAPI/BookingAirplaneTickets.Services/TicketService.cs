using BookingAirplaneTickets.DataAccess;
using BookingAirplaneTickets.DomainModels;

using BookingAirplaneTickets.Models;
using BookingAirplaneTickets.Services.Exceptions;
using BookingAirplaneTickets.Services.Helpers;
using BookingAirplaneTickets.Services.Interfaces;
using BookingAirplaneTickets.Shared.Enums;
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


            if (ticketDto.AirLine == AirLines.AirLine_A)
            {
                Ticket ticket = MapingTickets.MapTicketA(ticketDto);
                _ticketRepository.Insert(ticket);
            }
            if (ticketDto.AirLine == AirLines.AirLine_B)
            {
                Ticket ticket = MapingTickets.MapTicketB(ticketDto);
                _ticketRepository.Insert(ticket);
            }
        }


        public IEnumerable<TicketDto> GetTickets(AirLines airline)
        {
            if (airline == AirLines.AirLine_A)
            {
                return _ticketRepository.GetAll()
                    .Where(t => t.AirLine == airline)
                    .Select(t => MapingTickets.MapTicketDtoA(t));
            }
            return _ticketRepository.GetAll()
                    .Where(t => t.AirLine == airline)
                    .Select(t => MapingTickets.MapTicketDtoB(t));
        }


        public void DeleteTicket(int ticketId)
        {
            Ticket ticket = _ticketRepository.GetAll().FirstOrDefault(t => t.Id == ticketId);

            if (ticket == null)
            {
                throw new TicketException($"Ticket with Id:{ticketId} does not exist!");
            }

            _ticketRepository.Remove(ticket);
        }


        public void UpdateTicket(TicketDto ticketDto)
        {
            Ticket ticket = _ticketRepository.GetAll().FirstOrDefault(t => t.Id == ticketDto.Id);

            if (ticket == null)
            {
                throw new TicketException($"Ticket with Id:{ticketDto.Id} does not exist!");
            }

            if (ticketDto.AirLine == AirLines.AirLine_A)
            {
                MapingTickets.UpdateTicketA(ticketDto, ticket);

                _ticketRepository.Update(ticket);
            }

            if (ticketDto.AirLine == AirLines.AirLine_B)
            {
                MapingTickets.UpdateTicketB(ticketDto, ticket);

                _ticketRepository.Update(ticket);
            }

        }

    }
}
