using BusinessLayer.BaseBL;
using BusinessLayer.Exceptions;
using Common.DTO;
using Common.Entities;
using Common.Enum;
using DataAccessLayer.BaseDL;
using DataAccessLayer.ScheduleDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ScheduleBL : BaseBL<Schedule>, IScheduleBL
    {
        List<string> Errors = new List<string>();
        private IScheduleDL _scheduleDL;

        public ScheduleBL(IScheduleDL scheduleDL) : base(scheduleDL)
        {
            _scheduleDL = scheduleDL;
        }

        protected override void Validate(Method method, Schedule record)
        {
            if (String.IsNullOrEmpty(record.ScheduleName))
            {
                Errors.Add("Missing ScheduleName");
            }

            if (Errors.Count > 0)
            {
                throw new ValidateException(Errors);
            }
        }
        public override PagingData<Schedule> GetFilterRecords(string? search, int pageSize = 10, int pageNumber = 1)
        {
            string where = $"ScheduleName like '{search}'";
            int offSet = (pageNumber - 1) * pageSize;
            return _scheduleDL.GetFilterRecords(where, "ModifiedDate DESC", offSet, pageSize);
        }
    }
}
