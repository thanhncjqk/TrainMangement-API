using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Type_Management 
    {
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public string Value { get; set; }
        public string CSSClass { get; set; }
        public string Sorting { get; set; }
        public int StateID { get; set; }
    }
}
