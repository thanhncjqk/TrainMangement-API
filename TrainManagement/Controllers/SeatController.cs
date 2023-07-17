using BusinessLayer.SeatBL;
using Common.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrainManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatController : BasesController<Seat>
    {
        private ISeatBL _seatBL;

        public SeatController(ISeatBL seatBL) : base(seatBL)
        {
            _seatBL = seatBL;
        }
    }
}
