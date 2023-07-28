using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Type_Management 
    {
        [Key]
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string Value { get; set; }
        public string CSSClass { get; set; }
        public string Sorting { get; set; }
        public int StateId { get; set; }
    }
}
