using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class CashflowRequest : _BaseRequest
    {
        public string ts_code { get; set; }
        public string ann_date { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string period { get; set; }
        public string report_type { get; set; }
        public string comp_type { get; set; }
    }
}
