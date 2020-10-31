using BookingAirplaneTickets.DomainModels.Enums;
using System;

namespace BookingAirplaneTickets.DomainModels
{
    public class Ticket
    {
        public int Id { get; set; }

        public AirLines AirLine { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PassportNo { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Return { get; set; }
        public int FreeCarryOnBag { get; set; }
        public int TrolleyBag { get; set; }
        public int CheckedInBag { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public int LoyalMemberId { get; set; }
        public bool UseLoyalMemberCredits { get; set; }

    }
}
