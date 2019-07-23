using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class RepurchaseRequest : _BaseRequest
    {
        public string ann_date { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
    }
}
