using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Ticket : Base
    {
        public int TicketID { get; set; }
        public int TicketCode { get; set; }
        public int TicketBuyer { get; set; }
        public int PassengerInformation { get; set; }
        public int TotalTicketPrice { get; set; }
        public int TrainTripID { get; set; }
        public int SeatID { get; set; }
        public int DepartureStation { get; set; }
        public int ArrivalStation { get; set; }
    }
}
