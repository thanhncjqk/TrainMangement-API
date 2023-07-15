using BusinessLayer;
using Common.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrainManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : BasesController<Schedule>
    {
        private IScheduleBL _scheduleBL;

        public ScheduleController(IScheduleBL scheduleBL) : base(scheduleBL) 
        {
            _scheduleBL = scheduleBL;
        }
    }
}
