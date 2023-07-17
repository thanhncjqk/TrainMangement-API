using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Train_Car : Base
    {
        public int TrainCarID { get; set; }
        public int TrainCarNumber { get; set; }
        public int TrainID { get; set; }
        public int TypeID { get; set; }
        public int StatusID { get; set; }
    }
}
