using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Seat : Base
    {
        [Key]
        public int SeatId { get; set; }
        public string SeatCode { get; set; }
        public int TrainCarId { get; set; }
        public int TypeId { get; set; }
        public int StatusId { get; set; }
    }
}
