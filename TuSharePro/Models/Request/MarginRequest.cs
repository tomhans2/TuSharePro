using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class MarginRequest : _BaseRequest
    {
        public string trade_date { get; set; }
        public string exchange_id { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
    }
}
