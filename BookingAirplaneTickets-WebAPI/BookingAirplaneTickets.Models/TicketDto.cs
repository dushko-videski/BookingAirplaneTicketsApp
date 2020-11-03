using BookingAirplaneTickets.Shared.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace BookingAirplaneTickets.Models
{
    public class TicketDto
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "AirLine is required")]
        [Range(1, 2, ErrorMessage = "AirLine should be either 1 or 2")]
        public AirLines AirLine { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Passport number is required")]
        public string PassportNo { get; set; }


        public int LoyalMemberId { get; set; }

        public bool UseLoyalMemberCredits { get; set; }


        [Required(ErrorMessage = "Origin is required")]
        public string Origin { get; set; }

        [Required(ErrorMessage = "Destionation is required")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "Departure date is required")]
        public DateTime Departure { get; set; }

        public DateTime Return { get; set; }

        [Required(ErrorMessage = "Free Carry On Bag field is required")]
        public int FreeCarryOnBag { get; set; }


        public int TrolleyBag { get; set; }


        [Required(ErrorMessage = "Checked in bag field is required")]
        public int CheckedInBag { get; set; }


    }
}
