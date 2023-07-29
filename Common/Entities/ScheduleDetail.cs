using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class ScheduleDetail : Base
    {
        [Key]
        public int ScheduleDetailId { get; set; }
        public int ScheduleId { get; set; }
        public int CurrentStation { get; set; }
        public int NextStation { get; set; }
        public decimal PriceToTheNextStation { get; set; }
    }
}
