using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class ForecastRequest : _BaseRequest
    {
        public string ts_code { get; set; }
        public string ann_date { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string period { get; set; }
        public string type { get; set; }
    }
}
