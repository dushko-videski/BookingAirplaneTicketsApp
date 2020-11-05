using BookingAirplaneTickets.Models;
using BookingAirplaneTickets.Services.Exceptions;
using BookingAirplaneTickets.Services.Interfaces;
using BookingAirplaneTickets.Shared.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BookingAirplaneTickets.Api.Controllers
{

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
        [HttpPost("ticket/new")]
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
                return BadRequest($"Ticket Exception:{ex.Message}");
            }
            catch (Exception ex)
            {
                return BadRequest($"Something went wrong:{ex.Message}");
            }
        }


        /// <summary>
        /// lists all tickets from chosen air line company or from both if no parametar is provided
        /// </summary>
        /// <param name="airline"></param>
        /// <returns></returns>
        [HttpGet("tickets")]
        [ProducesResponseType(typeof(IEnumerable<TicketDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<TicketDto>> GetAll([FromQuery] AirLines? airline)
        {
            try
            {
                return Ok(_ticketService.GetTickets(airline));
            }
            catch (TicketException ex)
            {
                return BadRequest($"Ticket Exception:{ex.Message}");
            }
            catch (Exception ex)
            {
                return BadRequest($"Something went wrong:{ex.Message}");
            }
        }

        /// <summary>
        /// gets ticekt by id
        /// </summary>
        /// <param name="ticketId"></param>
        /// <returns></returns>
        [HttpGet("ticket")]
        [ProducesResponseType(typeof(TicketDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<TicketDto> Get([FromQuery] int ticketId)
        {
            try
            {
                return Ok(_ticketService.GetTicket(ticketId));
            }
            catch (TicketException ex)
            {
                return BadRequest($"Ticket Exception:{ex.Message}");
            }
            catch (Exception ex)
            {
                return BadRequest($"Something went wrong:{ex.Message}");
            }

        }


        /// <summary>
        /// deletes ticket by id
        /// </summary>
        /// <param name="ticketId"></param>
        /// <returns></returns>
        [HttpDelete("ticket/delete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Delete([FromQuery] int ticketId)
        {
            try
            {
                _ticketService.DeleteTicket(ticketId);
                return Ok("Successfully deleted ticket!");
            }
            catch (TicketException ex)
            {
                return BadRequest($"Ticket Exception:{ex.Message}");
            }
            catch (Exception ex)
            {
                return BadRequest($"Something went wrong:{ex.Message}");
            }
        }
        /// <summary>
        /// updates ticket's info
        /// </summary>
        /// <param name="ticketDto"></param>
        /// <returns></returns>
        [HttpPut("ticket/update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Update([FromBody] TicketDto ticketDto)
        {
            try
            {
                _ticketService.UpdateTicket(ticketDto);
                return Ok($"Successfully updated ticket with id:{ticketDto.Id}");
            }
            catch (TicketException ex)
            {
                return BadRequest($"Ticket Exception:{ex.Message}");
            }
            catch (Exception ex)
            {
                return BadRequest($"Something went wrong:{ex.Message}");
            }
        }





    }
}
