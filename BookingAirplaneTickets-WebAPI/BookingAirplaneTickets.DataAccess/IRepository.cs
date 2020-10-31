using BookingAirplaneTickets.DomainModels.Enums;
using System.Collections.Generic;

namespace BookingAirplaneTickets.DataAccess
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll(AirLines airline);
        void Insert(T entity);
        void Update(T entity);
        void Remove(T entity);

    }
}
