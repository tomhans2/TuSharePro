using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class StockBasicRequest : _BaseRequest
    {
        public string is_hs { get; set; }
        public string list_status { get; set; }
        public string exchange { get; set; }

    }
}
