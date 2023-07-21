using BusinessLayer.TrainTripBL;
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
    }
}
