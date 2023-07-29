using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Status : Base
    {
        [Key]
        public int StatusId { get; set; }
        public string TableName { get; set; }
        public string StateName { get; set; }
        public string Value { get; set; }
        public string CSSClass { get; set; }
        public string Sorting { get; set; }
    }
}
