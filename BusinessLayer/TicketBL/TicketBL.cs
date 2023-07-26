
using BusinessLayer.BaseBL;
using BusinessLayer.Exceptions;
using Common.DTO;
using Common.Entities;
using Common.Enum;
using DataAccessLayer.TicketDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.TicketBL
{
    public class TicketBL : BaseBL<Ticket>, ITicketBL
    {
        List<string> Errors = new List<string>();
        private ITicketDL _ticketDL;
        public TicketBL (ITicketDL ticketDL) : base(ticketDL)
        {
            _ticketDL = ticketDL;
        }

        protected override void Validate(Method method, Ticket record)
        {
            if (record.TicketCode != null )
            {
                Errors.Add("Missing TicketCode");
            }

            if (record.TicketBuyer >0)
            {
                Errors.Add("Missing TicketBuyer");
            }

            if (record.PassengerInformation > 0 )
            {
                Errors.Add("Missing PassengerInformation");
            }

            if (record.TotalTicketPrice > 0)
            {
                Errors.Add("Missing TotalTicketPrice");
            }

            if (record.TrainTripID !=null )
            {
                Errors.Add("Missing TrainTripID");
            }

            if (record.SeatID != null )
            {
                Errors.Add("Missing SeatID");
            }

            if (record.DepartureStation > 0)
            {
                Errors.Add("Missing DepartureStation");
            }

            if (record.ArrivalStation > 0)
            {
                Errors.Add("Missing ArrivalStation");
            }

            if (Errors.Count > 0)
            {
                throw new ValidateException(Errors);
            }
        }

        public override PagingData<Ticket> GetFilterRecords(string? search, int pageSize = 10, int pageNumber = 1)
        {
            string where = $"PassengerInformation like '{search}'";
            int offSet = (pageNumber - 1) * pageSize;
            return _ticketDL.GetFilterRecords(where, "ModifiedDate DESC", offSet, pageSize);
        }
    }
}
