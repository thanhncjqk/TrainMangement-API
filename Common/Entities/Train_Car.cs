using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Train_Car : Base
    {
        [Key]
        public int TrainCarId { get; set; }
        public int TrainCarNumber { get; set; }
        public int TrainId { get; set; }
        public int TypeId { get; set; }
        public int StatusId { get; set; }
    }
}
