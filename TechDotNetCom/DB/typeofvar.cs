using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DataGridAX
{
    public class typeofvar
    {
        [Key]
        public int type_id { get; set; }
        public string description { get; set; }
        public string description_short { get; set; }
    }
}
