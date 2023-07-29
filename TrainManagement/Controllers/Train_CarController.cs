using BusinessLayer.TrainCarBL;
using Common.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrainManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Train_CarController : BasesController<TrainCar>
    {
        private ITrainCarBL _trainCarBL;

        public Train_CarController(ITrainCarBL trainCarBL) : base(trainCarBL) 
        {
            _trainCarBL = trainCarBL;
        }
    }
}
