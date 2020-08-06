
using System.ComponentModel.DataAnnotations;

namespace DataGridAX
{
    // стркуктура таблицы action_en в БД ЗП
    public class action_en
    {
        [Key]
        public int action_id { get; set; }
        public string description { get; set; }
        public string description_short { get; set; }
    }
}
