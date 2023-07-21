using BusinessLayer.TrainBL;
using Common.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrainManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainController : BasesController<Train>
    {
        private ITrainBL _trainBL;

        public TrainController(ITrainBL trainBL) : base(trainBL)
        {
            _trainBL = trainBL;
        }
    }
}
