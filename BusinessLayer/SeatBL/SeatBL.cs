using BusinessLayer.BaseBL;
using BusinessLayer.Exceptions;
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

            if (record.TrainCarID != null)
            {
                Errors.Add("Missing ScheduleId");
            }

            if (record.TypeID != null)
            {
                Errors.Add("Missing TypeID");
            }

            if (record.StatusID != null)
            {
                Errors.Add("Missing StatusID");
            }

            if (Errors.Count > 0)
            {
                throw new ValidateException(Errors);
            }
        }
    }
}
