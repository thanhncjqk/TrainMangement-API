using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Train : Base
    {
        [Key]
        public int TrainID { get; set; }
        public int TrainNumber { get; set; }
        public int TypeID { get; set; }
        public int StatusID { get; set; }
    }
}
