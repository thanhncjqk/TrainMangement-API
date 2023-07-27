using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Station : Base
    {
        [Key]
        public int StationID { get; set; }
        public string StationName { get; set; }
    }
}
