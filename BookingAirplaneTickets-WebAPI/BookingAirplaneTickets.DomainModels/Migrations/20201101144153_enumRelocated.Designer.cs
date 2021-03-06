﻿// <auto-generated />
using System;
using BookingAirplaneTickets.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookingAirplaneTickets.DomainModels.Migrations
{
    [DbContext(typeof(TicketDBContext))]
    [Migration("20201101144153_enumRelocated")]
    partial class enumRelocated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookingAirplaneTickets.DomainModels.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AirLine");

                    b.Property<int>("CheckedInBag");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<DateTime>("Departure");

                    b.Property<string>("Destination")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int>("FreeCarryOnBag");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<int>("LoyalMemberId");

                    b.Property<string>("Origin")
                        .IsRequired();

                    b.Property<string>("PassportNo")
                        .IsRequired();

                    b.Property<DateTime>("Return");

                    b.Property<int>("TrolleyBag");

                    b.Property<DateTime>("UpdatedOn");

                    b.Property<bool>("UseLoyalMemberCredits");

                    b.HasKey("Id");

                    b.ToTable("Tickets");

                    b.HasData(
                        new { Id = 1, AirLine = 1, CheckedInBag = 1, CreatedOn = new DateTime(2020, 11, 1, 14, 41, 53, 441, DateTimeKind.Utc), DateOfBirth = new DateTime(1983, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), Departure = new DateTime(2020, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), Destination = "Miami", FirstName = "Dushko", FreeCarryOnBag = 1, LastName = "Videski", LoyalMemberId = 0, Origin = "Skopje", PassportNo = "B123456789", Return = new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), TrolleyBag = 2, UpdatedOn = new DateTime(2020, 11, 1, 14, 41, 53, 441, DateTimeKind.Utc), UseLoyalMemberCredits = false },
                        new { Id = 2, AirLine = 2, CheckedInBag = 2, CreatedOn = new DateTime(2020, 11, 1, 14, 41, 53, 441, DateTimeKind.Utc), DateOfBirth = new DateTime(1986, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), Departure = new DateTime(2020, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), Destination = "Miami", FirstName = "Ljupka", FreeCarryOnBag = 2, LastName = "Postolova", LoyalMemberId = 123456, Origin = "Skopje", PassportNo = "B987654321", Return = new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), TrolleyBag = 0, UpdatedOn = new DateTime(2020, 11, 1, 14, 41, 53, 441, DateTimeKind.Utc), UseLoyalMemberCredits = true }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
