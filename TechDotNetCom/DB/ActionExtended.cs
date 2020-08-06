using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridAX
{
    public class ActionExtended
    {
        public static int id = 0;

        public ActionExtended() => Id = ++id;
        public int Id { get; set; }
        public string VariableName { get; set; }
        public int HashCode { get; set; }
        public long PickId { get; set; }        

        [Browsable(false)]
        public DateTime TimeOfAction { get; set; }
        
        public string Time
        {
            get
            {
                return TimeOfAction.ToString("dd.MM HH:mm");
            }
            
        }  
        public int Milliseconds { get; set; }
        public int ActionId { get; set; }
        public int ActionType { get; set; }
        public string ActionTypeDescription { get; set; }
        public int Action { get; set; }
        public string ActionDesc { get; set; }
        public string ActionDescShort { get; set; }
    }
}
