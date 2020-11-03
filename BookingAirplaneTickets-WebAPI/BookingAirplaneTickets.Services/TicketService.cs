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

            Ticket ticket = MapingTickets.MapTicket(ticketDto);
            _ticketRepository.Insert(ticket);
        }


        public IEnumerable<TicketDto> GetTickets(AirLines? airline)
        {
            if (airline == null)
            {
                return _ticketRepository.GetAll()
                .Select(t => MapingTickets.MapTicketDto(t));
            }

            return _ticketRepository.GetAll()
                .Where(t => t.AirLine == airline)
                .Select(t => MapingTickets.MapTicketDto(t));
        }


        public TicketDto GetTicket(int ticketId)
        {
            Ticket ticket = _ticketRepository.GetById(ticketId);

            if (ticket == null)
            {
                throw new TicketException($"Ticket with Id:{ticketId} does not exist!");
            }

            return MapingTickets.MapTicketDto(ticket);

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
            Ticket ticket = _ticketRepository.GetById(ticketDto.Id);

            if (ticket == null)
            {
                throw new TicketException($"Ticket with Id:{ticketDto.Id} does not exist!");
            }

            MapingTickets.UpdateTicket(ticketDto, ticket);
            _ticketRepository.Update(ticket);

        }

    }
}
