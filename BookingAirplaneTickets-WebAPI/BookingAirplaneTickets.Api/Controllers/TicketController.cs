using BookingAirplaneTickets.Models;
using BookingAirplaneTickets.Services.Exceptions;
using BookingAirplaneTickets.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BookingAirplaneTickets.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        /// <summary>
        /// adds new ticket
        /// </summary>
        /// <param name="ticketDto"></param>
        /// <returns></returns>
        [HttpPost("add-ticket")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Add([FromBody] TicketDto ticketDto)
        {
            try
            {
                _ticketService.AddTicket(ticketDto);
                return Ok("Successfully added ticket");
            }
            catch (TicketException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }








    }
}
