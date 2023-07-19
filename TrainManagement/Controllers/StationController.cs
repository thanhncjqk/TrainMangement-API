using BusinessLayer.StationBL;
using Common.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrainManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : BasesController<Station>
    {
        private IStationBL _stationBL;

        public StationController(IStationBL stationBL): base(stationBL)
        {
            _stationBL = stationBL;
        }
    }
}
