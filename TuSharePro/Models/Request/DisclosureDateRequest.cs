using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class DisclosureDateRequest:_BaseRequest
    {
        public string ts_code { get; set; }
        public string end_date { get; set; }
        public string pre_date { get; set; }
        public string actual_date { get; set; }
    }
}
