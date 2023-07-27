using BusinessLayer.Exceptions;
using BusinessLayer;
using Common.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Common.DTO;

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

        [HttpPost("filter-train")]
        public IActionResult FilterTrain([FromBody] FilterTime filterTime)
        {
            try
            {
                var records = _tripBL.FilterTrain(filterTime);

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
