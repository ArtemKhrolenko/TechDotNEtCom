using System;
using System.ComponentModel.DataAnnotations;

namespace DataGridAX
{
    public class actioncode
    {
        [Key]
        public int action_id { get; set; }
        public int type { get; set; }
        public int action { get; set; }
        public string description { get; set; }
        public typeofvar typeOfVar { get; set; }
    }
}
