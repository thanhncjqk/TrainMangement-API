using BusinessLayer.Exceptions;
using BusinessLayer;
using Common.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrainManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Train_TripController : BasesController<Train_Trip>
    {
        private ITrainTripBL _tripBL;

        public Train_TripController(ITrainTripBL tripBL) : base(tripBL) 
        {
            _tripBL = tripBL;
        }

        [HttpGet("filter-train")]
        public IActionResult FilterTrain([FromQuery] DateTime DepartureTime, DateTime ArrivalTime, [FromQuery] int pageSize = 10, [FromQuery] int pageNumber = 1)
        {
            try
            {
                var records = _tripBL.FilterTrain(DepartureTime, ArrivalTime, pageSize, pageNumber);

                if(records != null)
                {
                    return StatusCode(200, records);
                }
                else
                {
                    return StatusCode(500, "Loi");
                }
            }
            catch (ValidateException ex)
            {
                var res = new
                {
                    devMvg = ex.Message,
                    userMsg = ex.Data
                };
                return StatusCode(400, res);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
                throw;
            }
        }
    }
}
