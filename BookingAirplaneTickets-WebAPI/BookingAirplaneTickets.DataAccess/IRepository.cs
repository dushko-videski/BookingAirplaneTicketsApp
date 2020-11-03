using System.Collections.Generic;

namespace BookingAirplaneTickets.DataAccess
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Remove(T entity);

    }
}
