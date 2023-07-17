
using BusinessLayer.BaseBL;
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
            if (record.TicketCode > 1 && record.TicketCode <= 11)
            {
                Errors.Add("Missing TicketCode");
            }
            
            
        }
    }
}
