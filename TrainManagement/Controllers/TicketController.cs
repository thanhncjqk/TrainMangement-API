using BusinessLayer.TicketBL;
using Common.Entities;
using DataAccessLayer.TicketDL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrainManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : BasesController<Ticket>
    {
        private ITicketBL _ticketBL;

        public TicketController(ITicketBL ticketBL) : base(ticketBL)
        {
            _ticketBL = ticketBL;
        }
    }
}
