using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class DividendRequest : _BaseRequest
    {
        public string ts_code { get; set; }
        public string ann_date { get; set; }
        public string record_date { get; set; }
        public string ex_date { get; set; }
        public string imp_ann_date { get; set; }
    }
}
