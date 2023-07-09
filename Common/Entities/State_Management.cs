using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class State_Management
    {
        public int StatusID { get; set; }
        public string TableName { get; set; }
        public string StateName { get; set; }
        public string Value { get; set; }
        public string CSSClass { get; set; }
        public string Sorting { get; set; }
    }
}
