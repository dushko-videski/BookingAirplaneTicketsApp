using BookingAirplaneTickets.DataAccess;
using BookingAirplaneTickets.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookingAirplaneTickets.Services.Helpers
{
    public static class DiModule
    {
        public static IServiceCollection RegisterModule(IServiceCollection services, string connectionString)
        {
            // registering DB CONTEXT
            services.AddDbContext<TicketDBContext>(x => x.UseSqlServer(connectionString));

            // register repository
            services.AddTransient<IRepository<Ticket>, TicketRepository>();




            return services;
        }
    }
}
