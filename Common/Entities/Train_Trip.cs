using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Train_Trip : Base
    {
        [Key]
        public int TrainTripID { get; set; }
        public string TrainTripCode { get; set; }
        public int TrainID { get; set; }
        public int ScheduleID { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }

    }
}
