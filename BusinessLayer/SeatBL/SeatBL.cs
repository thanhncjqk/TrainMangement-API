using BusinessLayer.BaseBL;
using Common.Entities;
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
        private ISeatDL _seatDL;

        public SeatBL(ISeatDL seatDL) : base(seatDL)
        {
            _seatDL = seatDL;
        }
    }
}
