using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Schedule : Base
    {
        [Key]
        public int ScheduleId { get; set; }
        public string ScheduleName { get; set; }

    }
}
