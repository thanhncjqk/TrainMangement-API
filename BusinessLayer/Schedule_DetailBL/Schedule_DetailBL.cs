using BusinessLayer.BaseBL;
using Common.Entities;
using Common.Enum;
using DataAccessLayer.Schedule_DetailDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Schedule_DetailBL
{
    public class Schedule_DetailBL : BaseBL<Schedule_Detail>, ISchedule_DetailBL
    {
        List<string> Errors = new List<string>();
        private ISchedule_DetailDL _scheduleDetailDL;

        public Schedule_DetailBL(ISchedule_DetailDL scheduleDetailDL) : base(scheduleDetailDL)
        {
            _scheduleDetailDL = scheduleDetailDL;
        }

        //protected override void Validate(Method method, Schedule_Detail record)
        //{
        //    if (record)
        //}
    }
}
