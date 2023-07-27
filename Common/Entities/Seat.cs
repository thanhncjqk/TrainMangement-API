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
        public int SeatID { get; set; }
        public string SeatCode { get; set; }
        public int TrainCarID { get; set; }
        public int TypeID { get; set; }
        public int StatusID { get; set; }
    }
}
