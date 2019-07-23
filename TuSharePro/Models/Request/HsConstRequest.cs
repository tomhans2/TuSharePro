using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuSharePro.Models.Request
{
    public class HsConstRequest : _BaseRequest
    {
        public string hs_type { get; set; }
        public string is_new { get; set; }

    }
}
