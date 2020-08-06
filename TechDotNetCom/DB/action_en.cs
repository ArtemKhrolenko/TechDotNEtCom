
using System.ComponentModel.DataAnnotations;

namespace DataGridAX
{
    public class action_en
    {
        [Key]
        public int action_id { get; set; }
        public string description { get; set; }
        public string description_short { get; set; }
    }
}
