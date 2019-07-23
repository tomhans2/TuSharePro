using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class FundDivRequest : _BaseRequest
    {
        public string ann_date { get; set; }
        public string ex_date { get; set; }
        public string pay_date { get; set; }
        public string ts_code { get; set; }
    }
}
