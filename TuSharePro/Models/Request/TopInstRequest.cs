using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class TopInstRequest : _BaseRequest
    {
        public string trade_date { get; set; }
        public string ts_code { get; set; }
    }
}
