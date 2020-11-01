using BookingAirplaneTickets.Shared.Enums;
using Microsoft.EntityFrameworkCore;
using System;

namespace BookingAirplaneTickets.DomainModels
{
    public class TicketDBContext : DbContext
    {

        public TicketDBContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Ticket>()
                .ToTable("Tickets")
                .HasKey(t => t.Id);
            modelBuilder
                .Entity<Ticket>()
                .Property(p => p.FirstName)
                .IsRequired();
            modelBuilder
                .Entity<Ticket>()
                .Property(p => p.LastName)
                .IsRequired();
            modelBuilder
                .Entity<Ticket>()
                .Property(p => p.DateOfBirth)
                .IsRequired();
            modelBuilder
                .Entity<Ticket>()
                .Property(p => p.PassportNo)
                .IsRequired();
            modelBuilder
                .Entity<Ticket>()
                .Property(p => p.Origin)
                .IsRequired();
            modelBuilder
                .Entity<Ticket>()
                .Property(p => p.Destination)
                .IsRequired();
            modelBuilder
                .Entity<Ticket>()
                .Property(p => p.Departure)
                .IsRequired();
            modelBuilder
                .Entity<Ticket>()
                .Property(p => p.Return)
                .IsRequired();
            modelBuilder
                .Entity<Ticket>()
                .Property(p => p.FreeCarryOnBag)
                .IsRequired();
            modelBuilder
                .Entity<Ticket>()
                .Property(p => p.CheckedInBag)
                .IsRequired();

            Seed(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Ticket>()
                .HasData(
                new Ticket()
                {
                    Id = 1,
                    AirLine = AirLines.AirLine_A,
                    FirstName = "Dushko",
                    LastName = "Videski",
                    DateOfBirth = new DateTime(1983, 08, 17),
                    PassportNo = "B123456789",
                    Origin = "Skopje",
                    Destination = "Miami",
                    Departure = new DateTime(2020, 12, 29),
                    Return = new DateTime(2021, 01, 15),
                    FreeCarryOnBag = 1,
                    TrolleyBag = 2,
                    CheckedInBag = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow
                },
                new Ticket()
                {
                    Id = 2,
                    AirLine = AirLines.AirLine_B,
                    FirstName = "Ljupka",
                    LastName = "Postolova",
                    DateOfBirth = new DateTime(1986, 08, 30),
                    PassportNo = "B987654321",
                    LoyalMemberId = 123456,
                    UseLoyalMemberCredits = true,
                    Origin = "Skopje",
                    Destination = "Miami",
                    Departure = new DateTime(2020, 12, 29),
                    Return = new DateTime(2021, 01, 15),
                    FreeCarryOnBag = 2,
                    CheckedInBag = 2,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = DateTime.UtcNow
                });
        }
    }
}
