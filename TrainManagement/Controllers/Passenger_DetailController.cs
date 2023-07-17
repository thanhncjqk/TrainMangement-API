using BusinessLayer.Passenger_DetailBL;
using Common.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrainManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Passenger_DetailController : BasesController<Passenger_Detail>
    {
        private IPassenger_DetailBL _passenger_detailBL;

        public Passenger_DetailController(IPassenger_DetailBL passenger_detailBL) : base (passenger_detailBL)
        {
            _passenger_detailBL = passenger_detailBL;
        }
    }
}
