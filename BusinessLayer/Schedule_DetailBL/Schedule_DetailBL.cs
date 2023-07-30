using BusinessLayer.BaseBL;
using BusinessLayer.Exceptions;
using Common.DTO;
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
    public class Schedule_DetailBL : BaseBL<ScheduleDetail>, ISchedule_DetailBL
    {
        List<string> Errors = new List<string>();
        private ISchedule_DetailDL _scheduleDetailDL;

        public Schedule_DetailBL(ISchedule_DetailDL scheduleDetailDL) : base(scheduleDetailDL)
        {
            _scheduleDetailDL = scheduleDetailDL;
        }

        protected override void Validate(Method method, ScheduleDetail record)
        {
            if (record.ScheduleId == null)
            {
                Errors.Add("Missing ScheduleId");
            }

            if (record.CurrentStation == null)
            {
                Errors.Add("Missing CurrentStation");
            }

            if (record.NextStation == null)
            {
                Errors.Add("Missing NextStation");
            }

            if (record.PriceToTheNextStation == null)
            {
                Errors.Add("Missing PriceToTheNextStation");
            }

            if (Errors.Count > 0)
            {
                throw new ValidateException(Errors);
            }
        }

        public override PagingData<ScheduleDetail> GetFilterRecords(string? search, int pageSize = 10, int pageNumber = 1)
        {
            string where = $"ScheduleId like '{search}'";
            int offSet = (pageNumber - 1) * pageSize;
            return _scheduleDetailDL.GetFilterRecords(where, "ModifiedDate DESC", offSet, pageSize);
        }
    }
}
