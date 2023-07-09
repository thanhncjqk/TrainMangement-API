using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Ticket : Base
    {
        public int SeatID { get; set; }
        public int DeparureStation { get; set; }
        public int ArrivalStation { get; set; }
    }
}
