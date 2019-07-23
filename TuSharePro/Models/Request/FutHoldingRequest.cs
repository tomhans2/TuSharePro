using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class FutHoldingRequest : _BaseRequest
    {
        public string trade_date { get; set; }
        public string symbol { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string exchange { get; set; }
    }
}
