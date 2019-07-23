using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class FundNavRequest : _BaseRequest
    {
        public string ts_code { get; set; }
        public string end_date { get; set; }
    }
}
