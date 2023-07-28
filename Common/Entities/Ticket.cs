using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Ticket : Base
    {
        [Key]
        public int TicketId { get; set; }
        public string TicketCode { get; set; }
        public int PassengerInformation { get; set; }
        public int TotalTicketPrice { get; set; }
        public int TrainTripId { get; set; }
        public int SeatId { get; set; }
        public int DepartureStation { get; set; }
        public int ArrivalStation { get; set; }
    }
}
