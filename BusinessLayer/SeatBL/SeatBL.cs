using BusinessLayer.BaseBL;
using BusinessLayer.Exceptions;
using Common.DTO;
using Common.Entities;
using Common.Enum;
using DataAccessLayer.SeatDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.SeatBL
{
    public class SeatBL : BaseBL<Seat>, ISeatBL
    {
        List<string> Errors = new List<string>();
        private ISeatDL _seatDL;

        public SeatBL(ISeatDL seatDL) : base(seatDL)
        {
            _seatDL = seatDL;
        }
        protected override void Validate(Method method, Seat record)
        {
            if (record.SeatCode != null)
            {
                Errors.Add("Missing SeatCode");
            }

            if (record.TrainCarId != null)
            {
                Errors.Add("Missing ScheduleId");
            }

            if (record.TypeId != null)
            {
                Errors.Add("Missing TypeID");
            }

            if (record.StatusId != null)
            {
                Errors.Add("Missing StatusID");
            }

            if (Errors.Count > 0)
            {
                throw new ValidateException(Errors);
            }
        }
        public override PagingData<Seat> GetFilterRecords(string? search, int pageSize = 10, int pageNumber = 1)
        {
            if (string.IsNullOrEmpty(search))
            {
                Errors.Add("Missing Train Car Id");
                throw new ValidateException(Errors);
            }
            string where  = $"TrainCarId like '{search}'";
            int offSet = (pageNumber - 1) * pageSize;
            return _seatDL.GetFilterRecords(where , "ModifiedDate DESC", offSet, pageSize);
        }
    }
}
