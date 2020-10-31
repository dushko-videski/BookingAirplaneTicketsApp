using BookingAirplaneTickets.DomainModels;
using BookingAirplaneTickets.DomainModels.Enums;
using System.Collections.Generic;
using System.Linq;

namespace BookingAirplaneTickets.DataAccess
{
    public class TicketRepository : IRepository<Ticket>
    {
        private readonly TicketDBContext _context;

        public TicketRepository(TicketDBContext context)
        {
            _context = context;
        }



        public IEnumerable<Ticket> GetAll(AirLines airline)
        {
            return _context.Tickets.Where(t => t.AirLine == airline);
        }

        public void Insert(Ticket entity)
        {
            _context.Tickets.Add(entity);
            _context.SaveChanges();
        }

        public void Remove(Ticket entity)
        {
            _context.Tickets.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Ticket entity)
        {
            _context.Tickets.Update(entity);
            _context.SaveChanges();
        }
    }
}
