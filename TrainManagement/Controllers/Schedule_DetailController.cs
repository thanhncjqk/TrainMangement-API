using BusinessLayer.Schedule_DetailBL;
using Common.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrainManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Schedule_DetailController : BasesController<ScheduleDetail>
    {
        private ISchedule_DetailBL _scheduleDetailBL;

        public Schedule_DetailController(ISchedule_DetailBL scheduleDetailBL) :  base(scheduleDetailBL)
        {
            _scheduleDetailBL = scheduleDetailBL;
        }
    }
}
