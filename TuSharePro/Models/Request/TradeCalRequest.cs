using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class TradeCalRequest :_BaseRequest
    {
        public string exchange { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string is_open { get; set; }
        
}
}
