using BusinessLayer.BaseBL;
using BusinessLayer.Exceptions;
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

        protected override void Validate(Method method, Schedule_Detail record)
        {
            if (record.ScheduleID != null)
            {
                Errors.Add("Missing ScheduleId");
            }

            if (record.StationID != null)
            {
                Errors.Add("Missing StationId");
            }

            if (record.PriceToTheNextStation > 0)
            {
                Errors.Add("Missing PriceToTheNextStation");
            }

            if (record.Arrange > 0)
            {
                Errors.Add("Missing Arrange");
            }

            if (Errors.Count > 0)
            {
                throw new ValidateException(Errors);
            }
        }
    }
}
