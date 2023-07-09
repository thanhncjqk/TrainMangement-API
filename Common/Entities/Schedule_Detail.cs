using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Schedule_Detail : Base
    {
        public int ScheduleDetailID { get; set; }
        public int ScheduleID { get; set; }
        public int StationID { get; set; }
        public int Arrange { get; set; }
        public decimal PriceToTheNextStation { get; set; }
    }
}
