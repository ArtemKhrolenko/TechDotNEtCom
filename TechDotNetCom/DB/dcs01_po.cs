using System;
using System.ComponentModel.DataAnnotations;

namespace DataGridAX
{
    public class dcs01_po
    {
        [Key]
        public long pick_id { get; set; }
        public DateTime time { get; set; }
        public int ms { get; set; }
        public int hash { get; set; }
        public int type { get; set; }
        public int action { get; set; }
        public long crc { get; set; }
    }
}
